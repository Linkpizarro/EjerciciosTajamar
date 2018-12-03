namespace WindowsFormsApp1
{
    partial class ModificarDoctor
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
            this.doctorList = new System.Windows.Forms.ListBox();
            this.lb = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.especial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctores";
            // 
            // doctorList
            // 
            this.doctorList.FormattingEnabled = true;
            this.doctorList.ItemHeight = 24;
            this.doctorList.Location = new System.Drawing.Point(33, 45);
            this.doctorList.Name = "doctorList";
            this.doctorList.ScrollAlwaysVisible = true;
            this.doctorList.Size = new System.Drawing.Size(155, 268);
            this.doctorList.TabIndex = 1;
            this.doctorList.SelectedIndexChanged += new System.EventHandler(this.doctorList_SelectedIndexChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(233, 47);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(105, 24);
            this.lb.TabIndex = 2;
            this.lb.Text = "Apellido : ";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(344, 47);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(168, 29);
            this.surname.TabIndex = 3;
            // 
            // especial
            // 
            this.especial.Location = new System.Drawing.Point(387, 112);
            this.especial.Name = "especial";
            this.especial.Size = new System.Drawing.Size(160, 29);
            this.especial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Especialidad : ";
            // 
            // salari
            // 
            this.salari.Location = new System.Drawing.Point(331, 168);
            this.salari.Name = "salari";
            this.salari.Size = new System.Drawing.Size(104, 29);
            this.salari.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario : ";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(237, 234);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(310, 79);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ModificarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 339);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.salari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.especial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.doctorList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ModificarDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox doctorList;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox especial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModify;
    }
}