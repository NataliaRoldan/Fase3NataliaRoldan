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
    public partial class Cola : Form
    {
        private string identificacion, nombre, genero, fecha;
        private double comuna, totalRegistros, auxilioEconomico;

        private Queue<ColaJuventud> colaJuventud = new Queue<ColaJuventud>();

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colaJuventud.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("¿Deseas eliminar el ultimo registro?",
                    "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ColaJuventud cola = new ColaJuventud();
                    cola = this.colaJuventud.Dequeue();
                    this.totalRegistros = this.totalRegistros - 1;
                    this.txtRegistros.Text = this.totalRegistros.ToString();
                    dataGridView1.DataSource = this.colaJuventud.ToArray();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            else
            {
                reporteToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colaJuventud.Count > 0)
            {
                txtRegistros.Text = colaJuventud.Count.ToString();
            }
            else
            {
                reporteToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("¿Deseas regresar?", "Regresar",
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
            dr = MessageBox.Show("¿Deseas salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public Cola()
        {
            InitializeComponent();
            eliminarToolStripMenuItem.Enabled = false;
            reporteToolStripMenuItem.Enabled = false;
        }

        private bool validarFormulario()
        {
            string mensaje = "";

            this.identificacion = this.txtNumeroIdentificacion.Text.Trim();
            if (this.identificacion == "")
            {
                mensaje = mensaje + "Número de identificación \n";
                this.txtNumeroIdentificacion.Focus();
            }

            this.nombre = this.txtNombre.Text.Trim();
            if (this.nombre == "")
            {
                mensaje = mensaje + "Nombre \n";
                this.txtNombre.Focus();
            }

            if (this.cmbComuna.Text == "")
            {
                mensaje = mensaje + "Dirección \n";
                this.cmbComuna.Focus();
            }
            else
            {
                this.comuna = Convert.ToDouble(this.cmbComuna.Text.Trim());
            }

            this.genero = this.cmbGenero.Text.Trim();
            if (this.genero == "")
            {
                mensaje = mensaje + "Género \n";
                this.cmbGenero.Focus();
            }

            if (mensaje != "")
            {
                mensaje = "Favor diligenciar los siguientes campos:\n" + mensaje;
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.fecha = this.dateTimePickerFecha.Value.ToString();
                calcularAuxilio();
                return true;
            }


        }
            private void calcularAuxilio()
            {
                if (this.comuna == 1 || this.comuna == 8 || this.comuna == 10)
                {
                    this.auxilioEconomico = 100000;
                }
                else
                {
                    this.auxilioEconomico = 50000;
                }
            }

        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                ColaJuventud cola = new ColaJuventud();
                cola.Identificacion = this.identificacion;
                cola.Nombre = this.nombre;
                cola.Comuna = this.comuna;
                cola.Genero = this.genero;
                cola.Fecha = this.fecha;
                cola.AuxilioEconomico = this.auxilioEconomico;
                txtAuxilioEconomico.Text = cola.AuxilioEconomico.ToString();
                this.totalRegistros = colaJuventud.Count() + 1;
                colaJuventud.Enqueue(cola);

                MessageBox.Show("Registro agregado");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.colaJuventud.ToArray();

                limpiarForm();

                eliminarToolStripMenuItem.Enabled = true;
                reporteToolStripMenuItem.Enabled = true;
            }
        }
        private void limpiarForm()
        {
            this.txtNumeroIdentificacion.Text = "";
            this.txtNombre.Text = "";
            this.cmbComuna.Text = "";
            this.cmbGenero.Text = "";
            this.dateTimePickerFecha.Value = DateTime.Now;
            this.txtRegistros.Text = "";
            this.txtAuxilioEconomico.Text = "";
        }
    }
}
