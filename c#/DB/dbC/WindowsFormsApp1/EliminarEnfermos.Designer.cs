namespace WindowsFormsApp1
{
    partial class EliminarEnfermos
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
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.enferList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Cursor = System.Windows.Forms.Cursors.No;
            this.surname.Enabled = false;
            this.surname.Location = new System.Drawing.Point(127, 23);
            this.surname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Size = new System.Drawing.Size(175, 29);
            this.surname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enfermo : ";
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Maroon;
            this.btnDel.Location = new System.Drawing.Point(26, 70);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(276, 42);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // enferList
            // 
            this.enferList.FormattingEnabled = true;
            this.enferList.ItemHeight = 24;
            this.enferList.Location = new System.Drawing.Point(26, 162);
            this.enferList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.enferList.Name = "enferList";
            this.enferList.Size = new System.Drawing.Size(276, 484);
            this.enferList.TabIndex = 3;
            this.enferList.SelectedIndexChanged += new System.EventHandler(this.enferList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enfermos";
            // 
            // EliminarEnfermos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 664);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enferList);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EliminarEnfermos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarEnfermos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox enferList;
        private System.Windows.Forms.Label label2;
    }
}