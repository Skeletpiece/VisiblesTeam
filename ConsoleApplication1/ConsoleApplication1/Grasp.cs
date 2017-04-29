﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Grasp
    {
        //Parámetros del algoritmo
        private static double Alpha = 0.2;
        private static int Iterations = 100;

        //Atributos
        private List<Worker> workers;
        private List<Ratio> ratios;
        private Random random;
        private List<ProcessProduct> process_product;

        public Grasp(Instance instance)
        {
            this.workers = instance.workers;
            //workers.OrderBy(worker => worker.id);
            this.ratios = instance.ratios;
            //ratios.OrderBy(ratio => ratio.worker.id).ThenBy(ratio => ratio.process_product_id);
            this.random = new Random();

            //instance.processes_products.CopyTo(jobs_per_process);

            //Revisar después
            Process tallado = new Process(1, "Tallado", 10);
            Process modelado = new Process(2, "Modelado", 10);
            Process horneado = new Process(3, "Horneado", 10);
            Process pintado = new Process(4, "Pintado", 10);
            process_product = new List<ProcessProduct>();
            process_product.Add(new ProcessProduct(10, modelado, 0));
            process_product.Add(new ProcessProduct(11, pintado, 0));
            process_product.Add(new ProcessProduct(12, horneado, 0));
            process_product.Add(new ProcessProduct(20, tallado, 1));
            process_product.Add(new ProcessProduct(30, tallado, 2));
            process_product.Add(new ProcessProduct(31, pintado, 2));

            //ESTO YA SE TENÍA QUE HACER EN RATIO!!!
            for (int i = 0; i < ratios.Count; i++)
                ratios[i].loss_index = instance.breakage_weight * ratios[i].breakage
                    + instance.time_weight * ratios[i].time;
        }

        public void GraspAlgorithm()
        {
            //Inicializar conjunto de soluciones como vacío
            List<GraspOutput> solution_list = new List<GraspOutput>();

            for (int i = 0; i < Iterations; i++)
            {
                //Obtener la lista de candidatos y calcular la función de costo para cada trabajador
                List<Assignment> candidates = this.ratios.ConvertAll(ratio =>
                    new Assignment(ratio.worker, ratio.process_product_id, ratio.loss_index));

                //Obtener solución y colocarla en la lista
                solution_list.Add(GenerateSolution(candidates));
            }

            //Convertir lista a soluciones
            List<int[]> solution_list_array = new List<int[]>();
            for (int i = 0; i < solution_list.Count; i++)
            {
                int[] solution = GraspOutput.ToArray(solution_list[i], workers.Count);
                solution_list_array.Add(solution);
            }
        }

        private GraspOutput GenerateSolution(List<Assignment> candidates)
        {
            //Inicializar solución como vacía y el valor de la F.O. en la máxima
            List<Assignment> solution = new List<Assignment>();
            double value_o_f = 0;

            for (int iteration_construction = 1; candidates.Count > 0; iteration_construction++)
            {
                //Obtener una lista de los trabajadores más eficientes
                List<Assignment> rcl = GenerateRCL(candidates);

                //Escoger un trabajador al azar e incorporarlo en la solución
                Assignment chosen = rcl[random.Next(0, rcl.Count - 1)];
                solution.Add(chosen);
                value_o_f += chosen.Cost;
                
                //Remover todos los candidatos que involucren al trabajador
                candidates.RemoveAll(Assignment.byWorker(chosen.Worker));
                //Si se agotaron los puestos de trabajo por proceso, quitar todos los relacionados
                if (Assignment.NumberOfProcessProducts(solution, chosen.ProcessProduct) >=
                    ProcessProduct.GetByID(process_product, chosen.ProcessProduct).process.number_jobs)
                {
                    candidates.RemoveAll(Assignment.byProcessProductId(chosen.ProcessProduct));
                }

                //Recalcular los costos para la función objetivo
                for (int k = 0; k < candidates.Count; k++)
                    candidates[k].NextCost(value_o_f, iteration_construction);
            }

            return new GraspOutput(solution, value_o_f);
        }

        public List<Assignment> GenerateRCL(List<Assignment> candidates)
        {
            List <Assignment> rcl = new List<Assignment>();
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Cost < min) min = candidates[i].Cost;
                if (candidates[i].Cost > max) max = candidates[i].Cost;
            }
            double max_rcl = min + Alpha * (max - min);
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Cost >= min && candidates[i].Cost <= max_rcl)
                    rcl.Add(candidates[i]);
            }
            return rcl;
        }
    }
}