using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3NataliaRoldan
{
    public partial class Pila : Form
    {
        private string numeroCDT, numeroIdentificacion, nombre, direccion,
            estrato, categoria, mesDeAperturaCdt, fechaPago;

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("¿Seguro deseas regresar?", "Regresar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("¿Seguro deseas salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private double tiempoCdt, montoCdt, totalPagar, totalPagosRegistrados;

        Stack<PilaCDT> pilaCDT = new Stack<PilaCDT>();

        public Pila()
        {
            InitializeComponent();
            this.reToolStripMenuItem.Enabled = false;
            this.RegistroToolStripMenuItem.Enabled = false;
        }

        private void calcularTotalPagar()
        {

            if (tiempoCdt >= 1 && tiempoCdt <= 12)
            {
                this.totalPagar = montoCdt + montoCdt * (0.2 / 100) * this.tiempoCdt;
            }
            if (tiempoCdt >= 13 && tiempoCdt <= 24)
            {
                this.totalPagar = montoCdt + montoCdt * (0.3 / 100) * this.tiempoCdt;
            }
            if (tiempoCdt >= 25)
            {
                this.totalPagar = montoCdt + montoCdt * (0.4 / 100) * this.tiempoCdt;
            }
        }

        private bool validarFormulario()
        {
            string mensaje = "";

            this.numeroCDT = this.txtNumeroCDT.Text.Trim();
            if (this.numeroCDT == "")
            {
                mensaje = mensaje + "Número del CDT \n";
                this.txtNumeroCDT.Focus();
            }

            this.numeroIdentificacion = this.txtIdentificacion.Text.Trim();
            if (this.numeroIdentificacion == "")
            {
                mensaje = mensaje + "Número de identificación \n";
                this.txtIdentificacion.Focus();
            }

            this.mesDeAperturaCdt = this.cmbMesesDeApertura.Text.Trim();
            if (this.mesDeAperturaCdt.Equals(""))
            {
                mensaje = mensaje + "Mes de apertura del CDT \n";
                this.cmbMesesDeApertura.Focus();
            }

            this.nombre = this.txtNombre.Text.Trim();
            if (nombre == "")
            {
                mensaje = mensaje + "Nombre \n";
                this.txtNombre.Focus();
            }

            this.direccion = this.txtDireccion.Text.Trim();
            if (direccion == "")
            {
                mensaje = mensaje + "Dirección \n";
                this.txtDireccion.Focus();
            }

            this.estrato = this.cmbEstrato.Text.Trim();
            if (estrato == "")
            {
                mensaje = mensaje + "Estrato socioeconómico \n";
                this.cmbEstrato.Focus();
            }

            this.categoria = this.cmbCategoria.Text.Trim();
            if (categoria == "")
            {
                mensaje = mensaje + "Categoría \n";
                this.cmbCategoria.Focus();
            }

            if (this.txtMesesDeEstarCDT.Text == "")
            {
                mensaje = mensaje + "Tiempo en meses de estar el CDT en el banco \n";
                this.txtMesesDeEstarCDT.Focus();
            }
            else
            {
                this.tiempoCdt = Convert.ToDouble(this.txtMesesDeEstarCDT.Text.Trim());
            }

            if (this.txtMontoCDT.Text == "")
            {
                mensaje = mensaje + "Monto CDT \n";
                this.txtMontoCDT.Focus();
            }
            else
            {
                this.montoCdt = Convert.ToDouble(this.txtMontoCDT.Text.Trim());
            }

            if (mensaje != "")
            {
                mensaje = "Favor diligenciar los siguientes campos:\n" + mensaje;
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.fechaPago = this.dateTimeFechaDePago.Value.ToString();
                calcularTotalPagar();
                this.txtTotalPagoCDT.Text = this.totalPagar.ToString();
                this.totalPagosRegistrados = this.totalPagosRegistrados + this.totalPagar;
                return true;
            }
        }


        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                PilaCDT pila = new PilaCDT();
                pila.NumCdt = this.numeroCDT;
                pila.NumIdentificacion = this.numeroIdentificacion;
                pila.MesAperturaCdt = this.mesDeAperturaCdt;
                pila.Nombre = this.nombre;
                pila.Direccion = this.direccion;
                pila.Estrato = this.estrato;
                pila.Categoria = this.categoria;
                pila.TiempoCdt = this.tiempoCdt;
                pila.FechaPago = this.fechaPago;
                pila.MontoCdt = this.montoCdt;
                pila.TotalPagar = this.totalPagar;
                pila.TotalPagosRegistrados = this.totalPagosRegistrados;

                pilaCDT.Push(pila);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pilaCDT.ToArray();

                MessageBox.Show("Guardado");

                this.limpiarForm();
                this.reToolStripMenuItem.Enabled = true;
                this.RegistroToolStripMenuItem.Enabled = true;
            }
        }

        private void limpiarForm()
        {
            this.txtNumeroCDT.Text = "";
            this.txtIdentificacion.Text = "";
            this.cmbMesesDeApertura.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.cmbEstrato.Text = "";
            this.cmbCategoria.Text = "";
            this.txtMesesDeEstarCDT.Text = "";
            this.dateTimeFechaDePago.Value = DateTime.Now;
            this.txtMontoCDT.Text = "";
            this.txtTotalPagoCDT.Text = "";
            this.txtPagosRegistrados.Text = "";
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pilaCDT.Count() > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("¿Deseas eliminar el ultimo registro?",
                    "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    PilaCDT pila = new PilaCDT();
                    pila = this.pilaCDT.Pop();
                    this.totalPagosRegistrados = this.totalPagosRegistrados - pila.TotalPagar;
                    this.txtTotalPagoCDT.Text = this.totalPagosRegistrados.ToString();
                    dataGridView1.DataSource = this.pilaCDT.ToArray();
                    MessageBox.Show("Eliminado");
                }
            }
            else
            {
                reToolStripMenuItem.Enabled = false;
                RegistroToolStripMenuItem.Enabled = false;
            }
        }
    }
}
