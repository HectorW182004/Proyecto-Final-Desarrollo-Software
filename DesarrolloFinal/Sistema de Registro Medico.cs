using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloFinal
{
    public partial class Sistema_Registro_Médico : Form
    {
        public Sistema_Registro_Médico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear_Registro ventana  = new Crear_Registro();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Modifcar_Registro ventana2 = new Modifcar_Registro();
            ventana2.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Eliminar_Registro ventana3 = new Eliminar_Registro();
            ventana3.Show();

            this.Hide();
        }

        private void Sistema_Registro_Médico_Load(object sender, EventArgs e)
        {

        }
    }
}
