namespace WindowsFormsApp1
{
    partial class Temperatura
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
            this.mesesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxima = new System.Windows.Forms.Label();
            this.minima = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.comboAnios = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.anioMaxima = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.anioMinima = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.anioMedia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nAnios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mesesList
            // 
            this.mesesList.FormattingEnabled = true;
            this.mesesList.ItemHeight = 27;
            this.mesesList.Location = new System.Drawing.Point(16, 362);
            this.mesesList.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mesesList.Name = "mesesList";
            this.mesesList.Size = new System.Drawing.Size(143, 382);
            this.mesesList.TabIndex = 0;
            this.mesesList.SelectedIndexChanged += new System.EventHandler(this.mesesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 632);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mínima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Média";
            // 
            // maxima
            // 
            this.maxima.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.maxima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxima.ForeColor = System.Drawing.Color.Firebrick;
            this.maxima.Location = new System.Drawing.Point(173, 374);
            this.maxima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.maxima.Name = "maxima";
            this.maxima.Size = new System.Drawing.Size(90, 85);
            this.maxima.TabIndex = 2;
            this.maxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minima
            // 
            this.minima.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minima.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.minima.Location = new System.Drawing.Point(173, 659);
            this.minima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minima.Name = "minima";
            this.minima.Size = new System.Drawing.Size(90, 85);
            this.minima.TabIndex = 6;
            this.minima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // media
            // 
            this.media.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.media.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media.Location = new System.Drawing.Point(173, 521);
            this.media.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(90, 85);
            this.media.TabIndex = 7;
            this.media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboAnios
            // 
            this.comboAnios.FormattingEnabled = true;
            this.comboAnios.Location = new System.Drawing.Point(10, 171);
            this.comboAnios.Name = "comboAnios";
            this.comboAnios.Size = new System.Drawing.Size(253, 35);
            this.comboAnios.TabIndex = 8;
            this.comboAnios.Text = "Seleccione Un Año";
            this.comboAnios.SelectedIndexChanged += new System.EventHandler(this.comboAnios_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(9, 86);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(254, 42);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar Años";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Años";
            // 
            // anioMaxima
            // 
            this.anioMaxima.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.anioMaxima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioMaxima.ForeColor = System.Drawing.Color.Firebrick;
            this.anioMaxima.Location = new System.Drawing.Point(18, 277);
            this.anioMaxima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.anioMaxima.Name = "anioMaxima";
            this.anioMaxima.Size = new System.Drawing.Size(70, 59);
            this.anioMaxima.TabIndex = 12;
            this.anioMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Máxima";
            // 
            // anioMinima
            // 
            this.anioMinima.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.anioMinima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioMinima.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.anioMinima.Location = new System.Drawing.Point(187, 277);
            this.anioMinima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.anioMinima.Name = "anioMinima";
            this.anioMinima.Size = new System.Drawing.Size(68, 59);
            this.anioMinima.TabIndex = 14;
            this.anioMinima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(173, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mínima";
            // 
            // anioMedia
            // 
            this.anioMedia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.anioMedia.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anioMedia.Location = new System.Drawing.Point(102, 277);
            this.anioMedia.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.anioMedia.Name = "anioMedia";
            this.anioMedia.Size = new System.Drawing.Size(71, 59);
            this.anioMedia.TabIndex = 16;
            this.anioMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "Média";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 27);
            this.label11.TabIndex = 17;
            this.label11.Text = "Número de Años";
            // 
            // nAnios
            // 
            this.nAnios.Location = new System.Drawing.Point(103, 46);
            this.nAnios.Name = "nAnios";
            this.nAnios.Size = new System.Drawing.Size(70, 34);
            this.nAnios.TabIndex = 18;
            this.nAnios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 759);
            this.Controls.Add(this.nAnios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.anioMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.anioMinima);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.anioMaxima);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.comboAnios);
            this.Controls.Add(this.media);
            this.Controls.Add(this.minima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mesesList);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Temperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            this.Load += new System.EventHandler(this.Temperatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mesesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxima;
        private System.Windows.Forms.Label minima;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.ComboBox comboAnios;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label anioMaxima;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label anioMinima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label anioMedia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nAnios;
    }
}