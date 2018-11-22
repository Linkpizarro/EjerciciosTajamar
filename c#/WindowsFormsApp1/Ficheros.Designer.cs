namespace WindowsFormsApp1
{
    partial class Ficheros
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.persons = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.psurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(100, 39);
            this.name.Margin = new System.Windows.Forms.Padding(6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(275, 29);
            this.name.TabIndex = 3;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto";
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.ItemHeight = 24;
            this.products.Location = new System.Drawing.Point(15, 240);
            this.products.Margin = new System.Windows.Forms.Padding(6);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(443, 268);
            this.products.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(161, 103);
            this.price.Margin = new System.Windows.Forms.Padding(6);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(154, 29);
            this.price.TabIndex = 6;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 144);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(443, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Productos";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(15, 519);
            this.btnDel.Margin = new System.Windows.Forms.Padding(6);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(443, 43);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Borrar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.Location = new System.Drawing.Point(587, 519);
            this.btnDelP.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(443, 43);
            this.btnDelP.TabIndex = 18;
            this.btnDelP.Text = "Borrar";
            this.btnDelP.UseVisualStyleBackColor = true;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Personas";
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(587, 144);
            this.btnAddP.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(443, 43);
            this.btnAddP.TabIndex = 16;
            this.btnAddP.Text = "Añadir";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(646, 39);
            this.pname.Margin = new System.Windows.Forms.Padding(6);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(154, 29);
            this.pname.TabIndex = 14;
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // persons
            // 
            this.persons.FormattingEnabled = true;
            this.persons.ItemHeight = 24;
            this.persons.Location = new System.Drawing.Point(587, 240);
            this.persons.Margin = new System.Windows.Forms.Padding(6);
            this.persons.Name = "persons";
            this.persons.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.persons.Size = new System.Drawing.Size(443, 268);
            this.persons.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Edad";
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(765, 103);
            this.page.Margin = new System.Windows.Forms.Padding(6);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(90, 29);
            this.page.TabIndex = 11;
            this.page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apellido";
            // 
            // psurname
            // 
            this.psurname.Location = new System.Drawing.Point(812, 39);
            this.psurname.Margin = new System.Windows.Forms.Padding(6);
            this.psurname.Name = "psurname";
            this.psurname.Size = new System.Drawing.Size(154, 29);
            this.psurname.TabIndex = 19;
            this.psurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ficheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 577);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.psurname);
            this.Controls.Add(this.btnDelP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.persons);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ficheros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficheros";
            this.Load += new System.EventHandler(this.Ficheros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.ListBox persons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox psurname;
    }
}