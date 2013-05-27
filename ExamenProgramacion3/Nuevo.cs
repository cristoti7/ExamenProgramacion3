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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conex = "datasource=localhost;port=3306;username=root;password=0569";
            string query ="insert into  directorio.contacto (ap,am,nombre,domicilio,colonia,cp,municipio,estado,pais,mapa,telefono,celular,radio,email,observaciones) values ('"+ this.textBoxAP.Text+"','"+this.textBoxAM.Text+"','"+this.textBoxNombre.Text+"','"+this.textBoxDomicilio.Text+"','"+this.textBoxColonia.Text+"','"+this.textBoxCP.Text+"','"+this.textBoxMunicipio.Text+"','"+this.textBoxEstado.Text+"','"+this.textBoxPais.Text+"','"+this.textBoxMapa.Text+"','"+this.textBoxTelefono.Text+"','"+this.textBoxCelular.Text+"','"+this.textBoxRadio.Text+"','"+this.textBoxEmail.Text+"','"+this.textBoxObs.Text+"') ;";
            MySqlConnection conexDirectorio = new MySqlConnection(conex);
            MySqlCommand comandoInsertar = new MySqlCommand(query, conexDirectorio);
            MySqlDataReader myReader;

            try
            {

                conexDirectorio.Open();
                myReader = comandoInsertar.ExecuteReader();
                MessageBox.Show(" GUARDADO");
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void Nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
