namespace WindowsFormsApp1
{
    partial class EjercicioEMP_DEPT
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
            this.cbxDept = new System.Windows.Forms.ComboBox();
            this.empleados = new System.Windows.Forms.ListBox();
            this.nPersonas = new System.Windows.Forms.TextBox();
            this.sumSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sal = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.job = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxDept
            // 
            this.cbxDept.BackColor = System.Drawing.Color.Purple;
            this.cbxDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxDept.ForeColor = System.Drawing.Color.White;
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Location = new System.Drawing.Point(49, 110);
            this.cbxDept.Margin = new System.Windows.Forms.Padding(6);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(320, 32);
            this.cbxDept.TabIndex = 0;
            this.cbxDept.Text = "Seleccione un departamento";
            this.cbxDept.SelectedIndexChanged += new System.EventHandler(this.cbxDept_SelectedIndexChanged);
            // 
            // empleados
            // 
            this.empleados.BackColor = System.Drawing.Color.Purple;
            this.empleados.ForeColor = System.Drawing.Color.White;
            this.empleados.FormattingEnabled = true;
            this.empleados.ItemHeight = 24;
            this.empleados.Location = new System.Drawing.Point(49, 180);
            this.empleados.Margin = new System.Windows.Forms.Padding(6);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(320, 436);
            this.empleados.TabIndex = 1;
            this.empleados.SelectedIndexChanged += new System.EventHandler(this.empleados_SelectedIndexChanged);
            // 
            // nPersonas
            // 
            this.nPersonas.BackColor = System.Drawing.Color.Purple;
            this.nPersonas.Enabled = false;
            this.nPersonas.ForeColor = System.Drawing.Color.White;
            this.nPersonas.Location = new System.Drawing.Point(477, 513);
            this.nPersonas.Margin = new System.Windows.Forms.Padding(6);
            this.nPersonas.Name = "nPersonas";
            this.nPersonas.ReadOnly = true;
            this.nPersonas.Size = new System.Drawing.Size(242, 29);
            this.nPersonas.TabIndex = 2;
            this.nPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sumSalario
            // 
            this.sumSalario.BackColor = System.Drawing.Color.Purple;
            this.sumSalario.Enabled = false;
            this.sumSalario.ForeColor = System.Drawing.Color.White;
            this.sumSalario.Location = new System.Drawing.Point(477, 586);
            this.sumSalario.Margin = new System.Windows.Forms.Padding(6);
            this.sumSalario.Name = "sumSalario";
            this.sumSalario.ReadOnly = true;
            this.sumSalario.Size = new System.Drawing.Size(242, 29);
            this.sumSalario.TabIndex = 3;
            this.sumSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(553, 496);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(538, 567);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario Total";
            // 
            // sal
            // 
            this.sal.BackColor = System.Drawing.Color.Purple;
            this.sal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sal.Enabled = false;
            this.sal.ForeColor = System.Drawing.Color.White;
            this.sal.Location = new System.Drawing.Point(477, 181);
            this.sal.Margin = new System.Windows.Forms.Padding(6);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(242, 29);
            this.sal.TabIndex = 6;
            this.sal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sal_KeyPress);
            // 
            // dept
            // 
            this.dept.BackColor = System.Drawing.Color.Purple;
            this.dept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dept.ForeColor = System.Drawing.Color.White;
            this.dept.FormattingEnabled = true;
            this.dept.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dept.Location = new System.Drawing.Point(477, 290);
            this.dept.Margin = new System.Windows.Forms.Padding(6);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(242, 32);
            this.dept.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(563, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(528, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Departamento ";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.DarkViolet;
            this.btnModify.Enabled = false;
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(477, 360);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(242, 42);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.BackColor = System.Drawing.Color.Purple;
            this.btnDrop.Enabled = false;
            this.btnDrop.ForeColor = System.Drawing.Color.White;
            this.btnDrop.Location = new System.Drawing.Point(477, 414);
            this.btnDrop.Margin = new System.Windows.Forms.Padding(6);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(242, 42);
            this.btnDrop.TabIndex = 13;
            this.btnDrop.Text = "Eliminar";
            this.btnDrop.UseVisualStyleBackColor = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // job
            // 
            this.job.BackColor = System.Drawing.Color.Purple;
            this.job.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job.Enabled = false;
            this.job.ForeColor = System.Drawing.Color.White;
            this.job.Location = new System.Drawing.Point(477, 236);
            this.job.Margin = new System.Windows.Forms.Padding(6);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(242, 29);
            this.job.TabIndex = 14;
            this.job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.job_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(563, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Oficio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(702, 73);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gestión de Empleados";
            // 
            // EjercicioEMP_DEPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(781, 672);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.job);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumSalario);
            this.Controls.Add(this.nPersonas);
            this.Controls.Add(this.empleados);
            this.Controls.Add(this.cbxDept);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EjercicioEMP_DEPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjercicioEMP_DEPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.ListBox empleados;
        private System.Windows.Forms.TextBox nPersonas;
        private System.Windows.Forms.TextBox sumSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}