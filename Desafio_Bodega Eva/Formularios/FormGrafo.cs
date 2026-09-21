using Desafio_Bodega_Eva.Estructuras;
using Desafio_Bodega_Eva.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desafio_Bodega_Eva.Formularios
{
    // Formulario para gestionar y visualizar el grafo
    // de agentes y puntos de respaldo de Bodega Eva.
    public class FormGrafo : Form
    {
        private GrafoAgente grafo;

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtUbicacion;

        private CheckBox chkDisponible;

        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtDistancia;

        private Button btnAgregarAgente;
        private Button btnConectar;
        private Button btnBuscarCercano;
        private Button btnMostrar;

        private ListBox lstResultado;
        private Label lblCantidad;

        // Constructor del formulario.
        public FormGrafo()
        {
            grafo = new GrafoAgente();

            InicializarFormulario();
        }

        // Configura los controles visuales del formulario.
        private void InicializarFormulario()
        {
            Text = "GRAFO DE AGENTES";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(950, 650);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Label lblTitulo = new Label();
            lblTitulo.Text = "GESTIÓN DE AGENTES Y CONEXIONES";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 20);

            Label lblSubtituloAgente = new Label();
            lblSubtituloAgente.Text = "REGISTRAR AGENTE";
            lblSubtituloAgente.Font = new Font(
                "Segoe UI",
                11,
                FontStyle.Bold);
            lblSubtituloAgente.AutoSize = true;
            lblSubtituloAgente.Location = new Point(30, 65);

            Label lblCodigo = CrearEtiqueta("Código:", 30, 105);
            Label lblNombre = CrearEtiqueta("Nombre:", 30, 145);
            Label lblUbicacion = CrearEtiqueta("Ubicación:", 30, 185);

            txtCodigo = CrearTexto(130, 102);
            txtNombre = CrearTexto(130, 142);
            txtUbicacion = CrearTexto(130, 182);

            chkDisponible = new CheckBox();
            chkDisponible.Text = "Agente disponible";
            chkDisponible.AutoSize = true;
            chkDisponible.Checked = true;
            chkDisponible.Location = new Point(130, 220);

            btnAgregarAgente = new Button();
            btnAgregarAgente.Text = "AGREGAR AGENTE";
            btnAgregarAgente.Size = new Size(170, 40);
            btnAgregarAgente.Location = new Point(30, 255);
            btnAgregarAgente.Click += BtnAgregarAgente_Click;

            Label lblSubtituloConexion = new Label();
            lblSubtituloConexion.Text = "CREAR CONEXIÓN";
            lblSubtituloConexion.Font = new Font(
                "Segoe UI",
                11,
                FontStyle.Bold);
            lblSubtituloConexion.AutoSize = true;
            lblSubtituloConexion.Location = new Point(30, 320);

            Label lblOrigen = CrearEtiqueta("Origen:", 30, 360);
            Label lblDestino = CrearEtiqueta("Destino:", 30, 400);
            Label lblDistancia = CrearEtiqueta("Distancia km:", 30, 440);

            txtOrigen = CrearTexto(130, 357);
            txtDestino = CrearTexto(130, 397);
            txtDistancia = CrearTexto(130, 437);

            btnConectar = new Button();
            btnConectar.Text = "CONECTAR AGENTES";
            btnConectar.Size = new Size(170, 40);
            btnConectar.Location = new Point(30, 475);
            btnConectar.Click += BtnConectar_Click;

            btnBuscarCercano = new Button();
            btnBuscarCercano.Text = "BUSCAR MÁS CERCANO";
            btnBuscarCercano.Size = new Size(190, 40);
            btnBuscarCercano.Location = new Point(220, 475);
            btnBuscarCercano.Click += BtnBuscarCercano_Click;

            btnMostrar = new Button();
            btnMostrar.Text = "MOSTRAR GRAFO";
            btnMostrar.Size = new Size(160, 40);
            btnMostrar.Location = new Point(430, 475);
            btnMostrar.Click += BtnMostrar_Click;

            lstResultado = new ListBox();
            lstResultado.Location = new Point(400, 105);
            lstResultado.Size = new Size(500, 340);

            lblCantidad = new Label();
            lblCantidad.Text = "Agentes registrados: 0";
            lblCantidad.Font = new Font(
                "Segoe UI",
                10,
                FontStyle.Bold);
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(400, 75);

            Controls.Add(lblTitulo);
            Controls.Add(lblSubtituloAgente);

            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblUbicacion);

            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(txtUbicacion);

            Controls.Add(chkDisponible);

            Controls.Add(btnAgregarAgente);

            Controls.Add(lblSubtituloConexion);
            Controls.Add(lblOrigen);
            Controls.Add(lblDestino);
            Controls.Add(lblDistancia);

            Controls.Add(txtOrigen);
            Controls.Add(txtDestino);
            Controls.Add(txtDistancia);

            Controls.Add(btnConectar);
            Controls.Add(btnBuscarCercano);
            Controls.Add(btnMostrar);

            Controls.Add(lstResultado);
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

        // Agrega un nuevo agente al grafo.
        private void BtnAgregarAgente_Click(
            object sender,
            EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show(
                    "Complete el nombre y la ubicación del agente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Agente nuevoAgente = new Agente(
                codigo,
                txtNombre.Text,
                txtUbicacion.Text,
                chkDisponible.Checked);

            if (!grafo.AgregarAgente(nuevoAgente))
            {
                MessageBox.Show(
                    "No se pudo agregar el agente. " +
                    "Verifique que el código no esté repetido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ActualizarResultado();
            LimpiarCamposAgente();

            MessageBox.Show(
                "Agente agregado correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Crea una conexión entre dos agentes.
        private void BtnConectar_Click(
            object sender,
            EventArgs e)
        {
            if (!int.TryParse(
                txtOrigen.Text,
                out int origen))
            {
                MessageBox.Show(
                    "Ingrese un código de origen válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtDestino.Text,
                out int destino))
            {
                MessageBox.Show(
                    "Ingrese un código de destino válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!double.TryParse(
                txtDistancia.Text,
                out double distancia))
            {
                MessageBox.Show(
                    "Ingrese una distancia válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (distancia < 0)
            {
                MessageBox.Show(
                    "La distancia no puede ser negativa.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!grafo.Conectar(
                origen,
                destino,
                distancia))
            {
                MessageBox.Show(
                    "No se pudo crear la conexión. " +
                    "Verifique los códigos, la distancia " +
                    "y que la conexión no exista.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ActualizarResultado();

            MessageBox.Show(
                "Conexión creada correctamente.",
                "Conexión exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Busca el agente disponible más cercano.
        private void BtnBuscarCercano_Click(
            object sender,
            EventArgs e)
        {
            if (!int.TryParse(
                txtOrigen.Text,
                out int origen))
            {
                MessageBox.Show(
                    "Ingrese el código del punto de origen.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double distancia;

            Agente agente = grafo.BuscarAgenteMasCercano(
                origen,
                out distancia);

            if (agente == null)
            {
                MessageBox.Show(
                    "No se encontró un agente disponible " +
                    "alcanzable desde el origen indicado.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                $"Agente disponible más cercano:\n\n" +
                $"Código: {agente.Codigo}\n" +
                $"Nombre: {agente.Nombre}\n" +
                $"Ubicación: {agente.Ubicacion}\n" +
                $"Distancia total: {distancia:F1} km",
                "Resultado de búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Muestra todos los agentes y sus conexiones.
        private void BtnMostrar_Click(
            object sender,
            EventArgs e)
        {
            ActualizarResultado();
        }

        // Actualiza la información visual del grafo.
        private void ActualizarResultado()
        {
            lstResultado.Items.Clear();

            if (grafo.EstaVacio())
            {
                lstResultado.Items.Add(
                    "No hay agentes registrados.");
            }
            else
            {
                string[] resultados =
                    grafo.Mostrar()
                    .Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.RemoveEmptyEntries);

                foreach (string resultado in resultados)
                {
                    lstResultado.Items.Add(resultado);
                }
            }

            lblCantidad.Text =
                $"Agentes registrados: {grafo.Contar()}";
        }

        // Limpia los campos correspondientes al agente.
        private void LimpiarCamposAgente()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtUbicacion.Clear();
            chkDisponible.Checked = true;

            txtCodigo.Focus();
        }
    }
}

/*
 * CONTEXTO DE IMPLEMENTACIÓN:
 *
 * Este archivo implementa el formulario Windows Forms utilizado para
 * interactuar con el grafo ponderado de agentes de Bodega Eva.
 *
 * El formulario permite registrar agentes, establecer conexiones entre
 * ellos indicando una distancia en kilómetros, visualizar las conexiones
 * existentes y buscar el agente disponible más cercano desde un punto
 * de origen.
 *
 * La interfaz se conecta directamente con GrafoAgente.cs, que administra
 * los nodos y las conexiones del grafo, y con Agente.cs, que representa
 * la información de cada punto de respaldo.
 *
 * La búsqueda del agente más cercano utiliza las distancias acumuladas
 * de las conexiones y permite demostrar mediante la interfaz el uso del
 * algoritmo de Dijkstra implementado en GrafoAgente.cs.
 *
 * Se incorporaron validaciones para evitar códigos inválidos, datos
 * incompletos, distancias negativas y conexiones incorrectas.
 *
 * Este formulario constituye la capa de interacción con el usuario
 * para demostrar el funcionamiento práctico del Grafo Ponderado
 * planteado en el proyecto.
 *
 * Aporte: Usuario 2 - Implementación del formulario para gestionar
 * el Grafo de Agentes y puntos de respaldo.
 */