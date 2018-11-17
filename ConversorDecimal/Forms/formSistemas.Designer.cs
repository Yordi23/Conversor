namespace ConversorDecimal.Forms
{
    partial class formSistemas
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
            this.cbmBoxFrom = new System.Windows.Forms.ComboBox();
            this.cbmBoxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmBoxFrom
            // 
            this.cbmBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBoxFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbmBoxFrom.FormattingEnabled = true;
            this.cbmBoxFrom.Items.AddRange(new object[] {
            "Binario",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.cbmBoxFrom.Location = new System.Drawing.Point(43, 12);
            this.cbmBoxFrom.Name = "cbmBoxFrom";
            this.cbmBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.cbmBoxFrom.TabIndex = 0;
            // 
            // cbmBoxTo
            // 
            this.cbmBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBoxTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbmBoxTo.FormattingEnabled = true;
            this.cbmBoxTo.Items.AddRange(new object[] {
            "Binario",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.cbmBoxTo.Location = new System.Drawing.Point(244, 12);
            this.cbmBoxTo.Name = "cbmBoxTo";
            this.cbmBoxTo.Size = new System.Drawing.Size(121, 21);
            this.cbmBoxTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(199, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "A:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(43, 56);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(121, 58);
            this.txtCode.TabIndex = 2;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(244, 56);
            this.txtConvert.Multiline = true;
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.ReadOnly = true;
            this.txtConvert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConvert.Size = new System.Drawing.Size(121, 58);
            this.txtConvert.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(63, 120);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // formSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 144);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmBoxTo);
            this.Controls.Add(this.cbmBoxFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formSistemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSistemas";
            this.Load += new System.EventHandler(this.formSistemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmBoxFrom;
        private System.Windows.Forms.ComboBox cbmBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.Button btnConvert;
    }
}