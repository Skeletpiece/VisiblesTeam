﻿using encription_SHA256;
using InkaArt.Data.Security;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;

namespace InkaArt.Business.Security
{
    public class UserController
    {
        private UserData user;
        private NpgsqlDataAdapter adap;
        private DataSet data;
        private DataTable table;
        private DataRow row;
        public bool checkCredentials(string loginUsername, string loginPass)
        {
            bool verified = false;
            SHA_2 sha = new SHA_2();
            string key = sha.encrypt(loginPass);

            user = new UserData();
            adap = new NpgsqlDataAdapter();
            data = new DataSet();

            user.connect();
            adap = user.userAdapter();
            adap.SelectCommand.Parameters[0].NpgsqlValue = loginUsername;

            data.Reset();
            data = user.getData(adap, "User");

            //  Read data from DB
            int rows = data.Tables[0].Rows.Count;
            string userDB, keyDB;

            if (rows > 0)   //Encontro un usuario
            {
                userDB = data.Tables["User"].Rows[0]["username"].ToString();
                keyDB = data.Tables["User"].Rows[0]["password"].ToString(); ;
            }
            else
            {
                userDB = "wrongUsername";
                keyDB = "badPassword";
            }


            if (string.Equals(key, keyDB) & string.Equals(loginUsername, userDB))
            {
                //  ToDo - GET ROLES

                //  GRANT ACCESS
                verified = true;
            }

            /*
             * ================================================
             * TEST LINE TO INSERT DATA
            insertData();
             * ================================================
            */
            return verified;
        }

        public void insertData()
        {
            //  Get connection string and connect to the database
            user.connect();
            
            //  Get the dataset table to modify
            table = data.Tables["User"];

            //  Create a new row for the table (Users)
            row = table.NewRow();

            //  Add the necesary fields
            row["username"] = "test1";
            row["password"] = "test1";
            row["status"] = 1;
            row["description"] = "descrip";

            //  Add the row created into the table
            table.Rows.Add(row);

            //  Push the data to the database (Will only work once, as the DB only accepts unique users, please delete the user created)
            int rowsAffected = user.insertData(data, adap, "User");
        }
    }
}
