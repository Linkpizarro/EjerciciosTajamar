namespace WindowsFormsApp1
{
    partial class Sorteo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.boleto = new System.Windows.Forms.FlowLayoutPanel();
            this.winners = new System.Windows.Forms.ListBox();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Números Premiados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boleto";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(324, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 52);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Sortear";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // boleto
            // 
            this.boleto.AutoScroll = true;
            this.boleto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.boleto.Location = new System.Drawing.Point(12, 55);
            this.boleto.Name = "boleto";
            this.boleto.Size = new System.Drawing.Size(306, 258);
            this.boleto.TabIndex = 6;
            // 
            // winners
            // 
            this.winners.FormattingEnabled = true;
            this.winners.ItemHeight = 27;
            this.winners.Location = new System.Drawing.Point(434, 66);
            this.winners.Name = "winners";
            this.winners.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.winners.Size = new System.Drawing.Size(153, 247);
            this.winners.TabIndex = 7;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(324, 127);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(104, 52);
            this.create.TabIndex = 9;
            this.create.Text = "Iniciar";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Sorteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 327);
            this.Controls.Add(this.create);
            this.Controls.Add(this.winners);
            this.Controls.Add(this.boleto);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Sorteo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteo";
            this.Load += new System.EventHandler(this.Sorteo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel boleto;
        private System.Windows.Forms.ListBox winners;
        private System.Windows.Forms.Button create;
    }
}