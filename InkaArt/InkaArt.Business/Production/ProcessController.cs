﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InkaArt.Data.Production;
using NpgsqlTypes;
using Npgsql;

namespace InkaArt.Business.Production
{
    public class ProcessController
    {
        private ProcessData process;
        private NpgsqlDataAdapter adapt;
        private DataSet data;
        private DataTable table;
        private DataRow row;

        public ProcessController()
        {
            process = new ProcessData();
            data = new DataSet();
            adapt = new NpgsqlDataAdapter();
        }

        public DataTable getData()
        {
            //adapt = new NpgsqlDataAdapter();
            adapt = process.processAdapter();

            data.Reset();
            data = process.getData(adapt, "Process");

            DataTable processList = new DataTable();
            processList = data.Tables[0];

            return processList;
        }

        public void insertData(string desc, string totalWorkstations)
        {
            adapt = process.processAdapter();

            data.Clear();
            data = process.getData(adapt, "Process");

            table = data.Tables["Process"];

            row = table.NewRow();

            row["description"] = desc;
            row["number_of_jobs"] = totalWorkstations;

            table.Rows.Add(row);
            int rowsAffected = process.insertData(data, adapt, "Process");
        }

        public void updateData(string id, string totatWorkstations)
        {
            adapt = process.processAdapter();

            data.Clear();
            data = process.getData(adapt, "Process");

            table = data.Tables["Process"];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (String.Compare(table.Rows[i]["id_process"].ToString(), id) == 0)
                {
                    //Debug.WriteLine(totatWorkstations);
                    table.Rows[i]["number_of_jobs"] = totatWorkstations;
                    break;
                }
            }
            int rowUpdated = process.updateData(data, adapt, "Process");
        }

        public void updateDataNoAdapter(int id, int number_of_jobs)
        {
            string updateQuery;
            //int filtros = 0;
            table = getData();  //ACA se inicializa la CONEXION, el GETDATA hace toda la inicializacion
            updateQuery = "UPDATE inkaart.\"Process\" SET ";
            updateQuery = updateQuery + "number_of_jobs = '" + number_of_jobs + "' ";
            updateQuery = updateQuery + " WHERE id_process = " + id + ";";
            process.execute(updateQuery);
        }
    }
}
