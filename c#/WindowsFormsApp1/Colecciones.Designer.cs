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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.shopList = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.TextBox();
            this.storageList = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(14, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 10);
            this.panel3.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tienda";
            // 
            // shopList
            // 
            this.shopList.FormattingEnabled = true;
            this.shopList.ItemHeight = 30;
            this.shopList.Location = new System.Drawing.Point(258, 544);
            this.shopList.Name = "shopList";
            this.shopList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.shopList.Size = new System.Drawing.Size(185, 214);
            this.shopList.TabIndex = 29;
            this.shopList.SelectedIndexChanged += new System.EventHandler(this.shopList_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.Location = new System.Drawing.Point(15, 586);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(180, 34);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(15, 632);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.LightGray;
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(15, 678);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(180, 34);
            this.btnModify.TabIndex = 32;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.Location = new System.Drawing.Point(15, 724);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(180, 34);
            this.btnDeleteAll.TabIndex = 33;
            this.btnDeleteAll.Text = "Limpiar";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 502);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 30);
            this.label9.TabIndex = 34;
            this.label9.Text = "Producto";
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(15, 538);
            this.product.Margin = new System.Windows.Forms.Padding(6);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(180, 37);
            this.product.TabIndex = 35;
            this.product.TextChanged += new System.EventHandler(this.product_TextChanged);
            this.product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_KeyPress);
            // 
            // storageList
            // 
            this.storageList.FormattingEnabled = true;
            this.storageList.ItemHeight = 30;
            this.storageList.Location = new System.Drawing.Point(754, 544);
            this.storageList.Name = "storageList";
            this.storageList.Size = new System.Drawing.Size(183, 214);
            this.storageList.TabIndex = 36;
            this.storageList.SelectedIndexChanged += new System.EventHandler(this.storageList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(799, 502);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 30);
            this.label10.TabIndex = 37;
            this.label10.Text = "Almacén";
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.BackColor = System.Drawing.Color.LightGray;
            this.btnMoveSelected.Enabled = false;
            this.btnMoveSelected.Location = new System.Drawing.Point(462, 595);
            this.btnMoveSelected.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.Size = new System.Drawing.Size(268, 34);
            this.btnMoveSelected.TabIndex = 38;
            this.btnMoveSelected.Text = "Mover Seleccionados";
            this.btnMoveSelected.UseVisualStyleBackColor = false;
            this.btnMoveSelected.Click += new System.EventHandler(this.btnMoveSelected_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.BackColor = System.Drawing.Color.LightGray;
            this.btnMoveAll.Enabled = false;
            this.btnMoveAll.Location = new System.Drawing.Point(504, 641);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(180, 34);
            this.btnMoveAll.TabIndex = 39;
            this.btnMoveAll.Text = "Mover Todos";
            this.btnMoveAll.UseVisualStyleBackColor = false;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightGray;
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(978, 578);
            this.btnUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(135, 51);
            this.btnUp.TabIndex = 40;
            this.btnUp.Text = "Subir";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.LightGray;
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(978, 645);
            this.btnDown.Margin = new System.Windows.Forms.Padding(6);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(135, 51);
            this.btnDown.TabIndex = 41;
            this.btnDown.Text = "Bajar";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Location = new System.Drawing.Point(17, 783);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1096, 10);
            this.panel4.TabIndex = 42;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGray;
            this.btn1.Location = new System.Drawing.Point(17, 814);
            this.btn1.Margin = new System.Windows.Forms.Padding(6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(180, 34);
            this.btn1.TabIndex = 43;
            this.btn1.Text = "Botón1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGray;
            this.btn2.Location = new System.Drawing.Point(17, 860);
            this.btn2.Margin = new System.Windows.Forms.Padding(6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(180, 34);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "Botón2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.Location = new System.Drawing.Point(17, 906);
            this.btn3.Margin = new System.Windows.Forms.Padding(6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(180, 34);
            this.btn3.TabIndex = 45;
            this.btn3.Text = "Botón 3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(209, 903);
            this.txt3.Margin = new System.Windows.Forms.Padding(6);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(180, 37);
            this.txt3.TabIndex = 46;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(209, 857);
            this.txt2.Margin = new System.Windows.Forms.Padding(6);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(180, 37);
            this.txt2.TabIndex = 47;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(209, 811);
            this.txt1.Margin = new System.Windows.Forms.Padding(6);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(180, 37);
            this.txt1.TabIndex = 48;
            // 
            // Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 950);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMoveSelected);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.storageList);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.shopList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox shopList;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.ListBox storageList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMoveSelected;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
    }
}