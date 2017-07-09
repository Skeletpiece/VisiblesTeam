﻿namespace InkaArt.Interface.Warehouse
{
    partial class ProductionMovement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_id_warehouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_name_warehouse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_lote = new System.Windows.Forms.TextBox();
            this.grid_lote = new System.Windows.Forms.DataGridView();
            this.nroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lote)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.text_id_warehouse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.text_name_warehouse);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(890, 104);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Almacén";
            // 
            // text_id_warehouse
            // 
            this.text_id_warehouse.BackColor = System.Drawing.Color.White;
            this.text_id_warehouse.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_warehouse.Location = new System.Drawing.Point(23, 54);
            this.text_id_warehouse.Margin = new System.Windows.Forms.Padding(2);
            this.text_id_warehouse.Name = "text_id_warehouse";
            this.text_id_warehouse.ReadOnly = true;
            this.text_id_warehouse.Size = new System.Drawing.Size(174, 24);
            this.text_id_warehouse.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID";
            // 
            // text_name_warehouse
            // 
            this.text_name_warehouse.BackColor = System.Drawing.Color.White;
            this.text_name_warehouse.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name_warehouse.Location = new System.Drawing.Point(229, 54);
            this.text_name_warehouse.Margin = new System.Windows.Forms.Padding(2);
            this.text_name_warehouse.Name = "text_name_warehouse";
            this.text_name_warehouse.ReadOnly = true;
            this.text_name_warehouse.Size = new System.Drawing.Size(638, 24);
            this.text_name_warehouse.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Nombre";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.SteelBlue;
            this.button_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(393, 428);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(138, 39);
            this.button_save.TabIndex = 55;
            this.button_save.Text = "🖫 Guardar";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.buttonSaveClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.text_lote);
            this.groupBox2.Controls.Add(this.grid_lote);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(890, 284);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lote de Producción";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(822, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 57;
            this.button1.Text = "🔎 Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSearchClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Número de lote";
            // 
            // text_lote
            // 
            this.text_lote.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_lote.Location = new System.Drawing.Point(675, 27);
            this.text_lote.Margin = new System.Windows.Forms.Padding(2);
            this.text_lote.Name = "text_lote";
            this.text_lote.Size = new System.Drawing.Size(142, 24);
            this.text_lote.TabIndex = 34;
            this.text_lote.TextChanged += new System.EventHandler(this.textLoteTextChanged);
            // 
            // grid_lote
            // 
            this.grid_lote.AllowUserToAddRows = false;
            this.grid_lote.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_lote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_lote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroLote,
            this.idProduct,
            this.ProductName,
            this.Cant,
            this.stockWarehouse,
            this.CurrentCant,
            this.MovCant,
            this.Modificar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_lote.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_lote.Location = new System.Drawing.Point(23, 68);
            this.grid_lote.Margin = new System.Windows.Forms.Padding(2);
            this.grid_lote.Name = "grid_lote";
            this.grid_lote.Size = new System.Drawing.Size(844, 187);
            this.grid_lote.TabIndex = 57;
            this.grid_lote.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLoteCellValueChanged);
            // 
            // nroLote
            // 
            this.nroLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nroLote.FillWeight = 70F;
            this.nroLote.HeaderText = "Lote";
            this.nroLote.Name = "nroLote";
            this.nroLote.ReadOnly = true;
            // 
            // idProduct
            // 
            this.idProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProduct.FillWeight = 80F;
            this.idProduct.HeaderText = "ID";
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 120F;
            this.ProductName.DataPropertyName = "name";
            this.ProductName.HeaderText = "Producto";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "produced";
            this.Cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cant.FillWeight = 90F;
            this.Cant.HeaderText = "Cantidad Total";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // stockWarehouse
            // 
            this.stockWarehouse.DataPropertyName = "currentStock";
            this.stockWarehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockWarehouse.FillWeight = 90F;
            this.stockWarehouse.HeaderText = "Stock en almacén";
            this.stockWarehouse.Name = "stockWarehouse";
            this.stockWarehouse.ReadOnly = true;
            // 
            // CurrentCant
            // 
            this.CurrentCant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentCant.FillWeight = 105F;
            this.CurrentCant.DataPropertyName = "product_stock";
            this.CurrentCant.HeaderText = "Cantidad por mover";
            this.CurrentCant.Name = "CurrentCant";
            this.CurrentCant.ReadOnly = true;
            // 
            // MovCant
            // 
            this.MovCant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MovCant.HeaderText = "Cantidad a mover";
            this.MovCant.Name = "MovCant";
            // 
            // Modificar
            // 
            this.Modificar.FillWeight = 90F;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Width = 90;
            // 
            // ProductionMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductionMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de producción";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox text_id_warehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_name_warehouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_lote;
        private System.Windows.Forms.DataGridView grid_lote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovCant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
    }
}