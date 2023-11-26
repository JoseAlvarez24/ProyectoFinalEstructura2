using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalEstructuraII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEjercicios_Click(object sender, EventArgs e)
        {
            if (!panel3.Visible)
                panel3.Visible = true;
            else
                panel3.Visible = false;
        }

        public void AbrirFomrs<Miforms>() where Miforms : Form, new()
        {
            Form Formulario;
            Formulario = PanelContenedor.Controls.OfType<Miforms>().FirstOrDefault();
            if (Formulario == null)
            {
                //este if ayuda a cerrar el formulario anterior para poder abrir uno nuevo
                if (this.PanelContenedor.Controls.Count > 0)
                    this.PanelContenedor.Controls.RemoveAt(0);
                // aqui termima xd
                Formulario = new Miforms();
                Formulario.TopLevel = false;
                Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(Formulario);
                PanelContenedor.Tag = Formulario;
                Formulario.BringToFront();
                Formulario.Show();
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnArbol_Click(object sender, EventArgs e)
        {

            AbrirFomrs<FormArbol>();
        }

        private void BtnGrafo_Click(object sender, EventArgs e)
        {
            AbrirFomrs<FormGrafo>();
        }
    }
}
