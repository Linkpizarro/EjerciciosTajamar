namespace WindowsFormsApp1
{
    partial class ClaseString
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
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.validate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.btnIsbn = new System.Windows.Forms.Button();
            this.resIsbn = new System.Windows.Forms.TextBox();
            this.resNarcisista = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNarcisista = new System.Windows.Forms.Button();
            this.invertir = new System.Windows.Forms.Button();
            this.resCadena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.invertirBuilder = new System.Windows.Forms.Button();
            this.cadena = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(94, 105);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(233, 30);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(118, 169);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(97, 37);
            this.validate.TabIndex = 2;
            this.validate.Text = "Validar";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 66);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "String";
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(25, 228);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Size = new System.Drawing.Size(292, 41);
            this.res.TabIndex = 4;
            this.res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.res.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN:";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(84, 327);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(233, 30);
            this.isbn.TabIndex = 6;
            this.isbn.TextChanged += new System.EventHandler(this.isbn_TextChanged);
            // 
            // btnIsbn
            // 
            this.btnIsbn.Location = new System.Drawing.Point(118, 390);
            this.btnIsbn.Name = "btnIsbn";
            this.btnIsbn.Size = new System.Drawing.Size(97, 37);
            this.btnIsbn.TabIndex = 7;
            this.btnIsbn.Text = "Validar";
            this.btnIsbn.UseVisualStyleBackColor = true;
            this.btnIsbn.Click += new System.EventHandler(this.btnIsbn_Click);
            // 
            // resIsbn
            // 
            this.resIsbn.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resIsbn.Location = new System.Drawing.Point(25, 461);
            this.resIsbn.Multiline = true;
            this.resIsbn.Name = "resIsbn";
            this.resIsbn.ReadOnly = true;
            this.resIsbn.Size = new System.Drawing.Size(292, 41);
            this.resIsbn.TabIndex = 8;
            this.resIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resIsbn.TextChanged += new System.EventHandler(this.resIsbn_TextChanged);
            // 
            // resNarcisista
            // 
            this.resNarcisista.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resNarcisista.Location = new System.Drawing.Point(456, 228);
            this.resNarcisista.Multiline = true;
            this.resNarcisista.Name = "resNarcisista";
            this.resNarcisista.ReadOnly = true;
            this.resNarcisista.Size = new System.Drawing.Size(292, 41);
            this.resNarcisista.TabIndex = 12;
            this.resNarcisista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resNarcisista.TextChanged += new System.EventHandler(this.resNarcisista_TextChanged);
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(515, 101);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(233, 30);
            this.numero.TabIndex = 10;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número:";
            // 
            // btnNarcisista
            // 
            this.btnNarcisista.Location = new System.Drawing.Point(561, 169);
            this.btnNarcisista.Name = "btnNarcisista";
            this.btnNarcisista.Size = new System.Drawing.Size(97, 37);
            this.btnNarcisista.TabIndex = 13;
            this.btnNarcisista.Text = "Validar";
            this.btnNarcisista.UseVisualStyleBackColor = true;
            this.btnNarcisista.Click += new System.EventHandler(this.btnNarcisista_Click);
            // 
            // invertir
            // 
            this.invertir.Location = new System.Drawing.Point(480, 390);
            this.invertir.Name = "invertir";
            this.invertir.Size = new System.Drawing.Size(97, 37);
            this.invertir.TabIndex = 17;
            this.invertir.Text = "Invertir";
            this.invertir.UseVisualStyleBackColor = true;
            this.invertir.Click += new System.EventHandler(this.invertir_Click);
            // 
            // resCadena
            // 
            this.resCadena.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resCadena.Location = new System.Drawing.Point(426, 461);
            this.resCadena.Multiline = true;
            this.resCadena.Name = "resCadena";
            this.resCadena.ReadOnly = true;
            this.resCadena.Size = new System.Drawing.Size(322, 41);
            this.resCadena.TabIndex = 16;
            this.resCadena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resCadena.TextChanged += new System.EventHandler(this.resCadena_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cadena";
            // 
            // invertirBuilder
            // 
            this.invertirBuilder.Location = new System.Drawing.Point(620, 373);
            this.invertirBuilder.Name = "invertirBuilder";
            this.invertirBuilder.Size = new System.Drawing.Size(128, 70);
            this.invertirBuilder.TabIndex = 18;
            this.invertirBuilder.Text = "Invertir Con Builder";
            this.invertirBuilder.UseVisualStyleBackColor = true;
            this.invertirBuilder.Click += new System.EventHandler(this.invertirBuilder_Click);
            // 
            // cadena
            // 
            this.cadena.Location = new System.Drawing.Point(515, 327);
            this.cadena.Name = "cadena";
            this.cadena.Size = new System.Drawing.Size(233, 30);
            this.cadena.TabIndex = 19;
            this.cadena.Text = "";
            this.cadena.TextChanged += new System.EventHandler(this.cadena_TextChanged_1);
            // 
            // ClaseString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 531);
            this.Controls.Add(this.cadena);
            this.Controls.Add(this.invertirBuilder);
            this.Controls.Add(this.invertir);
            this.Controls.Add(this.resCadena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNarcisista);
            this.Controls.Add(this.resNarcisista);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resIsbn);
            this.Controls.Add(this.btnIsbn);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.res);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ClaseString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ClaseString_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Button btnIsbn;
        private System.Windows.Forms.TextBox resIsbn;
        private System.Windows.Forms.TextBox resNarcisista;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNarcisista;
        private System.Windows.Forms.Button invertir;
        private System.Windows.Forms.TextBox resCadena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button invertirBuilder;
        private System.Windows.Forms.RichTextBox cadena;
    }
}