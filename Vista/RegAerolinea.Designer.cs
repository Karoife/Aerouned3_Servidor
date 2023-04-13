namespace Vista
{
    partial class RegAerolinea
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
            cmbRALEstado = new ComboBox();
            txtRALTelefono = new TextBox();
            txtRALNombre = new TextBox();
            txtRALId = new TextBox();
            btnRALCancelar = new Button();
            btnRALAceptar = new Button();
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
            panel1.Controls.Add(cmbRALEstado);
            panel1.Controls.Add(txtRALTelefono);
            panel1.Controls.Add(txtRALNombre);
            panel1.Controls.Add(txtRALId);
            panel1.Controls.Add(btnRALCancelar);
            panel1.Controls.Add(btnRALAceptar);
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
            // cmbRALEstado
            // 
            cmbRALEstado.FormattingEnabled = true;
            cmbRALEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbRALEstado.Location = new Point(195, 248);
            cmbRALEstado.Name = "cmbRALEstado";
            cmbRALEstado.Size = new Size(100, 23);
            cmbRALEstado.TabIndex = 10;
            cmbRALEstado.Text = "Activo";
            // 
            // txtRALTelefono
            // 
            txtRALTelefono.Location = new Point(195, 203);
            txtRALTelefono.MaxLength = 12;
            txtRALTelefono.Name = "txtRALTelefono";
            txtRALTelefono.Size = new Size(100, 23);
            txtRALTelefono.TabIndex = 9;
            // 
            // txtRALNombre
            // 
            txtRALNombre.Location = new Point(195, 150);
            txtRALNombre.MaxLength = 20;
            txtRALNombre.Name = "txtRALNombre";
            txtRALNombre.Size = new Size(100, 23);
            txtRALNombre.TabIndex = 8;
            // 
            // txtRALId
            // 
            txtRALId.Location = new Point(195, 103);
            txtRALId.MaxLength = 4;
            txtRALId.Name = "txtRALId";
            txtRALId.Size = new Size(100, 23);
            txtRALId.TabIndex = 7;
            txtRALId.KeyPress += txtRALId_KeyPress;
            // 
            // btnRALCancelar
            // 
            btnRALCancelar.Location = new Point(236, 355);
            btnRALCancelar.Name = "btnRALCancelar";
            btnRALCancelar.Size = new Size(75, 23);
            btnRALCancelar.TabIndex = 6;
            btnRALCancelar.Text = "Cancelar";
            btnRALCancelar.UseVisualStyleBackColor = true;
            btnRALCancelar.Click += btnRALCancelar_Click;
            // 
            // btnRALAceptar
            // 
            btnRALAceptar.Location = new Point(98, 355);
            btnRALAceptar.Name = "btnRALAceptar";
            btnRALAceptar.Size = new Size(75, 23);
            btnRALAceptar.TabIndex = 5;
            btnRALAceptar.Text = "Aceptar";
            btnRALAceptar.UseVisualStyleBackColor = true;
            btnRALAceptar.Click += btnRALAceptar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 250);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 205);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 3;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 152);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 103);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 23);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro Aerolínea";
            // 
            // RegAerolinea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 436);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegAerolinea";
            Text = "Registrar Aerolínea";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRALCancelar;
        private Button btnRALAceptar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRALEstado;
        private TextBox txtRALTelefono;
        private TextBox txtRALNombre;
        private TextBox txtRALId;
    }
}