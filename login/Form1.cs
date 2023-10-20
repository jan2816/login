using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 3;
        SqlConnection conex = new SqlConnection("server=localhost\\SQLEXPRESS;database=db_usuario; integrated security=true");
        private void btnentrar_Click(object sender, EventArgs e)
        {
            conex.Open();
            string conusta = "select * from registro where nombre='" + txtusuario.Text + "' and contraseña='" + txrcontraseña.Text + "'";
            SqlCommand comando = new SqlCommand(conusta, conex);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (string.IsNullOrEmpty(txrcontraseña.Text) || string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Por favor ingrese nombre de usuario y contraseña", "Error");

            }
            else
            {
                if (lector.HasRows == true)
                {
                    MessageBox.Show("Bienvenido");
                    Application.Exit();
                }
                else
                {
                    loginAttempts++;

                    if (loginAttempts >= maxLoginAttempts)
                    {
                        MessageBox.Show("Ha excedido el número máximo de intentos fallidos. La aplicación se cerrará.", "Error");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos. Intentos restantes: " + (maxLoginAttempts - loginAttempts), "Error");
                    }
                }
            }

            conex.Close();
        }

        private void checkbxmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxmostrar.Checked)
            {
                txrcontraseña.PasswordChar = '\0';

            }
            else
            {
                txrcontraseña.PasswordChar = '*';
            }
        }

        private void lblsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
//CREATE DATABASE db_usuario 
//use db_usuario 
//create table registro(
//nombre varchar(50) not null,
//contraseña varchar (50) not null )
//insert into registro values( 'valentina', '1234')
//insert into registro values( 'jan', '1234')