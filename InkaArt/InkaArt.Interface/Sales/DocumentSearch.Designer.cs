﻿namespace InkaArt.Interface.Sales
{
    partial class DocumentSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_documents = new System.Windows.Forms.DataGridView();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.button_see = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_documents)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_documents
            // 
            this.grid_documents.AllowUserToAddRows = false;
            this.grid_documents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_documents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_documents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_documents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_documents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_documents.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_documents.Location = new System.Drawing.Point(29, 28);
            this.grid_documents.Margin = new System.Windows.Forms.Padding(2);
            this.grid_documents.Name = "grid_documents";
            this.grid_documents.ReadOnly = true;
            this.grid_documents.RowTemplate.Height = 24;
            this.grid_documents.Size = new System.Drawing.Size(661, 384);
            this.grid_documents.TabIndex = 0;
            this.grid_documents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_documents_CellContentDoubleClick);
            this.grid_documents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_documents_CellDoubleClick);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.button_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(448, 434);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(150, 39);
            this.button_cancel.TabIndex = 32;
            this.button_cancel.Text = "🗙 Cancelar";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.SteelBlue;
            this.button_select.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.ForeColor = System.Drawing.Color.White;
            this.button_select.Location = new System.Drawing.Point(282, 434);
            this.button_select.Margin = new System.Windows.Forms.Padding(2);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(150, 39);
            this.button_select.TabIndex = 31;
            this.button_select.Text = "✓ Seleccionar";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_see
            // 
            this.button_see.BackColor = System.Drawing.Color.SteelBlue;
            this.button_see.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_see.ForeColor = System.Drawing.Color.White;
            this.button_see.Location = new System.Drawing.Point(120, 434);
            this.button_see.Margin = new System.Windows.Forms.Padding(2);
            this.button_see.Name = "button_see";
            this.button_see.Size = new System.Drawing.Size(150, 39);
            this.button_see.TabIndex = 33;
            this.button_see.Text = "🔍 Ver";
            this.button_see.UseVisualStyleBackColor = false;
            this.button_see.UseWaitCursor = true;
            this.button_see.Click += new System.EventHandler(this.button_see_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Monto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "IGV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "ID Pedido";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // DocumentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 494);
            this.Controls.Add(this.button_see);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.grid_documents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocumentSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Documentos de Venta";
            this.Load += new System.EventHandler(this.DocumentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_documents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_documents;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_see;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}