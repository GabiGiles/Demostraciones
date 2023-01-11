
namespace WindowsPresentacionColecciones
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
            this.btnGuardarProductsLista = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.lstPrecioProducto = new System.Windows.Forms.ListBox();
            this.btnCrearClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarProductsLista
            // 
            this.btnGuardarProductsLista.Location = new System.Drawing.Point(59, 24);
            this.btnGuardarProductsLista.Name = "btnGuardarProductsLista";
            this.btnGuardarProductsLista.Size = new System.Drawing.Size(162, 109);
            this.btnGuardarProductsLista.TabIndex = 0;
            this.btnGuardarProductsLista.Text = "Guardar productos en una lista";
            this.btnGuardarProductsLista.UseVisualStyleBackColor = true;
            this.btnGuardarProductsLista.Click += new System.EventHandler(this.btnGuardarProductsLista_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(281, 24);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(162, 109);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar lista";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(59, 170);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RowHeadersWidth = 51;
            this.gridProductos.RowTemplate.Height = 24;
            this.gridProductos.Size = new System.Drawing.Size(412, 234);
            this.gridProductos.TabIndex = 2;
            // 
            // lstPrecioProducto
            // 
            this.lstPrecioProducto.FormattingEnabled = true;
            this.lstPrecioProducto.ItemHeight = 16;
            this.lstPrecioProducto.Location = new System.Drawing.Point(513, 170);
            this.lstPrecioProducto.Name = "lstPrecioProducto";
            this.lstPrecioProducto.Size = new System.Drawing.Size(237, 228);
            this.lstPrecioProducto.TabIndex = 3;
            // 
            // btnCrearClientes
            // 
            this.btnCrearClientes.Location = new System.Drawing.Point(522, 24);
            this.btnCrearClientes.Name = "btnCrearClientes";
            this.btnCrearClientes.Size = new System.Drawing.Size(212, 109);
            this.btnCrearClientes.TabIndex = 4;
            this.btnCrearClientes.Text = "Crear Clientes";
            this.btnCrearClientes.UseVisualStyleBackColor = true;
            this.btnCrearClientes.Click += new System.EventHandler(this.btnCrearClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearClientes);
            this.Controls.Add(this.lstPrecioProducto);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardarProductsLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarProductsLista;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.ListBox lstPrecioProducto;
        private System.Windows.Forms.Button btnCrearClientes;
    }
}

