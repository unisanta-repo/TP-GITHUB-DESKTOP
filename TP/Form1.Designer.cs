﻿namespace TP
{
    partial class Form1
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
            this.NometextBox = new System.Windows.Forms.TextBox();
            this.Nomelb = new System.Windows.Forms.Label();
            this.ComplexidadecomboBox = new System.Windows.Forms.ComboBox();
            this.Complexidadelb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datavenciomentolb = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusLb = new System.Windows.Forms.Label();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.Editarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NometextBox
            // 
            this.NometextBox.Location = new System.Drawing.Point(12, 52);
            this.NometextBox.Name = "NometextBox";
            this.NometextBox.Size = new System.Drawing.Size(182, 20);
            this.NometextBox.TabIndex = 0;
            this.NometextBox.TextChanged += new System.EventHandler(this.NometextBox_TextChanged);
            // 
            // Nomelb
            // 
            this.Nomelb.AutoSize = true;
            this.Nomelb.Location = new System.Drawing.Point(12, 25);
            this.Nomelb.Name = "Nomelb";
            this.Nomelb.Size = new System.Drawing.Size(35, 13);
            this.Nomelb.TabIndex = 2;
            this.Nomelb.Text = "Nome";
            // 
            // ComplexidadecomboBox
            // 
            this.ComplexidadecomboBox.FormattingEnabled = true;
            this.ComplexidadecomboBox.Items.AddRange(new object[] {
            "Baixa",
            "Media",
            "Alta"});
            this.ComplexidadecomboBox.Location = new System.Drawing.Point(12, 114);
            this.ComplexidadecomboBox.Name = "ComplexidadecomboBox";
            this.ComplexidadecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ComplexidadecomboBox.TabIndex = 4;
            this.ComplexidadecomboBox.SelectedIndexChanged += new System.EventHandler(this.ComplexidadecomboBox_SelectedIndexChanged);
            // 
            // Complexidadelb
            // 
            this.Complexidadelb.AutoSize = true;
            this.Complexidadelb.Location = new System.Drawing.Point(12, 89);
            this.Complexidadelb.Name = "Complexidadelb";
            this.Complexidadelb.Size = new System.Drawing.Size(73, 13);
            this.Complexidadelb.TabIndex = 5;
            this.Complexidadelb.Text = "Complexidade";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Datavenciomentolb
            // 
            this.Datavenciomentolb.AutoSize = true;
            this.Datavenciomentolb.Location = new System.Drawing.Point(12, 156);
            this.Datavenciomentolb.Name = "Datavenciomentolb";
            this.Datavenciomentolb.Size = new System.Drawing.Size(89, 13);
            this.Datavenciomentolb.TabIndex = 7;
            this.Datavenciomentolb.Text = "Data Vencimento";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(15, 415);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 8;
            this.Addbutton.Text = "Salvar";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 303);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(12, 224);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(37, 13);
            this.StatusLb.TabIndex = 11;
            this.StatusLb.Text = "Status";
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Concluida",
            "Pendente"});
            this.StatuscomboBox.Location = new System.Drawing.Point(12, 249);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(121, 21);
            this.StatuscomboBox.TabIndex = 10;
            // 
            // Editarbutton
            // 
            this.Editarbutton.Location = new System.Drawing.Point(110, 415);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(75, 23);
            this.Editarbutton.TabIndex = 12;
            this.Editarbutton.Text = "Editar";
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.StatusLb);
            this.Controls.Add(this.StatuscomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Datavenciomentolb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Complexidadelb);
            this.Controls.Add(this.ComplexidadecomboBox);
            this.Controls.Add(this.Nomelb);
            this.Controls.Add(this.NometextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NometextBox;
        private System.Windows.Forms.Label Nomelb;
        private System.Windows.Forms.ComboBox ComplexidadecomboBox;
        private System.Windows.Forms.Label Complexidadelb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datavenciomentolb;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.Button Editarbutton;
    }
}

