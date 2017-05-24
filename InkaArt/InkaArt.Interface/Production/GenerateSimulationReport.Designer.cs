﻿namespace InkaArt.Interface.Production
{
    partial class GenerateSimulationReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.simulation_grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.report_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_of = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_huacos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_stones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_altarpieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report_workers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.simulation_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo total de ejecución:";
            // 
            // simulation_grid
            // 
            this.simulation_grid.AllowUserToAddRows = false;
            this.simulation_grid.AllowUserToDeleteRows = false;
            this.simulation_grid.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.simulation_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simulation_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_date,
            this.report_iterations,
            this.report_of,
            this.report_huacos,
            this.report_stones,
            this.report_altarpieces,
            this.report_workers});
            this.simulation_grid.Location = new System.Drawing.Point(15, 50);
            this.simulation_grid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.simulation_grid.Name = "simulation_grid";
            this.simulation_grid.ReadOnly = true;
            this.simulation_grid.RowHeadersVisible = false;
            this.simulation_grid.Size = new System.Drawing.Size(853, 291);
            this.simulation_grid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(350, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "🖶 Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // report_date
            // 
            this.report_date.HeaderText = "Fecha";
            this.report_date.Name = "report_date";
            this.report_date.ReadOnly = true;
            // 
            // report_iterations
            // 
            this.report_iterations.HeaderText = "# iteraciones Tabu";
            this.report_iterations.Name = "report_iterations";
            this.report_iterations.ReadOnly = true;
            // 
            // report_of
            // 
            this.report_of.HeaderText = "Valor F.O.";
            this.report_of.Name = "report_of";
            this.report_of.ReadOnly = true;
            // 
            // report_huacos
            // 
            this.report_huacos.HeaderText = "Huacos producidos";
            this.report_huacos.Name = "report_huacos";
            this.report_huacos.ReadOnly = true;
            // 
            // report_stones
            // 
            this.report_stones.HeaderText = "Piedras de Huamanga producidas";
            this.report_stones.Name = "report_stones";
            this.report_stones.ReadOnly = true;
            this.report_stones.Width = 180;
            // 
            // report_altarpieces
            // 
            this.report_altarpieces.HeaderText = "Retablos producidos";
            this.report_altarpieces.Name = "report_altarpieces";
            this.report_altarpieces.ReadOnly = true;
            // 
            // report_workers
            // 
            this.report_workers.HeaderText = "# trabajadores asignados";
            this.report_workers.Name = "report_workers";
            this.report_workers.ReadOnly = true;
            this.report_workers.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 25);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "4:15 min.";
            // 
            // GenerateSimulationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simulation_grid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GenerateSimulationReport";
            this.Text = "Reporte de simulación de trabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.simulation_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView simulation_grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_iterations;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_of;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_huacos;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_stones;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_altarpieces;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_workers;
        private System.Windows.Forms.TextBox textBox1;
    }
}