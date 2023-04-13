namespace Vista
{
    partial class RegBoleto
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
            numCBAsientos = new NumericUpDown();
            cmbCBCliente = new ComboBox();
            dtpCBFecha = new DateTimePicker();
            cmbCBVuelo = new ComboBox();
            txtCBNumero = new TextBox();
            txtCBCancelar = new Button();
            btnCBAceptar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCBAsientos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numCBAsientos);
            panel1.Controls.Add(cmbCBCliente);
            panel1.Controls.Add(dtpCBFecha);
            panel1.Controls.Add(cmbCBVuelo);
            panel1.Controls.Add(txtCBNumero);
            panel1.Controls.Add(txtCBCancelar);
            panel1.Controls.Add(btnCBAceptar);
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
            // numCBAsientos
            // 
            numCBAsientos.Location = new Point(149, 243);
            numCBAsientos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCBAsientos.Name = "numCBAsientos";
            numCBAsientos.Size = new Size(162, 23);
            numCBAsientos.TabIndex = 12;
            numCBAsientos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbCBCliente
            // 
            cmbCBCliente.FormattingEnabled = true;
            cmbCBCliente.Location = new Point(149, 204);
            cmbCBCliente.Name = "cmbCBCliente";
            cmbCBCliente.Size = new Size(162, 23);
            cmbCBCliente.TabIndex = 11;
            // 
            // dtpCBFecha
            // 
            dtpCBFecha.Format = DateTimePickerFormat.Short;
            dtpCBFecha.Location = new Point(149, 160);
            dtpCBFecha.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dtpCBFecha.MinDate = new DateTime(2023, 4, 7, 0, 0, 0, 0);
            dtpCBFecha.Name = "dtpCBFecha";
            dtpCBFecha.Size = new Size(162, 23);
            dtpCBFecha.TabIndex = 10;
            // 
            // cmbCBVuelo
            // 
            cmbCBVuelo.FormattingEnabled = true;
            cmbCBVuelo.Location = new Point(149, 120);
            cmbCBVuelo.Name = "cmbCBVuelo";
            cmbCBVuelo.Size = new Size(162, 23);
            cmbCBVuelo.TabIndex = 9;
            // 
            // txtCBNumero
            // 
            txtCBNumero.Location = new Point(149, 84);
            txtCBNumero.Name = "txtCBNumero";
            txtCBNumero.Size = new Size(162, 23);
            txtCBNumero.TabIndex = 8;
            txtCBNumero.KeyPress += txtCBNumero_KeyPress;
            // 
            // txtCBCancelar
            // 
            txtCBCancelar.Location = new Point(236, 355);
            txtCBCancelar.Name = "txtCBCancelar";
            txtCBCancelar.Size = new Size(75, 23);
            txtCBCancelar.TabIndex = 7;
            txtCBCancelar.Text = "Cancelar";
            txtCBCancelar.UseVisualStyleBackColor = true;
            txtCBCancelar.Click += txtCBCancelar_Click;
            // 
            // btnCBAceptar
            // 
            btnCBAceptar.Location = new Point(98, 355);
            btnCBAceptar.Name = "btnCBAceptar";
            btnCBAceptar.Size = new Size(75, 23);
            btnCBAceptar.TabIndex = 6;
            btnCBAceptar.Text = "Aceptar";
            btnCBAceptar.UseVisualStyleBackColor = true;
            btnCBAceptar.Click += btnCBAceptar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(54, 240);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 5;
            label6.Text = "Asientos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(66, 202);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 4;
            label5.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 161);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(76, 122);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Vuelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 82);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 17);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "Comprar Boleto";
            // 
            // RegBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 436);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegBoleto";
            Text = "Comprar Boleto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCBAsientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button txtCBCancelar;
        private Button btnCBAceptar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numCBAsientos;
        private ComboBox cmbCBCliente;
        private DateTimePicker dtpCBFecha;
        private ComboBox cmbCBVuelo;
        private TextBox txtCBNumero;
    }
}