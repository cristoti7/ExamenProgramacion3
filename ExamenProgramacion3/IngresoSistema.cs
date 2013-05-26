using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void butonCerrar_Click(object sender, EventArgs e)
        {
          
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
                LinkLabelIdioma.Text = "Español";
            }
            else
            {
                labUsuario.Text = "Usuario";
                labClave.Text = "Clave";
                labAcesoSistema.Text = "Acceso al Sistema";
                botonAceptar.Text = "Aceptar";
                botonCerrar.Text = "Cerrar";
                LinkLabelIdioma.Text = "English";

            }





        }
    }
}
