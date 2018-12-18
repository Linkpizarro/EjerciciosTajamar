namespace PostVideo
{
    partial class Cifrado
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
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textEncrypt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.publicKeyE = new System.Windows.Forms.TextBox();
            this.privateKeyE = new System.Windows.Forms.TextBox();
            this.publicKeyD = new System.Windows.Forms.TextBox();
            this.privateKeyD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.privateKeyE);
            this.panel1.Controls.Add(this.publicKeyE);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.encrypt);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 683);
            this.panel1.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(24, 52);
            this.text.Margin = new System.Windows.Forms.Padding(6);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(544, 274);
            this.text.TabIndex = 13;
            this.text.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Texto";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(228, 623);
            this.encrypt.Margin = new System.Windows.Forms.Padding(6);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(96, 42);
            this.encrypt.TabIndex = 12;
            this.encrypt.Text = "Cifrar";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(248, 544);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 42);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar archivo...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 553);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Guardar en :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.privateKeyD);
            this.panel2.Controls.Add(this.publicKeyD);
            this.panel2.Controls.Add(this.textEncrypt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.decrypt);
            this.panel2.Controls.Add(this.btnRead);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(630, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 683);
            this.panel2.TabIndex = 1;
            // 
            // textEncrypt
            // 
            this.textEncrypt.Location = new System.Drawing.Point(32, 391);
            this.textEncrypt.Margin = new System.Windows.Forms.Padding(6);
            this.textEncrypt.Name = "textEncrypt";
            this.textEncrypt.Size = new System.Drawing.Size(544, 274);
            this.textEncrypt.TabIndex = 13;
            this.textEncrypt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Texto";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(229, 284);
            this.decrypt.Margin = new System.Windows.Forms.Padding(6);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(121, 42);
            this.decrypt.TabIndex = 12;
            this.decrypt.Text = "Descifrar";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(229, 218);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(212, 42);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Buscar archivo...";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Leer :";
            // 
            // publicKeyE
            // 
            this.publicKeyE.Location = new System.Drawing.Point(216, 391);
            this.publicKeyE.Name = "publicKeyE";
            this.publicKeyE.Size = new System.Drawing.Size(150, 29);
            this.publicKeyE.TabIndex = 15;
            // 
            // privateKeyE
            // 
            this.privateKeyE.Location = new System.Drawing.Point(216, 478);
            this.privateKeyE.Name = "privateKeyE";
            this.privateKeyE.Size = new System.Drawing.Size(150, 29);
            this.privateKeyE.TabIndex = 16;
            // 
            // publicKeyD
            // 
            this.publicKeyD.Location = new System.Drawing.Point(209, 50);
            this.publicKeyD.Name = "publicKeyD";
            this.publicKeyD.Size = new System.Drawing.Size(165, 29);
            this.publicKeyD.TabIndex = 15;
            // 
            // privateKeyD
            // 
            this.privateKeyD.Location = new System.Drawing.Point(209, 150);
            this.privateKeyD.Name = "privateKeyD";
            this.privateKeyD.Size = new System.Drawing.Size(165, 29);
            this.privateKeyD.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Clave Pública";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Clave Privada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Clave Pública";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Clave Privada";
            // 
            // Cifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Cifrado";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox privateKeyE;
        private System.Windows.Forms.TextBox publicKeyE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox privateKeyD;
        private System.Windows.Forms.TextBox publicKeyD;
    }
}

