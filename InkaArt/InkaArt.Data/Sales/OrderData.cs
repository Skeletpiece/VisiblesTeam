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
        public NpgsqlDataAdapter orderAdapter()
        {
            NpgsqlDataAdapter orderAdapter = new NpgsqlDataAdapter();
            orderAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Order\";", Connection);
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
            connect();
            adap = orderIdAdapter();
            adap.SelectCommand.Parameters[0].NpgsqlValue = igv;
            data.Clear();
            data = getData(adap, "Order");
            DataTable order = new DataTable();
            order = data.Tables[0];
            DataRow rowOrder = order.Rows[0];
            int orderId = int.Parse(rowOrder["idOrder"].ToString());
            connect();
            adap = insertOrderLineAdapter();
            data.Clear();
            data = getData(adap, "LineItem");
            table = data.Tables["LineItem"];
            foreach(DataRow r in orderLines.Rows)
            {
                row = table.NewRow();
                row["quantity"] = r["Cantidad"];
                row["quality"] = r["Calidad"];
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
            connect();

            adap = recipeIdAdapter();
            adap.SelectCommand.Parameters[0].NpgsqlValue = productId;

            data.Clear();
            data = getData(adap, "Recipe");

            DataTable documentList = new DataTable();
            documentList = data.Tables[0];
            DataRow row = documentList.Rows[0];
            int id = int.Parse(row["idRecipe"].ToString());
            return id;
        }

        private int getProductId(string productName)
        {
            connect();

            adap = productIdAdapter();
            adap.SelectCommand.Parameters[0].NpgsqlValue = productName;

            data.Clear();
            data = getData(adap, "Product");

            DataTable documentList = new DataTable();
            documentList = data.Tables[0];
            DataRow row = documentList.Rows[0];
            int id = int.Parse(row["idProduct"].ToString());
            return id;
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
            productAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"Product\";", Connection);
            return productAdapter;
        }
        public NpgsqlDataAdapter insertDocumentAdapter()
        {
            NpgsqlDataAdapter insertDocumentAdapter = new NpgsqlDataAdapter();
            insertDocumentAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"SalesDocument\";", Connection);
            return insertDocumentAdapter;
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
            insertOrderLineAdapter.SelectCommand = new NpgsqlCommand("SELECT * FROM inkaart.\"LineItem\";", Connection);
            return insertOrderLineAdapter;
        }
        public DataTable GetDocumentTypes()
        {
            connect();

            adap = documentAdapter();

            data.Clear();
            data = getData(adap, "DocumentType");

            DataTable documentList = new DataTable();
            documentList = data.Tables[0];
            return documentList;
        }
        public DataTable GetProducts()
        {
            connect();

            adap = productAdapter();

            data.Clear();
            data = getData(adap, "Product");

            DataTable productList = new DataTable();
            productList = data.Tables[0];
            return productList;
        }
        public int InsertSaleDocument(int documentTypeId, float saleAmount, float igv, float totalAmount)
        {
            connect();
            adap = insertDocumentAdapter();
            data.Clear();
            data = getData(adap, "SalesDocument");
            table = data.Tables["SalesDocument"];
            row = table.NewRow();
            row["idDocumentType"] = documentTypeId;
            row["amount"] = saleAmount;
            row["igv"] = igv;
            row["totalAmount"] = totalAmount;
            table.Rows.Add(row);

            int rowsAffected = insertData(data, adap, "SalesDocument");
            return rowsAffected;
        }
        public int InsertOrder(int idClient, DateTime deliveryDate, string saleAmount, string igv, string totalAmount, string orderStatus, int bdStatus)
        {
            connect();
            adap = insertOrderAdapter();
            data.Clear();
            data = getData(adap, "Order");
            table = data.Tables["Order"];
            row = table.NewRow();
            row["idClient"] = idClient;
            row["deliveryDate"] = deliveryDate;
            row["saleAmount"] = totalAmount;
            row["igv"] = igv;
            row["totalAmount"] = totalAmount;
            row["bdStatus"] = bdStatus;
            row["orderStatus"] = orderStatus;
            table.Rows.Add(row);
            int rowsAffected = insertData(data, adap, "Order");
            return rowsAffected;
        }
    }
}
