using Msg;
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
    public partial class Pedir : Form
    {
        public int ValorIngresado { get; private set; }
        public string Mensaje { get; set; }
        public Pedir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtpedir.Text, out int resultado))
            {
                ValorIngresado = resultado;
                DialogResult = DialogResult.OK;
                
            }
            else
            {
                MsgBox m = new MsgBox("error", "Ingrese un valor numérico valido.");
                m.ShowDialog();
            }
           
        }

        private void Pedir_Load(object sender, EventArgs e)
        {
            lblMsg.Text = Mensaje;
            ok.Visible = true;
            panel1.BackColor = Color.FromArgb(0, 128, 0); // RGB para verde oscuro
            panel2.BackColor = Color.FromArgb(0, 128, 0); // RGB para verde oscuro
        }
    }
}
