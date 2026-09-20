namespace Desafio_Bodega_Eva.Formularios
{
    partial class FormVentas
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
            lblTitulo = new Label();
            lblCliente = new Label();
            lblProductos = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            lblLista = new Label();
            lblCantidadVentas = new Label();
            txtCliente = new TextBox();
            txtProductos = new TextBox();
            txtCantidad = new TextBox();
            txtTotal = new TextBox();
            btnRegistrar = new Button();
            btnReversar = new Button();
            lstVentas = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(241, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(122, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE VENTAS";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(40, 115);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(40, 155);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(64, 15);
            lblProductos.TabIndex = 2;
            lblProductos.Text = "Productos:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(40, 191);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(43, 226);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(40, 367);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(126, 15);
            lblLista.TabIndex = 6;
            lblLista.Text = "VENTAS REGISTRADAS";
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.Location = new Point(272, 632);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(91, 15);
            lblCantidadVentas.TabIndex = 7;
            lblCantidadVentas.Text = "Ventas en pila: 0";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(192, 111);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(365, 23);
            txtCliente.TabIndex = 8;
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(190, 147);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(367, 23);
            txtProductos.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(190, 183);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(367, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(190, 223);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(367, 23);
            txtTotal.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(241, 290);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 23);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "REGISTRAR VENTA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnReversar
            // 
            btnReversar.Location = new Point(229, 591);
            btnReversar.Name = "btnReversar";
            btnReversar.Size = new Size(171, 23);
            btnReversar.TabIndex = 13;
            btnReversar.Text = "REVERSAR ÚLTIMA VENTA";
            btnReversar.UseVisualStyleBackColor = true;
            btnReversar.Click += btnReversar_Click;
            // 
            // lstVentas
            // 
            lstVentas.FormattingEnabled = true;
            lstVentas.Location = new Point(40, 400);
            lstVentas.Name = "lstVentas";
            lstVentas.Size = new Size(536, 154);
            lstVentas.TabIndex = 14;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 667);
            Controls.Add(lstVentas);
            Controls.Add(btnReversar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtProductos);
            Controls.Add(txtCliente);
            Controls.Add(lblCantidadVentas);
            Controls.Add(lblLista);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductos);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            Name = "FormVentas";
            Text = "FormVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCliente;
        private Label lblProductos;
        private Label lblCantidad;
        private Label lblTotal;
        private Label lblLista;
        private Label lblCantidadVentas;
        private TextBox txtCliente;
        private TextBox txtProductos;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        private Button btnRegistrar;
        private Button btnReversar;
        private ListBox lstVentas;
    }
}