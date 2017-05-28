﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace InkaArt.Classes
{

    public class BD_Connector
    {
        private NpgsqlConnection connection;
        private static NpgsqlConnectionStringBuilder connectionString;
        private string serverAddress;
        private string databaseName;
        private string uid, pwd;
        private int port;
        public BD_Connector()
        {
            ConnectionString = new NpgsqlConnectionStringBuilder();

            ConnectionString.Host = "skeletpiece.homeip.net";
            ConnectionString.Database = "desarrolloprogramas1";
            ConnectionString.Username = "admin";
            ConnectionString.Password = "fae48";
            ConnectionString.Pooling = true;
        }

        public void connect()
        {
            try
            {
                Connection = new NpgsqlConnection(ConnectionString.ConnectionString);
                Connection.Open();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
        }

        public DataSet getData(NpgsqlDataAdapter adapter, string srcTable)
        {
            DataSet data = new DataSet();
            
            adapter.Fill(data, srcTable);

            Connection.Close();

            return data;
        }

        private void execute(string command)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = command;
            cmd.Connection = Connection;
            try
            {
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
        }

        public void commit()
        {
            execute("COMMIT;");
        }

        public void closeConnection()
        {
            Connection.Close();
        }

        public string ServerAddress { get { return serverAddress; } set { serverAddress = value; } }
        protected NpgsqlConnection Connection { get { return connection; } set { connection = value; } }
        public static NpgsqlConnectionStringBuilder ConnectionString { get { return connectionString; } set { connectionString = value; } }
        public string DatabaseName { get { return databaseName; } set { databaseName = value; } }
        public string Uid { get { return uid; } set { uid = value; } }
        public string Pwd { get { return pwd; } set { pwd = value; } }
        public int Port { get { return port; } set { port = value; } }
    }
}
