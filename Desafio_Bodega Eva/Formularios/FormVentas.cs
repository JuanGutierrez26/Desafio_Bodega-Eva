using Desafio_Bodega_Eva.Estructuras;
using Desafio_Bodega_Eva.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio_Bodega_Eva.Formularios
{
    public partial class FormVentas : Form
    {
        private PilaVentas pilaVentas;
        private int siguienteCodigo = 1;
        public FormVentas()
        {
            InitializeComponent();

            pilaVentas = new PilaVentas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtProductos.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
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

            Venta venta = new Venta(
                siguienteCodigo,
                txtCliente.Text,
                txtProductos.Text,
                cantidad,
                total
            );

            pilaVentas.Apilar(venta);

            siguienteCodigo++;

            MostrarVentas();

            txtCliente.Clear();
            txtProductos.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();

            txtCliente.Focus();
        }

        private void MostrarVentas()
        {
            lstVentas.Items.Clear();

            string ventas = pilaVentas.Mostrar();

            if (pilaVentas.EstaVacia())
            {
                lstVentas.Items.Add("No hay ventas registradas.");
            }
            else
            {
                string[] lista = ventas.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string venta in lista)
                {
                    lstVentas.Items.Add(venta);
                }
            }

            lblCantidadVentas.Text =
                $"Ventas en pila: {pilaVentas.Contar()}";
        }

        private void btnReversar_Click(object sender, EventArgs e)
        {
            if (pilaVentas.EstaVacia())
            {
                MessageBox.Show("No hay ventas para reversar.");
                return;
            }

            Venta ventaReversada = pilaVentas.Desapilar();

            MessageBox.Show(
                $"Venta reversada:\n\n" +
                $"Código: {ventaReversada.Codigo}\n" +
                $"Cliente: {ventaReversada.Cliente}\n" +
                $"Productos: {ventaReversada.Productos}\n" +
                $"Cantidad: {ventaReversada.Cantidad}\n" +
                $"Total: S/ {ventaReversada.Total:F2}"
            );

            MostrarVentas();
        }

    }
}
