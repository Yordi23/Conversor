namespace ConversorDecimal
{
    partial class formMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenAscii = new System.Windows.Forms.Button();
            this.btnOpenSistemas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenAscii
            // 
            this.btnOpenAscii.Location = new System.Drawing.Point(17, 52);
            this.btnOpenAscii.Name = "btnOpenAscii";
            this.btnOpenAscii.Size = new System.Drawing.Size(168, 28);
            this.btnOpenAscii.TabIndex = 0;
            this.btnOpenAscii.Text = "CONVERTIDOR ASCII";
            this.btnOpenAscii.UseVisualStyleBackColor = true;
            this.btnOpenAscii.Click += new System.EventHandler(this.btnOpenAscii_Click);
            // 
            // btnOpenSistemas
            // 
            this.btnOpenSistemas.Location = new System.Drawing.Point(17, 103);
            this.btnOpenSistemas.Name = "btnOpenSistemas";
            this.btnOpenSistemas.Size = new System.Drawing.Size(168, 35);
            this.btnOpenSistemas.TabIndex = 1;
            this.btnOpenSistemas.Text = "CONVERTIDOR \r\nSISTEMAS NUMÉRICOS";
            this.btnOpenSistemas.UseVisualStyleBackColor = true;
            this.btnOpenSistemas.Click += new System.EventHandler(this.btnOpenSistemas_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 163);
            this.Controls.Add(this.btnOpenSistemas);
            this.Controls.Add(this.btnOpenAscii);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenAscii;
        private System.Windows.Forms.Button btnOpenSistemas;
    }
}

