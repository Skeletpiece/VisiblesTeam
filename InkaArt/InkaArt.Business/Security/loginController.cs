﻿using encription_SHA256;
using InkaArt.Data.Security;
using Npgsql;
using System;
using System.Data;
using sendEmail;

namespace InkaArt.Business.Security
{
    public class LoginController
    {
        private UserController user;
        private NpgsqlDataAdapter adap;
        private DataSet data;
        private DataRow row;
        public static int userID, roleID;
        public static string userName, firstName, lastName;
        public LoginController()
        {
            user = new UserController();
            adap = new NpgsqlDataAdapter();
            data = new DataSet();
        }
        public bool checkCredentials(string loginUsername, string loginPass)
        {
            bool verified = false;
            SHA_2 sha = new SHA_2();
            string key = sha.encrypt(loginPass);
            
            row = user.getUserRow(loginUsername);

            //  Read data from DB
            
            string userDB, keyDB;

            if (row != null)   //Encontro un usuario
            {
                userDB = row["username"].ToString();
                userName = userDB;
                keyDB = row["password"].ToString();
                userID = Convert.ToInt32(row["id_user"]);
                roleID = Convert.ToInt32(row["id_role"]);
            }
            else
            {
                userDB = "wrongUsername";
                keyDB = "badPassword";
            }


            if (string.Equals(key, keyDB) & string.Equals(loginUsername, userDB))
            {
                verified = true;
            }
            return verified;
        }
        public void sendResetPassword(string username)
        {
            user.sendResetPass(username);
        }
    }
}
