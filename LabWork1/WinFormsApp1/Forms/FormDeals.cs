using LabWork1.Repositories;
using Unity;

namespace LabWork1.Forms
{
    public partial class FormDeals : Form
    {
        private readonly IUnityContainer _container;
        private readonly IDealRepository _dealRepository;

        public FormDeals(IUnityContainer container, IDealRepository dealRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _dealRepository = dealRepository ?? throw new ArgumentNullException(nameof(dealRepository));
        }

        private void FormDeals_Load(object sender, EventArgs e) => LoadList();

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try { _container.Resolve<FormDealAdd>().ShowDialog(); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // МЕТОД Изменить
        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try
            {
                var form = _container.Resolve<FormDealAdd>();
                form.Id = findId; // Передаем ID в форму
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // МЕТОД Удалить
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try { _dealRepository.DeleteDeal(findId); LoadList(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadList() => dataGridViewData.DataSource = _dealRepository.ReadDeals();

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