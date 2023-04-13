namespace Vista
{
    partial class RegAeropuerto
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
            cmbRAPEstado = new ComboBox();
            txtRAPTelefono = new TextBox();
            txtRAPCiudad = new TextBox();
            txtRAPPais = new TextBox();
            txtRAPNombre = new TextBox();
            txtRAPCodigo = new TextBox();
            btnRAPCancelar = new Button();
            btnRAPAceptar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbRAPEstado);
            panel1.Controls.Add(txtRAPTelefono);
            panel1.Controls.Add(txtRAPCiudad);
            panel1.Controls.Add(txtRAPPais);
            panel1.Controls.Add(txtRAPNombre);
            panel1.Controls.Add(txtRAPCodigo);
            panel1.Controls.Add(btnRAPCancelar);
            panel1.Controls.Add(btnRAPAceptar);
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
            // cmbRAPEstado
            // 
            cmbRAPEstado.FormattingEnabled = true;
            cmbRAPEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbRAPEstado.Location = new Point(190, 279);
            cmbRAPEstado.Name = "cmbRAPEstado";
            cmbRAPEstado.Size = new Size(100, 23);
            cmbRAPEstado.TabIndex = 14;
            cmbRAPEstado.Text = "Activo";
            // 
            // txtRAPTelefono
            // 
            txtRAPTelefono.Location = new Point(190, 237);
            txtRAPTelefono.MaxLength = 12;
            txtRAPTelefono.Name = "txtRAPTelefono";
            txtRAPTelefono.Size = new Size(100, 23);
            txtRAPTelefono.TabIndex = 13;
            // 
            // txtRAPCiudad
            // 
            txtRAPCiudad.Location = new Point(190, 197);
            txtRAPCiudad.MaxLength = 20;
            txtRAPCiudad.Name = "txtRAPCiudad";
            txtRAPCiudad.Size = new Size(100, 23);
            txtRAPCiudad.TabIndex = 12;
            // 
            // txtRAPPais
            // 
            txtRAPPais.Location = new Point(190, 157);
            txtRAPPais.MaxLength = 20;
            txtRAPPais.Name = "txtRAPPais";
            txtRAPPais.Size = new Size(100, 23);
            txtRAPPais.TabIndex = 11;
            // 
            // txtRAPNombre
            // 
            txtRAPNombre.Location = new Point(190, 121);
            txtRAPNombre.MaxLength = 30;
            txtRAPNombre.Name = "txtRAPNombre";
            txtRAPNombre.Size = new Size(100, 23);
            txtRAPNombre.TabIndex = 10;
            // 
            // txtRAPCodigo
            // 
            txtRAPCodigo.Location = new Point(190, 80);
            txtRAPCodigo.MaxLength = 4;
            txtRAPCodigo.Name = "txtRAPCodigo";
            txtRAPCodigo.Size = new Size(100, 23);
            txtRAPCodigo.TabIndex = 9;
            // 
            // btnRAPCancelar
            // 
            btnRAPCancelar.Location = new Point(236, 355);
            btnRAPCancelar.Name = "btnRAPCancelar";
            btnRAPCancelar.Size = new Size(75, 23);
            btnRAPCancelar.TabIndex = 8;
            btnRAPCancelar.Text = "Cancelar";
            btnRAPCancelar.UseVisualStyleBackColor = true;
            btnRAPCancelar.Click += btnRAPCancelar_Click;
            // 
            // btnRAPAceptar
            // 
            btnRAPAceptar.Location = new Point(98, 355);
            btnRAPAceptar.Name = "btnRAPAceptar";
            btnRAPAceptar.Size = new Size(75, 23);
            btnRAPAceptar.TabIndex = 7;
            btnRAPAceptar.Text = "Aceptar";
            btnRAPAceptar.UseVisualStyleBackColor = true;
            btnRAPAceptar.Click += btnRAPAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(98, 277);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 6;
            label7.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(83, 235);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 5;
            label6.Text = "Teléfono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 195);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 4;
            label5.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(119, 155);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 3;
            label4.Text = "País:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 119);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 78);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 15);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro Aeropuerto";
            // 
            // RegAeropuerto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 436);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegAeropuerto";
            Text = "Registro Aeropuerto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRAPCancelar;
        private Button btnRAPAceptar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRAPEstado;
        private TextBox txtRAPTelefono;
        private TextBox txtRAPCiudad;
        private TextBox txtRAPPais;
        private TextBox txtRAPNombre;
        private TextBox txtRAPCodigo;
    }
}