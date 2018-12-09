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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.job = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxDept
            // 
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Location = new System.Drawing.Point(12, 12);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(162, 21);
            this.cbxDept.TabIndex = 0;
            this.cbxDept.Text = "Seleccione un departamento";
            this.cbxDept.SelectedIndexChanged += new System.EventHandler(this.cbxDept_SelectedIndexChanged);
            // 
            // empleados
            // 
            this.empleados.FormattingEnabled = true;
            this.empleados.Location = new System.Drawing.Point(12, 50);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(162, 290);
            this.empleados.TabIndex = 1;
            this.empleados.SelectedIndexChanged += new System.EventHandler(this.empleados_SelectedIndexChanged);
            // 
            // nPersonas
            // 
            this.nPersonas.Location = new System.Drawing.Point(205, 276);
            this.nPersonas.Name = "nPersonas";
            this.nPersonas.Size = new System.Drawing.Size(123, 20);
            this.nPersonas.TabIndex = 2;
            // 
            // sumSalario
            // 
            this.sumSalario.Location = new System.Drawing.Point(205, 316);
            this.sumSalario.Name = "sumSalario";
            this.sumSalario.Size = new System.Drawing.Size(123, 20);
            this.sumSalario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personas : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario Total : ";
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(205, 63);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(123, 20);
            this.sal.TabIndex = 6;
            // 
            // dept
            // 
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(205, 146);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(123, 21);
            this.dept.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salario : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Oficio : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Departamento : ";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(205, 184);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(123, 23);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(205, 224);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(123, 23);
            this.btnDrop.TabIndex = 13;
            this.btnDrop.Text = "Eliminar";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(205, 107);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(121, 20);
            this.job.TabIndex = 14;
            // 
            // EjercicioEMP_DEPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 348);
            this.Controls.Add(this.job);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumSalario);
            this.Controls.Add(this.nPersonas);
            this.Controls.Add(this.empleados);
            this.Controls.Add(this.cbxDept);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.TextBox job;
    }
}