namespace WindowsApp
{
    partial class frmLoop
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
            this.btnPruebaLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaLoop
            // 
            this.btnPruebaLoop.Location = new System.Drawing.Point(414, 47);
            this.btnPruebaLoop.Name = "btnPruebaLoop";
            this.btnPruebaLoop.Size = new System.Drawing.Size(224, 23);
            this.btnPruebaLoop.TabIndex = 0;
            this.btnPruebaLoop.Text = "Prueba For - While";
            this.btnPruebaLoop.UseVisualStyleBackColor = true;
            this.btnPruebaLoop.Click += new System.EventHandler(this.btnPruebaLoop_Click);
            // 
            // frmLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebaLoop);
            this.Name = "frmLoop";
            this.Text = "frmLoop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaLoop;
    }
}