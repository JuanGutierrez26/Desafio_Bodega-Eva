using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Desafio_Bodega_Eva.Estructuras;
using Desafio_Bodega_Eva.Modelos;

namespace Desafio_Bodega_Eva.Formularios
{
    public partial class FormPedidos : Form
    {
        private ColaPedidos colaPedidos;
        private int siguienteCodigo = 1;
        public FormPedidos()
        {
            InitializeComponent();
            colaPedidos = new ColaPedidos();
        }
        private void MostrarPedidos()
        {
            lstPedidos.Items.Clear();

            string pedidos = colaPedidos.Mostrar();

            if (colaPedidos.EstaVacia())
            {
                lstPedidos.Items.Add("No hay pedidos en espera.");
            }
            else
            {
                string[] lista = pedidos.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string pedido in lista)
                {
                    lstPedidos.Items.Add(pedido);
                }
            }

            lblCantidadPedidos.Text =
                $"Pedidos en cola: {colaPedidos.Contar()}";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtProductos.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número.");
                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show("El total debe ser un número válido.");
                return;
            }

            Pedido pedido = new Pedido(
                siguienteCodigo,
                txtCliente.Text,
                txtProductos.Text,
                cantidad,
                total
            );

            colaPedidos.Encolar(pedido);

            siguienteCodigo++;

            MostrarPedidos();

            txtCliente.Clear();
            txtProductos.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();

            txtCliente.Focus();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (colaPedidos.EstaVacia())
            {
                MessageBox.Show("No hay pedidos para atender.");
                return;
            }

            Pedido pedidoAtendido = colaPedidos.Desencolar();

            MessageBox.Show(
                $"Pedido atendido:\n\n" +
                $"Código: {pedidoAtendido.Codigo}\n" +
                $"Cliente: {pedidoAtendido.Cliente}\n" +
                $"Productos: {pedidoAtendido.Productos}\n" +
                $"Cantidad: {pedidoAtendido.Cantidad}\n" +
                $"Total: S/ {pedidoAtendido.Total:F2}"
            );

            MostrarPedidos();
        }
    }
}
