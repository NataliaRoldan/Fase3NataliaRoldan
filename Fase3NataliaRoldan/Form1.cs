namespace Fase3NataliaRoldan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string password = "123";
        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            string clave = "";
            clave = this.txtPassword.Text;

            if (clave == "")
            {
                error.SetError(this.txtPassword, "Ingrese contraseña");
                this.txtPassword.Focus();
            }
            else
            {
                if (clave != password)
                {
                    error.SetError(this.txtPassword, "Clave erronea");
                    this.txtPassword.Clear();
                    this.txtPassword.Focus();
                }
                else
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                }
            }
        }
    }
}