namespace WindowsApp
{
    partial class frmMetodos
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnMostrarMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(296, 82);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(180, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnMostrarMensaje
            // 
            this.btnMostrarMensaje.Location = new System.Drawing.Point(296, 153);
            this.btnMostrarMensaje.Name = "btnMostrarMensaje";
            this.btnMostrarMensaje.Size = new System.Drawing.Size(180, 23);
            this.btnMostrarMensaje.TabIndex = 1;
            this.btnMostrarMensaje.Text = "Mostrar Mensaje";
            this.btnMostrarMensaje.UseVisualStyleBackColor = true;
            this.btnMostrarMensaje.Click += new System.EventHandler(this.btnMostrarMensaje_Click);
            // 
            // frmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarMensaje);
            this.Controls.Add(this.btnImprimir);
            this.Name = "frmMetodos";
            this.Text = "frmMetodos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnMostrarMensaje;
    }
}