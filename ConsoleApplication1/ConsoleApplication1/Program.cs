﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* todo esto debe repetirse 30 veces con 30 entradas distintas*/
            // for(int i = 0; i < 30; i++){

                Instance instance = new Instance();

                /* GRASP */
                Grasp grasp = new Grasp(instance);
                List<int[]> solutions = grasp.GraspAlgorithm();

                /* Tabu */
                //List<int> initial_solution = instance.getBestSolution(solutions);
                List<int> initial_solution = instance.getInitialSolution();
                TabuSearch tabu = new TabuSearch(instance);

                tabu.run(initial_solution);

                tabu.print();                
                List<int> production = instance.getProduction(tabu.best_solution);
                instance.printProduction(production);

                /* Genetic */
                //GeneticAlgorithm genetic = new GeneticAlgorithm(instance);
                //genetic.CreateFirstGen();
                //List<int> genetic_solution = genetic.RunGenetic();
                //for (int i = 0; i < genetic_solution.Count(); i++)
                //    Console.Write(genetic_solution[i] + ", ");
                //Console.WriteLine();

                //List<int> production = instance.getProduction(genetic_solution);
                //instance.printProduction(production);


            //}

            Console.Read();
        }
    }
}
