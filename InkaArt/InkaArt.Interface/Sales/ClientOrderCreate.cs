﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkaArt.Interface.Sales
{
    public partial class ClientOrderCreate : Form
    {
        public ClientOrderCreate()
        {
            InitializeComponent();
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

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Form client_form = new ClientCreate();
            client_form.Show();
        }
        
        private void documentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (documentCombo.Text.Equals("Boleta"))
                clientIdentifierLabel.Text = "DNI";
            else
                clientIdentifierLabel.Text = "RUC";

        }
        
    }
}
