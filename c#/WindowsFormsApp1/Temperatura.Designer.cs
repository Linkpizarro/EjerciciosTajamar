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
            this.SuspendLayout();
            // 
            // mesesList
            // 
            this.mesesList.FormattingEnabled = true;
            this.mesesList.ItemHeight = 27;
            this.mesesList.Location = new System.Drawing.Point(20, 19);
            this.mesesList.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mesesList.Name = "mesesList";
            this.mesesList.Size = new System.Drawing.Size(143, 409);
            this.mesesList.TabIndex = 0;
            this.mesesList.SelectedIndexChanged += new System.EventHandler(this.mesesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 17);
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
            this.label3.Location = new System.Drawing.Point(180, 177);
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
            this.label5.Location = new System.Drawing.Point(189, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Média";
            // 
            // maxima
            // 
            this.maxima.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxima.Location = new System.Drawing.Point(177, 44);
            this.maxima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.maxima.Name = "maxima";
            this.maxima.Size = new System.Drawing.Size(90, 85);
            this.maxima.TabIndex = 2;
            this.maxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minima
            // 
            this.minima.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minima.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minima.Location = new System.Drawing.Point(177, 204);
            this.minima.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minima.Name = "minima";
            this.minima.Size = new System.Drawing.Size(90, 85);
            this.minima.TabIndex = 6;
            this.minima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // media
            // 
            this.media.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.media.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media.Location = new System.Drawing.Point(177, 361);
            this.media.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(90, 85);
            this.media.TabIndex = 7;
            this.media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 469);
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
    }
}