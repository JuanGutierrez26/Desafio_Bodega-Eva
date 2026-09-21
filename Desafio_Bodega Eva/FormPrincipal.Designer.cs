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
            btnOperaciones = new Button();
            btnBoletas = new Button();
            btnGrafo = new Button();
            btnSalir = new Button();
            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(278, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(76, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BODEGA EVA";

            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(264, 85);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(120, 30);
            btnPedidos.TabIndex = 1;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;

            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(264, 125);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(120, 30);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;

            // 
            // btnOperaciones
            // 
            btnOperaciones.Location = new Point(264, 165);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(120, 30);
            btnOperaciones.TabIndex = 3;
            btnOperaciones.Text = "Operaciones";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;

            // 
            // btnBoletas
            // 
            btnBoletas.Location = new Point(264, 205);
            btnBoletas.Name = "btnBoletas";
            btnBoletas.Size = new Size(120, 30);
            btnBoletas.TabIndex = 4;
            btnBoletas.Text = "Boletas";
            btnBoletas.UseVisualStyleBackColor = true;
            btnBoletas.Click += btnBoletas_Click;

            // 
            // btnGrafo
            // 
            btnGrafo.Location = new Point(264, 245);
            btnGrafo.Name = "btnGrafo";
            btnGrafo.Size = new Size(120, 30);
            btnGrafo.TabIndex = 5;
            btnGrafo.Text = "Grafo";
            btnGrafo.UseVisualStyleBackColor = true;
            btnGrafo.Click += btnGrafo_Click;

            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(264, 295);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 30);
            btnSalir.TabIndex = 6;
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
            Controls.Add(btnGrafo);
            Controls.Add(btnBoletas);
            Controls.Add(btnOperaciones);
            Controls.Add(btnVentas);
            Controls.Add(btnPedidos);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Bodega Eva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnPedidos;
        private Button btnVentas;
        private Button btnOperaciones;
        private Button btnBoletas;
        private Button btnGrafo;
        private Button btnSalir;
    }
}