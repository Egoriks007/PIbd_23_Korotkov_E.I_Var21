using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Forms
{
    public partial class FormProvidedServiceAdd : Form
    {
        private readonly IProvidedServiceRepository _providedServiceRepository;
        private int? _providedServiceId; // Переменная для хранения ID (null, если создаем новую)

        // Свойство для передачи ID из формы списка при редактировании
        public int Id
        {
            set
            {
                try
                {
                    var ps = _providedServiceRepository.ReadProvidedServiceById(value);
                    if (ps == null) throw new InvalidDataException(nameof(ps));

                    comboBoxDeal.SelectedValue = ps.DealId;
                    comboBoxService.SelectedValue = ps.ServiceId;
                    numericUpDownQuantity.Value = ps.Quantity;

                    _providedServiceId = value; // Запоминаем, что мы редактируем
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Конструктор формы, куда IoC-контейнер внедряет репозитории
        public FormProvidedServiceAdd(IDealRepository dealRepository, IServiceRepository serviceRepository, IProvidedServiceRepository providedServiceRepository)
        {
            InitializeComponent();
            _providedServiceRepository = providedServiceRepository ?? throw new ArgumentNullException(nameof(providedServiceRepository));

          
            comboBoxDeal.DataSource = dealRepository.ReadDeals();
            comboBoxDeal.DisplayMember = "Id"; 
            comboBoxDeal.ValueMember = "Id";

            // Заполняем ComboBox с услугами
            comboBoxService.DataSource = serviceRepository.ReadServices();
            comboBoxService.DisplayMember = "Name"; 
            comboBoxService.ValueMember = "Id";     
        }

        // Обработчик кнопки "Сохранить"
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBoxDeal.SelectedIndex < 0 || comboBoxService.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                
                var ps = ProvidedService.CreateElement(
                    _providedServiceId ?? 0,
                    (int)comboBoxDeal.SelectedValue!,
                    (int)comboBoxService.SelectedValue!,
                    Convert.ToInt32(numericUpDownQuantity.Value)
                );

                
                if (_providedServiceId.HasValue)
                {
                    _providedServiceRepository.UpdateProvidedService(ps);
                }
                else
                {
                    _providedServiceRepository.CreateProvidedService(ps);
                }

                Close(); // Закрываем форму после успешного сохранения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки "Отмена"
        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}