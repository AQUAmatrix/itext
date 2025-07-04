namespace SignPDF_Proc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt64Encode = new System.Windows.Forms.RichTextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtCertifURI = new System.Windows.Forms.TextBox();
            this.txtAuthSecret = new System.Windows.Forms.TextBox();
            this.txtAuthId = new System.Windows.Forms.TextBox();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtHashAlg = new System.Windows.Forms.TextBox();
            this.txtCertFriendlyName = new System.Windows.Forms.TextBox();
            this.txtCertAlias = new System.Windows.Forms.TextBox();
            this.txtCertificatePath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDst);
            this.groupBox1.Controls.Add(this.txtSrc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder";
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(93, 36);
            this.txtDst.Name = "txtDst";
            this.txtDst.Size = new System.Drawing.Size(422, 20);
            this.txtDst.TabIndex = 3;
            this.txtDst.Text = "C:\\_Test\\DigitalSign\\Sign\\";
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(93, 13);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(422, 20);
            this.txtSrc.TabIndex = 2;
            this.txtSrc.Text = "C:\\_Test\\DigitalSign\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt64Encode);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.txtCertifURI);
            this.groupBox2.Controls.Add(this.txtAuthSecret);
            this.groupBox2.Controls.Add(this.txtAuthId);
            this.groupBox2.Controls.Add(this.txtAccessToken);
            this.groupBox2.Controls.Add(this.txtHashAlg);
            this.groupBox2.Controls.Add(this.txtCertFriendlyName);
            this.groupBox2.Controls.Add(this.txtCertAlias);
            this.groupBox2.Controls.Add(this.txtCertificatePath);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 442);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signing Config";
            // 
            // txt64Encode
            // 
            this.txt64Encode.Location = new System.Drawing.Point(19, 274);
            this.txt64Encode.Name = "txt64Encode";
            this.txt64Encode.Size = new System.Drawing.Size(496, 162);
            this.txt64Encode.TabIndex = 22;
            this.txt64Encode.Text = "";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(106, 231);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(409, 20);
            this.txtLocation.TabIndex = 21;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(106, 207);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(409, 20);
            this.txtReason.TabIndex = 20;
            // 
            // txtCertifURI
            // 
            this.txtCertifURI.Location = new System.Drawing.Point(106, 183);
            this.txtCertifURI.Name = "txtCertifURI";
            this.txtCertifURI.Size = new System.Drawing.Size(409, 20);
            this.txtCertifURI.TabIndex = 19;
            // 
            // txtAuthSecret
            // 
            this.txtAuthSecret.Location = new System.Drawing.Point(106, 159);
            this.txtAuthSecret.Name = "txtAuthSecret";
            this.txtAuthSecret.Size = new System.Drawing.Size(409, 20);
            this.txtAuthSecret.TabIndex = 18;
            // 
            // txtAuthId
            // 
            this.txtAuthId.Location = new System.Drawing.Point(106, 135);
            this.txtAuthId.Name = "txtAuthId";
            this.txtAuthId.Size = new System.Drawing.Size(409, 20);
            this.txtAuthId.TabIndex = 17;
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(106, 111);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(409, 20);
            this.txtAccessToken.TabIndex = 16;
            // 
            // txtHashAlg
            // 
            this.txtHashAlg.Location = new System.Drawing.Point(106, 87);
            this.txtHashAlg.Name = "txtHashAlg";
            this.txtHashAlg.Size = new System.Drawing.Size(409, 20);
            this.txtHashAlg.TabIndex = 15;
            // 
            // txtCertFriendlyName
            // 
            this.txtCertFriendlyName.Location = new System.Drawing.Point(106, 63);
            this.txtCertFriendlyName.Name = "txtCertFriendlyName";
            this.txtCertFriendlyName.Size = new System.Drawing.Size(409, 20);
            this.txtCertFriendlyName.TabIndex = 14;
            // 
            // txtCertAlias
            // 
            this.txtCertAlias.Location = new System.Drawing.Point(106, 39);
            this.txtCertAlias.Name = "txtCertAlias";
            this.txtCertAlias.Size = new System.Drawing.Size(409, 20);
            this.txtCertAlias.TabIndex = 13;
            // 
            // txtCertificatePath
            // 
            this.txtCertificatePath.Location = new System.Drawing.Point(106, 15);
            this.txtCertificatePath.Name = "txtCertificatePath";
            this.txtCertificatePath.Size = new System.Drawing.Size(409, 20);
            this.txtCertificatePath.TabIndex = 4;
            this.txtCertificatePath.Text = "C:\\_Test\\DigitalSign\\";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Location:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Reason:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Certificate URI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Authorizor Secret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Authorizor Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Access Token:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "64Endode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Friendly Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cerificate Alias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hash Algorithm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Certificate Path:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(542, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(487, 543);
            this.txtLog.TabIndex = 23;
            this.txtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 567);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Signing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtCertifURI;
        private System.Windows.Forms.TextBox txtAuthSecret;
        private System.Windows.Forms.TextBox txtAuthId;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtHashAlg;
        private System.Windows.Forms.TextBox txtCertFriendlyName;
        private System.Windows.Forms.TextBox txtCertAlias;
        private System.Windows.Forms.TextBox txtCertificatePath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt64Encode;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}