﻿using InkaArt.Data.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkaArt.Business.Algorithm
{
    public class Assignment
    {
        private DateTime date;
        private double objective_function_value;
        private AssignmentLine[,] assignment_lines;

        private int huacos_produced;
        private int huamanga_produced;
        private int altarpiece_produced;

        private int total_miniturns; //Total de miniturnos de un día
        private WorkerController selected_workers;

        public DateTime Date
        {
            get { return date; }
        }
        public double ObjectiveFunction
        {
            get { return objective_function_value; }
            set { objective_function_value = value; }
        }

        public Assignment(DateTime date, WorkerController selected_workers, int total_miniturns)
        {
            this.date = date;
            this.objective_function_value = 0;
            this.total_miniturns = total_miniturns;
            this.assignment_lines = new AssignmentLine[selected_workers.NumberOfWorkers, this.total_miniturns];
            this.huacos_produced = 0;
            this.huamanga_produced = 0;
            this.altarpiece_produced = 0;
            this.selected_workers = selected_workers;
        }

        public void AddAssignmentLines(List<AssignmentLine> assignment_lines)
        {
            throw new NotImplementedException();
        }

        public bool IsWorkerFull(Worker worker, List<AssignmentLine> temp_assignment_lines)
        {
            int worker_index = selected_workers.GetIndex(worker.ID), assigned_miniturns = 0;

            for (int i = 0; i < total_miniturns && assignment_lines[worker_index, i] != null; i++)
                assigned_miniturns++;
            for (int i = 0; i < temp_assignment_lines.Count; i++)
                if (temp_assignment_lines[i].Worker.ID == worker.ID) assigned_miniturns += temp_assignment_lines[i].TotalMiniturnsUsed;

            return (assigned_miniturns >= total_miniturns);
        }

        public AssignmentLine GetNextAssignmentLine(Index chosen_candidate)
        {
            int worker_index = selected_workers.GetIndex(chosen_candidate.Worker.ID), next_miniturn;

            for (next_miniturn = 0; next_miniturn < total_miniturns && assignment_lines[worker_index, next_miniturn] != null; next_miniturn++) ;
            if (next_miniturn >= total_miniturns) return null;

            int total_miniturns_used = total_miniturns - next_miniturn;
            int products = Convert.ToInt32(Math.Truncate(total_miniturns_used * Simulation.MiniturnLength / chosen_candidate.AverageTime));
            
            return new AssignmentLine(chosen_candidate.Worker, chosen_candidate.Recipe, chosen_candidate.Job, next_miniturn, total_miniturns_used, products);
        }
    }
}