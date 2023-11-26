namespace ProyectoFinalEstructuraII
{
    partial class FormArbol
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEliminarArbol = new System.Windows.Forms.Button();
            this.BtnConarHijosDer = new System.Windows.Forms.Button();
            this.BtnEliminarUltimoNodo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtDatoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(243, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 248);
            this.panel2.TabIndex = 35;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnEliminarArbol
            // 
            this.BtnEliminarArbol.BackColor = System.Drawing.Color.Teal;
            this.BtnEliminarArbol.Location = new System.Drawing.Point(419, 103);
            this.BtnEliminarArbol.Name = "BtnEliminarArbol";
            this.BtnEliminarArbol.Size = new System.Drawing.Size(86, 42);
            this.BtnEliminarArbol.TabIndex = 40;
            this.BtnEliminarArbol.Text = "Eliminar Arbol";
            this.BtnEliminarArbol.UseVisualStyleBackColor = false;
            this.BtnEliminarArbol.Click += new System.EventHandler(this.BtnEliminarArbol_Click);
            // 
            // BtnConarHijosDer
            // 
            this.BtnConarHijosDer.BackColor = System.Drawing.Color.Teal;
            this.BtnConarHijosDer.Location = new System.Drawing.Point(302, 103);
            this.BtnConarHijosDer.Name = "BtnConarHijosDer";
            this.BtnConarHijosDer.Size = new System.Drawing.Size(111, 42);
            this.BtnConarHijosDer.TabIndex = 39;
            this.BtnConarHijosDer.Text = "Contar Nodos con solo hijos derecho";
            this.BtnConarHijosDer.UseVisualStyleBackColor = false;
            this.BtnConarHijosDer.Click += new System.EventHandler(this.BtnConarHijosDer_Click);
            // 
            // BtnEliminarUltimoNodo
            // 
            this.BtnEliminarUltimoNodo.BackColor = System.Drawing.Color.Teal;
            this.BtnEliminarUltimoNodo.Location = new System.Drawing.Point(511, 103);
            this.BtnEliminarUltimoNodo.Name = "BtnEliminarUltimoNodo";
            this.BtnEliminarUltimoNodo.Size = new System.Drawing.Size(75, 42);
            this.BtnEliminarUltimoNodo.TabIndex = 38;
            this.BtnEliminarUltimoNodo.Text = "Eliminar Ultima hoja";
            this.BtnEliminarUltimoNodo.UseVisualStyleBackColor = false;
            this.BtnEliminarUltimoNodo.Click += new System.EventHandler(this.BtnEliminarUltimoNodo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Teal;
            this.BtnAgregar.Location = new System.Drawing.Point(230, 103);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(66, 42);
            this.BtnAgregar.TabIndex = 37;
            this.BtnAgregar.Text = "Agregar Nodo";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtDatoA
            // 
            this.TxtDatoA.Location = new System.Drawing.Point(53, 261);
            this.TxtDatoA.Name = "TxtDatoA";
            this.TxtDatoA.Size = new System.Drawing.Size(100, 20);
            this.TxtDatoA.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingrese un dato para crear el arbol";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalEstructuraII.Properties.Resources.Arbol_binario_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(592, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 42;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "*Para eliminar la ultima hoja seleccione la hoja";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(677, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminarArbol);
            this.Controls.Add(this.BtnConarHijosDer);
            this.Controls.Add(this.BtnEliminarUltimoNodo);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtDatoA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormArbol";
            this.Text = "FormArbol";
            this.Load += new System.EventHandler(this.FormArbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEliminarArbol;
        private System.Windows.Forms.Button BtnConarHijosDer;
        private System.Windows.Forms.Button BtnEliminarUltimoNodo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtDatoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}