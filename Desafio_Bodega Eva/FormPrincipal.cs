using Desafio_Bodega_Eva.Formularios;

namespace Desafio_Bodega_Eva
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos form = new FormPedidos();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas form = new FormVentas();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
