using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinalEstructuraII
{
    public partial class FormGrafo : Form
    {

        private Dictionary<string, Point> nodos = new Dictionary<string, Point>();
        private List<Tuple<string, string>> aristas = new List<Tuple<string, string>>();
        public FormGrafo()
        {
            InitializeComponent();
            MostrarGrafo();
        }
        

        private void AgregarArista(string origen, string destino)
        {
            aristas.Add(Tuple.Create(origen, destino));
            if (!nodos.ContainsKey(origen))
                nodos[origen] = Point.Empty;
            if (!nodos.ContainsKey(destino))
                nodos[destino] = Point.Empty;
        }
        private void MostrarGrafo()
        {
            // Configurar el PictureBox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.SkyBlue);

            // Configurar posición de los nodos
            nodos["A"] = new Point(100, 100);
            nodos["B"] = new Point(250, 100);
            nodos["C"] = new Point(175, 250);
            nodos["D"] = new Point(300, 250);


            // Dibujar aristas con flechas
            foreach (var arista in aristas)
            {
                Point inicio = nodos[arista.Item1];
                Point fin = nodos[arista.Item2];

                if (inicio != fin)
                {
                   
                    double angle = Math.Atan2(fin.Y - inicio.Y, fin.X - inicio.X);
                    double arrowSize = 15;
                    PointF arrowPoint = new PointF((float)(fin.X - arrowSize * Math.Cos(angle)),
                                                  (float)(fin.Y - arrowSize * Math.Sin(angle)));

                  
                    g.DrawLine(Pens.Black, inicio, fin);

                  
                    AdjustableArrowCap arrowCap = new AdjustableArrowCap(5, 5);
                    Pen arrowPen = new Pen(Color.Black);
                    arrowPen.CustomEndCap = arrowCap;
                    g.DrawLine(arrowPen, inicio, arrowPoint);
                }
                else
                {
                   
                    int radio = 20;
                    RectangleF rect = new RectangleF(inicio.X - radio, inicio.Y - radio, 2 * radio, 2 * radio);
                    float startAngle = 180;
                    float sweepAngle = 180;
                    g.DrawArc(Pens.Black, rect, startAngle, sweepAngle);
                }
            }

            // Dibujar nodos
            foreach (var nodo in nodos)
            {
                int radio = 15; 
                Brush colorNodo = Brushes.Gold; 

                g.FillEllipse(colorNodo, nodo.Value.X - radio, nodo.Value.Y - radio, 2 * radio, 2 * radio);
                g.DrawString(nodo.Key, DefaultFont, Brushes.Black, nodo.Value.X - 5, nodo.Value.Y - 5);
            }



            // Actualizar el PictureBox
            pictureBox1.Invalidate();
        }


        private void FormGrafo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            // Obtener los valores del TextBox para el origen y destino
            string origen = txtOrigen.Text.ToUpper(); // Convertir a mayúsculas para manejar entradas en minúsculas
            string destino = txtDestino.Text.ToUpper();

            // Validar que los valores ingresados sean A, B, C o D
            if (EsLetraPermitida(origen) && EsLetraPermitida(destino))
            {
                // Agregar la arista y mostrar el grafo
                AgregarArista(origen, destino);
                MostrarGrafo();
            }
            else
            {
                string letras = "";
                foreach (var item in LetrasPermitidas.letras)
                {
                    letras += item.ToString() + " ";
                }

                MessageBox.Show($"Ingrese valores válidos para el origen y destino ( {letras}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsLetraPermitida(string letra)
        {
           
            return LetrasPermitidas.letras.Contains(letra);
        }

        private void btnCrearVertice_Click(object sender, EventArgs e)
        {
            if (txtCordX.Text.Length != 0 && txtCordY.Text.Length != 0 && txtNombre.Text.Length != 0)
            {
                nodos[txtNombre.Text.ToUpper()] = new Point(int.Parse(txtCordX.Text), int.Parse(txtCordY.Text));

                Graphics g = Graphics.FromImage(pictureBox1.Image);
                foreach (var nodo in nodos)
                {
                    int radio = 15; // Tamaño del radio del nodo
                    Brush colorNodo = Brushes.Green; // Color del nodo

                    g.FillEllipse(colorNodo, nodo.Value.X - radio, nodo.Value.Y - radio, 2 * radio, 2 * radio);
                    g.DrawString(nodo.Key, DefaultFont, Brushes.Black, nodo.Value.X - 5, nodo.Value.Y - 5);
                }
                LetrasPermitidas.letras.Add(txtNombre.Text.ToUpper());
                pictureBox1.Invalidate();
            }
            else
            {
                MessageBox.Show("No puede dejar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
