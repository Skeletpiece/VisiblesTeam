﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkaArt.Interface.Production
{
    public partial class GenerateProductivityReport : Form
    {
        public GenerateProductivityReport()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            ProductivityReport productivity_form = new ProductivityReport();
            productivity_form.Show();
        }
    }
}