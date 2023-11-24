using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_EstructurasII
{
    
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Arboles arboles = new Arboles();

            arboles.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafos grafos = new Grafos();

            grafos.Show();

            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
