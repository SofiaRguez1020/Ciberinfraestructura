using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Tarea 1";
        }

      

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Agregamos funcion al boton de validar
        private void ButtonValidar_Click(object sender, EventArgs e)
        {
            // Obtener el texto de los campos de texto
            string contrasenia = textBox1.Text;
            string confirmacionContrasenia = textBox2.Text;

            // Definir una expresion regular para validar la contrasenia
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$";

            // Realizar la validación usando Regex
            if (Regex.IsMatch(contrasenia, patron) && contrasenia == confirmacionContrasenia)
            {
                MessageBox.Show("La contraseña ha sido validada", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos o las contraseñas no coinciden", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Agregamos funcion a la imagen
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}