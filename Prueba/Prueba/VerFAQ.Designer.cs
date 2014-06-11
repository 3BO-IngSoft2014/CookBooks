namespace Prueba
{
    partial class VerFAQ
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
            this.Elegir = new System.Windows.Forms.Button();
            this.pregBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elegir
            // 
            this.Elegir.Location = new System.Drawing.Point(367, 31);
            this.Elegir.Name = "Elegir";
            this.Elegir.Size = new System.Drawing.Size(75, 23);
            this.Elegir.TabIndex = 0;
            this.Elegir.Text = "Elegir";
            this.Elegir.UseVisualStyleBackColor = true;
            this.Elegir.Click += new System.EventHandler(this.Elegir_Click);
            // 
            // pregBox
            // 
            this.pregBox.FormattingEnabled = true;
            this.pregBox.Location = new System.Drawing.Point(23, 31);
            this.pregBox.Name = "pregBox";
            this.pregBox.Size = new System.Drawing.Size(338, 21);
            this.pregBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 243);
            this.dataGridView1.TabIndex = 2;
            // 
            // VerFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pregBox);
            this.Controls.Add(this.Elegir);
            this.Name = "VerFAQ";
            this.Text = "VerFAQ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Elegir;
        private System.Windows.Forms.ComboBox pregBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}