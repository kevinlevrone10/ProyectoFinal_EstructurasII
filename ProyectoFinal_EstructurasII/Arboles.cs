using Microsoft.VisualBasic;
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
using System.Windows.Media;


namespace ProyectoFinal_EstructurasII
{
    public partial class Arboles : Form
    {
         class Nodo
        {
            public int dato;
            public Nodo izquierda;
            public Nodo derecha;
            public Nodo(int v, Nodo i, Nodo d)
            {
                dato = v;
                izquierda = i;
                derecha = d;
            }
        }

        public Arboles()
        {
            InitializeComponent();
        }


        private Nodo raiz = null;

        private int Pedir(string mensaje)
        {
            Pedir pedir = new Pedir();
            pedir.Mensaje = mensaje;

            if (pedir.ShowDialog() == DialogResult.OK)
            {
                int valor = pedir.ValorIngresado;
                return valor;
            }
           
            return Pedir(mensaje);
            
        }


        private void Crearnodo(ref Nodo q, int d)
        {
            q = new Nodo(d, q, q);
            q.izquierda = null;
            q.derecha = null;
        }

        private void Insertarnodo(ref Nodo r)
        {
            Nodo t1 = null, t2 = null, t = null;
            int resp = 1, d = 0;
            while (resp == 1)
            {
                if (r == null)
                {
                    d = Pedir("Ingrese el Dato para el Nodo Raiz");
                    Crearnodo(ref r, d);
                }
                else
                {
                    d = Pedir("Ingrese el dato para el Nodo Hijo");
                    t1 = t2 = r;
                    while (t1 != null)
                    {
                        t2 = t1;
                        if (d < t2.dato)
                            t1 = t2.izquierda;
                        else
                            t1 = t2.derecha;
                    }
                    Crearnodo(ref t, d);
                    if (d < t2.dato)
                        t2.izquierda = t;
                    else
                        t2.derecha = t;
                }

                MsgBox m = new MsgBox("pregunta", "Desea seguir Agregando Datos?");
                m.ShowDialog();

                if (m.DialogResultCustom == DialogResult.Yes)
                {
                    // Código si el usuario presiona "Aceptar"
                    resp = 1;
                }
                else
                {
                    // Código si el usuario presiona "Cancelar"
                    resp = 0;
                }
            }
        }

        private Nodo EliminarNodo(ref Nodo raiz, int valorAEliminar)
        {
            if (raiz == null)
            {
                // Árbol vacío o nodo no encontrado
                throw new InvalidOperationException($"El nodo con valor {valorAEliminar} no existe.");
            }

            // Buscar el nodo a eliminar en el subárbol izquierdo o derecho
            if (valorAEliminar < raiz.dato)
            {
                raiz.izquierda = EliminarNodo(ref raiz.izquierda, valorAEliminar);
            }
            else if (valorAEliminar > raiz.dato)
            {
                raiz.derecha = EliminarNodo(ref raiz.derecha, valorAEliminar);
            }
            else
            {
                // Nodo encontrado, confirmar eliminación
                if (ConfirmarEliminacion(valorAEliminar))
                {
                    // Realizar la eliminación
                    if (raiz.izquierda == null)
                    {
                        raiz = raiz.derecha;  // Sin hijo izquierdo, asigna el hijo derecho (o null si no tiene)
                    }
                    else if (raiz.derecha == null)
                    {
                        raiz = raiz.izquierda;  // Sin hijo derecho, asigna el hijo izquierdo
                    }
                    else
                    {
                        // Nodo con dos hijos, encuentra el sucesor inorden (mínimo en el subárbol derecho)
                        raiz.dato = EncontrarMinimo(raiz.derecha);

                        // Elimina el sucesor inorden encontrado
                        raiz.derecha = EliminarNodo(ref raiz.derecha, raiz.dato);
                    }

                    MsgBox m = new MsgBox("ok", $"El nodo con valor {valorAEliminar} se elimino correctamente.");
                    m.ShowDialog();
                }
                else
                {
                    MsgBox m = new MsgBox("error", $" el nodo con valor {valorAEliminar} no se elimino.");
                    m.ShowDialog();
                }
            }

            return raiz;
        }

        private bool ConfirmarEliminacion(int valorAEliminar)
        {
            MsgBox pedirForm = new MsgBox("pregunta", $"Se encontró el nodo {valorAEliminar}. ¿Desea eliminarlo?");
            pedirForm.ShowDialog();
            DialogResult result = pedirForm.DialogResultCustom;
            return result == DialogResult.Yes;
        }


        static int EncontrarMinimo(Nodo raiz)
        {
            while (raiz.izquierda != null)
            {
                raiz = raiz.izquierda;
            }

            return raiz.dato;
        }

        bool eliminandoNodos = false;

        public void ActualizarTreeView()
        {
            treeView1.Nodes.Clear(); // Limpiar nodos existentes en el TreeView

            if (raiz != null)
            {
                AgregarNodosTreeView(raiz, null); // Agregar nodos del árbol al TreeView
                treeView1.ExpandAll(); // Expandir todos los nodos
                treeView1.ShowRootLines = false; // Ocultar las líneas del nodo raíz
            }
            else if (!eliminandoNodos)
            {
                MsgBox m = new MsgBox("error", "no hay datos para imprimir");
                m.ShowDialog();
                
            }
        }

        void AgregarNodosTreeView(Nodo nodo, TreeNode parentNode)
        {
            if (nodo != null)
            {
                // Agregar el nodo actual
                TreeNode currentNode;
                if (parentNode == null)
                {
                    currentNode = treeView1.Nodes.Add(nodo.dato.ToString());
                }
                else
                {
                    currentNode = parentNode.Nodes.Add(nodo.dato.ToString());
                }

                // Agregar los nodos hijos recursivamente
                AgregarNodosTreeView(nodo.izquierda, currentNode);
                AgregarNodosTreeView(nodo.derecha, currentNode);
            }
        }
        private void Arboles_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertarnodo(ref raiz);
        }

        private void Impinorden(Nodo t, TreeNodeCollection nodes)
        {
            if (nodes != null && t != null)
            {
                Impinorden(t.izquierda, nodes);
                nodes.Add(t.dato.ToString());
                Impinorden(t.derecha, nodes);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarTreeView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valorAEliminar;
            if (int.TryParse(txtValorAEliminar.Text, out valorAEliminar))
            {
                try
                {
                    eliminandoNodos = true;
                    EliminarNodo(ref raiz, valorAEliminar);
                    txtValorAEliminar.Text = "";  // Limpiar el TextBox           
                    ActualizarTreeView();
                    eliminandoNodos = false;
                }
                catch (InvalidOperationException ex)
                {
                    MsgBox m = new MsgBox("error", ex.Message);
                    m.ShowDialog();
                    txtValorAEliminar.Text = "";  // Limpiar el TextBox
                    eliminandoNodos = false;
                }
            }
            else
            {
                MsgBox m = new MsgBox("error", "Ingrese un valor numérico válido.");
                m.ShowDialog();

                txtValorAEliminar.Text = "";  // Limpiar el TextBox
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarTreeView();
        }
    }
}
