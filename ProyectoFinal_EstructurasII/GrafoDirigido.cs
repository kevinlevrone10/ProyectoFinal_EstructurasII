using Msg;
using ProyectoFinal_EstructurasII;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grafo_1_Representacion_Grafica
{
    class GrafoDirigido
    {
        public static int V; // Número de vértices
        public static List<int>[] listaAdyacencia; // Lista de adyacencia
        public static int[] gradosEntrantes;

        public GrafoDirigido(int v)
        {
            V = v;
            listaAdyacencia = new List<int>[v];
            gradosEntrantes = new int[v];

            for (int i = 0; i < v; i++)
            {
                listaAdyacencia[i] = new List<int>();
            }
        }



        public void BuscarEliminarVertice(int valor)
        {
            bool encontrado = false;
            for (int i = 0; i < V; i++)
            {
                if (listaAdyacencia[i].Contains(valor))
                {
                    encontrado = true;

                    MsgBox pedirForm = new MsgBox("pregunta", $"Se encontro el nodo {valor} ¿Desea eliminarlo?");
                    pedirForm.ShowDialog();

                    // Obtener el resultado del formulario personalizado
                    DialogResult result = pedirForm.DialogResultCustom;

                    if (result == DialogResult.Yes)
                    {
                        // Eliminar el vértice
                        for (int j = 0; j < V; j++)
                        {
                            listaAdyacencia[j].Remove(valor);
                        }

                        MsgBox m = new MsgBox("ok", $"El nodo con valor {valor} ha sido eliminado");
                        m.ShowDialog();
                    }
                    else
                    {
                        MsgBox m = new MsgBox("error", "operacion cancelada");
                        m.ShowDialog();
                    }

                    break;  // Salir del bucle una vez que se encuentra el vértice
                }
            }

            if (!encontrado)
            {
                MsgBox m = new MsgBox("error", $"el nodo con valor {valor} no existe");
                m.ShowDialog();

            }
        }


        public void ActualizarRepresentacionGrafoEnTextBox(TextBox textBox)
        {
            textBox.Clear();
            textBox.AppendText("Representación del Grafo Dirigido:" + Environment.NewLine);
            for (int i = 0; i < V; i++)
            {
                textBox.AppendText($"Vértice {i} -> ");
                foreach (var nodo in listaAdyacencia[i])
                {
                    textBox.AppendText($"{nodo} ");
                }
                textBox.AppendText(Environment.NewLine);
            }
        }


        // Método para crear grafo
        public static void CrearGrafo()
        {
            Console.Write("Ingrese el número de vértices: ");
            int numVertices = int.Parse(Console.ReadLine());

            GrafoDirigido grafo = new GrafoDirigido(numVertices);

            while (true)
            {
                Console.WriteLine("Ingrese una arista (origen destino) o escriba 'fin' para terminar:");
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                {
                    break;
                }

                string[] partes = input.Split(' ');
                if (partes.Length != 2)
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar dos números separados por espacio.");
                    continue;
                }

                int origen = int.Parse(partes[0]);
                int destino = int.Parse(partes[1]);
                grafo.AgregarArista(origen, destino);
            }

        }

        public void AgregarArista(int origen, int destino)
        {
            // Verificar que los vértices origen y destino están dentro del rango válido
            if (origen >= 0 && origen < V && destino >= 0 && destino < V)
            {
                listaAdyacencia[origen].Add(destino);
                gradosEntrantes[destino]++;
                MsgBox m = new MsgBox("ok", $"Arista ({origen}, {destino}) agregada con éxito.");
                m.ShowDialog();
            }
            else
            {
                MsgBox m = new MsgBox("error", "No se puede agregar , fuera de rango");
                m.ShowDialog();
            }
        }


    }
}