﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkaArt.Presentation.Purchases
{
    public partial class SupplierDetail : Form
    {
        public SupplierDetail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSupply pageAddSupply = new AddSupply();
            pageAddSupply.Show();
        }
    }
}
