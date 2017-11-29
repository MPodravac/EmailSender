namespace WindowsFormsMail
{
    partial class Form1
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
            this.lblPrimatelj = new System.Windows.Forms.Label();
            this.lblNaslovPoruke = new System.Windows.Forms.Label();
            this.lblTijeloPoruke = new System.Windows.Forms.Label();
            this.inptMailTo = new System.Windows.Forms.TextBox();
            this.inptMailTitle = new System.Windows.Forms.TextBox();
            this.inptMailBody = new System.Windows.Forms.TextBox();
            this.btnMailSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimatelj
            // 
            this.lblPrimatelj.AutoSize = true;
            this.lblPrimatelj.Location = new System.Drawing.Point(26, 44);
            this.lblPrimatelj.Name = "lblPrimatelj";
            this.lblPrimatelj.Size = new System.Drawing.Size(46, 13);
            this.lblPrimatelj.TabIndex = 0;
            this.lblPrimatelj.Text = "Primatelj";
            // 
            // lblNaslovPoruke
            // 
            this.lblNaslovPoruke.AutoSize = true;
            this.lblNaslovPoruke.Location = new System.Drawing.Point(26, 86);
            this.lblNaslovPoruke.Name = "lblNaslovPoruke";
            this.lblNaslovPoruke.Size = new System.Drawing.Size(76, 13);
            this.lblNaslovPoruke.TabIndex = 1;
            this.lblNaslovPoruke.Text = "Naslov poruke";
            // 
            // lblTijeloPoruke
            // 
            this.lblTijeloPoruke.AutoSize = true;
            this.lblTijeloPoruke.Location = new System.Drawing.Point(26, 126);
            this.lblTijeloPoruke.Name = "lblTijeloPoruke";
            this.lblTijeloPoruke.Size = new System.Drawing.Size(68, 13);
            this.lblTijeloPoruke.TabIndex = 2;
            this.lblTijeloPoruke.Text = "Tijelo poruke";
            // 
            // inptMailTo
            // 
            this.inptMailTo.Location = new System.Drawing.Point(164, 37);
            this.inptMailTo.Name = "inptMailTo";
            this.inptMailTo.Size = new System.Drawing.Size(351, 20);
            this.inptMailTo.TabIndex = 3;
            this.inptMailTo.TextChanged += new System.EventHandler(this.inptMailTo_TextChanged);
            // 
            // inptMailTitle
            // 
            this.inptMailTitle.Location = new System.Drawing.Point(164, 79);
            this.inptMailTitle.Name = "inptMailTitle";
            this.inptMailTitle.Size = new System.Drawing.Size(351, 20);
            this.inptMailTitle.TabIndex = 4;
            this.inptMailTitle.TextChanged += new System.EventHandler(this.inptMailTitle_TextChanged);
            // 
            // inptMailBody
            // 
            this.inptMailBody.Location = new System.Drawing.Point(164, 119);
            this.inptMailBody.Name = "inptMailBody";
            this.inptMailBody.Size = new System.Drawing.Size(351, 20);
            this.inptMailBody.TabIndex = 5;
            this.inptMailBody.TextChanged += new System.EventHandler(this.inptMailBody_TextChanged);
            // 
            // btnMailSend
            // 
            this.btnMailSend.Location = new System.Drawing.Point(29, 166);
            this.btnMailSend.Name = "btnMailSend";
            this.btnMailSend.Size = new System.Drawing.Size(75, 23);
            this.btnMailSend.TabIndex = 6;
            this.btnMailSend.Text = "Pošalji";
            this.btnMailSend.UseVisualStyleBackColor = true;
            this.btnMailSend.Click += new System.EventHandler(this.btnMailSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 305);
            this.Controls.Add(this.btnMailSend);
            this.Controls.Add(this.inptMailBody);
            this.Controls.Add(this.inptMailTitle);
            this.Controls.Add(this.inptMailTo);
            this.Controls.Add(this.lblTijeloPoruke);
            this.Controls.Add(this.lblNaslovPoruke);
            this.Controls.Add(this.lblPrimatelj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimatelj;
        private System.Windows.Forms.Label lblNaslovPoruke;
        private System.Windows.Forms.Label lblTijeloPoruke;
        private System.Windows.Forms.TextBox inptMailTo;
        private System.Windows.Forms.TextBox inptMailTitle;
        private System.Windows.Forms.TextBox inptMailBody;
        private System.Windows.Forms.Button btnMailSend;
    }
}

