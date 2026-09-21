using Desafio_Bodega_Eva.Estructuras;
using Desafio_Bodega_Eva.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desafio_Bodega_Eva.Formularios
{
    // Formulario para registrar, buscar y visualizar
    // las operaciones almacenadas en la lista enlazada.
    public class FormOperaciones : Form
    {
        private ListaOperaciones listaOperaciones;

        private TextBox txtCodigo;
        private TextBox txtTipo;
        private TextBox txtDescripcion;
        private TextBox txtResponsable;
        private TextBox txtMonto;

        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnMostrar;

        private ListBox lstOperaciones;
        private Label lblCantidad;

        // Constructor del formulario.
        public FormOperaciones()
        {
            listaOperaciones = new ListaOperaciones();

            InicializarFormulario();
        }

        // Configura los controles visuales del formulario.
        private void InicializarFormulario()
        {
            Text = "OPERACIONES DIARIAS";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(900, 600);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "REGISTRO DE OPERACIONES";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 20);

            Label lblCodigo = CrearEtiqueta("Código:", 30, 80);
            Label lblTipo = CrearEtiqueta("Tipo:", 30, 125);
            Label lblDescripcion = CrearEtiqueta("Descripción:", 30, 170);
            Label lblResponsable = CrearEtiqueta("Responsable:", 30, 215);
            Label lblMonto = CrearEtiqueta("Monto:", 30, 260);

            txtCodigo = CrearTexto(150, 77);
            txtTipo = CrearTexto(150, 122);
            txtDescripcion = CrearTexto(150, 167);
            txtResponsable = CrearTexto(150, 212);
            txtMonto = CrearTexto(150, 257);

            btnRegistrar = new Button();
            btnRegistrar.Text = "REGISTRAR OPERACIÓN";
            btnRegistrar.Size = new Size(180, 40);
            btnRegistrar.Location = new Point(30, 315);
            btnRegistrar.Click += BtnRegistrar_Click;

            btnBuscar = new Button();
            btnBuscar.Text = "BUSCAR POR CÓDIGO";
            btnBuscar.Size = new Size(180, 40);
            btnBuscar.Location = new Point(220, 315);
            btnBuscar.Click += BtnBuscar_Click;

            btnMostrar = new Button();
            btnMostrar.Text = "MOSTRAR OPERACIONES";
            btnMostrar.Size = new Size(180, 40);
            btnMostrar.Location = new Point(410, 315);
            btnMostrar.Click += BtnMostrar_Click;

            lstOperaciones = new ListBox();
            lstOperaciones.Location = new Point(400, 80);
            lstOperaciones.Size = new Size(460, 210);

            lblCantidad = new Label();
            lblCantidad.Text = "Operaciones registradas: 0";
            lblCantidad.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(400, 365);

            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(lblTipo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblResponsable);
            Controls.Add(lblMonto);

            Controls.Add(txtCodigo);
            Controls.Add(txtTipo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtResponsable);
            Controls.Add(txtMonto);

            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrar);

            Controls.Add(lstOperaciones);
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

        // Registra una nueva operación en la lista enlazada.
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show(
                    "Ingrese un código numérico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show(
                    "Ingrese un monto válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (listaOperaciones.Buscar(codigo) != null)
            {
                MessageBox.Show(
                    "Ya existe una operación con ese código.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Operacion nuevaOperacion = new Operacion(
                codigo,
                txtTipo.Text,
                txtDescripcion.Text,
                txtResponsable.Text,
                monto);

            listaOperaciones.Agregar(nuevaOperacion);

            ActualizarLista();

            LimpiarCampos();

            MessageBox.Show(
                "Operación registrada correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Busca una operación mediante su código.
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show(
                    "Ingrese un código válido para realizar la búsqueda.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Operacion operacion = listaOperaciones.Buscar(codigo);

            if (operacion == null)
            {
                MessageBox.Show(
                    "No se encontró una operación con ese código.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                $"Operación encontrada:\n\n{operacion}",
                "Resultado de búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Muestra todas las operaciones registradas.
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            ActualizarLista();

            if (listaOperaciones.EstaVacia())
            {
                MessageBox.Show(
                    "No hay operaciones registradas.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Actualiza la lista visual con las operaciones almacenadas.
        private void ActualizarLista()
        {
            lstOperaciones.Items.Clear();

            if (!listaOperaciones.EstaVacia())
            {
                string[] operaciones =
                    listaOperaciones.Mostrar()
                    .Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (string operacion in operaciones)
                {
                    lstOperaciones.Items.Add(operacion);
                }
            }

            lblCantidad.Text =
                $"Operaciones registradas: {listaOperaciones.Contar()}";
        }

        // Limpia los campos después de registrar una operación.
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTipo.Clear();
            txtDescripcion.Clear();
            txtResponsable.Clear();
            txtMonto.Clear();

            txtCodigo.Focus();
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa el formulario Windows Forms utilizado para
 * interactuar con la lista enlazada de operaciones de Bodega Eva.
 *
 * El formulario permite registrar nuevas operaciones, buscar una operación
 * mediante su código y visualizar los registros almacenados. Para ello,
 * utiliza la clase ListaOperaciones, que administra internamente los nodos
 * de la lista enlazada.
 *
 * La interfaz fue implementada directamente mediante código para mantener
 * el formulario funcional aun cuando inicialmente no contaba con un
 * diseñador visual configurado. Los controles permiten ingresar los datos
 * de una operación y ejecutar las principales operaciones de la estructura.
 *
 * La validación de datos evita registrar códigos repetidos, valores
 * numéricos inválidos o campos obligatorios vacíos.
 *
 * Este formulario constituye la capa de interacción con el usuario del
 * módulo de Lista Enlazada y conecta la interfaz gráfica con las clases
 * Operacion, NodoLista y ListaOperaciones.
 *
 * Aporte: Usuario 2 - Implementación del formulario para gestionar
 * la Lista Enlazada de Operaciones.
 */