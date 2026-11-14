using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Forms
{
    public partial class FormDealAdd : Form
    {
        private readonly IDealRepository _dealRepository;
        private readonly IProvidedServiceRepository _providedServiceRepository;
        private int? _dealId; 

        // Свойство для приема ID при редактировании
        public int Id
        {
            set
            {
                try
                {
                    var deal = _dealRepository.ReadDealById(value);
                    if (deal == null) throw new InvalidDataException(nameof(deal));

                    comboBoxClient.SelectedValue = deal.ClientId;
                    comboBoxApartment.SelectedValue = deal.ApartmentId;
                    _dealId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public FormDealAdd(IClientRepository clientRepository, IApartmentRepository apartmentRepository,
            IServiceRepository serviceRepository, IDealRepository dealRepository, IProvidedServiceRepository providedServiceRepository)
        {
            InitializeComponent();
            _dealRepository = dealRepository ?? throw new ArgumentNullException(nameof(dealRepository));
            _providedServiceRepository = providedServiceRepository ?? throw new ArgumentNullException(nameof(providedServiceRepository));

            comboBoxClient.DataSource = clientRepository.ReadClients();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxApartment.DataSource = apartmentRepository.ReadApartments();
            comboBoxApartment.DisplayMember = "Address";
            comboBoxApartment.ValueMember = "Id";

            var services = serviceRepository.ReadServices().ToList();
            ColumnService.DataSource = services;
            ColumnService.DisplayMember = "Name";
            ColumnService.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedIndex < 0 || comboBoxApartment.SelectedIndex < 0)
                    throw new Exception("Имеются незаполненные поля");

                var deal = Deal.CreateOperation(_dealId ?? 0, (int)comboBoxClient.SelectedValue!, (int)comboBoxApartment.SelectedValue!, 0);

                // Проверяем: создаем новую или обновляем существующую
                if (_dealId.HasValue) _dealRepository.UpdateDeal(deal);
                else _dealRepository.CreateDeal(deal);

                
                foreach (DataGridViewRow row in dataGridViewServices.Rows)
                {
                    if (row.Cells["ColumnService"].Value == null || row.Cells["ColumnCount"].Value == null) continue;

                    var ps = ProvidedService.CreateElement(0, deal.Id, (int)row.Cells["ColumnService"].Value, Convert.ToInt32(row.Cells["ColumnCount"].Value));
                    _providedServiceRepository.CreateProvidedService(ps);
                }
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}