﻿using System;
using System.Collections.Generic;
using System.Data;
using InkaArt.Business.Purchases;
using System.Windows.Forms;
using System.Linq;

namespace InkaArt.Interface.Purchases
{
    public partial class PurchaseOrder : Form
    {
        PurchaseOrderController control;
        public PurchaseOrder()
        {
            InitializeComponent();
            control = new PurchaseOrderController();
            DataTable purchaseOrderList = control.getData();
            dataGridView_purchaseOrder.DataSource = purchaseOrderList;

            dataGridView_purchaseOrder.Columns["idOrder"].HeaderText = "ID";
            dataGridView_purchaseOrder.Columns["idSupplier"].HeaderText = "Proveedor";
            dataGridView_purchaseOrder.Columns["status"].HeaderText = "Estado";
            dataGridView_purchaseOrder.Columns["creationDate"].HeaderText = "Fecha de emisión";
            dataGridView_purchaseOrder.Columns["deliveryDate"].HeaderText = "Fecha de entrega";
            dataGridView_purchaseOrder.Columns["total"].HeaderText = "Total";

            dataGridView_purchaseOrder.Columns["deliveryDate"].Visible=false;
        }

        private void button_search(object sender, EventArgs e)
        {
            textBox_name.Text = textBox_name.Text.Trim();
            
        }

        private void button_add(object sender, EventArgs e)
        {
            Form purchaseDetail = new PurchaseOrderDetail(control);
            purchaseDetail.Show();
        }

        private void button_delete(object sender, EventArgs e)
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView_purchaseOrder.Rows)
            {
                bool s = Convert.ToBoolean(row.Cells[0].Value);

                if (s == true)
                {
                    toDelete.Add(row);
                }
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dataGridView_purchaseOrder.Rows.Remove(row);
            }
        }

        private void editPurchaseOrder(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentPurchaseOrder = dataGridView_purchaseOrder.CurrentRow;
            Form purchaseDetail = new PurchaseOrderDetail(currentPurchaseOrder,control);
            purchaseDetail.Show();
        }

        private void validating_id(object sender, EventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = textBox_id.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                }
                else
                {
                    MessageBox.Show("Solo puede ingresar números en el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            textBox_id.Text = actualdata;
        }
    }
}
