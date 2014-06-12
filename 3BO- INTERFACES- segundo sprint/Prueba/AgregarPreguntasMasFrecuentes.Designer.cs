namespace Prueba
{
    partial class AgregarPreguntasMasFrecuentes
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
            this.AgregarPreguntaYRespuesta = new System.Windows.Forms.Button();
            this.preg_text = new System.Windows.Forms.TextBox();
            this.resp_text = new System.Windows.Forms.TextBox();
            this.Pregunta = new System.Windows.Forms.Label();
            this.Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgregarPreguntaYRespuesta
            // 
            this.AgregarPreguntaYRespuesta.Location = new System.Drawing.Point(101, 254);
            this.AgregarPreguntaYRespuesta.Name = "AgregarPreguntaYRespuesta";
            this.AgregarPreguntaYRespuesta.Size = new System.Drawing.Size(189, 23);
            this.AgregarPreguntaYRespuesta.TabIndex = 0;
            this.AgregarPreguntaYRespuesta.Text = "AgregarPreguntaYRespuesta";
            this.AgregarPreguntaYRespuesta.UseVisualStyleBackColor = true;
            this.AgregarPreguntaYRespuesta.Click += new System.EventHandler(this.AgregarPreguntaYRespuesta_Click);
            // 
            // preg_text
            // 
            this.preg_text.Location = new System.Drawing.Point(46, 112);
            this.preg_text.Name = "preg_text";
            this.preg_text.Size = new System.Drawing.Size(303, 20);
            this.preg_text.TabIndex = 1;
            // 
            // resp_text
            // 
            this.resp_text.Location = new System.Drawing.Point(46, 197);
            this.resp_text.Name = "resp_text";
            this.resp_text.Size = new System.Drawing.Size(303, 20);
            this.resp_text.TabIndex = 2;
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSize = true;
            this.Pregunta.Location = new System.Drawing.Point(43, 74);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(50, 13);
            this.Pregunta.TabIndex = 3;
            this.Pregunta.Text = "Pregunta";
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Location = new System.Drawing.Point(43, 171);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(58, 13);
            this.Respuesta.TabIndex = 4;
            this.Respuesta.Text = "Respuesta";
            // 
            // AgregarPreguntasMasFrecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 330);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.resp_text);
            this.Controls.Add(this.preg_text);
            this.Controls.Add(this.AgregarPreguntaYRespuesta);
            this.Name = "AgregarPreguntasMasFrecuentes";
            this.Text = "AgregarPreguntasMasFrecuentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarPreguntaYRespuesta;
        private System.Windows.Forms.TextBox preg_text;
        private System.Windows.Forms.TextBox resp_text;
        private System.Windows.Forms.Label Pregunta;
        private System.Windows.Forms.Label Respuesta;
    }
}