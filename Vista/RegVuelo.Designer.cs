namespace Vista
{
    partial class RegVuelo
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
            numRVCapacidad = new NumericUpDown();
            dtpRVDuracion = new DateTimePicker();
            cmbRVDestino = new ComboBox();
            cmbRVOrigen = new ComboBox();
            cmbRVAerolinea = new ComboBox();
            txtRVNumero = new TextBox();
            btnRVCancelar = new Button();
            btnRVAceptar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRVCapacidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numRVCapacidad);
            panel1.Controls.Add(dtpRVDuracion);
            panel1.Controls.Add(cmbRVDestino);
            panel1.Controls.Add(cmbRVOrigen);
            panel1.Controls.Add(cmbRVAerolinea);
            panel1.Controls.Add(txtRVNumero);
            panel1.Controls.Add(btnRVCancelar);
            panel1.Controls.Add(btnRVAceptar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 412);
            panel1.TabIndex = 0;
            // 
            // numRVCapacidad
            // 
            numRVCapacidad.Location = new Point(196, 270);
            numRVCapacidad.Maximum = new decimal(new int[] { 856, 0, 0, 0 });
            numRVCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRVCapacidad.Name = "numRVCapacidad";
            numRVCapacidad.Size = new Size(100, 23);
            numRVCapacidad.TabIndex = 14;
            numRVCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpRVDuracion
            // 
            dtpRVDuracion.CustomFormat = "HH:mm";
            dtpRVDuracion.Format = DateTimePickerFormat.Custom;
            dtpRVDuracion.Location = new Point(196, 233);
            dtpRVDuracion.MinDate = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dtpRVDuracion.Name = "dtpRVDuracion";
            dtpRVDuracion.ShowUpDown = true;
            dtpRVDuracion.Size = new Size(100, 23);
            dtpRVDuracion.TabIndex = 13;
            dtpRVDuracion.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // cmbRVDestino
            // 
            cmbRVDestino.FormattingEnabled = true;
            cmbRVDestino.Location = new Point(196, 195);
            cmbRVDestino.Name = "cmbRVDestino";
            cmbRVDestino.Size = new Size(100, 23);
            cmbRVDestino.TabIndex = 12;
            cmbRVDestino.DropDown += cmbRVDestino_DropDown;
            // 
            // cmbRVOrigen
            // 
            cmbRVOrigen.FormattingEnabled = true;
            cmbRVOrigen.Location = new Point(196, 158);
            cmbRVOrigen.Name = "cmbRVOrigen";
            cmbRVOrigen.Size = new Size(100, 23);
            cmbRVOrigen.TabIndex = 11;
            cmbRVOrigen.DropDown += cmbRVOrigen_DropDown;
            // 
            // cmbRVAerolinea
            // 
            cmbRVAerolinea.FormattingEnabled = true;
            cmbRVAerolinea.Location = new Point(196, 123);
            cmbRVAerolinea.Name = "cmbRVAerolinea";
            cmbRVAerolinea.Size = new Size(100, 23);
            cmbRVAerolinea.TabIndex = 10;
            // 
            // txtRVNumero
            // 
            txtRVNumero.Location = new Point(196, 85);
            txtRVNumero.MaxLength = 4;
            txtRVNumero.Name = "txtRVNumero";
            txtRVNumero.Size = new Size(100, 23);
            txtRVNumero.TabIndex = 9;
            txtRVNumero.KeyPress += txtRVNumero_KeyPress;
            // 
            // btnRVCancelar
            // 
            btnRVCancelar.Location = new Point(236, 355);
            btnRVCancelar.Name = "btnRVCancelar";
            btnRVCancelar.Size = new Size(75, 23);
            btnRVCancelar.TabIndex = 8;
            btnRVCancelar.Text = "Cancelar";
            btnRVCancelar.UseVisualStyleBackColor = true;
            btnRVCancelar.Click += btnRVCancelar_Click;
            // 
            // btnRVAceptar
            // 
            btnRVAceptar.Location = new Point(98, 355);
            btnRVAceptar.Name = "btnRVAceptar";
            btnRVAceptar.Size = new Size(75, 23);
            btnRVAceptar.TabIndex = 7;
            btnRVAceptar.Text = "Aceptar";
            btnRVAceptar.UseVisualStyleBackColor = true;
            btnRVAceptar.Click += btnRVAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(74, 272);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 6;
            label7.Text = "Capacidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(85, 234);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 5;
            label6.Text = "Duración:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(94, 195);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(100, 160);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 3;
            label4.Text = "Origen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 123);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Aerolínea:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 17);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro Vuelo";
            // 
            // RegVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 436);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegVuelo";
            Text = "Registro Vuelo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRVCapacidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRVCancelar;
        private Button btnRVAceptar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numRVCapacidad;
        private DateTimePicker dtpRVDuracion;
        private ComboBox cmbRVDestino;
        private ComboBox cmbRVOrigen;
        private ComboBox cmbRVAerolinea;
        private TextBox txtRVNumero;
    }
}