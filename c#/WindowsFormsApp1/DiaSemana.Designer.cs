namespace WindowsFormsApp1
{
    partial class DiaSemana
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
            this.day = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.BackColor = System.Drawing.Color.Khaki;
            this.day.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(101, 218);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 30);
            this.day.TabIndex = 0;
            this.day.TextChanged += new System.EventHandler(this.day_TextChanged);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.Khaki;
            this.year.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(395, 218);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 30);
            this.year.TabIndex = 1;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // month
            // 
            this.month.BackColor = System.Drawing.Color.Khaki;
            this.month.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(244, 220);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 30);
            this.month.TabIndex = 2;
            this.month.TextChanged += new System.EventHandler(this.month_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.Khaki;
            this.calc.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(244, 274);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(100, 48);
            this.calc.TabIndex = 5;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.Khaki;
            this.consoleBox.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleBox.Location = new System.Drawing.Point(141, 100);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(303, 55);
            this.consoleBox.TabIndex = 6;
            this.consoleBox.Text = "El día de su nacimiento fue : ";
            this.consoleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.consoleBox.TextChanged += new System.EventHandler(this.consoleBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Día de Nacimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(81, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 48);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Día";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Año";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(526, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 48);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(-1, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 48);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Location = new System.Drawing.Point(31, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 19);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Location = new System.Drawing.Point(56, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 19);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Location = new System.Drawing.Point(56, 341);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(19, 19);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Khaki;
            this.panel7.Location = new System.Drawing.Point(501, 341);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 19);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Khaki;
            this.panel8.Location = new System.Drawing.Point(501, 316);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(19, 19);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Khaki;
            this.panel9.Location = new System.Drawing.Point(526, 316);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(19, 19);
            this.panel9.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Khaki;
            this.panel10.Location = new System.Drawing.Point(56, 370);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(464, 19);
            this.panel10.TabIndex = 16;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Khaki;
            this.panel11.Location = new System.Drawing.Point(-1, 56);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(26, 279);
            this.panel11.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Khaki;
            this.panel12.Location = new System.Drawing.Point(551, 56);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(26, 279);
            this.panel12.TabIndex = 18;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Khaki;
            this.panel13.Location = new System.Drawing.Point(526, 56);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(19, 19);
            this.panel13.TabIndex = 15;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Khaki;
            this.panel14.Location = new System.Drawing.Point(501, 56);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(19, 19);
            this.panel14.TabIndex = 15;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Khaki;
            this.panel15.Location = new System.Drawing.Point(31, 56);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(19, 19);
            this.panel15.TabIndex = 19;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Khaki;
            this.panel16.Location = new System.Drawing.Point(56, 31);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(19, 19);
            this.panel16.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Khaki;
            this.panel17.Location = new System.Drawing.Point(56, 56);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(19, 19);
            this.panel17.TabIndex = 15;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Khaki;
            this.panel18.Location = new System.Drawing.Point(501, 31);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(19, 19);
            this.panel18.TabIndex = 15;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Khaki;
            this.panel19.Location = new System.Drawing.Point(-1, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(51, 48);
            this.panel19.TabIndex = 20;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Khaki;
            this.panel20.Location = new System.Drawing.Point(526, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(51, 48);
            this.panel20.TabIndex = 14;
            // 
            // DiaSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(577, 389);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.day);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DiaSemana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiaSemana";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
    }
}