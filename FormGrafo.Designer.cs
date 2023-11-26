namespace ProyectoFinalEstructuraII
{
    partial class FormGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCrearVertice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCordY = new System.Windows.Forms.TextBox();
            this.txtCordX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(33, 58);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(148, 58);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(88, 128);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(104, 37);
            this.btnAgregarArista.TabIndex = 4;
            this.btnAgregarArista.Text = "Agregar Arista";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAgregarArista);
            this.panel1.Controls.Add(this.txtOrigen);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Location = new System.Drawing.Point(360, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 212);
            this.panel1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nota* Las vertices por defecto son A,B,C,D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Menu para agregar aristas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnCrearVertice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCordY);
            this.panel2.Controls.Add(this.txtCordX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(360, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 208);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Menu para agregar Vertices";
            // 
            // btnCrearVertice
            // 
            this.btnCrearVertice.Location = new System.Drawing.Point(117, 170);
            this.btnCrearVertice.Name = "btnCrearVertice";
            this.btnCrearVertice.Size = new System.Drawing.Size(75, 23);
            this.btnCrearVertice.TabIndex = 22;
            this.btnCrearVertice.Text = "Crear Vertice";
            this.btnCrearVertice.UseVisualStyleBackColor = true;
            this.btnCrearVertice.Click += new System.EventHandler(this.btnCrearVertice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "y";
            // 
            // txtCordY
            // 
            this.txtCordY.Location = new System.Drawing.Point(186, 103);
            this.txtCordY.Name = "txtCordY";
            this.txtCordY.Size = new System.Drawing.Size(100, 20);
            this.txtCordY.TabIndex = 20;
            // 
            // txtCordX
            // 
            this.txtCordX.Location = new System.Drawing.Point(47, 103);
            this.txtCordX.Name = "txtCordX";
            this.txtCordX.Size = new System.Drawing.Size(100, 20);
            this.txtCordX.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre del vertice";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "X y Y son los ejes sobre los que se creara el vertice";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(210, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGrafo";
            this.Text = "FormGrafo";
            this.Load += new System.EventHandler(this.FormGrafo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCrearVertice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCordY;
        private System.Windows.Forms.TextBox txtCordX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}