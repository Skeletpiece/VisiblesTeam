﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InkaArt.Classes;
using InkaArt.Data.Algorithm;
using System.IO;

namespace InkaArt.Business.Algorithm
{
    public class IndexController
    {
        private List<Index> indexes;

        private WorkerController workers;
        private JobController jobs;
        private RecipeController recipes;

        public IndexController(WorkerController workers, JobController jobs, RecipeController recipes)
        {
            this.indexes = new List<Index>();

            this.workers = workers;
            this.jobs = jobs;
            this.recipes = recipes;
        }

        public IndexController()
        {
            this.indexes = new List<Index>();

            this.workers = new WorkerController();
            this.workers.Load();
            this.jobs = new JobController();
            this.jobs.Load();
            this.recipes = new RecipeController();
            this.recipes.Load();
        }

        public void Load()
        {
            NpgsqlConnection connection = new NpgsqlConnection(BD_Connector.ConnectionString.ConnectionString);
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM inkaart.\"Index\" WHERE status = :status ORDER BY id_index ASC", connection);
            command.Parameters.AddWithValue("status", NpgsqlDbType.Boolean, true);
            
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id_index = reader.GetInt32(0);
                Worker worker = workers.GetByID(reader.GetInt32(1));
                Job job = jobs.GetByID(reader.GetInt32(2));
                Recipe recipe = recipes.GetByID(reader.GetInt32(3));
                double average_breakage = reader.GetDouble(4);
                double average_time = reader.GetDouble(5);
                Index index = new Index(id_index, worker, job, recipe, average_breakage, average_time);
                indexes.Add(index);
            }

