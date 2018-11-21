namespace WindowsFormsApp1
{
    partial class BatallaPokemon
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
            this.mypokeimage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtack1 = new System.Windows.Forms.Button();
            this.btnAtack4 = new System.Windows.Forms.Button();
            this.btnAtack3 = new System.Windows.Forms.Button();
            this.btnAtack2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nhp = new System.Windows.Forms.Label();
            this.varhp = new System.Windows.Forms.Label();
            this.varex = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.varendex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nlevel = new System.Windows.Forms.Label();
            this.varname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mypokeimage)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mypokeimage
            // 
            this.mypokeimage.InitialImage = null;
            this.mypokeimage.Location = new System.Drawing.Point(-22, 172);
            this.mypokeimage.Name = "mypokeimage";
            this.mypokeimage.Size = new System.Drawing.Size(101, 111);
            this.mypokeimage.TabIndex = 0;
            this.mypokeimage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.varendex);
            this.panel1.Controls.Add(this.varex);
            this.panel1.Controls.Add(this.varhp);
            this.panel1.Controls.Add(this.nhp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 58);
            this.panel1.TabIndex = 1;
            // 
            // btnAtack1
            // 
            this.btnAtack1.Location = new System.Drawing.Point(101, 38);
            this.btnAtack1.Name = "btnAtack1";
            this.btnAtack1.Size = new System.Drawing.Size(92, 29);
            this.btnAtack1.TabIndex = 2;
            this.btnAtack1.UseVisualStyleBackColor = true;
            // 
            // btnAtack4
            // 
            this.btnAtack4.Location = new System.Drawing.Point(3, 38);
            this.btnAtack4.Name = "btnAtack4";
            this.btnAtack4.Size = new System.Drawing.Size(92, 29);
            this.btnAtack4.TabIndex = 3;
            this.btnAtack4.UseVisualStyleBackColor = true;
            // 
            // btnAtack3
            // 
            this.btnAtack3.Location = new System.Drawing.Point(101, 3);
            this.btnAtack3.Name = "btnAtack3";
            this.btnAtack3.Size = new System.Drawing.Size(92, 29);
            this.btnAtack3.TabIndex = 4;
            this.btnAtack3.UseVisualStyleBackColor = true;
            // 
            // btnAtack2
            // 
            this.btnAtack2.Location = new System.Drawing.Point(3, 3);
            this.btnAtack2.Name = "btnAtack2";
            this.btnAtack2.Size = new System.Drawing.Size(92, 29);
            this.btnAtack2.TabIndex = 5;
            this.btnAtack2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exp";
            // 
            // nhp
            // 
            this.nhp.AutoSize = true;
            this.nhp.Location = new System.Drawing.Point(218, 9);
            this.nhp.Name = "nhp";
            this.nhp.Size = new System.Drawing.Size(0, 13);
            this.nhp.TabIndex = 2;
            // 
            // varhp
            // 
            this.varhp.BackColor = System.Drawing.Color.SpringGreen;
            this.varhp.Location = new System.Drawing.Point(42, 14);
            this.varhp.Name = "varhp";
            this.varhp.Size = new System.Drawing.Size(170, 8);
            this.varhp.TabIndex = 3;
            // 
            // varex
            // 
            this.varex.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.varex.Location = new System.Drawing.Point(42, 35);
            this.varex.Name = "varex";
            this.varex.Size = new System.Drawing.Size(162, 10);
            this.varex.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAtack2);
            this.flowLayoutPanel1.Controls.Add(this.btnAtack3);
            this.flowLayoutPanel1.Controls.Add(this.btnAtack4);
            this.flowLayoutPanel1.Controls.Add(this.btnAtack1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 350);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 74);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // varendex
            // 
            this.varendex.BackColor = System.Drawing.SystemColors.GrayText;
            this.varendex.Location = new System.Drawing.Point(210, 35);
            this.varendex.Name = "varendex";
            this.varendex.Size = new System.Drawing.Size(10, 10);
            this.varendex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Level : ";
            // 
            // nlevel
            // 
            this.nlevel.Location = new System.Drawing.Point(220, 266);
            this.nlevel.Name = "nlevel";
            this.nlevel.Size = new System.Drawing.Size(37, 17);
            this.nlevel.TabIndex = 8;
            // 
            // varname
            // 
            this.varname.Location = new System.Drawing.Point(85, 266);
            this.varname.Name = "varname";
            this.varname.Size = new System.Drawing.Size(81, 17);
            this.varname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // BatallaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 419);
            this.Controls.Add(this.varname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nlevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mypokeimage);
            this.Name = "BatallaPokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.BatallaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mypokeimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mypokeimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label varex;
        private System.Windows.Forms.Label varhp;
        private System.Windows.Forms.Label nhp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtack1;
        private System.Windows.Forms.Button btnAtack4;
        private System.Windows.Forms.Button btnAtack3;
        private System.Windows.Forms.Button btnAtack2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label varendex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nlevel;
        private System.Windows.Forms.Label varname;
        private System.Windows.Forms.Label label5;
    }
}