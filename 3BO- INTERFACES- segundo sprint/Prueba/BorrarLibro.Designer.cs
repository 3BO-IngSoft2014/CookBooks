namespace Prueba
{
    partial class BorrarLibro
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
            this.Activar_Borrado = new System.Windows.Forms.Button();
            this.bl_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Activar_Borrado
            // 
            this.Activar_Borrado.Location = new System.Drawing.Point(212, 115);
            this.Activar_Borrado.Name = "Activar_Borrado";
            this.Activar_Borrado.Size = new System.Drawing.Size(75, 23);
            this.Activar_Borrado.TabIndex = 0;
            this.Activar_Borrado.Text = "Borrar";
            this.Activar_Borrado.UseVisualStyleBackColor = true;
            this.Activar_Borrado.Click += new System.EventHandler(this.Activar_Borrado_Click);
            // 
            // bl_text
            // 
            this.bl_text.Location = new System.Drawing.Point(12, 117);
            this.bl_text.Name = "bl_text";
            this.bl_text.Size = new System.Drawing.Size(194, 20);
            this.bl_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE ISBN";
            // 
            // BorrarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bl_text);
            this.Controls.Add(this.Activar_Borrado);
            this.Name = "BorrarLibro";
            this.Text = "BorrarLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Activar_Borrado;
        private System.Windows.Forms.TextBox bl_text;
        private System.Windows.Forms.Label label1;
    }
}