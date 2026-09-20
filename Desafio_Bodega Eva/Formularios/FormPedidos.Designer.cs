namespace Desafio_Bodega_Eva.Formularios
{
    partial class FormPedidos
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
            lblSubtitulo = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            lblProductos = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            txtProductos = new TextBox();
            txtCantidad = new TextBox();
            txtTotal = new TextBox();
            btnRegistrar = new Button();
            lstPedidos = new ListBox();
            lblLista = new Label();
            btnAtender = new Button();
            lblCantidadPedidos = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(155, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(265, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PEDIDOS WHATSAPP";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(200, 83);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(161, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión de pedidos en espera";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(155, 126);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(347, 23);
            txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(43, 129);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente:";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(43, 177);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(64, 15);
            lblProductos.TabIndex = 6;
            lblProductos.Text = "Productos:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(43, 220);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(43, 267);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(156, 174);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(346, 23);
            txtProductos.TabIndex = 10;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(156, 217);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(346, 23);
            txtCantidad.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(155, 259);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(347, 23);
            txtTotal.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(205, 315);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(157, 23);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "REGISTRAR PEDIDO";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstPedidos
            // 
            lstPedidos.FormattingEnabled = true;
            lstPedidos.Location = new Point(28, 388);
            lstPedidos.Name = "lstPedidos";
            lstPedidos.Size = new Size(525, 169);
            lstPedidos.TabIndex = 14;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(28, 360);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(115, 15);
            lblLista.TabIndex = 15;
            lblLista.Text = "PEDIDOS EN ESPERA";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(221, 582);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(140, 23);
            btnAtender.TabIndex = 16;
            btnAtender.Text = "ATENDER SIGUIENTE";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lblCantidadPedidos
            // 
            lblCantidadPedidos.AutoSize = true;
            lblCantidadPedidos.Location = new Point(236, 627);
            lblCantidadPedidos.Name = "lblCantidadPedidos";
            lblCantidadPedidos.Size = new Size(102, 15);
            lblCantidadPedidos.TabIndex = 17;
            lblCantidadPedidos.Text = "Pedidos en cola: 0";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 669);
            Controls.Add(lblCantidadPedidos);
            Controls.Add(btnAtender);
            Controls.Add(lblLista);
            Controls.Add(lstPedidos);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtProductos);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductos);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "FormPedidos";
            Text = "FormPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label lblProductos;
        private Label lblCantidad;
        private Label lblTotal;
        private TextBox txtProductos;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        private Button btnRegistrar;
        private ListBox lstPedidos;
        private Label lblLista;
        private Button btnAtender;
        private Label lblCantidadPedidos;
    }
}