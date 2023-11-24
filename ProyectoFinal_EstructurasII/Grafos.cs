using Grafo_1_Representacion_Grafica;
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
    public partial class Grafos : Form
    {
        private GrafoDirigido grafo;
        public Grafos()
        {
            InitializeComponent();
            grafo = null;
        }
        private void Grafos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void LimpiarEntradasArista()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int numVertices;
            if (int.TryParse(txtNumVertices.Text, out numVertices))
            {
                grafo = new GrafoDirigido(numVertices);
                MsgBox m = new MsgBox("ok", $"se ha creado un Grafo de un tamaño de {numVertices}");
                m.ShowDialog();
                txtNumVertices.Text = "";
            }
            else
            { 
                MsgBox m = new MsgBox("error", "Ingrese un numero valido de vertices");
                m.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (grafo == null)
            {
                MsgBox m = new MsgBox("error", "primero cree el Grafo");
                m.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            int origen, destino;
            if (int.TryParse(textBox1.Text, out origen) && int.TryParse(textBox2.Text, out destino))
            {
                grafo.AgregarArista(origen, destino);
                LimpiarEntradasArista();
            }
            else
            {
                MsgBox m = new MsgBox("error", "Ingrese elementos validos");
                m.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grafo == null)
            {
                MsgBox m = new MsgBox("error", "no hay elementos para Imprimir");
                m.ShowDialog();
                return;
            }

            grafo.ActualizarRepresentacionGrafoEnTextBox(txtResultado);
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int valorBuscadoEliminar;

            if (grafo == null)
            {
                MsgBox m = new MsgBox("error", "no hay nada que buscar ,Grafo vacio");
                m.ShowDialog();
                txtbus.Text = "";
                return;
            }
            else if (int.TryParse(txtbus.Text, out valorBuscadoEliminar))
            {
                grafo.BuscarEliminarVertice(valorBuscadoEliminar);
                grafo.ActualizarRepresentacionGrafoEnTextBox(txtResultado);
            }
            else
            {
                MsgBox m = new MsgBox("error", "Ingrese un valor numerico válido");
                m.ShowDialog();
                txtbus.Text = "";

            }
        }
    }
}
