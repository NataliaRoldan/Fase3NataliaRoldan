namespace Fase3NataliaRoldan
{
    partial class Pila
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.cmbMesesDeApertura = new System.Windows.Forms.ComboBox();
            this.txtNumeroCDT = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.txtMesesDeEstarCDT = new System.Windows.Forms.TextBox();
            this.txtMontoCDT = new System.Windows.Forms.TextBox();
            this.txtTotalPagoCDT = new System.Windows.Forms.TextBox();
            this.txtPagosRegistrados = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.RegistroToolStripMenuItem,
            this.reToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // RegistroToolStripMenuItem
            // 
            this.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem";
            this.RegistroToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.RegistroToolStripMenuItem.Text = "Reporte";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.reToolStripMenuItem.Text = "Eliminar";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PILA CDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero CDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Estrato";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(537, 151);
            this.dataGridView1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Meses de estar en el CDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mes de apertura del CDT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Direccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Monto CDT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total pago por CDT";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(103, 61);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(157, 23);
            this.txtIdentificacion.TabIndex = 14;
            // 
            // cmbMesesDeApertura
            // 
            this.cmbMesesDeApertura.FormattingEnabled = true;
            this.cmbMesesDeApertura.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Noviembre",
            "Diciembre"});
            this.cmbMesesDeApertura.Location = new System.Drawing.Point(436, 89);
            this.cmbMesesDeApertura.Name = "cmbMesesDeApertura";
            this.cmbMesesDeApertura.Size = new System.Drawing.Size(134, 23);
            this.cmbMesesDeApertura.TabIndex = 15;
            // 
            // txtNumeroCDT
            // 
            this.txtNumeroCDT.Location = new System.Drawing.Point(394, 56);
            this.txtNumeroCDT.Name = "txtNumeroCDT";
            this.txtNumeroCDT.Size = new System.Drawing.Size(176, 23);
            this.txtNumeroCDT.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(103, 127);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(157, 23);
            this.cmbEstrato.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(395, 124);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 23);
            this.txtDireccion.TabIndex = 19;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Urbano"});
            this.cmbCategoria.Location = new System.Drawing.Point(395, 153);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(175, 23);
            this.cmbCategoria.TabIndex = 20;
            // 
            // dateTimeFechaDePago
            // 
            this.dateTimeFechaDePago.Location = new System.Drawing.Point(121, 200);
            this.dateTimeFechaDePago.Name = "dateTimeFechaDePago";
            this.dateTimeFechaDePago.Size = new System.Drawing.Size(139, 23);
            this.dateTimeFechaDePago.TabIndex = 21;
            // 
            // txtMesesDeEstarCDT
            // 
            this.txtMesesDeEstarCDT.Location = new System.Drawing.Point(160, 165);
            this.txtMesesDeEstarCDT.Name = "txtMesesDeEstarCDT";
            this.txtMesesDeEstarCDT.Size = new System.Drawing.Size(100, 23);
            this.txtMesesDeEstarCDT.TabIndex = 22;
            // 
            // txtMontoCDT
            // 
            this.txtMontoCDT.Location = new System.Drawing.Point(395, 182);
            this.txtMontoCDT.Name = "txtMontoCDT";
            this.txtMontoCDT.Size = new System.Drawing.Size(175, 23);
            this.txtMontoCDT.TabIndex = 23;
            // 
            // txtTotalPagoCDT
            // 
            this.txtTotalPagoCDT.Location = new System.Drawing.Point(405, 211);
            this.txtTotalPagoCDT.Name = "txtTotalPagoCDT";
            this.txtTotalPagoCDT.Size = new System.Drawing.Size(165, 23);
            this.txtTotalPagoCDT.TabIndex = 24;
            // 
            // txtPagosRegistrados
            // 
            this.txtPagosRegistrados.Location = new System.Drawing.Point(192, 405);
            this.txtPagosRegistrados.Name = "txtPagosRegistrados";
            this.txtPagosRegistrados.Size = new System.Drawing.Size(100, 23);
            this.txtPagosRegistrados.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Total de pagos registrados";
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 434);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPagosRegistrados);
            this.Controls.Add(this.txtTotalPagoCDT);
            this.Controls.Add(this.txtMontoCDT);
            this.Controls.Add(this.txtMesesDeEstarCDT);
            this.Controls.Add(this.dateTimeFechaDePago);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroCDT);
            this.Controls.Add(this.cmbMesesDeApertura);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pila";
            this.Text = "Pila";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem RegistroToolStripMenuItem;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtIdentificacion;
        private ComboBox cmbMesesDeApertura;
        private TextBox txtNumeroCDT;
        private TextBox txtNombre;
        private ComboBox cmbEstrato;
        private TextBox txtDireccion;
        private ComboBox cmbCategoria;
        private DateTimePicker dateTimeFechaDePago;
        private TextBox txtMesesDeEstarCDT;
        private TextBox txtMontoCDT;
        private TextBox txtTotalPagoCDT;
        private TextBox txtPagosRegistrados;
        private Label label13;
    }
}