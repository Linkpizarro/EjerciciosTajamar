namespace FormApiBlobToken
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
            this.btn_token = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.text_token = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.list_blob = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_token
            // 
            this.btn_token.BackColor = System.Drawing.Color.LightBlue;
            this.btn_token.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_token.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_token.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_token.Location = new System.Drawing.Point(68, 20);
            this.btn_token.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_token.Name = "btn_token";
            this.btn_token.Size = new System.Drawing.Size(363, 107);
            this.btn_token.TabIndex = 0;
            this.btn_token.Text = "Obtener Clave";
            this.btn_token.UseVisualStyleBackColor = false;
            this.btn_token.Click += new System.EventHandler(this.btn_token_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.LightBlue;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_upload.Location = new System.Drawing.Point(776, 20);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(352, 107);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "Subir Blob";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.LightBlue;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_show.Location = new System.Drawing.Point(65, 294);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(366, 56);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Mostar Blobs";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // text_token
            // 
            this.text_token.BackColor = System.Drawing.SystemColors.HighlightText;
            this.text_token.Location = new System.Drawing.Point(68, 178);
            this.text_token.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_token.Multiline = true;
            this.text_token.Name = "text_token";
            this.text_token.ReadOnly = true;
            this.text_token.Size = new System.Drawing.Size(1058, 65);
            this.text_token.TabIndex = 3;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(580, 294);
            this.img.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(546, 435);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 4;
            this.img.TabStop = false;
            // 
            // list_blob
            // 
            this.list_blob.BackColor = System.Drawing.SystemColors.HighlightText;
            this.list_blob.FormattingEnabled = true;
            this.list_blob.ItemHeight = 22;
            this.list_blob.Location = new System.Drawing.Point(69, 433);
            this.list_blob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_blob.Name = "list_blob";
            this.list_blob.Size = new System.Drawing.Size(361, 290);
            this.list_blob.TabIndex = 5;
            this.list_blob.SelectedIndexChanged += new System.EventHandler(this.list_blob_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clave de Acceso SaS";
            // 
            // dtn_delete
            // 
            this.dtn_delete.BackColor = System.Drawing.Color.LightBlue;
            this.dtn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dtn_delete.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtn_delete.Location = new System.Drawing.Point(65, 378);
            this.dtn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtn_delete.Name = "dtn_delete";
            this.dtn_delete.Size = new System.Drawing.Size(366, 45);
            this.dtn_delete.TabIndex = 7;
            this.dtn_delete.Text = "Eliminar Blob";
            this.dtn_delete.UseVisualStyleBackColor = false;
            this.dtn_delete.Click += new System.EventHandler(this.dtn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.dtn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_blob);
            this.Controls.Add(this.img);
            this.Controls.Add(this.text_token);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.btn_token);
            this.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_token;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox text_token;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ListBox list_blob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dtn_delete;
    }
}

