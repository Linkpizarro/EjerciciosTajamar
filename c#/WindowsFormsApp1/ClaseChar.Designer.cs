namespace WindowsFormsApp1
{
    partial class ClaseChar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.punt = new System.Windows.Forms.TextBox();
            this.let = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.simb = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Símbolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Números";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puntuación";
            // 
            // punt
            // 
            this.punt.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punt.Location = new System.Drawing.Point(33, 269);
            this.punt.Multiline = true;
            this.punt.Name = "punt";
            this.punt.ReadOnly = true;
            this.punt.Size = new System.Drawing.Size(204, 81);
            this.punt.TabIndex = 4;
            this.punt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.punt.TextChanged += new System.EventHandler(this.punt_TextChanged);
            // 
            // let
            // 
            this.let.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.let.Location = new System.Drawing.Point(33, 139);
            this.let.Multiline = true;
            this.let.Name = "let";
            this.let.ReadOnly = true;
            this.let.Size = new System.Drawing.Size(204, 81);
            this.let.TabIndex = 5;
            this.let.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.let.TextChanged += new System.EventHandler(this.let_TextChanged);
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(296, 139);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Size = new System.Drawing.Size(189, 81);
            this.num.TabIndex = 6;
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // simb
            // 
            this.simb.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simb.Location = new System.Drawing.Point(296, 269);
            this.simb.Multiline = true;
            this.simb.Name = "simb";
            this.simb.ReadOnly = true;
            this.simb.Size = new System.Drawing.Size(189, 81);
            this.simb.TabIndex = 7;
            this.simb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.simb.TextChanged += new System.EventHandler(this.simb_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(212, 380);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 38);
            this.start.TabIndex = 8;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 73);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 56);
            this.label5.TabIndex = 0;
            this.label5.Text = "Char";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Khaki;
            this.panel9.Location = new System.Drawing.Point(31, 406);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 12);
            this.panel9.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Khaki;
            this.panel8.Location = new System.Drawing.Point(32, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 12);
            this.panel8.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Khaki;
            this.panel7.Location = new System.Drawing.Point(13, 388);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 12);
            this.panel7.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Location = new System.Drawing.Point(477, 406);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 12);
            this.panel6.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Location = new System.Drawing.Point(477, 388);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 12);
            this.panel5.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Location = new System.Drawing.Point(496, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 12);
            this.panel4.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(0, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 25);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(496, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 24;
            // 
            // ClaseChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.simb);
            this.Controls.Add(this.num);
            this.Controls.Add(this.let);
            this.Controls.Add(this.punt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ClaseChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaseChar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox punt;
        private System.Windows.Forms.TextBox let;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox simb;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}