using Desafio_Bodega_Eva.Estructuras;
using Desafio_Bodega_Eva.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desafio_Bodega_Eva.Formularios
{
    // Formulario para registrar, buscar y visualizar
    // las boletas almacenadas en el Árbol Binario de Búsqueda.
    public class FormBoletas : Form
    {
        private ArbolBoleta arbolBoletas;

        private TextBox txtCodigo;
        private TextBox txtCliente;
        private TextBox txtProductos;
        private TextBox txtTotal;

        private CheckBox chkFiado;

        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnMostrar;

        private ListBox lstBoletas;
        private Label lblCantidad;

        // Constructor del formulario.
        public FormBoletas()
        {
            arbolBoletas = new ArbolBoleta();

            InicializarFormulario();
        }

        // Configura los controles visuales del formulario.
        private void InicializarFormulario()
        {
            Text = "BOLETAS Y FIADOS";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(900, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "GESTIÓN DE BOLETAS Y FIADOS";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 20);

            Label lblCodigo = CrearEtiqueta("Código:", 30, 80);
            Label lblCliente = CrearEtiqueta("Cliente:", 30, 125);
            Label lblProductos = CrearEtiqueta("Productos:", 30, 170);
            Label lblTotal = CrearEtiqueta("Total:", 30, 215);

            txtCodigo = CrearTexto(150, 77);
            txtCliente = CrearTexto(150, 122);
            txtProductos = CrearTexto(150, 167);
            txtTotal = CrearTexto(150, 212);

            chkFiado = new CheckBox();
            chkFiado.Text = "Registrar como fiado";
            chkFiado.AutoSize = true;
            chkFiado.Location = new Point(150, 255);

            btnRegistrar = new Button();
            btnRegistrar.Text = "REGISTRAR BOLETA";
            btnRegistrar.Size = new Size(170, 40);
            btnRegistrar.Location = new Point(30, 305);
            btnRegistrar.Click += BtnRegistrar_Click;

            btnBuscar = new Button();
            btnBuscar.Text = "BUSCAR POR CÓDIGO";
            btnBuscar.Size = new Size(170, 40);
            btnBuscar.Location = new Point(210, 305);
            btnBuscar.Click += BtnBuscar_Click;

            btnMostrar = new Button();
            btnMostrar.Text = "MOSTRAR ORDENADAS";
            btnMostrar.Size = new Size(170, 40);
            btnMostrar.Location = new Point(390, 305);
            btnMostrar.Click += BtnMostrar_Click;

            lstBoletas = new ListBox();
            lstBoletas.Location = new Point(400, 80);
            lstBoletas.Size = new Size(460, 200);

            lblCantidad = new Label();
            lblCantidad.Text = "Boletas registradas: 0";
            lblCantidad.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(400, 290);

            Controls.Add(lblTitulo);

            Controls.Add(lblCodigo);
            Controls.Add(lblCliente);
            Controls.Add(lblProductos);
            Controls.Add(lblTotal);

            Controls.Add(txtCodigo);
            Controls.Add(txtCliente);
            Controls.Add(txtProductos);
            Controls.Add(txtTotal);

            Controls.Add(chkFiado);

            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrar);

            Controls.Add(lstBoletas);
            Controls.Add(lblCantidad);
        }

        // Crea una etiqueta para el formulario.
        private Label CrearEtiqueta(string texto, int x, int y)
        {
            Label etiqueta = new Label();
            etiqueta.Text = texto;
            etiqueta.AutoSize = true;
            etiqueta.Location = new Point(x, y);

            return etiqueta;
        }

        // Crea una caja de texto para el formulario.
        private TextBox CrearTexto(int x, int y)
        {
            TextBox texto = new TextBox();
            texto.Size = new Size(220, 25);
            texto.Location = new Point(x, y);

            return texto;
        }

        // Registra una nueva boleta en el árbol.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Ingrese el código de la boleta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtProductos.Text))
            {
                MessageBox.Show(
                    "Complete los datos del cliente y productos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtTotal.Text, out decimal total))
            {
                MessageBox.Show(
                    "Ingrese un total válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (arbolBoletas.Buscar(txtCodigo.Text) != null)
            {
                MessageBox.Show(
                    "Ya existe una boleta con ese código.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Boleta nuevaBoleta = new Boleta(
                txtCodigo.Text,
                txtCliente.Text,
                txtProductos.Text,
                total,
                chkFiado.Checked);

            bool registrada = arbolBoletas.Insertar(nuevaBoleta);

            if (registrada)
            {
                ActualizarLista();
                LimpiarCampos();

                MessageBox.Show(
                    "Boleta registrada correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Busca una boleta mediante su código.
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Ingrese un código para realizar la búsqueda.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Boleta boleta = arbolBoletas.Buscar(txtCodigo.Text);

            if (boleta == null)
            {
                MessageBox.Show(
                    "No se encontró una boleta con ese código.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                $"Boleta encontrada:\n\n{boleta}",
                "Resultado de búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Muestra las boletas mediante un recorrido Inorden.
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            ActualizarLista();

            if (arbolBoletas.EstaVacio())
            {
                MessageBox.Show(
                    "No hay boletas registradas.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Actualiza la lista visual de boletas.
        private void ActualizarLista()
        {
            lstBoletas.Items.Clear();

            if (!arbolBoletas.EstaVacio())
            {
                string[] boletas =
                    arbolBoletas.MostrarInorden()
                    .Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (string boleta in boletas)
                {
                    lstBoletas.Items.Add(boleta);
                }
            }

            lblCantidad.Text =
                $"Boletas registradas: {arbolBoletas.Contar()}";
        }

        // Limpia los campos del formulario.
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCliente.Clear();
            txtProductos.Clear();
            txtTotal.Clear();
            chkFiado.Checked = false;

            txtCodigo.Focus();
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa el formulario Windows Forms utilizado para
 * interactuar con el Árbol Binario de Búsqueda de boletas.
 *
 * El formulario permite registrar nuevas boletas, realizar búsquedas
 * mediante el código identificador y mostrar los registros utilizando
 * un recorrido Inorden del árbol.
 *
 * También permite identificar si una operación corresponde a un registro
 * de fiado mediante la opción "Registrar como fiado".
 *
 * La interfaz se conecta directamente con ArbolBoleta.cs, que administra
 * la estructura del árbol, y con Boleta.cs, que representa los datos
 * almacenados en cada nodo.
 *
 * Se incorporaron validaciones para evitar códigos repetidos, datos
 * incompletos y valores monetarios inválidos.
 *
 * La implementación permite visualizar desde la interfaz el funcionamiento
 * práctico de la estructura de datos seleccionada para las consultas
 * de boletas y fiados del proyecto.
 *
 * Aporte: Usuario 2 - Implementación del formulario para gestionar
 * el Árbol Binario de Búsqueda de Boletas.
 */