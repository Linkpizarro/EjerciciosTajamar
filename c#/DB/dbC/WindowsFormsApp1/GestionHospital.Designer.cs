namespace WindowsFormsApp1
{
    partial class GestionHospital
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
            this.empleados = new System.Windows.Forms.ListBox();
            this.sal = new System.Windows.Forms.TextBox();
            this.hospitales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            this.med = new System.Windows.Forms.TextBox();
            this.persons = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empleados
            // 
            this.empleados.BackColor = System.Drawing.Color.PaleTurquoise;
            this.empleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empleados.FormattingEnabled = true;
            this.empleados.ItemHeight = 19;
            this.empleados.Location = new System.Drawing.Point(15, 116);
            this.empleados.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(226, 306);
            this.empleados.TabIndex = 0;
            this.empleados.SelectedIndexChanged += new System.EventHandler(this.empleados_SelectedIndexChanged);
            // 
            // sal
            // 
            this.sal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.Location = new System.Drawing.Point(255, 116);
            this.sal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(195, 26);
            this.sal.TabIndex = 1;
            // 
            // hospitales
            // 
            this.hospitales.BackColor = System.Drawing.SystemColors.Window;
            this.hospitales.FormattingEnabled = true;
            this.hospitales.Location = new System.Drawing.Point(15, 50);
            this.hospitales.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hospitales.Name = "hospitales";
            this.hospitales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hospitales.Size = new System.Drawing.Size(435, 27);
            this.hospitales.TabIndex = 2;
            this.hospitales.Text = "Seleccione un Hospital";
            this.hospitales.SelectedIndexChanged += new System.EventHandler(this.hospitales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hospital";
            // 
            // job
            // 
            this.job.BackColor = System.Drawing.Color.PaleTurquoise;
            this.job.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job.Location = new System.Drawing.Point(255, 171);
            this.job.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(195, 26);
            this.job.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trabajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Personas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Suma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Media";
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sum.Enabled = false;
            this.sum.Location = new System.Drawing.Point(255, 345);
            this.sum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(195, 26);
            this.sum.TabIndex = 11;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // med
            // 
            this.med.BackColor = System.Drawing.Color.PaleTurquoise;
            this.med.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.med.Enabled = false;
            this.med.Location = new System.Drawing.Point(255, 393);
            this.med.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(195, 26);
            this.med.TabIndex = 10;
            this.med.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // persons
            // 
            this.persons.BackColor = System.Drawing.Color.PaleTurquoise;
            this.persons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.persons.Enabled = false;
            this.persons.Location = new System.Drawing.Point(255, 297);
            this.persons.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.persons.Name = "persons";
            this.persons.Size = new System.Drawing.Size(195, 26);
            this.persons.TabIndex = 9;
            this.persons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Empleados";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModify.Location = new System.Drawing.Point(255, 204);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(195, 67);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // GestionHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(466, 435);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.med);
            this.Controls.Add(this.persons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hospitales);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.empleados);
            this.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GestionHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox empleados;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.ComboBox hospitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox persons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModify;
    }
}