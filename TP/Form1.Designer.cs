namespace TP
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
            this.SuspendLayout();
            // 
            // NometextBox
            // 
            this.NometextBox.Location = new System.Drawing.Point(12, 52);
            this.NometextBox.Name = "NometextBox";
            this.NometextBox.Size = new System.Drawing.Size(182, 20);
            this.NometextBox.TabIndex = 0;
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
            this.ComplexidadecomboBox.Location = new System.Drawing.Point(15, 95);
            this.ComplexidadecomboBox.Name = "ComplexidadecomboBox";
            this.ComplexidadecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ComplexidadecomboBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComplexidadecomboBox);
            this.Controls.Add(this.Nomelb);
            this.Controls.Add(this.NometextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NometextBox;
        private System.Windows.Forms.Label Nomelb;
        private System.Windows.Forms.ComboBox ComplexidadecomboBox;
    }
}

