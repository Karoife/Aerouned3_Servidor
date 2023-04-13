namespace Vista
{
    partial class Consulta
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
            panel1 = new Panel();
            tablaFinal = new DataGridView();
            titulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaFinal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(titulo);
            panel1.Controls.Add(tablaFinal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 573);
            panel1.TabIndex = 0;
            // 
            // tablaFinal
            // 
            tablaFinal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaFinal.Location = new Point(70, 52);
            tablaFinal.Name = "tablaFinal";
            tablaFinal.RowTemplate.Height = 25;
            tablaFinal.Size = new Size(700, 478);
            tablaFinal.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(370, 17);
            titulo.Name = "titulo";
            titulo.Size = new Size(76, 32);
            titulo.TabIndex = 1;
            titulo.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 597);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Consulta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaFinal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titulo;
        private DataGridView tablaFinal;
    }
}