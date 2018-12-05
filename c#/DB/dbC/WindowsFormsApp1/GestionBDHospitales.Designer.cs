namespace WindowsFormsApp1
{
    partial class GestionBDHospitales
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
            this.list = new System.Windows.Forms.ListBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStrict = new System.Windows.Forms.CheckBox();
            this.tablas = new System.Windows.Forms.ComboBox();
            this.col = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.columnsZone = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataZone = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.HorizontalScrollbar = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(508, 48);
            this.list.Margin = new System.Windows.Forms.Padding(6);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(472, 372);
            this.list.TabIndex = 0;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(97, 113);
            this.value.Margin = new System.Windows.Forms.Padding(6);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(294, 29);
            this.value.TabIndex = 2;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parámetro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor a Buscar";
            // 
            // cbStrict
            // 
            this.cbStrict.AutoSize = true;
            this.cbStrict.Checked = true;
            this.cbStrict.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStrict.Location = new System.Drawing.Point(188, 154);
            this.cbStrict.Margin = new System.Windows.Forms.Padding(6);
            this.cbStrict.Name = "cbStrict";
            this.cbStrict.Size = new System.Drawing.Size(98, 28);
            this.cbStrict.TabIndex = 6;
            this.cbStrict.Text = "Estricto";
            this.cbStrict.UseVisualStyleBackColor = true;
            this.cbStrict.CheckedChanged += new System.EventHandler(this.cbStrict_CheckedChanged);
            // 
            // tablas
            // 
            this.tablas.FormattingEnabled = true;
            this.tablas.Location = new System.Drawing.Point(15, 48);
            this.tablas.Margin = new System.Windows.Forms.Padding(6);
            this.tablas.Name = "tablas";
            this.tablas.Size = new System.Drawing.Size(472, 32);
            this.tablas.TabIndex = 7;
            this.tablas.Text = "Seleccione una tabla";
            this.tablas.SelectedIndexChanged += new System.EventHandler(this.tablas_SelectedIndexChanged);
            // 
            // col
            // 
            this.col.FormattingEnabled = true;
            this.col.Location = new System.Drawing.Point(97, 42);
            this.col.Margin = new System.Windows.Forms.Padding(6);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(294, 32);
            this.col.TabIndex = 9;
            this.col.Text = "Seleccione una columna";
            this.col.SelectedIndexChanged += new System.EventHandler(this.col_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tablas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.col);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.value);
            this.panel1.Controls.Add(this.cbStrict);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 190);
            this.panel1.TabIndex = 11;
            // 
            // columnsZone
            // 
            this.columnsZone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.columnsZone.Location = new System.Drawing.Point(15, 328);
            this.columnsZone.Name = "columnsZone";
            this.columnsZone.Size = new System.Drawing.Size(472, 91);
            this.columnsZone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Buscador Personalizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datos";
            // 
            // dataZone
            // 
            this.dataZone.BackColor = System.Drawing.Color.Teal;
            this.dataZone.Location = new System.Drawing.Point(999, 48);
            this.dataZone.Name = "dataZone";
            this.dataZone.Size = new System.Drawing.Size(359, 371);
            this.dataZone.TabIndex = 15;
            // 
            // GestionBDHospitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 436);
            this.Controls.Add(this.dataZone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.columnsZone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablas);
            this.Controls.Add(this.list);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GestionBDHospitales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pruebaConexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbStrict;
        private System.Windows.Forms.ComboBox tablas;
        private System.Windows.Forms.ComboBox col;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel columnsZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel dataZone;
    }
}