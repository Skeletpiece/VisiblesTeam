﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InkaArt.Classes;
using System.Data;
using Npgsql;

namespace InkaArt.Data.Sales
{
    public class OrderData : BD_Connector
    {
        private DataSet data;
        private DataTable table;
        private DataRow row;
        private NpgsqlDataAdapter adap;
        public OrderData()
        {
            data = new DataSet();
        }
        public DataTable GetOrders(int id = -1, string type = "", long doc = -1, string clientName = "", string orderStatus = "")
        {
            adap = orderAdapter();
            byClient(adap,doc,clientName);
            byId(adap,id);
            byType(adap,type);
            byOrderStatus(adap,orderStatus);
            adap.SelectCommand.CommandText += ";";
            data.Clear();
            data = getData(adap, "Orders");
            DataTable orderList = new DataTable();
            orderList = data.Tables[0];
            return orderList;
        }

        private void byClient(NpgsqlDataAdapter adap, long doc, string clientName)
        {
            if (doc == -1 && clientName.Equals("")) return;
            int id = getClientId(doc,clientName);
            if (id != -1)
            {
                int numParams = adap.SelectCommand.Parameters.Count();
                if (numParams == 0) adap.SelectCommand.CommandText += " WHERE ";
                else adap.SelectCommand.CommandText += " AND ";
                adap.SelectCommand.CommandText += "\"idClient\" = :idClient";
                adap.SelectCommand.Parameters.Add(new NpgsqlParameter("idClient", DbType.Int32));
                adap.SelectCommand.Parameters[numParams].Direction = ParameterDirection.Input;
                adap.SelectCommand.Parameters[numParams].SourceColumn = "idClient";
                adap.SelectCommand.Parameters[numParams].NpgsqlValue = id;
            }
        }

        private int getClientId(long doc, string clientName)
        {
            NpgsqlDataAdapter curAdap = new NpgsqlDataAdapter();
            DataSet curData = new DataSet();
            curAdap = clientAdapter();
            curAdap.SelectCommand.CommandText += " WHERE ";
            if (doc != -1)
            {
                curAdap.SelectCommand.CommandText += "ruc = :ruc";
                curAdap.SelectCommand.Parameters.Add(new NpgsqlParameter("ruc", DbType.Int64));
                curAdap.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
                curAdap.SelectCommand.Parameters[0].SourceColumn = "ruc";
                curAdap.SelectCommand.Parameters[0].NpgsqlValue = doc;
                if (!clientName.Equals("")) curAdap.SelectCommand.CommandText += " AND ";
                else curAdap.SelectCommand.CommandText += ";";
            }
            if (!clientName.Equals(""))
            {
                clientName = "%" + clientName + "%";
                curAdap.SelectCommand.CommandText += "name LIKE :name";
                curAdap.SelectCommand.Parameters.Add(new NpgsqlParameter("name", DbType.AnsiStringFixedLength));
                curAdap.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
                curAdap.SelectCommand.Parameters[0].SourceColumn = "name";
                curAdap.SelectCommand.Parameters[0].NpgsqlValue = clientName;
                if (doc != -1) curAdap.SelectCommand.CommandText += " AND ";
                else curAdap.SelectCommand.CommandText += ";";
            }
            curData.Clear();
            curData = getData(curAdap, "Client");
            DataTable client = new DataTable();
            client = data.Tables[0];
            return int.Parse(client.Rows[0]["idClient"].ToString());
        }

        private void byOrderStatus(NpgsqlDataAdapter adap, string orderStatus)
        {
            if (orderStatus.Equals("")) return;
            int numParams = adap.SelectCommand.Parameters.Count();
            if (numParams == 0) adap.SelectCommand.CommandText += " WHERE ";
            else adap.SelectCommand.CommandText += " AND ";
            adap.SelectCommand.CommandText += "orderStatus LIKE :orderStatus";
            adap.SelectCommand.Parameters.Add(new NpgsqlParameter("orderStatus", DbType.AnsiStringFixedLength));
            adap.SelectCommand.Parameters[numParams].Direction = ParameterDirection.Input;
            adap.SelectCommand.Parameters[numParams].SourceColumn = "orderStatus";
            adap.SelectCommand.Parameters[numParams].NpgsqlValue = orderStatus;

        }
        private void byType(NpgsqlDataAdapter adap, string type)
        {
            if (type.Equals("")) return;
            int numParams = adap.SelectCommand.Parameters.Count();
            if (numParams == 0) adap.SelectCommand.CommandText += " WHERE ";
            else adap.SelectCommand.CommandText += " AND ";
            adap.SelectCommand.CommandText += "type LIKE :type";
            adap.SelectCommand.Parameters.Add(new NpgsqlParameter("type", DbType.AnsiStringFixedLength));
            adap.SelectCommand.Parameters[numParams].Direction = ParameterDirection.Input;
            adap.SelectCommand.Parameters[numParams].SourceColumn = "type";
            adap.SelectCommand.Parameters[numParams].NpgsqlValue = type;
        }

