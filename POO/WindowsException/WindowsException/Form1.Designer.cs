namespace WindowsException
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
            this.btnPruebaException = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMiExepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaException
            // 
            this.btnPruebaException.Location = new System.Drawing.Point(558, 69);
            this.btnPruebaException.Name = "btnPruebaException";
            this.btnPruebaException.Size = new System.Drawing.Size(184, 23);
            this.btnPruebaException.TabIndex = 0;
            this.btnPruebaException.Text = "Prueba de exception";
            this.btnPruebaException.UseVisualStyleBackColor = true;
            this.btnPruebaException.Click += new System.EventHandler(this.btnPruebaException_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prueba de SqlException";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMiExepcion
            // 
            this.btnMiExepcion.Location = new System.Drawing.Point(544, 212);
            this.btnMiExepcion.Name = "btnMiExepcion";
            this.btnMiExepcion.Size = new System.Drawing.Size(184, 23);
            this.btnMiExepcion.TabIndex = 2;
            this.btnMiExepcion.Text = "Prueba mi Exception";
            this.btnMiExepcion.UseVisualStyleBackColor = true;
            this.btnMiExepcion.Click += new System.EventHandler(this.btnMiExepcion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMiExepcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPruebaException);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaException;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMiExepcion;
    }
}

