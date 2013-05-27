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
    public partial class Indice : Form
    {
        public Indice()
        {
            InitializeComponent();
        }

        private void Indice_Load(object sender, EventArgs e)
        {

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {

            Nuevo Directorio = new Nuevo();
            Directorio.Visible = true;
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDITAR DirectorioEditar= new EDITAR();
            DirectorioEditar.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ELIMINAR DirectorioEliminar = new ELIMINAR();
            DirectorioEliminar.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VER DirectorioVer = new VER();
            DirectorioVer.Visible = true;
            this.Visible = false;
        }

       
    }
}
