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
    public partial class Lista : Form
    {

          private string tipoDeIdentificacion, edad, nombre, estrato, fecha, voto;
          private int numeroDeIdentificacion;

        private List<ListaEstudiante> listaEstudiante = new List<ListaEstudiante>();

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listaEstudiante.Count() > 0)
            {

                if (txtNumeroID.Text == "")
                {
                    MessageBox.Show("El campo identificación no puede estar vacio para realizar la consulta");
                    this.txtNumeroID.Focus();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtNumeroID.Text.Trim());
                    ListaEstudiante lista = buscarEstudiante(id);

                    if (lista != null)
                    {
                        this.CmbTipoID.Text = lista.TipoDeIdentificacion;
                        this.txtNumeroID.Text = lista.NumeroDeIdentificacion.ToString();
                        this.txtEdad.Text = lista.Edad;
                        this.txtNombre.Text = lista.Nombre;
                        this.cmbEstrato.Text = lista.Estrato;
                        this.dateTimePickerFecha.Value = Convert.ToDateTime(lista.Fecha);
                        if (lista.Voto == "Si")
                        {
                            this.radioButtonSI.Checked = true;
                        }
                        if (lista.Voto == "No")
                        {
                            this.radioButtonNO.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El estudiante con el número identificación " + id + " no hace parte de la lista.");
                        this.txtNumeroID.Focus();
                    }
                }
            }
            else
            {
                this.consultarToolStripMenuItem.Enabled = false;
                this.eliminarToolStripMenuItem.Enabled = false;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listaEstudiante.Count > 0)
            {
                if (this.txtNumeroID.Text == "")
                {
                    MessageBox.Show("El campo identificación no puede estar vacio para eliminar un estudiante");
                    this.txtNumeroID.Focus();
                }
                else
                {
                    int id = Convert.ToInt32(this.txtNumeroID.Text.Trim());
                    ListaEstudiante lista = buscarEstudiante(id);

                    if (lista != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registro de la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this.listaEstudiante.Remove(lista);
                            dataGridView1.DataSource = this.listaEstudiante.ToArray();
                            MessageBox.Show("Registro eliminado correctamente");
                            limpiarForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El estudiante con número identificación " + id + " no se encuentra en la lista.");
                        this.txtNumeroID.Focus();
                    }
                }
            }
            else
            {
                this.consultarToolStripMenuItem.Enabled = false;
                this.eliminarToolStripMenuItem.Enabled = false;
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

        public Lista()
        {
            InitializeComponent();

            consultarToolStripMenuItem.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;

        }
        private ListaEstudiante buscarEstudiante(int ident)
        {
            foreach (ListaEstudiante lista in this.listaEstudiante)
            {
                if (lista.NumeroDeIdentificacion.Equals(ident))
                {
                    return lista;
                }
            }
            return null;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                ListaEstudiante lista = new ListaEstudiante();

                lista.TipoDeIdentificacion = this.tipoDeIdentificacion;
                lista.NumeroDeIdentificacion = this.numeroDeIdentificacion;
                lista.Edad = this.edad;
                lista.Nombre = this.nombre;
                lista.Estrato = this.estrato;
                lista.Fecha = this.fecha;
                lista.Voto = this.voto;

                if (buscarEstudiante(lista.NumeroDeIdentificacion) != null)
                {
                    MessageBox.Show("El estudiante con identificación " + lista.NumeroDeIdentificacion +
                        " ya hace parte de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNumeroID.Focus();
                }
                else
                {
                    this.listaEstudiante.Add(lista);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = this.listaEstudiante.ToArray();

                    MessageBox.Show("Estudiante agregado correctamente");
                    limpiarForm();
                    this.consultarToolStripMenuItem.Enabled = true;
                    this.eliminarToolStripMenuItem.Enabled = true;
                }

            }
        }
        private void limpiarForm()
        {
            this.CmbTipoID.Text = "";
            this.txtNumeroID.Text = "";
            this.txtEdad.Text = "";
            this.txtNombre.Text = "";
            this.cmbEstrato.Text = "";
            this.dateTimePickerFecha.Value = DateTime.Now;
            this.radioButtonSI.Checked = false;
            this.radioButtonNO.Checked = false;
        }
        private bool validarFormulario()
            {
                string mensaje = "";

                this.tipoDeIdentificacion = this.CmbTipoID.Text.Trim();
                if (this.tipoDeIdentificacion == "")
                {
                    mensaje = mensaje + "-Tipo de identificación \n";
                    this.CmbTipoID.Focus();
                }

                if (this.txtNumeroID.Text == "")
                {
                    mensaje = mensaje + "Numero de identificación \n";
                    this.txtNumeroID.Focus();
                }
                else
                {
                    this.numeroDeIdentificacion = Convert.ToInt32(this.txtNumeroID.Text.Trim());
                }

                this.edad = this.txtEdad.Text.Trim();
                if (this.edad == "")
                {
                    mensaje = mensaje + "Edad \n";
                    this.txtEdad.Focus();
                }

                this.nombre = this.txtNombre.Text.Trim();
                if (nombre == "")
                {
                    mensaje = mensaje + "Nombre \n";
                    this.txtNombre.Focus();
                }

                this.estrato = this.cmbEstrato.Text.Trim();
                if (estrato == "")
                {
                    mensaje = mensaje + "Estrato socioeconómico \n";
                    this.cmbEstrato.Focus();
                }

                if (this.radioButtonSI.Checked == false && this.radioButtonNO.Checked == false)
                {
                    mensaje = mensaje + "-¿Voto en las elecciones presidenciales? \n";
                }

                else
                {
                    if (this.radioButtonSI.Checked == true)
                    {
                        this.voto = "Si";
                    }
                    if (this.radioButtonNO.Checked == true)
                    {
                        this.voto = "No";
                    }
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
                    return true;
                }
            }
    }
}
