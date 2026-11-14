using Unity;
using LabWork1.Forms;

namespace LabWork1
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void ClientsMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormClients>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ApartmentsMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormApartments>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ServicesMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormServices>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DealsMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormDeals>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ProvidedServicesMenuItem_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormProvidedServices>().ShowDialog(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}