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
    public partial class GenerateSalesReport : Form
    {
        public GenerateSalesReport()
        {
            InitializeComponent();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            SalesReport sales_form = new SalesReport();
            sales_form.Show();
        }
    }
}
