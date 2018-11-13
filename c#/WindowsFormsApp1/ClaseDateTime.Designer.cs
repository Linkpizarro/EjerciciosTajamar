namespace WindowsFormsApp1
{
    partial class ClaseDateTime
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.changeFormat = new System.Windows.Forms.CheckBox();
            this.currentDate = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.dateResult = new System.Windows.Forms.TextBox();
            this.rDay = new System.Windows.Forms.RadioButton();
            this.rMonth = new System.Windows.Forms.RadioButton();
            this.rYear = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.diferent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(57, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incrementar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Resultado:";
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(204, 310);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(104, 30);
            this.increment.TabIndex = 9;
            this.increment.Text = "Incrementar";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // changeFormat
            // 
            this.changeFormat.AutoSize = true;
            this.changeFormat.Location = new System.Drawing.Point(143, 167);
            this.changeFormat.Name = "changeFormat";
            this.changeFormat.Size = new System.Drawing.Size(105, 17);
            this.changeFormat.TabIndex = 10;
            this.changeFormat.Text = "Cambiar Formato";
            this.changeFormat.UseVisualStyleBackColor = true;
            this.changeFormat.CheckedChanged += new System.EventHandler(this.changeFormat_CheckedChanged);
            // 
            // currentDate
            // 
            this.currentDate.Location = new System.Drawing.Point(61, 122);
            this.currentDate.Name = "currentDate";
            this.currentDate.ReadOnly = true;
            this.currentDate.Size = new System.Drawing.Size(269, 20);
            this.currentDate.TabIndex = 11;
            this.currentDate.TextChanged += new System.EventHandler(this.currentDate_TextChanged);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(242, 278);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(66, 20);
            this.value.TabIndex = 12;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // dateResult
            // 
            this.dateResult.Location = new System.Drawing.Point(61, 429);
            this.dateResult.Name = "dateResult";
            this.dateResult.Size = new System.Drawing.Size(269, 20);
            this.dateResult.TabIndex = 13;
            this.dateResult.TextChanged += new System.EventHandler(this.dateResult_TextChanged);
            // 
            // rDay
            // 
            this.rDay.AutoSize = true;
            this.rDay.Location = new System.Drawing.Point(99, 272);
            this.rDay.Name = "rDay";
            this.rDay.Size = new System.Drawing.Size(43, 17);
            this.rDay.TabIndex = 14;
            this.rDay.TabStop = true;
            this.rDay.Text = "Día";
            this.rDay.UseVisualStyleBackColor = true;
            this.rDay.CheckedChanged += new System.EventHandler(this.rDay_CheckedChanged);
            // 
            // rMonth
            // 
            this.rMonth.AutoSize = true;
            this.rMonth.Location = new System.Drawing.Point(99, 310);
            this.rMonth.Name = "rMonth";
            this.rMonth.Size = new System.Drawing.Size(45, 17);
            this.rMonth.TabIndex = 15;
            this.rMonth.TabStop = true;
            this.rMonth.Text = "Mes";
            this.rMonth.UseVisualStyleBackColor = true;
            this.rMonth.CheckedChanged += new System.EventHandler(this.rMonth_CheckedChanged);
            // 
            // rYear
            // 
            this.rYear.AutoSize = true;
            this.rYear.Location = new System.Drawing.Point(99, 352);
            this.rYear.Name = "rYear";
            this.rYear.Size = new System.Drawing.Size(44, 17);
            this.rYear.TabIndex = 16;
            this.rYear.TabStop = true;
            this.rYear.Text = "Año";
            this.rYear.UseVisualStyleBackColor = true;
            this.rYear.CheckedChanged += new System.EventHandler(this.rYear_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Diferencia";
            // 
            // diferent
            // 
            this.diferent.Location = new System.Drawing.Point(61, 512);
            this.diferent.Name = "diferent";
            this.diferent.ReadOnly = true;
            this.diferent.Size = new System.Drawing.Size(269, 20);
            this.diferent.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(361, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(-1, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 25);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Location = new System.Drawing.Point(361, 512);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 12);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Location = new System.Drawing.Point(342, 512);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 12);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Location = new System.Drawing.Point(342, 530);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 12);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Khaki;
            this.panel7.Location = new System.Drawing.Point(12, 512);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 12);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Khaki;
            this.panel8.Location = new System.Drawing.Point(31, 512);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 12);
            this.panel8.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Khaki;
            this.panel9.Location = new System.Drawing.Point(30, 530);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 12);
            this.panel9.TabIndex = 22;
            // 
            // ClaseDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 554);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.diferent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rYear);
            this.Controls.Add(this.rMonth);
            this.Controls.Add(this.rDay);
            this.Controls.Add(this.dateResult);
            this.Controls.Add(this.value);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.changeFormat);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ClaseDateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.CheckBox changeFormat;
        private System.Windows.Forms.TextBox currentDate;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox dateResult;
        private System.Windows.Forms.RadioButton rDay;
        private System.Windows.Forms.RadioButton rMonth;
        private System.Windows.Forms.RadioButton rYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diferent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}