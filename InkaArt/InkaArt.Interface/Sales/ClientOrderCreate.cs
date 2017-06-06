﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InkaArt.Business.Sales;

namespace InkaArt.Interface.Sales
{
    public partial class ClientOrderCreate : Form
    {
        OrderController orderController = new OrderController();
        DataTable saleDocumentList;
        DataTable productList;
        private int currentClientId;
        private double amount;
        public ClientOrderCreate()
        {
            InitializeComponent();
            amount = 0;
        }

        public ClientOrderCreate(string text)
        {
            InitializeComponent();
            Text = text;
        }

        private void clients_index_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClientOrderCreate_Load(object sender, EventArgs e)
        {
            saleDocumentList = orderController.GetDocumentTypes();
            populateCombobox(combo_doc, saleDocumentList, "nombre", "idTipoDocumento");
            productList = orderController.GetProducts();
            populateCombobox(combo_product, productList, "name", "idProduct");
        }

        private void populateCombobox(ComboBox combo, DataTable dataSource, string displayParam, string valueParam)
        {
            var dp = displayParam;
            var vp = valueParam;
            Dictionary<string, string> obj = new Dictionary<string, string>();
            foreach (DataRow row in dataSource.Rows)
            {
                obj.Add(row[dp].ToString(), row[vp].ToString());
            }
            combo.DataSource = new BindingSource(obj, null);
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int docTypeId = -1;
            foreach (DataRow row in saleDocumentList.Rows)
            {
                if (row["nombre"].ToString().Equals(combo_doc.Text))
                    docTypeId = int.Parse(row["idTipoDocumento"].ToString());
            }
            DataTable orderLine = parseDataGrid(grid_orderline);
            int response = orderController.AddOrder(currentClientId, docTypeId, date_delivery.Value, textbox_amount.Text, textbox_igv.Text, textbox_total.Text, "registrado", 1, orderLine,"pedido");
            if (response > 0)
            {
                MessageBox.Show(this, "El pedido ha sido registrado con éxito.", "Registrar Pedido", MessageBoxButtons.OK);
                ClearFields();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ClearFields()
        {
            amount = 0;
            currentClientId = -1;
            date_delivery.Value = DateTime.Now;
            textbox_doc.Clear();
            textbox_name.Clear();
            numeric_quantity.Value = 0;
            grid_orderline.Rows.Clear();
            textbox_amount.Text = textbox_igv.Text = textbox_total.Text = "S/. 0.00";
        }

        private DataTable parseDataGrid(DataGridView grid_orderline)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in grid_orderline.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in grid_orderline.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Form client_form = new ClientCreate();
            client_form.Show();
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            var form = new ClientSearch();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentClientId = form.SelectedClientId;
                textbox_doc.Text = form.SelectedClientDoc.ToString();
                textbox_name.Text = form.SelectedClientName;
            }
        }

        private void ClientOrderCreate_Shown(object sender, EventArgs e)
        {

        }

        private void combo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_doc.Text.Equals("Boleta"))
                clientIdentifierLabel.Text = "DNI";
            else
                clientIdentifierLabel.Text = "RUC";
        }

        private void numeric_quantity_ValueChanged(object sender, EventArgs e)
        {
            button_add.Enabled = numeric_quantity.Value > 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Console.WriteLine(combo_product.SelectedValue);
            if (productList.Rows.Count == 0) productList = orderController.GetProducts();
            foreach (DataRow row in productList.Rows)
            {
                var aux = row["idProduct"];
                string strAux = aux.ToString();
                if (combo_product.SelectedValue.ToString().Equals(row["idProduct"].ToString()))
                {
                    float price = float.Parse(row["localPrice"].ToString()) + float.Parse(row["basePrice"].ToString());
                    amount += price * float.Parse(numeric_quantity.Value.ToString());
                    grid_orderline.Rows.Add(row["name"], combo_quality.Text, price.ToString(), numeric_quantity.Value.ToString());
                }
            }
            textbox_amount.Text = Math.Round(amount,2).ToString();
            textbox_igv.Text = Math.Round((0.18 * amount),2).ToString();
            textbox_total.Text = Math.Round((1.18 * amount),2).ToString();
        }

        private void numeric_quantity_KeyUp(object sender, KeyEventArgs e)
        {
            button_add.Enabled = numeric_quantity.Value > 0;
        }
    }
}
