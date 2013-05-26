using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamenProgramacion3
{
    public partial class IngresoSistema : Form
    {
        public IngresoSistema()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {


            try{

            string myConnection= "datasource=localhost;port=3306;username=root;password=0569";
            MySqlConnection  myConn= new MySqlConnection(myConnection);
            MySqlCommand ComandoSelect= new MySqlCommand("select * from directorio.usuarios where login='"+ this.textBoxUsuario.Text + "' and password='" + this.textBoxClave.Text + "';",myConn);
            MySqlDataReader myReader;
            myConn.Open();
                myReader= ComandoSelect.ExecuteReader();
                int contador = 0;
                while(myReader.Read())
                {
                 contador = contador + 1;

                }
                if (contador==1)
                {

                    MessageBox.Show("Acceso Correcto");
                }
                else if( contador>1)
                {

                    MessageBox.Show(" Usuario y Contraseña duplicados acceso denegado");
                }
                else  MessageBox.Show("usuario y contraseña son incorrectos");

                myConn.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void butonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelIdioma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if ( linkLabelIdioma.Text == "English")
            {
                labelUsuario.Text = "User";
                labelClave.Text = "Password";
                labelAccesoSistema.Text = "System Access";
                botonAceptar.Text = "Ok";
                botonCerrar.Text = "Close";
                linkLabelIdioma.Text = "Español";
                labelTituloPro3.Text = "PROGRAMMING 3";
            }
            else
            {
                labelUsuario.Text = "Usuario";
                labelClave.Text = "Clave";
                labelAccesoSistema.Text = "Acceso al Sistema";
                botonAceptar.Text = "Aceptar";
                botonCerrar.Text = "Cerrar";
                linkLabelIdioma.Text = "English";
                labelTituloPro3.Text = "PROGRAMACION 3";
            }





        }

        private void IngresoSistema_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }




        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
