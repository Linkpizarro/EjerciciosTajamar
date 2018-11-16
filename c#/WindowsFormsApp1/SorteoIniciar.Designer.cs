namespace WindowsFormsApp1
{
    partial class SorteoIniciar
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
            this.nlab = new System.Windows.Forms.TextBox();
            this.nwin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nlab
            // 
            this.nlab.Location = new System.Drawing.Point(148, 15);
            this.nlab.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.nlab.Multiline = true;
            this.nlab.Name = "nlab";
            this.nlab.Size = new System.Drawing.Size(72, 49);
            this.nlab.TabIndex = 0;
            this.nlab.TextChanged += new System.EventHandler(this.ok_Click);
            this.nlab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nlab_KeyPress);
            // 
            // nwin
            // 
            this.nwin.Location = new System.Drawing.Point(148, 88);
            this.nwin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.nwin.Multiline = true;
            this.nwin.Name = "nwin";
            this.nwin.Size = new System.Drawing.Size(72, 48);
            this.nwin.TabIndex = 1;
            this.nwin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nwin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apuestas";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(48, 170);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(155, 44);
            this.ok.TabIndex = 4;
            this.ok.Text = "Aplicar";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // SorteoIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 226);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nwin);
            this.Controls.Add(this.nlab);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SorteoIniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorteoIniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nlab;
        private System.Windows.Forms.TextBox nwin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok;
    }
}