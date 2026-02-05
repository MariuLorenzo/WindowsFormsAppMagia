namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inicio = new System.Windows.Forms.Label();
            this.opcion = new System.Windows.Forms.Label();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.Intento = new System.Windows.Forms.Label();
            this.labelIntento = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.respuesta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicio.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.ForeColor = System.Drawing.Color.Indigo;
            this.inicio.Location = new System.Drawing.Point(462, 38);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(327, 122);
            this.inicio.TabIndex = 1;
            this.inicio.Text = "Pruebe su magia interna";
            this.inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // opcion
            // 
            this.opcion.AutoSize = true;
            this.opcion.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opcion.Location = new System.Drawing.Point(454, 187);
            this.opcion.Name = "opcion";
            this.opcion.Size = new System.Drawing.Size(358, 29);
            this.opcion.TabIndex = 5;
            this.opcion.Text = "Cree poseer dotes mágicos?";
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdivinar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAdivinar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdivinar.FlatAppearance.BorderSize = 3;
            this.btnAdivinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinar.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinar.ForeColor = System.Drawing.Color.Black;
            this.btnAdivinar.Location = new System.Drawing.Point(50, 525);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(266, 109);
            this.btnAdivinar.TabIndex = 6;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = false;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // Intento
            // 
            this.Intento.AutoSize = true;
            this.Intento.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intento.Location = new System.Drawing.Point(657, 606);
            this.Intento.Name = "Intento";
            this.Intento.Size = new System.Drawing.Size(24, 28);
            this.Intento.TabIndex = 8;
            this.Intento.Text = "0";
            // 
            // labelIntento
            // 
            this.labelIntento.AutoSize = true;
            this.labelIntento.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntento.Location = new System.Drawing.Point(542, 606);
            this.labelIntento.Name = "labelIntento";
            this.labelIntento.Size = new System.Drawing.Size(111, 28);
            this.labelIntento.TabIndex = 7;
            this.labelIntento.Text = "Intentos:";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtNum.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.IndianRed;
            this.txtNum.Location = new System.Drawing.Point(547, 343);
            this.txtNum.Name = "txtNum";
            this.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNum.Size = new System.Drawing.Size(134, 69);
            this.txtNum.TabIndex = 9;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.MouseLeave += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.respuesta.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.respuesta.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(54, 379);
            this.respuesta.Margin = new System.Windows.Forms.Padding(3);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(15, 33);
            this.respuesta.TabIndex = 10;
            this.respuesta.Text = "\r\n";
            this.respuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adivine el número que estoy pensando...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "entre 1 y 100";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(880, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.Intento);
            this.Controls.Add(this.labelIntento);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.opcion);
            this.Controls.Add(this.inicio);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Magia interna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.Label opcion;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Label Intento;
        private System.Windows.Forms.Label labelIntento;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

