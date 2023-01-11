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
            this.btnCrearArchivos = new System.Windows.Forms.Button();
            this.btnCrearPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearArchivos
            // 
            this.btnCrearArchivos.Location = new System.Drawing.Point(480, 146);
            this.btnCrearArchivos.Name = "btnCrearArchivos";
            this.btnCrearArchivos.Size = new System.Drawing.Size(205, 59);
            this.btnCrearArchivos.TabIndex = 0;
            this.btnCrearArchivos.Text = "Crear archivos";
            this.btnCrearArchivos.UseVisualStyleBackColor = true;
            this.btnCrearArchivos.Click += new System.EventHandler(this.btnCrearArchivos_Click);
            // 
            // btnCrearPersonas
            // 
            this.btnCrearPersonas.Location = new System.Drawing.Point(480, 232);
            this.btnCrearPersonas.Name = "btnCrearPersonas";
            this.btnCrearPersonas.Size = new System.Drawing.Size(207, 76);
            this.btnCrearPersonas.TabIndex = 1;
            this.btnCrearPersonas.Text = "Crear personas";
            this.btnCrearPersonas.UseVisualStyleBackColor = true;
            this.btnCrearPersonas.Click += new System.EventHandler(this.btnCrearPersonas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearPersonas);
            this.Controls.Add(this.btnCrearArchivos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArchivos;
        private System.Windows.Forms.Button btnCrearPersonas;
    }
}

