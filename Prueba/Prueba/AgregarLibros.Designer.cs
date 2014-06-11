namespace Prueba
{
    partial class AgregarLibros
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Agregar = new System.Windows.Forms.Button();
            this.ISBN_text = new System.Windows.Forms.TextBox();
            this.NA_text = new System.Windows.Forms.TextBox();
            this.NL_text = new System.Windows.Forms.TextBox();
            this.Stock_text = new System.Windows.Forms.TextBox();
            this.UV_text = new System.Windows.Forms.TextBox();
            this.isbn_label = new System.Windows.Forms.Label();
            this.NA_label = new System.Windows.Forms.Label();
            this.NL_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.UV_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(288, 45);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // ISBN_text
            // 
            this.ISBN_text.Location = new System.Drawing.Point(16, 45);
            this.ISBN_text.Name = "ISBN_text";
            this.ISBN_text.Size = new System.Drawing.Size(245, 20);
            this.ISBN_text.TabIndex = 1;
            // 
            // NA_text
            // 
            this.NA_text.Location = new System.Drawing.Point(16, 100);
            this.NA_text.Name = "NA_text";
            this.NA_text.Size = new System.Drawing.Size(245, 20);
            this.NA_text.TabIndex = 2;
            // 
            // NL_text
            // 
            this.NL_text.Location = new System.Drawing.Point(16, 163);
            this.NL_text.Name = "NL_text";
            this.NL_text.Size = new System.Drawing.Size(245, 20);
            this.NL_text.TabIndex = 3;
            // 
            // Stock_text
            // 
            this.Stock_text.Location = new System.Drawing.Point(16, 219);
            this.Stock_text.Name = "Stock_text";
            this.Stock_text.Size = new System.Drawing.Size(245, 20);
            this.Stock_text.TabIndex = 4;
            // 
            // UV_text
            // 
            this.UV_text.Location = new System.Drawing.Point(16, 267);
            this.UV_text.Name = "UV_text";
            this.UV_text.Size = new System.Drawing.Size(245, 20);
            this.UV_text.TabIndex = 5;
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(13, 29);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 6;
            this.isbn_label.Text = "ISBN";
            // 
            // NA_label
            // 
            this.NA_label.AutoSize = true;
            this.NA_label.Location = new System.Drawing.Point(13, 84);
            this.NA_label.Name = "NA_label";
            this.NA_label.Size = new System.Drawing.Size(72, 13);
            this.NA_label.TabIndex = 7;
            this.NA_label.Text = "Nombre Autor";
            // 
            // NL_label
            // 
            this.NL_label.AutoSize = true;
            this.NL_label.Location = new System.Drawing.Point(15, 147);
            this.NL_label.Name = "NL_label";
            this.NL_label.Size = new System.Drawing.Size(70, 13);
            this.NL_label.TabIndex = 8;
            this.NL_label.Text = "Nombre Libro";
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Location = new System.Drawing.Point(15, 203);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(35, 13);
            this.stock_label.TabIndex = 9;
            this.stock_label.Text = "Stock";
            // 
            // UV_label
            // 
            this.UV_label.AutoSize = true;
            this.UV_label.Location = new System.Drawing.Point(15, 251);
            this.UV_label.Name = "UV_label";
            this.UV_label.Size = new System.Drawing.Size(99, 13);
            this.UV_label.TabIndex = 10;
            this.UV_label.Text = "Unidades Vendidas";
            // 
            // AgregarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 314);
            this.Controls.Add(this.UV_label);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.NL_label);
            this.Controls.Add(this.NA_label);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.UV_text);
            this.Controls.Add(this.Stock_text);
            this.Controls.Add(this.NL_text);
            this.Controls.Add(this.NA_text);
            this.Controls.Add(this.ISBN_text);
            this.Controls.Add(this.Agregar);
            this.Name = "AgregarLibros";
            this.Text = "Agregar Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox ISBN_text;
        private System.Windows.Forms.TextBox NA_text;
        private System.Windows.Forms.TextBox NL_text;
        private System.Windows.Forms.TextBox Stock_text;
        private System.Windows.Forms.TextBox UV_text;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label NA_label;
        private System.Windows.Forms.Label NL_label;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.Label UV_label;
    }
}

