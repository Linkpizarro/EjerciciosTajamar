namespace WindowsFormsApp1
{
    partial class pruebaConexion
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
            this.button1 = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.TextBox();
            this.col = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(180, 56);
            this.list.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(133, 74);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(59, 20);
            this.value.TabIndex = 2;
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(12, 74);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(104, 20);
            this.col.TabIndex = 3;
            // 
            // pruebaConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 168);
            this.Controls.Add(this.col);
            this.Controls.Add(this.value);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list);
            this.Name = "pruebaConexion";
            this.Text = "pruebaConexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox col;
    }
}