using LabWork1.Entities;
using LabWork1.Entities.Enums;
using LabWork1.Repositories;

namespace LabWork1.Forms
{
    public partial class FormApartmentEdit : Form
    {
        private readonly IApartmentRepository _apartmentRepository;
        private int? _apartmentId;

        public int Id
        {
            set
            {
                try
                {
                    var apartment = _apartmentRepository.ReadApartmentById(value);
                    if (apartment == null) throw new InvalidDataException(nameof(apartment));

                    textBoxAddress.Text = apartment.Address;
                    numericUpDownArea.Value = (decimal)apartment.Area;
                    numericUpDownPrice.Value = apartment.Price;

                    for (int i = 0; i < checkedListBoxRenovation.Items.Count; i++)
                    {
                        var item = (RenovationType)checkedListBoxRenovation.Items[i];
                        if ((item & apartment.Renovation) == item) checkedListBoxRenovation.SetItemChecked(i, true);
                    }
                    _apartmentId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public FormApartmentEdit(IApartmentRepository apartmentRepository)
        {
            InitializeComponent();
            _apartmentRepository = apartmentRepository ?? throw new ArgumentNullException(nameof(apartmentRepository));

            foreach (var item in Enum.GetValues(typeof(RenovationType)))
                checkedListBoxRenovation.Items.Add(item);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text) || checkedListBoxRenovation.CheckedItems.Count == 0)
                    throw new Exception("Имеются незаполненные поля");

                RenovationType renovation = RenovationType.None;
                foreach (var item in checkedListBoxRenovation.CheckedItems)
                    renovation |= (RenovationType)item;

                var apartment = Apartment.CreateEntity(_apartmentId ?? 0, textBoxAddress.Text, (double)numericUpDownArea.Value, numericUpDownPrice.Value, renovation);

                if (_apartmentId.HasValue) _apartmentRepository.UpdateApartment(apartment);
                else _apartmentRepository.CreateApartment(apartment);

                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}