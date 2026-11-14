using LabWork1.Repositories;
using Unity;

namespace LabWork1.Forms
{
    public partial class FormProvidedServices : Form
    {
        private readonly IUnityContainer _container;
        private readonly IProvidedServiceRepository _providedServiceRepository;

        public FormProvidedServices(IUnityContainer container, IProvidedServiceRepository providedServiceRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _providedServiceRepository = providedServiceRepository ?? throw new ArgumentNullException(nameof(providedServiceRepository));
        }

        private void FormProvidedServices_Load(object sender, EventArgs e) => LoadList();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormProvidedServiceAdd>().ShowDialog(); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try
            {
                var form = _container.Resolve<FormProvidedServiceAdd>();
                form.Id = findId; // Передаем ID в форму редактирования
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                _providedServiceRepository.DeleteProvidedService(findId);
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _providedServiceRepository.ReadProvidedServices();

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}