using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ProyectoFinalEstructuraII.FormArbol;

namespace ProyectoFinalEstructuraII
{
    public partial class FormArbol : Form
    {
        
        public FormArbol()
        {
            InitializeComponent();
        }
        private Nodo raiz = null;

        public class Nodo
        {
            public int dato;
            public Nodo izquierda;
            public Nodo derecha;

            public Nodo(int dato, Nodo izq, Nodo der)
            {
                this.dato = dato;
                izquierda = izq;
                derecha = der;
            }
        }

        private void AgregarNodo(ref Nodo r, int d)
        {
            if (r == null)
            {
                CrearNodo(ref r, d);
            }
            else
            {
                Nodo t1 = r, t2 = r, t = null;

                while (t1 != null)
                {
                    t2 = t1;
                    if (d < t2.dato)
                        t1 = t2.izquierda;
                    else
                        t1 = t2.derecha;
                }

                CrearNodo(ref t, d);

                if (d < t2.dato)
                    t2.izquierda = t;
                else
                    t2.derecha = t;
            }
        }

        private void CrearNodo(ref Nodo q, int d)
        {
            q = new Nodo(d, null, null);
            q.izquierda = null;
            q.derecha = null;
        }

        private void DibujarArbol(Nodo t, int x, int y, int distanciaX, Graphics g)
        {
            if (t != null)
            {
                g.FillEllipse(Brushes.Gold, x - 25, y - 25, 50, 50);
                g.DrawEllipse(Pens.Gold, x - 25, y - 25, 50, 50);
                g.DrawString(t.dato.ToString(), Font, Brushes.Black, x - 10, y - 10);

                int distanciaY = 50;

                if (t.izquierda != null)
                {
                    g.DrawLine(Pens.Black, x, y, x - distanciaX, y + distanciaY);
                    DibujarArbol(t.izquierda, x - distanciaX, y + distanciaY, distanciaX / 2, g);
                }

                if (t.derecha != null)
                {
                    g.DrawLine(Pens.Black, x, y, x + distanciaX, y + distanciaY);
                    DibujarArbol(t.derecha, x + distanciaX, y + distanciaY, distanciaX / 2, g);
                }
            }

        }

        private void FormArbol_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int distanciaXInicial = 100; // Puedes ajustar este valor según sea necesario
            DibujarArbol(raiz, panel2.Width / 2, 50, distanciaXInicial, e.Graphics);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(TxtDatoA.Text, out dato))
            {
                AgregarNodo(ref raiz, dato);
                panel2.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtDatoA.Clear();
        }

        private void BtnEliminarUltimoNodo_Click(object sender, EventArgs e)
        {
            int bd = int.Parse(TxtDatoA.Text);
            bool band = false;
            EliminarHoja(ref raiz, bd, ref band);
            if (band)
                MessageBox.Show($"La hoja a sido eliminada", "Hoja Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Hoja No encontrada o no Eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel2.Invalidate();
        }
        static void EliminarHoja(ref Nodo nodo, int bd, ref bool x)
        {
            if (nodo != null)
                if (nodo.dato == bd && (nodo.izquierda == null && nodo.derecha == null))
                {
                    nodo = null;
                    x = true;
                    Console.WriteLine("Dato eliminado");
                }
                else if (nodo.dato > bd)
                    EliminarHoja(ref nodo.izquierda, bd, ref x);
                else
                    EliminarHoja(ref nodo.derecha, bd, ref x);
        }

        private void BtnConarHijosDer_Click(object sender, EventArgs e)
        {
            int NodosDerecho = ContarNodoDerecho(raiz);

            if (NodosDerecho != 0)
            {
                MessageBox.Show($"La cantidad de nodos derecho son: {NodosDerecho} se encuentra en el árbol.", "Nodo Contados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No hay nodos derechos", "Nodos No Encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int ContarNodoDerecho(Nodo nodo)
        {
            if (nodo != null)
                if (nodo.derecha != null && nodo.izquierda == null)
                    return 1 + ContarNodoDerecho(nodo.izquierda) + ContarNodoDerecho(nodo.derecha);
                else
                    return ContarNodoDerecho(nodo.izquierda) + ContarNodoDerecho(nodo.derecha);
            else
                return 0;
        }

        private void BtnEliminarArbol_Click(object sender, EventArgs e)
        {
            EliminarArbol(raiz);
            raiz = null;  // Asegurarse de que la raíz también se establezca en null
            panel2.Invalidate();
        }

        private void EliminarArbol(Nodo nodo)
        {
            if (nodo != null)
            {
                EliminarArbol(nodo.izquierda);  // Eliminar subárbol izquierdo
                EliminarArbol(nodo.derecha);    // Eliminar subárbol derecho

                // Eliminar el nodo actual
                nodo = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
