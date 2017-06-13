﻿namespace InkaArt.Interface.Sales
{
    partial class DevolutionCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_reason = new System.Windows.Forms.TextBox();
            this.combo_quality = new System.Windows.Forms.ComboBox();
            this.textbox_devtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_igv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textbox_devamount = new System.Windows.Forms.TextBox();
            this.grid_orderline = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.combo_product = new System.Windows.Forms.ComboBox();
            this.numeric_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_doc = new System.Windows.Forms.TextBox();
            this.clientIdentifierLabel = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.combo_doc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.date_deliverydate = new System.Windows.Forms.DateTimePicker();
            this.textbox_docid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textbox_reason);
            this.groupBox2.Controls.Add(this.combo_quality);
            this.groupBox2.Controls.Add(this.textbox_devtotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textbox_igv);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textbox_devamount);
            this.groupBox2.Controls.Add(this.grid_orderline);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.combo_product);
            this.groupBox2.Controls.Add(this.numeric_quantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(515, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 560);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Devolución";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Firebrick;
            this.button_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(393, 110);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(161, 48);
            this.button_delete.TabIndex = 39;
            this.button_delete.Text = "🗑 Eliminar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 348);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Motivo";
            // 
            // textbox_reason
            // 
            this.textbox_reason.BackColor = System.Drawing.Color.White;
            this.textbox_reason.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reason.Location = new System.Drawing.Point(268, 377);
            this.textbox_reason.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_reason.Multiline = true;
            this.textbox_reason.Name = "textbox_reason";
            this.textbox_reason.Size = new System.Drawing.Size(324, 153);
            this.textbox_reason.TabIndex = 34;
            // 
            // combo_quality
            // 
            this.combo_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_quality.FormattingEnabled = true;
            this.combo_quality.Items.AddRange(new object[] {
            "Premium",
            "Estandar",
            "Económico"});
            this.combo_quality.Location = new System.Drawing.Point(261, 65);
            this.combo_quality.Margin = new System.Windows.Forms.Padding(4);
            this.combo_quality.Name = "combo_quality";
            this.combo_quality.Size = new System.Drawing.Size(219, 31);
            this.combo_quality.TabIndex = 29;
            // 
            // textbox_devtotal
            // 
            this.textbox_devtotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_devtotal.Enabled = false;
            this.textbox_devtotal.Location = new System.Drawing.Point(32, 498);
            this.textbox_devtotal.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_devtotal.Name = "textbox_devtotal";
            this.textbox_devtotal.Size = new System.Drawing.Size(219, 30);
            this.textbox_devtotal.TabIndex = 28;
            this.textbox_devtotal.Text = "S/.  0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 473);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Devolución Total";
            // 
            // textbox_igv
            // 
            this.textbox_igv.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_igv.Enabled = false;
            this.textbox_igv.Location = new System.Drawing.Point(33, 438);
            this.textbox_igv.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_igv.Name = "textbox_igv";
            this.textbox_igv.Size = new System.Drawing.Size(219, 30);
            this.textbox_igv.TabIndex = 26;
            this.textbox_igv.Text = "S/.  0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "IGV";
            // 
            // textbox_devamount
            // 
            this.textbox_devamount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_devamount.Enabled = false;
            this.textbox_devamount.Location = new System.Drawing.Point(33, 377);
            this.textbox_devamount.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_devamount.Name = "textbox_devamount";
            this.textbox_devamount.Size = new System.Drawing.Size(219, 30);
            this.textbox_devamount.TabIndex = 21;
            this.textbox_devamount.Text = "S/.  0.00";
            // 
            // grid_orderline
            // 
            this.grid_orderline.AllowUserToAddRows = false;
            this.grid_orderline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_orderline.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.grid_orderline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_orderline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_orderline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_orderline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_orderline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Column1,
            this.cost,
            this.Cantidad,
            this.deleteColumn});
            this.grid_orderline.Location = new System.Drawing.Point(33, 171);
            this.grid_orderline.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.grid_orderline.Name = "grid_orderline";
            this.grid_orderline.Size = new System.Drawing.Size(560, 167);
            this.grid_orderline.TabIndex = 22;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Calidad";
            this.Column1.Name = "Column1";
            // 
            // cost
            // 
            this.cost.HeaderText = "PU";
            this.cost.Name = "cost";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Eliminar";
            this.deleteColumn.Name = "deleteColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Devolución";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Gray;
            this.button_add.Enabled = false;
            this.button_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(243, 110);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(143, 48);
            this.button_add.TabIndex = 21;
            this.button_add.Text = "＋ Agregar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // combo_product
            // 
            this.combo_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_product.FormattingEnabled = true;
            this.combo_product.Items.AddRange(new object[] {
            "Retablo",
            "Piedra de Huamanga",
            "Huaco"});
            this.combo_product.Location = new System.Drawing.Point(33, 65);
            this.combo_product.Margin = new System.Windows.Forms.Padding(4);
            this.combo_product.Name = "combo_product";
            this.combo_product.Size = new System.Drawing.Size(219, 31);
            this.combo_product.TabIndex = 13;
            // 
            // numeric_quantity
            // 
            this.numeric_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_quantity.Location = new System.Drawing.Point(487, 66);
            this.numeric_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_quantity.Name = "numeric_quantity";
            this.numeric_quantity.Size = new System.Drawing.Size(107, 30);
            this.numeric_quantity.TabIndex = 19;
            this.numeric_quantity.ValueChanged += new System.EventHandler(this.numeric_quantity_ValueChanged);
            this.numeric_quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numeric_quantity_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Calidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textbox_doc);
            this.groupBox1.Controls.Add(this.clientIdentifierLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(39, 415);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 224);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // textbox_name
            // 
            this.textbox_name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_name.Enabled = false;
            this.textbox_name.Location = new System.Drawing.Point(33, 148);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(368, 30);
            this.textbox_name.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // textbox_doc
            // 
            this.textbox_doc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_doc.Enabled = false;
            this.textbox_doc.Location = new System.Drawing.Point(33, 74);
            this.textbox_doc.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_doc.Name = "textbox_doc";
            this.textbox_doc.Size = new System.Drawing.Size(368, 30);
            this.textbox_doc.TabIndex = 17;
            // 
            // clientIdentifierLabel
            // 
            this.clientIdentifierLabel.AutoSize = true;
            this.clientIdentifierLabel.Location = new System.Drawing.Point(28, 46);
            this.clientIdentifierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientIdentifierLabel.Name = "clientIdentifierLabel";
            this.clientIdentifierLabel.Size = new System.Drawing.Size(43, 23);
            this.clientIdentifierLabel.TabIndex = 16;
            this.clientIdentifierLabel.Text = "DNI";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Gray;
            this.button_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(149, 176);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(135, 48);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "🔎 Buscar";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_total);
            this.groupBox3.Controls.Add(this.combo_doc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.date_deliverydate);
            this.groupBox3.Controls.Add(this.textbox_docid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button_search);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox3.Location = new System.Drawing.Point(39, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(445, 389);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedido";
            // 
            // textbox_total
            // 
            this.textbox_total.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textbox_total.Enabled = false;
            this.textbox_total.Location = new System.Drawing.Point(32, 321);
            this.textbox_total.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(369, 30);
            this.textbox_total.TabIndex = 30;
            this.textbox_total.Text = "S/.  0.00";
            // 
            // combo_doc
            // 
            this.combo_doc.BackColor = System.Drawing.Color.White;
            this.combo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_doc.Enabled = false;
            this.combo_doc.FormattingEnabled = true;
            this.combo_doc.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.combo_doc.Location = new System.Drawing.Point(33, 68);
            this.combo_doc.Margin = new System.Windows.Forms.Padding(4);
            this.combo_doc.Name = "combo_doc";
            this.combo_doc.Size = new System.Drawing.Size(369, 31);
            this.combo_doc.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 295);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Monto Total";
            // 
            // date_deliverydate
            // 
            this.date_deliverydate.Font = new System.Drawing.Font("Arial", 11F);
            this.date_deliverydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_deliverydate.Location = new System.Drawing.Point(33, 261);
            this.date_deliverydate.Margin = new System.Windows.Forms.Padding(4);
            this.date_deliverydate.Name = "date_deliverydate";
            this.date_deliverydate.Size = new System.Drawing.Size(368, 29);
            this.date_deliverydate.TabIndex = 12;
            // 
            // textbox_docid
            // 
            this.textbox_docid.BackColor = System.Drawing.Color.White;
            this.textbox_docid.Enabled = false;
            this.textbox_docid.Location = new System.Drawing.Point(33, 133);
            this.textbox_docid.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_docid.Name = "textbox_docid";
            this.textbox_docid.Size = new System.Drawing.Size(368, 30);
            this.textbox_docid.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(29, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de Emisión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Número de Documento";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.SteelBlue;
            this.button_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(757, 591);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(143, 48);
            this.button_save.TabIndex = 21;
            this.button_save.Text = "🖫 Guardar";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // DevolutionCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DevolutionCreate";
            this.Text = "Registro de Devolución";
            this.Load += new System.EventHandler(this.DevolutionCreate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_orderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textbox_devtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid_orderline;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox combo_product;
        private System.Windows.Forms.NumericUpDown numeric_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_doc;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label clientIdentifierLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_doc;
        private System.Windows.Forms.DateTimePicker date_deliverydate;
        private System.Windows.Forms.TextBox textbox_docid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_igv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textbox_devamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_quality;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_reason;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteColumn;
    }
}