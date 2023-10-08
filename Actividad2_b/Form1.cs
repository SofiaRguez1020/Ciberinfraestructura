using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Data;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Actividad 2";
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
        //Agregamos funcion al boton de conectar
        private void ButtonValidar_Click(object sender, EventArgs e)
        {
            //Capturamos datos de text boxes con la informacion de la conexion
            String Host = txtHost.Text;
            String User = txtUsuario.Text;
            String Password = txtPassword.Text;
            String Puerto = txtPuerto.Text;
            String DB = txtDB.Text;

            //Creamos el objeto d ela conexion con los datos capturados
            String connectionString = BuildConnectionString(Host, User, Password, Puerto, DB);
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //Usamos el try catch para que en caso de error mostrar mensaje
                try
                {
                    //Abrimos conexion 
                    con.Open();
                    //Obetnemos los datos de la tabla CatPersonal
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    //Creamos objeto tabla para capturar los datos de la DB
                    DataTable dt = new DataTable();
                    //Llenamos la tabla con la informacion
                    adapter.Fill(dt);
                    //Agregamos la tabla al objeto de data grid view del form
                    dgvDatos.DataSource = dt;

                }
                catch (Exception ex)
                {
                    //En caso de tener mal los datos o de un error en conexion, mostramos msg
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
        }
        //Creamos funcion para armar la string de la conexion
        private string BuildConnectionString(string host, string user, string password, string port, string DB)
        {
            return $"SERVER = {host}; PORT ={port}; DATABASE = {DB};USER ID = {user}; PASSWORD ={password};";
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