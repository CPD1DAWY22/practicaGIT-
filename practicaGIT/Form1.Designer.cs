namespace practicaGIT
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ordinarioRadio = new System.Windows.Forms.RadioButton();
            this.UrgenteBoton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(163, 133);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(478, 126);
            this.txtTelegrama.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coste:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordinarioRadio
            // 
            this.ordinarioRadio.AutoSize = true;
            this.ordinarioRadio.Checked = true;
            this.ordinarioRadio.Location = new System.Drawing.Point(163, 287);
            this.ordinarioRadio.Name = "ordinarioRadio";
            this.ordinarioRadio.Size = new System.Drawing.Size(67, 17);
            this.ordinarioRadio.TabIndex = 10;
            this.ordinarioRadio.TabStop = true;
            this.ordinarioRadio.Text = "Ordinario";
            this.ordinarioRadio.UseVisualStyleBackColor = true;
            // 
            // UrgenteBoton
            // 
            this.UrgenteBoton.AutoSize = true;
            this.UrgenteBoton.Location = new System.Drawing.Point(266, 287);
            this.UrgenteBoton.Name = "UrgenteBoton";
            this.UrgenteBoton.Size = new System.Drawing.Size(63, 17);
            this.UrgenteBoton.TabIndex = 10;
            this.UrgenteBoton.TabStop = true;
            this.UrgenteBoton.Text = "Urgente";
            this.UrgenteBoton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UrgenteBoton);
            this.Controls.Add(this.ordinarioRadio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ordinarioRadio;
        private System.Windows.Forms.RadioButton UrgenteBoton;
    }
}

