namespace WindowsFormsApp1
{
    partial class Colecciones
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
            this.element = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.removeAll = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.myList = new System.Windows.Forms.ListBox();
            this.removeSelect = new System.Windows.Forms.Button();
            this.numList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.operate = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.odds = new System.Windows.Forms.TextBox();
            this.evens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mi Lista";
            // 
            // element
            // 
            this.element.Location = new System.Drawing.Point(276, 171);
            this.element.Margin = new System.Windows.Forms.Padding(6);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(290, 37);
            this.element.TabIndex = 3;
            this.element.TextChanged += new System.EventHandler(this.element_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elemento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 114);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colecciones";
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(275, 409);
            this.removeAll.Margin = new System.Windows.Forms.Padding(6);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(291, 51);
            this.removeAll.TabIndex = 11;
            this.removeAll.Text = "Eliminar Todo";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(275, 283);
            this.remove.Margin = new System.Windows.Forms.Padding(6);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(291, 51);
            this.remove.TabIndex = 12;
            this.remove.Text = "Eliminar";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(275, 220);
            this.add.Margin = new System.Windows.Forms.Padding(6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(291, 51);
            this.add.TabIndex = 13;
            this.add.Text = "Añadir";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // myList
            // 
            this.myList.FormattingEnabled = true;
            this.myList.ItemHeight = 30;
            this.myList.Location = new System.Drawing.Point(12, 186);
            this.myList.Name = "myList";
            this.myList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.myList.Size = new System.Drawing.Size(241, 274);
            this.myList.TabIndex = 14;
            this.myList.SelectedIndexChanged += new System.EventHandler(this.myList_SelectedIndexChanged);
            // 
            // removeSelect
            // 
            this.removeSelect.Location = new System.Drawing.Point(276, 346);
            this.removeSelect.Margin = new System.Windows.Forms.Padding(6);
            this.removeSelect.Name = "removeSelect";
            this.removeSelect.Size = new System.Drawing.Size(290, 51);
            this.removeSelect.TabIndex = 15;
            this.removeSelect.Text = "Eliminar Seleccionado";
            this.removeSelect.UseVisualStyleBackColor = true;
            this.removeSelect.Click += new System.EventHandler(this.removeSelect_Click);
            // 
            // numList
            // 
            this.numList.FormattingEnabled = true;
            this.numList.ItemHeight = 30;
            this.numList.Location = new System.Drawing.Point(725, 186);
            this.numList.Name = "numList";
            this.numList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.numList.Size = new System.Drawing.Size(123, 274);
            this.numList.TabIndex = 16;
            this.numList.SelectedIndexChanged += new System.EventHandler(this.numList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Números";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(857, 186);
            this.generate.Margin = new System.Windows.Forms.Padding(6);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(250, 51);
            this.generate.TabIndex = 18;
            this.generate.Text = "Generar";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // operate
            // 
            this.operate.Location = new System.Drawing.Point(857, 259);
            this.operate.Margin = new System.Windows.Forms.Padding(6);
            this.operate.Name = "operate";
            this.operate.Size = new System.Drawing.Size(250, 51);
            this.operate.TabIndex = 19;
            this.operate.Text = "Mostrar";
            this.operate.UseVisualStyleBackColor = true;
            this.operate.Click += new System.EventHandler(this.operate_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(1053, 328);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(54, 37);
            this.total.TabIndex = 20;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // odds
            // 
            this.odds.Location = new System.Drawing.Point(1053, 423);
            this.odds.Name = "odds";
            this.odds.Size = new System.Drawing.Size(53, 37);
            this.odds.TabIndex = 21;
            this.odds.TextChanged += new System.EventHandler(this.odds_TextChanged);
            // 
            // evens
            // 
            this.evens.Location = new System.Drawing.Point(1053, 371);
            this.evens.Name = "evens";
            this.evens.Size = new System.Drawing.Size(53, 37);
            this.evens.TabIndex = 22;
            this.evens.TextChanged += new System.EventHandler(this.evens_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(888, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(888, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(888, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "Impares";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(640, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 322);
            this.panel2.TabIndex = 26;
            // 
            // Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.evens);
            this.Controls.Add(this.odds);
            this.Controls.Add(this.total);
            this.Controls.Add(this.operate);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numList);
            this.Controls.Add(this.removeSelect);
            this.Controls.Add(this.myList);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.element);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Colecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colecciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox element;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox myList;
        private System.Windows.Forms.Button removeSelect;
        private System.Windows.Forms.ListBox numList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button operate;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox odds;
        private System.Windows.Forms.TextBox evens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}