            connection.Close();
        }

        /************************ INSERTAR O ACTUALIZAR EN LAS TABLAS INDEX Y RATIOPERDAY ************************/

        public string InsertOrUpdate(Ratio ratio, int initial_count_ratios)
        {
            //Si el número de ratios que cumple los parámetros de ratio es 0, se inserta.
            if (initial_count_ratios <= 0) return Index.Insert(ratio);

            //Si el número de ratios que cummple los parámetros es mayor que 0, se actualiza el ya existente.
            double average_breakage, average_time;
            ratio.AverageValues(out average_breakage, out average_time);

            return Index.Update(ratio, average_breakage, average_time);
        }

        public string UpdateOrDelete(Ratio ratio)
        {
            double average_breakage, average_time;
            ratio.AverageValues(out average_breakage, out average_time);

            //Si ambos valores son mayores que cero, entonces se actualiza.
            if (average_breakage >= 0 && average_time >= 0) return Index.Update(ratio, average_breakage, average_time);

            //Sino, se procede a realizar un soft deletion.
            return Index.Delete(ratio);
        }

        /*********************** ALGORITMO ***********************/

        public void CalculateIndexes(Simulation simulation)
        {
            double[,] average_breakage_mean = new double[recipes.NumberOfRecipes, jobs.NumberOfJobs];
            double[,] average_time_mean = new double[recipes.NumberOfRecipes, jobs.NumberOfJobs];
            int[,] average_mean_count = new int[recipes.NumberOfRecipes, jobs.NumberOfJobs];

            //Calcular los promedios de average_breakage y average_time. Esta función es O(n^3) :(
            for (int recipe = 0; recipe < recipes.NumberOfRecipes; recipe++)
            {
                List<Job> product_jobs = jobs.GetJobsByProduct(recipes[recipe].Product);
                for (int job = 0; job < product_jobs.Count; job++)
                {
                    int job_index = jobs.GetIndex(product_jobs[job].ID);
                    int recipe_index = recipes.GetIndex(recipes[recipe].ID);

                    for (int index = 0; index < indexes.Count; index++)
                    {
                        if (indexes[index].Job.ID == jobs[job_index].ID && indexes[index].Recipe.ID == recipes[recipe_index].ID)
                        {
                            average_mean_count[job_index, recipe_index]++;
                            average_breakage_mean[job_index, recipe_index] += indexes[index].AverageBreakage;
                            average_time_mean[job_index, recipe_index] += indexes[index].AverageTime;
                        }
                    }

                    average_breakage_mean[recipe_index, job_index] = (average_mean_count[recipe_index, job_index] <= 0)
                        ? 1 : average_breakage_mean[recipe_index, job_index] / average_mean_count[recipe_index, job_index];
                    average_time_mean[recipe_index, job_index] = (average_mean_count[recipe_index, job_index] <= 0)
                        ? 1 : average_time_mean[recipe_index, job_index] / average_mean_count[recipe_index, job_index];
                }
            }

            //Calcular los promedios de average_breakage y average_time. Esta función es O(n^4). Ineficiencia 100% :(
            for (int worker = 0; worker < simulation.SelectedWorkers.Count(); worker++)
            {
                for (int recipe = 0; recipe < recipes.NumberOfRecipes; recipe++)
                {
                    List<Job> product_jobs = jobs.GetJobsByProduct(recipes[recipe].Product);
                    for (int job = 0; job < product_jobs.Count; job++)
                    {
                        int job_index = jobs.GetIndex(product_jobs[job].ID);
                        int recipe_index = recipes.GetIndex(recipes[recipe].ID);
                        Worker worker_object = simulation.SelectedWorkers[worker];

                        Index index = FindByWorkerJobAndRecipe(worker_object, jobs[job_index], recipes[recipe_index]);
                        if (index == null)
                        {
                            index = new Index(0, worker_object, jobs[job_index], recipes[recipe_index],
                                average_breakage_mean[recipe_index, job_index], average_time_mean[recipe_index, job_index]);
                            indexes.Add(index);
                        }

                        double product_weight = simulation.ProductWeight(jobs.GetByID(index.Job.ID).Product);
                        index.CalculateIndexes(average_breakage_mean[job_index, recipe_index], average_time_mean[job_index, recipe_index],
                            simulation.BreakageWeight, simulation.TimeWeight, product_weight);
                    }
                }
            }
        }

        /********************************* FUNCIONES AUXILIARES *********************************/

        public Index GetByID(int id_index)
        {
            foreach (Index index in indexes)
                if (index.ID == id_index) return index;
            return null;
        }

        public Index this[int index]
        {
            get { return indexes[index]; }
        }

        public int Count()
        {
            return indexes.Count;
        }

        public void Add(Index index)
        {
            this.indexes.Add(index);
        }

        public void RemoveFirst()
        {
            this.indexes.RemoveAt(0);
        }

        public void Remove(Index index)
        {
            this.indexes.Remove(index);
        }

        public Index Find(Worker worker, Job job, Recipe recipe)
        {
            if (worker == null || job == null || recipe == null) return null;
            return indexes.Find(index => index.Worker.ID == worker.ID && index.Job.ID == job.ID && index.Recipe.ID == recipe.ID);
        }

        public Index FindByAssignment(AssignmentLine line)
        {
            if (line == null) return null;
            return indexes.Find(index => index.Worker != null && index.Worker.ID == line.Worker.ID 
                && index.Job != null && index.Job.ID == line.Job.ID 
                && index.Recipe != null && index.Recipe.ID == line.Recipe.ID);
        }


        public Index FindByWorkerJobAndRecipe(Worker worker, Job job, Recipe recipe)
        {
            if (worker == null || job == null || recipe == null) return null;
            foreach (Index index in indexes)
                if (index.Worker.ID == worker.ID && index.Job.ID == job.ID && index.Recipe.ID == recipe.ID) return index;
            return null;
        }

        public void indexesToCSV()
        {
            //before your loop
            var csv = new StringBuilder();

            foreach (Index index in indexes)
            {
                var worker = index.Worker.FullName;
                var worker_id = index.Worker.ID.ToString();
                var job = index.Job.ID.ToString();
                var recipe = index.Recipe.ID.ToString();
                var br = index.BreakageIndex.ToString();
                var ti = index.TimeIndex.ToString();
                var lo = index.LossIndex.ToString();
                var newLine = string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}", worker_id, worker, job, recipe, br, ti, lo);
                csv.AppendLine(newLine);
            }
                        
            //after your loop
            File.WriteAllText("indexes.csv", csv.ToString());
        }
    }
}