        private void byId(NpgsqlDataAdapter adap, int id)
        {
            if (id == -1) return;
            int numParams = adap.SelectCommand.Parameters.Count();
            if (numParams == 0) adap.SelectCommand.CommandText += " WHERE ";
            else adap.SelectCommand.CommandText += " AND ";
            adap.SelectCommand.CommandText += "\"idOrder\" = :idOrder";
            adap.SelectCommand.Parameters.Add(new NpgsqlParameter("idOrder", DbType.Int32));
            adap.SelectCommand.Parameters[numParams].Direction = ParameterDirection.Input;
            adap.SelectCommand.Parameters[numParams].SourceColumn = "idOrder";
            adap.SelectCommand.Parameters[numParams].NpgsqlValue = id;
        }

        public NpgsqlDataAdapter orderAdapter()
        {
            NpgsqlDataAdapter orderAdapter = new NpgsqlDataAdapter();
            orderAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Order\"", Connection);
            return orderAdapter;
        }
        public NpgsqlDataAdapter orderIdAdapter()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT \"idOrder\" FROM inkaart.\"Order\" WHERE igv = :igv;", Connection);
            adapter.SelectCommand.Parameters.Add(new NpgsqlParameter("igv", DbType.Double));
            adapter.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters[0].SourceColumn = "igv";
            return adapter;
        }
        public NpgsqlDataAdapter documentAdapter()
        {
            NpgsqlDataAdapter documentAdapter = new NpgsqlDataAdapter();
            documentAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"DocumentType\";", Connection);
            return documentAdapter;
        }

        public int InsertOrderLines(DataTable orderLines, double igv)
        {
            adap = orderAdapter();
            data.Clear();
            data = getData(adap, "Order");
            DataTable order;
            order = data.Tables[0];
            int index = order.Rows.Count;
            DataRow rowOrder = order.Rows[index - 1];
            int orderId = int.Parse(rowOrder["idOrder"].ToString());
            adap = insertOrderLineAdapter();
            adap.SelectCommand.CommandText += ";";
            data.Clear();
            data = getData(adap, "LineItem");
            table = data.Tables["LineItem"];
            foreach (DataRow r in orderLines.Rows)
            {
                row = table.NewRow();
                var cantColumn = r["Cantidad"];
                if (cantColumn == DBNull.Value) break;
                float cant = float.Parse(r["Cantidad"].ToString());
                string cali = r["Calidad"].ToString();
                row["quantity"] = cant;
                row["quality"] = cali;
                row["idRecipe"] = getRecipeId(getProductId(r["Producto"].ToString()));
                row["idProduct"] = getProductId(r["Producto"].ToString());
                row["idOrder"] = orderId;
                table.Rows.Add(row);
            }
            int rowsAffected = insertData(data, adap, "LineItem");
            return rowsAffected;
        }

        private int getRecipeId(int productId)
        {
            DataSet myData = new DataSet();
            NpgsqlDataAdapter myAdap = recipeIdAdapter();
            myAdap.SelectCommand.Parameters[0].NpgsqlValue = productId;

            myData.Clear();
            myData = getData(myAdap, "Recipe");

            DataTable documentList = new DataTable();
            documentList = myData.Tables[0];
            DataRow row = documentList.Rows[0];
            int id = int.Parse(row["idRecipe"].ToString());
            return id;
        }

        private int getProductId(string productName)
        {
            DataSet myData = new DataSet();
            NpgsqlDataAdapter myAdap = productIdAdapter();
            myAdap.SelectCommand.Parameters[0].NpgsqlValue = productName;

            myData.Clear();
            myData = getData(myAdap, "Product");

            DataTable documentList = new DataTable();
            documentList = myData.Tables[0];
            DataRow row = documentList.Rows[0];
            int id = int.Parse(row["idProduct"].ToString());
            return id;
        }
        public string getProductPU(int id)
        {
            NpgsqlDataAdapter curAdap = new NpgsqlDataAdapter();
            DataSet curData = new DataSet();
            curAdap = productAdapter();
            curAdap.SelectCommand.CommandText += " WHERE \"idProduct\" = :idProduct;";
            curAdap.SelectCommand.Parameters.Add(new NpgsqlParameter("idProduct", DbType.Int32));
            curAdap.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            curAdap.SelectCommand.Parameters[0].SourceColumn = "idProduct";
            curAdap.SelectCommand.Parameters[0].NpgsqlValue = id;
            curData.Clear();
            curData = getData(curAdap, "Product");
            DataTable orderLine = new DataTable();
            orderLine = curData.Tables[0];
            string pu = (double.Parse(orderLine.Rows[0]["localPrice"].ToString()) + double.Parse(orderLine.Rows[0]["basePrice"].ToString())).ToString();
            return pu;
        }

        public string getProductName(int id)
        {
            NpgsqlDataAdapter curAdap = new NpgsqlDataAdapter();
            DataSet curData = new DataSet();
            curAdap = productAdapter();
            curAdap.SelectCommand.CommandText += " WHERE \"idProduct\" = :idProduct;";
            curAdap.SelectCommand.Parameters.Add(new NpgsqlParameter("idProduct", DbType.Int32));
            curAdap.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            curAdap.SelectCommand.Parameters[0].SourceColumn = "idProduct";
            curAdap.SelectCommand.Parameters[0].NpgsqlValue = id;
            curData.Clear();
            curData = getData(curAdap, "Product");
            DataTable orderLine = new DataTable();
            orderLine = curData.Tables[0];            
            return orderLine.Rows[0]["name"].ToString();
        }
        public DataTable getOrderLines(int idOrder)
        {
            NpgsqlDataAdapter curAdapter = new NpgsqlDataAdapter();
            DataSet curData = new DataSet();
            curAdapter = insertOrderLineAdapter();
            curAdapter.SelectCommand.CommandText += " WHERE \"idOrder\" = :idOrder;";
            curAdapter.SelectCommand.Parameters.Add(new NpgsqlParameter("idOrder", DbType.Int32));
            curAdapter.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            curAdapter.SelectCommand.Parameters[0].SourceColumn = "idOrder";
            curAdapter.SelectCommand.Parameters[0].NpgsqlValue = idOrder;
            curData.Clear();
            curData = getData(curAdapter, "LineItem");
            DataTable orderLines = new DataTable();
            orderLines = curData.Tables[0];
            return orderLines;
        }
        public NpgsqlDataAdapter productIdAdapter()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT \"idProduct\" FROM inkaart.\"Product\" WHERE name = :name;", Connection);
            adapter.SelectCommand.Parameters.Add(new NpgsqlParameter("name", DbType.AnsiStringFixedLength));
            adapter.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters[0].SourceColumn = "name";
            return adapter;
        }
        public NpgsqlDataAdapter recipeIdAdapter()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT \"idRecipe\" FROM inkaart.\"Recipe\" WHERE \"idProduct\" = :idProduct;", Connection);
            adapter.SelectCommand.Parameters.Add(new NpgsqlParameter("idProduct", DbType.Int32));
            adapter.SelectCommand.Parameters[0].Direction = ParameterDirection.Input;
            adapter.SelectCommand.Parameters[0].SourceColumn = "idProduct";
            return adapter;
        }
        public NpgsqlDataAdapter productAdapter()
        {
            NpgsqlDataAdapter productAdapter = new NpgsqlDataAdapter();
            productAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Product\"", Connection);
            return productAdapter;
        }
        public NpgsqlDataAdapter insertOrderAdapter()
        {
            NpgsqlDataAdapter insertOrderAdapter = new NpgsqlDataAdapter();
            insertOrderAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Order\";", Connection);
            return insertOrderAdapter;
        }
        public NpgsqlDataAdapter insertOrderLineAdapter()
        {
            NpgsqlDataAdapter insertOrderLineAdapter = new NpgsqlDataAdapter();
            insertOrderLineAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"LineItem\"", Connection);
            return insertOrderLineAdapter;
        }
        public NpgsqlDataAdapter clientAdapter()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            adapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Client\";", Connection);
            return adapter;
        }
        public DataTable GetDocumentTypes()
        {

            adap = documentAdapter();

            data.Clear();
            data = getData(adap, "DocumentType");

            DataTable documentList = new DataTable();
            documentList = data.Tables[0];
            return documentList;
        }
        public DataTable GetProducts()
        {

            adap = productAdapter();
            adap.SelectCommand.CommandText += ";";
            data.Clear();
            data = getData(adap, "Product");

            DataTable productList = new DataTable();
            productList = data.Tables[0];
            return productList;
        }
        public int InsertOrder(int idClient, DateTime deliveryDate, string saleAmount, string igv, string totalAmount, string orderStatus, int bdStatus, string type)
        {
            adap = insertOrderAdapter();
            data.Clear();
            data = getData(adap, "Order");
            table = data.Tables["Order"];
            row = table.NewRow();
            row["idClient"] = idClient;
            row["deliveryDate"] = deliveryDate;
            row["saleAmount"] = saleAmount;
            row["igv"] = igv;
            row["totalAmount"] = totalAmount;
            row["bdStatus"] = bdStatus;
            row["orderStatus"] = orderStatus;
            row["type"] = type;
            table.Rows.Add(row);
            int rowsAffected = insertData(data, adap, "Order");
            return rowsAffected;
        }
    }
}
