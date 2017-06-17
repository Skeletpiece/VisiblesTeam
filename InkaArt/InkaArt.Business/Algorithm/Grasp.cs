﻿using InkaArt.Classes;
using InkaArt.Data.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkaArt.Business.Algorithm
{
    public class Grasp
    {
        public const int NumberOfIterations = 1000;
        public const double Alpha = 0.2;

        private WorkerController selected_workers;
        private OrderController selected_orders;
        private JobController jobs;
        private RecipeController recipes;
        private IndexController indexes;
        private Simulation simulation;

        public Grasp(Simulation simulation, JobController jobs, RecipeController recipes, IndexController indexes)
        {
            this.simulation = simulation;
            this.selected_workers = simulation.SelectedWorkers;
            this.selected_orders = new OrderController(simulation.SelectedOrders);
            this.jobs = jobs;
            this.recipes = recipes;
            this.indexes = indexes;
        }

        public Assignment ExecuteGraspAlgorithm(int day, ref int elapsed_time)
        {
            Assignment selected_assignment = null;
            
            for (int iteration = 0; elapsed_time < Simulation.LimitTime && iteration < Grasp.NumberOfIterations; iteration++)
            {
                Assignment assignment = new Assignment(simulation.StartDate.AddDays(day));

                //Inicializar la lista de candidatos para ser asignados
                List<Index> candidates = new List<Index>();
                for (int i = 0; i < indexes.Count(); i++)
                    if (selected_workers.GetByID(indexes[i].Worker.ID) != null) candidates.Add(indexes[i]);

                this.ExecuteGraspConstructionPhase(assignment, candidates, iteration, ref elapsed_time);

                //Si se logró minimizar la función objetivo, se reemplaza la mejor asignación del día
                //por la nueva asignación generada.
                if (selected_assignment == null || assignment.ObjectiveFunction < selected_assignment.ObjectiveFunction)
                    selected_assignment = assignment;
            }

            return selected_assignment;
        }

        private void ExecuteGraspConstructionPhase(Assignment assignment, List<Index> candidates, int iteration, ref int elapsed_time)
        {
            List<Recipe> order_recipes = GetOrderRecipes(selected_orders[0]);
            List<Job> current_product_jobs = new List<Job>();

            for (int construction = 1; elapsed_time < Simulation.LimitTime && selected_orders.Count() > 0 && candidates.Count() > 0;
                construction++)
            {
                LogHandler.WriteLine("Iteracion de construccion " + construction);
                LogHandler.WriteLine("# ordenes = " + selected_orders.Count() + ", # candidatos = " + candidates.Count());

                //Seleccionar el producto a fabricar si es que nos acabamos el producto
                if (current_product_jobs.Count <= 0) SelectJobsPerProduct(current_product_jobs, order_recipes);

                //Obtener una lista de los trabajadores más eficientes
                List<Index> rcl = GenerateReleaseCandidateList(candidates, assignment, iteration,
                    current_product_jobs);
                //Si no se pudo realizar el producto, borrar el producto y 
                if (rcl.Count() <= 0)
                {
                    current_product_jobs.Clear();
                    break;
                }

                //Escoger un trabajador al azar e incorporarlo en la solución
                Index chosen = rcl[Randomizer.NextNumber(0, rcl.Count() - 1)];

                AssignmentLine assignment_line = new AssignmentLine(chosen.Worker, chosen.Recipe, chosen.Job);
                //int number_of_miniturns = Convert.ToInt32(chosen.AverageTime / Simulation.MiniturnLength);
                //Añadir línea

                assignment.ObjectiveFunction += chosen.CostValue(assignment.ObjectiveFunction, iteration);
                //if (selected_orders[0].UpdateLineItem(chosen.Recipe) == false) break;

                LogHandler.WriteLine("# ordenes = " + selected_orders.Count() + ", # candidatos = " + candidates.Count());
                //Quitar los candidatos necesarios
                if (assignment.IsWorkerFull(chosen.Worker))
                {
                    for (int i = 0; i < candidates.Count();)
                    {
                        if (candidates[i].Worker == chosen.Worker) candidates.Remove(candidates[i]);
                        else i++;
                    }
                }
                candidates.Remove(chosen);

                LogHandler.WriteLine("# ordenes = " + selected_orders.Count() + ", # candidatos = " + candidates.Count());

                //Si la orden se completó, removerla de la lista
                if (selected_orders[0].Completed()) selected_orders.RemoveFirst();
            }
        }

        private List<Recipe> GetOrderRecipes(Order order)
        {
            List<Recipe> order_recipes = new List<Recipe>();
            for (int i = 0; i < order.NumberOfLineItems; i++)
                order_recipes.Add(recipes.GetByID(order[i].Recipe));
            return order_recipes;
        }

        private void SelectJobsPerProduct(List<Job> current_product_jobs, List<Recipe> order_recipes)
        {
            Recipe recipe = order_recipes[Randomizer.NextNumber(0, order_recipes.Count - 1)];
            
            for (int i = 0; i < jobs.NumberOfJobs; i++)
                if (jobs[i].Product == recipe.Product) current_product_jobs.Add(jobs[i]);
        }

        private List<Index> GenerateReleaseCandidateList(List<Index> candidates, Assignment assignment,
            int iteration, List<Job> current_product_jobs)
        {
            //Inicializar el RCL con los candidatos asociados al producto y receta a producir
            List<Index> rcl = new List<Index>();
            for (int i = 0; i < candidates.Count(); i++)
                if (current_product_jobs.Contains(candidates[i].Job)) rcl.Add(candidates[i]);

            //Calcular el máximo y el mínimo costo de los candidatos que podrían pertenecer al RCL
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < rcl.Count(); i++)
            {
                double cost_value = rcl[i].CostValue(assignment.ObjectiveFunction, iteration);
                if (cost_value < min) min = cost_value;
                if (cost_value > max) max = cost_value;
            }

            //Obtener el rango del RCL y quitar los índices del RCL que no estén en el rango
            double max_rcl = min + Alpha * (max - min);
            for (int i = 0; i < rcl.Count();)
            {
                double cost_value = rcl[i].CostValue(assignment.ObjectiveFunction, iteration);

                if (cost_value >= min && cost_value <= max_rcl) i++;
                else rcl.RemoveAt(i);
            }

            return rcl;
        }
    }
}
 