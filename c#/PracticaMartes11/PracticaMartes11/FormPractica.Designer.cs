namespace PracticaMartes11
{
    partial class FormPractica
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
            this.cmbclientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstpedidos = new System.Windows.Forms.ListBox();
            this.txtfechaentrega = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtformaenvio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.btnnuevopedido = new System.Windows.Forms.Button();
            this.btnmodificarcliente = new System.Windows.Forms.Button();
            this.btneliminarpedido = new System.Windows.Forms.Button();
            this.txtcodigopedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // cmbclientes
            // 
            this.cmbclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclientes.FormattingEnabled = true;
            this.cmbclientes.Location = new System.Drawing.Point(17, 40);
            this.cmbclientes.Name = "cmbclientes";
            this.cmbclientes.Size = new System.Drawing.Size(168, 32);
            this.cmbclientes.TabIndex = 1;
            this.cmbclientes.SelectedIndexChanged += new System.EventHandler(this.cmbclientes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(224, 40);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(125, 29);
            this.txtempresa.TabIndex = 3;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(224, 118);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(166, 29);
            this.txtcontacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contacto";
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(224, 194);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(166, 29);
            this.txtcargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(224, 274);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(166, 29);
            this.txtciudad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(223, 342);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(167, 29);
            this.txttelefono.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pedidos";
            // 
            // lstpedidos
            // 
            this.lstpedidos.FormattingEnabled = true;
            this.lstpedidos.ItemHeight = 24;
            this.lstpedidos.Location = new System.Drawing.Point(443, 40);
            this.lstpedidos.Name = "lstpedidos";
            this.lstpedidos.Size = new System.Drawing.Size(223, 340);
            this.lstpedidos.TabIndex = 15;
            this.lstpedidos.SelectedIndexChanged += new System.EventHandler(this.lstpedidos_SelectedIndexChanged);
            // 
            // txtfechaentrega
            // 
            this.txtfechaentrega.Location = new System.Drawing.Point(713, 117);
            this.txtfechaentrega.Name = "txtfechaentrega";
            this.txtfechaentrega.Size = new System.Drawing.Size(167, 29);
            this.txtfechaentrega.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(709, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha entrega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Forma de envío";
            // 
            // txtformaenvio
            // 
            this.txtformaenvio.Location = new System.Drawing.Point(713, 202);
            this.txtformaenvio.Name = "txtformaenvio";
            this.txtformaenvio.Size = new System.Drawing.Size(167, 29);
            this.txtformaenvio.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(713, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(713, 282);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(167, 29);
            this.txtimporte.TabIndex = 23;
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnnuevopedido
            // 
            this.btnnuevopedido.Location = new System.Drawing.Point(713, 342);
            this.btnnuevopedido.Name = "btnnuevopedido";
            this.btnnuevopedido.Size = new System.Drawing.Size(167, 43);
            this.btnnuevopedido.TabIndex = 24;
            this.btnnuevopedido.Text = "Nuevo pedido";
            this.btnnuevopedido.UseVisualStyleBackColor = true;
            this.btnnuevopedido.Click += new System.EventHandler(this.btnnuevopedido_Click);
            // 
            // btnmodificarcliente
            // 
            this.btnmodificarcliente.Location = new System.Drawing.Point(17, 237);
            this.btnmodificarcliente.Name = "btnmodificarcliente";
            this.btnmodificarcliente.Size = new System.Drawing.Size(168, 43);
            this.btnmodificarcliente.TabIndex = 25;
            this.btnmodificarcliente.Text = "Modificar cliente";
            this.btnmodificarcliente.UseVisualStyleBackColor = true;
            this.btnmodificarcliente.Click += new System.EventHandler(this.btnmodificarcliente_Click);
            // 
            // btneliminarpedido
            // 
            this.btneliminarpedido.Location = new System.Drawing.Point(713, 401);
            this.btneliminarpedido.Name = "btneliminarpedido";
            this.btneliminarpedido.Size = new System.Drawing.Size(167, 39);
            this.btneliminarpedido.TabIndex = 26;
            this.btneliminarpedido.Text = "Eliminar pedido";
            this.btneliminarpedido.UseVisualStyleBackColor = true;
            this.btneliminarpedido.Click += new System.EventHandler(this.btneliminarpedido_Click);
            // 
            // txtcodigopedido
            // 
            this.txtcodigopedido.Location = new System.Drawing.Point(713, 43);
            this.txtcodigopedido.Name = "txtcodigopedido";
            this.txtcodigopedido.Size = new System.Drawing.Size(167, 29);
            this.txtcodigopedido.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(709, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Código pedido";
            // 
            // FormPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 455);
            this.Controls.Add(this.txtcodigopedido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btneliminarpedido);
            this.Controls.Add(this.btnmodificarcliente);
            this.Controls.Add(this.btnnuevopedido);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtformaenvio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtfechaentrega);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstpedidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtempresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbclientes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormPractica";
            this.Text = "Clientes pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbclientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstpedidos;
        private System.Windows.Forms.TextBox txtfechaentrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtformaenvio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Button btnnuevopedido;
        private System.Windows.Forms.Button btnmodificarcliente;
        private System.Windows.Forms.Button btneliminarpedido;
        private System.Windows.Forms.TextBox txtcodigopedido;
        private System.Windows.Forms.Label label9;
    }
}

