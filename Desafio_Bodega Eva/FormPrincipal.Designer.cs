namespace Desafio_Bodega_Eva
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnPedidos = new Button();
            btnVentas = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(254, 66);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(76, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BODEGA EVA";
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(376, 130);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(75, 23);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(376, 194);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(75, 23);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(128, 273);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 365);
            Controls.Add(btnSalir);
            Controls.Add(btnVentas);
            Controls.Add(btnPedidos);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnPedidos;
        private Button btnVentas;
        private Button btnSalir;
    }
}
