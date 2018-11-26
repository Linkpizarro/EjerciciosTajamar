namespace WindowsFormsApp1
{
    partial class SerializeImage
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
            this.cuadroImagen = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.TextBox();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coches = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cuadroImagen
            // 
            this.cuadroImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuadroImagen.Location = new System.Drawing.Point(128, 22);
            this.cuadroImagen.Name = "cuadroImagen";
            this.cuadroImagen.Size = new System.Drawing.Size(185, 158);
            this.cuadroImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuadroImagen.TabIndex = 0;
            this.cuadroImagen.TabStop = false;
            this.cuadroImagen.Click += new System.EventHandler(this.cuadroImagen_Click);
            // 
            // open
            // 
            this.open.FileName = "open";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(305, 62);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(8, 63);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(119, 20);
            this.marca.TabIndex = 3;
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(8, 112);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(119, 20);
            this.modelo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imagen";
            // 
            // coches
            // 
            this.coches.FormattingEnabled = true;
            this.coches.Location = new System.Drawing.Point(8, 385);
            this.coches.Name = "coches";
            this.coches.Size = new System.Drawing.Size(305, 238);
            this.coches.TabIndex = 8;
            this.coches.SelectedIndexChanged += new System.EventHandler(this.coches_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(8, 640);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(305, 62);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Borrar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(8, 282);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(305, 62);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Coches";
            // 
            // SerializeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.coches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cuadroImagen);
            this.Name = "SerializeImage";
            this.Text = "SerializeImage";
            this.Load += new System.EventHandler(this.SerializeImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadroImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cuadroImagen;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox coches;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label4;
    }
}