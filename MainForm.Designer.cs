namespace RequestSigner
{
    partial class MainForm
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
            this.RequestTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignatureTextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CertificatTextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestTextbox
            // 
            this.RequestTextbox.Location = new System.Drawing.Point(12, 62);
            this.RequestTextbox.Name = "RequestTextbox";
            this.RequestTextbox.Size = new System.Drawing.Size(315, 138);
            this.RequestTextbox.TabIndex = 0;
            this.RequestTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request (json formatted)";
            // 
            // SignatureTextbox
            // 
            this.SignatureTextbox.Location = new System.Drawing.Point(12, 318);
            this.SignatureTextbox.Name = "SignatureTextbox";
            this.SignatureTextbox.ReadOnly = true;
            this.SignatureTextbox.Size = new System.Drawing.Size(314, 120);
            this.SignatureTextbox.TabIndex = 2;
            this.SignatureTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detached JWS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Signature";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateSignature);
            // 
            // CertificatTextbox
            // 
            this.CertificatTextbox.Location = new System.Drawing.Point(466, 62);
            this.CertificatTextbox.Name = "CertificatTextbox";
            this.CertificatTextbox.ReadOnly = true;
            this.CertificatTextbox.Size = new System.Drawing.Size(291, 138);
            this.CertificatTextbox.TabIndex = 4;
            this.CertificatTextbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TPP-Signature-Certificate Header";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select Certificate File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Certificate2Base64);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CertificatTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignatureTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestTextbox);
            this.Name = "MainForm";
            this.Text = "RequestSigner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RequestTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SignatureTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox CertificatTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

