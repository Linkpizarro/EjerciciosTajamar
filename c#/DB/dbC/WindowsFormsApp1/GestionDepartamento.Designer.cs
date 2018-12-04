namespace WindowsFormsApp1
{
    partial class GestionDepartamento
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
            this.deptList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.bntInsert = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deptList
            // 
            this.deptList.FormattingEnabled = true;
            this.deptList.ItemHeight = 24;
            this.deptList.Location = new System.Drawing.Point(69, 91);
            this.deptList.Name = "deptList";
            this.deptList.Size = new System.Drawing.Size(187, 316);
            this.deptList.TabIndex = 6;
            this.deptList.SelectedIndexChanged += new System.EventHandler(this.deptList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departamentos";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Black;
            this.btnDel.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDel.Location = new System.Drawing.Point(23, 672);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(283, 40);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Black;
            this.btnModify.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnModify.Location = new System.Drawing.Point(23, 626);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(283, 40);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // bntInsert
            // 
            this.bntInsert.BackColor = System.Drawing.Color.Black;
            this.bntInsert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntInsert.Location = new System.Drawing.Point(23, 580);
            this.bntInsert.Name = "bntInsert";
            this.bntInsert.Size = new System.Drawing.Size(283, 40);
            this.bntInsert.TabIndex = 17;
            this.bntInsert.Text = "Insertar";
            this.bntInsert.UseVisualStyleBackColor = false;
            this.bntInsert.Click += new System.EventHandler(this.bntInsert_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 498);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(163, 29);
            this.name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre : ";
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(143, 533);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(163, 29);
            this.loc.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Localidad : ";
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(143, 463);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(163, 29);
            this.no.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número : ";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(136, 30);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 29);
            this.search.TabIndex = 21;
            this.search.Click += new System.EventHandler(this.search_Click);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscador : ";
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(69, 410);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(187, 25);
            this.msg.TabIndex = 22;
            this.msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GestionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 722);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.bntInsert);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deptList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GestionDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deptList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button bntInsert;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msg;
    }
}