﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkaArt.Model
{
    class Solution
    {
        private List<Assignment> assignments;
        private double objective_function_value;

        public Solution(List<Assignment> assignments, double objective_function_value)
        {
            this.assignments = assignments;
            this.objective_function_value = objective_function_value;
        }

        public double ObjectiveFunctionValue
        {
            get { return objective_function_value; }
            set { objective_function_value = value; }
        }

        public void Print()
        {
            Console.WriteLine("Solución GRASP con valor objetivo {0}:",
                objective_function_value);
            for (int i = 0; i < assignments.Count; i++)
            {
                Console.Write("Asignación {0}: ", i + 1);
                assignments[i].Print();
            }
        }

        public int[] ToArray(int number_of_workers)
        {
            int[] solution = new int[number_of_workers];
            for (int i = 0; i < number_of_workers; i++)
            {
                solution[i] = 0;
            }
            for (int i = 0; i < assignments.Count; i++)
            {
                solution[assignments[i].worker.id - 1] = assignments[i].process_product.id;
            }
            return solution;
        }
    }
}