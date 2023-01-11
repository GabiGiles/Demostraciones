namespace WindowsPresentacion
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
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.Location = new System.Drawing.Point(479, 88);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(212, 23);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear Objetos";
            this.btnCrearObjetos.UseVisualStyleBackColor = true;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjetos;
    }
}

