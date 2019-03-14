namespace FileAzureForm
{
    partial class Form1
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
            this.btnread = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(241, 22);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(282, 63);
            this.btnread.TabIndex = 0;
            this.btnread.Text = "Leer Azure";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(31, 127);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt.Size = new System.Drawing.Size(712, 281);
            this.txt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.TextBox txt;
    }
}

