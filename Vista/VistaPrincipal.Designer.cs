namespace Vista
{
    partial class VistaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            comprarBoletoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            aeropuertoToolStripMenuItem = new ToolStripMenuItem();
            aerolíneaToolStripMenuItem = new ToolStripMenuItem();
            vueloToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            aeropuertosToolStripMenuItem = new ToolStripMenuItem();
            aerolíneasToolStripMenuItem = new ToolStripMenuItem();
            vuelosToolStripMenuItem = new ToolStripMenuItem();
            boletosToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            groupBox3 = new GroupBox();
            lstClientesConectados = new ListBox();
            labelDisponible = new Label();
            bitacoraServidor = new TextBox();
            IniciarServidor = new Button();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, registrarToolStripMenuItem, consultarToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(578, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprarBoletoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // comprarBoletoToolStripMenuItem
            // 
            comprarBoletoToolStripMenuItem.Name = "comprarBoletoToolStripMenuItem";
            comprarBoletoToolStripMenuItem.Size = new Size(158, 22);
            comprarBoletoToolStripMenuItem.Text = "Comprar Boleto";
            comprarBoletoToolStripMenuItem.Click += comprarBoletoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(158, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, aeropuertoToolStripMenuItem, aerolíneaToolStripMenuItem, vueloToolStripMenuItem });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(65, 20);
            registrarToolStripMenuItem.Text = "Registrar";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(134, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // aeropuertoToolStripMenuItem
            // 
            aeropuertoToolStripMenuItem.Name = "aeropuertoToolStripMenuItem";
            aeropuertoToolStripMenuItem.Size = new Size(134, 22);
            aeropuertoToolStripMenuItem.Text = "Aeropuerto";
            aeropuertoToolStripMenuItem.Click += aeropuertoToolStripMenuItem_Click;
            // 
            // aerolíneaToolStripMenuItem
            // 
            aerolíneaToolStripMenuItem.Name = "aerolíneaToolStripMenuItem";
            aerolíneaToolStripMenuItem.Size = new Size(134, 22);
            aerolíneaToolStripMenuItem.Text = "Aerolínea";
            aerolíneaToolStripMenuItem.Click += aerolíneaToolStripMenuItem_Click;
            // 
            // vueloToolStripMenuItem
            // 
            vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            vueloToolStripMenuItem.Size = new Size(134, 22);
            vueloToolStripMenuItem.Text = "Vuelo";
            vueloToolStripMenuItem.Click += vueloToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, aeropuertosToolStripMenuItem, aerolíneasToolStripMenuItem, vuelosToolStripMenuItem, boletosToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // aeropuertosToolStripMenuItem
            // 
            aeropuertosToolStripMenuItem.Name = "aeropuertosToolStripMenuItem";
            aeropuertosToolStripMenuItem.Size = new Size(180, 22);
            aeropuertosToolStripMenuItem.Text = "Aeropuertos";
            aeropuertosToolStripMenuItem.Click += aeropuertosToolStripMenuItem_Click;
            // 
            // aerolíneasToolStripMenuItem
            // 
            aerolíneasToolStripMenuItem.Name = "aerolíneasToolStripMenuItem";
            aerolíneasToolStripMenuItem.Size = new Size(180, 22);
            aerolíneasToolStripMenuItem.Text = "Aerolíneas";
            aerolíneasToolStripMenuItem.Click += aerolíneasToolStripMenuItem_Click;
            // 
            // vuelosToolStripMenuItem
            // 
            vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            vuelosToolStripMenuItem.Size = new Size(180, 22);
            vuelosToolStripMenuItem.Text = "Vuelos";
            vuelosToolStripMenuItem.Click += vuelosToolStripMenuItem_Click;
            // 
            // boletosToolStripMenuItem
            // 
            boletosToolStripMenuItem.Name = "boletosToolStripMenuItem";
            boletosToolStripMenuItem.Size = new Size(180, 22);
            boletosToolStripMenuItem.Text = "Boletos";
            boletosToolStripMenuItem.Click += boletosToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 466);
            panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(button9);
            groupBox4.Location = new Point(19, 175);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(85, 156);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Boletos";
            // 
            // button10
            // 
            button10.Location = new Point(6, 93);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 1;
            button10.Text = "Consultar";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(4, 50);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 0;
            button9.Text = "Comprar";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstClientesConectados);
            groupBox3.Controls.Add(labelDisponible);
            groupBox3.Controls.Add(bitacoraServidor);
            groupBox3.Controls.Add(IniciarServidor);
            groupBox3.Location = new Point(110, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 288);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Servidor";
            // 
            // lstClientesConectados
            // 
            lstClientesConectados.FormattingEnabled = true;
            lstClientesConectados.ItemHeight = 15;
            lstClientesConectados.Location = new Point(335, 53);
            lstClientesConectados.Name = "lstClientesConectados";
            lstClientesConectados.Size = new Size(87, 229);
            lstClientesConectados.TabIndex = 3;
            // 
            // labelDisponible
            // 
            labelDisponible.AutoSize = true;
            labelDisponible.Location = new Point(286, 19);
            labelDisponible.Name = "labelDisponible";
            labelDisponible.Size = new Size(128, 15);
            labelDisponible.TabIndex = 2;
            labelDisponible.Text = "Servidor Desconectado";
            // 
            // bitacoraServidor
            // 
            bitacoraServidor.Location = new Point(6, 53);
            bitacoraServidor.Multiline = true;
            bitacoraServidor.Name = "bitacoraServidor";
            bitacoraServidor.Size = new Size(323, 228);
            bitacoraServidor.TabIndex = 1;
            // 
            // IniciarServidor
            // 
            IniciarServidor.BackColor = Color.Red;
            IniciarServidor.Location = new Point(15, 22);
            IniciarServidor.Name = "IniciarServidor";
            IniciarServidor.Size = new Size(75, 23);
            IniciarServidor.TabIndex = 0;
            IniciarServidor.Text = "Iniciar";
            IniciarServidor.UseVisualStyleBackColor = false;
            IniciarServidor.Click += IniciarServidor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(306, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 149);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultar";
            // 
            // button8
            // 
            button8.Location = new Point(90, 109);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 3;
            button8.Text = "Vuelos";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(90, 80);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 2;
            button7.Text = "Aerolíneas";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(90, 51);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "Aeropuertos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(90, 22);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            button5.Text = "Clientes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(19, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar";
            // 
            // button4
            // 
            button4.Location = new Point(74, 109);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Vuelo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(74, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Aerolínea";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(74, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Aeropuerto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(74, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VistaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 505);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "VistaPrincipal";
            Text = "Aerouned 3.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem comprarBoletoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem aeropuertoToolStripMenuItem;
        private ToolStripMenuItem aerolíneaToolStripMenuItem;
        private ToolStripMenuItem vueloToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem aeropuertosToolStripMenuItem;
        private ToolStripMenuItem aerolíneasToolStripMenuItem;
        private ToolStripMenuItem vuelosToolStripMenuItem;
        private ToolStripMenuItem boletosToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Button IniciarServidor;
        private TextBox bitacoraServidor;
        private Label labelDisponible;
        private ListBox lstClientesConectados;
        private GroupBox groupBox4;
        private Button button10;
        private Button button9;
    }
}