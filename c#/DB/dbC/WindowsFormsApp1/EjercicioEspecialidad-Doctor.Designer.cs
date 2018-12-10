namespace WindowsFormsApp1
{
    partial class EjercicioEspecialidad_Doctor
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
            this.hospitales = new System.Windows.Forms.ComboBox();
            this.especialidades = new System.Windows.Forms.ComboBox();
            this.doctores = new System.Windows.Forms.ListBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.cbxEspecialidad = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hospitales
            // 
            this.hospitales.BackColor = System.Drawing.Color.Purple;
            this.hospitales.ForeColor = System.Drawing.Color.White;
            this.hospitales.FormattingEnabled = true;
            this.hospitales.Location = new System.Drawing.Point(547, 212);
            this.hospitales.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hospitales.Name = "hospitales";
            this.hospitales.Size = new System.Drawing.Size(200, 32);
            this.hospitales.TabIndex = 1;
            // 
            // especialidades
            // 
            this.especialidades.BackColor = System.Drawing.Color.Purple;
            this.especialidades.ForeColor = System.Drawing.Color.White;
            this.especialidades.FormattingEnabled = true;
            this.especialidades.Location = new System.Drawing.Point(547, 270);
            this.especialidades.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.especialidades.Name = "especialidades";
            this.especialidades.Size = new System.Drawing.Size(200, 32);
            this.especialidades.TabIndex = 2;
            // 
            // doctores
            // 
            this.doctores.BackColor = System.Drawing.Color.Purple;
            this.doctores.ForeColor = System.Drawing.Color.White;
            this.doctores.FormattingEnabled = true;
            this.doctores.ItemHeight = 24;
            this.doctores.Location = new System.Drawing.Point(327, 147);
            this.doctores.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.doctores.Name = "doctores";
            this.doctores.Size = new System.Drawing.Size(184, 340);
            this.doctores.TabIndex = 3;
            this.doctores.SelectedIndexChanged += new System.EventHandler(this.doctores_SelectedIndexChanged);
            // 
            // salario
            // 
            this.salario.BackColor = System.Drawing.Color.Purple;
            this.salario.ForeColor = System.Drawing.Color.White;
            this.salario.Location = new System.Drawing.Point(548, 326);
            this.salario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(200, 29);
            this.salario.TabIndex = 4;
            this.salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salario_KeyPress);
            // 
            // apellido
            // 
            this.apellido.BackColor = System.Drawing.Color.Purple;
            this.apellido.ForeColor = System.Drawing.Color.White;
            this.apellido.Location = new System.Drawing.Point(547, 157);
            this.apellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(200, 29);
            this.apellido.TabIndex = 5;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(604, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(606, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hospital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(586, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(606, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salario";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(547, 381);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(201, 42);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Purple;
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(547, 441);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(201, 42);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.BackColor = System.Drawing.Color.Purple;
            this.cbxEspecialidad.ForeColor = System.Drawing.Color.White;
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.ItemHeight = 24;
            this.cbxEspecialidad.Location = new System.Drawing.Point(125, 147);
            this.cbxEspecialidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cbxEspecialidad.Size = new System.Drawing.Size(190, 340);
            this.cbxEspecialidad.TabIndex = 12;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Especialidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Purple;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(372, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doctores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Purple;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(636, 73);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gestión de Doctores";
            // 
            // EjercicioEspecialidad_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(862, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxEspecialidad);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.doctores);
            this.Controls.Add(this.especialidades);
            this.Controls.Add(this.hospitales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EjercicioEspecialidad_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjercicioEspecialidad_Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hospitales;
        private System.Windows.Forms.ComboBox especialidades;
        private System.Windows.Forms.ListBox doctores;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListBox cbxEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}