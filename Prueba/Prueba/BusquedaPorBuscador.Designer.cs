namespace Prueba
{
    partial class BusquedaPorBuscador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palabra_clave = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.busq_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // palabra_clave
            // 
            this.palabra_clave.AutoSize = true;
            this.palabra_clave.Location = new System.Drawing.Point(12, 32);
            this.palabra_clave.Name = "palabra_clave";
            this.palabra_clave.Size = new System.Drawing.Size(93, 13);
            this.palabra_clave.TabIndex = 1;
            this.palabra_clave.Text = "PALABRA CLAVE";
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(407, 55);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(102, 23);
            this.BUSCAR.TabIndex = 2;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseCompatibleTextRendering = true;
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // busq_text
            // 
            this.busq_text.Location = new System.Drawing.Point(0, 58);
            this.busq_text.Name = "busq_text";
            this.busq_text.Size = new System.Drawing.Size(393, 20);
            this.busq_text.TabIndex = 3;
            // 
            // BusquedaPorBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 416);
            this.Controls.Add(this.busq_text);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.palabra_clave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BusquedaPorBuscador";
            this.Text = "BusquedaPorBuscador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label palabra_clave;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.TextBox busq_text;
    }
}