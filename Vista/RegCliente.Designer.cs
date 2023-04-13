using Datos;
using Entidades;

namespace Vista
{
    partial class RegCliente
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
            cmbRCGenero = new ComboBox();
            dtpRCData = new DateTimePicker();
            txtRCApellido2 = new TextBox();
            txtRCApellido1 = new TextBox();
            txtRCNombre = new TextBox();
            txtRCID = new TextBox();
            btnRCCancelar = new Button();
            btnRCAceptar = new Button();
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
            panel1.Controls.Add(cmbRCGenero);
            panel1.Controls.Add(dtpRCData);
            panel1.Controls.Add(txtRCApellido2);
            panel1.Controls.Add(txtRCApellido1);
            panel1.Controls.Add(txtRCNombre);
            panel1.Controls.Add(txtRCID);
            panel1.Controls.Add(btnRCCancelar);
            panel1.Controls.Add(btnRCAceptar);
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
            // cmbRCGenero
            // 
            cmbRCGenero.FormattingEnabled = true;
            cmbRCGenero.Items.AddRange(new object[] { "Femenino", "Masculino", "No Especifica" });
            cmbRCGenero.Location = new Point(236, 264);
            cmbRCGenero.Name = "cmbRCGenero";
            cmbRCGenero.Size = new Size(100, 23);
            cmbRCGenero.TabIndex = 14;
            cmbRCGenero.Text = "No Especifica";
            // 
            // dtpRCData
            // 
            dtpRCData.Format = DateTimePickerFormat.Short;
            dtpRCData.Location = new Point(236, 222);
            dtpRCData.MaxDate = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            dtpRCData.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpRCData.Name = "dtpRCData";
            dtpRCData.Size = new Size(100, 23);
            dtpRCData.TabIndex = 13;
            dtpRCData.Value = new DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // txtRCApellido2
            // 
            txtRCApellido2.Location = new Point(236, 185);
            txtRCApellido2.MaxLength = 40;
            txtRCApellido2.Name = "txtRCApellido2";
            txtRCApellido2.Size = new Size(100, 23);
            txtRCApellido2.TabIndex = 12;
            // 
            // txtRCApellido1
            // 
            txtRCApellido1.Location = new Point(236, 149);
            txtRCApellido1.MaxLength = 40;
            txtRCApellido1.Name = "txtRCApellido1";
            txtRCApellido1.Size = new Size(100, 23);
            txtRCApellido1.TabIndex = 11;
            // 
            // txtRCNombre
            // 
            txtRCNombre.Location = new Point(236, 117);
            txtRCNombre.MaxLength = 40;
            txtRCNombre.Name = "txtRCNombre";
            txtRCNombre.Size = new Size(100, 23);
            txtRCNombre.TabIndex = 10;
            // 
            // txtRCID
            // 
            txtRCID.Location = new Point(236, 85);
            txtRCID.MaxLength = 12;
            txtRCID.Name = "txtRCID";
            txtRCID.Size = new Size(100, 23);
            txtRCID.TabIndex = 9;
            // 
            // btnRCCancelar
            // 
            btnRCCancelar.Location = new Point(236, 355);
            btnRCCancelar.Name = "btnRCCancelar";
            btnRCCancelar.Size = new Size(75, 23);
            btnRCCancelar.TabIndex = 8;
            btnRCCancelar.Text = "Cancelar";
            btnRCCancelar.UseVisualStyleBackColor = true;
            btnRCCancelar.Click += btnRCCancelar_Click;
            // 
            // btnRCAceptar
            // 
            btnRCAceptar.Location = new Point(98, 355);
            btnRCAceptar.Name = "btnRCAceptar";
            btnRCAceptar.Size = new Size(75, 23);
            btnRCAceptar.TabIndex = 7;
            btnRCAceptar.Text = "Aceptar";
            btnRCAceptar.UseVisualStyleBackColor = true;
            btnRCAceptar.Click += btnRCAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(131, 266);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 6;
            label7.Text = "Género:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 223);
            label6.Name = "label6";
            label6.Size = new Size(167, 21);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 187);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 4;
            label5.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 151);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 3;
            label4.Text = "Primer Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 117);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 83);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "Registrar Cliente";
            // 
            // RegCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 436);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegCliente";
            Text = "Registrar Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRCCancelar;
        private Button btnRCAceptar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRCGenero;
        private DateTimePicker dtpRCData;
        private TextBox txtRCApellido2;
        private TextBox txtRCApellido1;
        private TextBox txtRCNombre;
        private TextBox txtRCID;
    }
}