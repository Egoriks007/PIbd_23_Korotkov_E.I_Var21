using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabWork1.Entities;
using LabWork1.Repositories;

namespace LabWork1.Forms
{
    public partial class FormServiceEdit : Form
    {
        private readonly IServiceRepository _serviceRepository;
        private int? _serviceId;

        public int Id
        {
            set
            {
                try
                {
                    var service = _serviceRepository.ReadServiceById(value);
                    if (service == null) throw new InvalidDataException(nameof(service));

                    textBoxName.Text = service.Name;
                    numericUpDownCost.Value = service.Cost;
                    _serviceId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public FormServiceEdit(IServiceRepository serviceRepository)
        {
            InitializeComponent();
            _serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text)) throw new Exception("Имеются незаполненные поля");

                var service = Service.CreateEntity(_serviceId ?? 0, textBoxName.Text, numericUpDownCost.Value);

                if (_serviceId.HasValue) _serviceRepository.UpdateService(service);
                else _serviceRepository.CreateService(service);

                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}