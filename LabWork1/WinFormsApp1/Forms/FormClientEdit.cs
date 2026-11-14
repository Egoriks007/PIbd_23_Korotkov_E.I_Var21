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
using LabWork1.Entities.Enums;
using LabWork1.Repositories;

namespace LabWork1.Forms
{
    public partial class FormClientEdit : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _clientId;

        public int Id
        {
            set
            {
                try
                {
                    var client = _clientRepository.ReadClientById(value);
                    if (client == null) throw new InvalidDataException(nameof(client));

                    textBoxFullName.Text = client.FullName;
                    textBoxPhone.Text = client.Phone;
                    comboBoxType.SelectedItem = client.Type;
                    _clientId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        public FormClientEdit(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            comboBoxType.DataSource = Enum.GetValues(typeof(ClientType));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text) || comboBoxType.SelectedIndex < 0)
                    throw new Exception("Имеются незаполненные поля");

                var client = Client.CreateEntity(_clientId ?? 0, textBoxFullName.Text, textBoxPhone.Text, (ClientType)comboBoxType.SelectedItem!);

                if (_clientId.HasValue) _clientRepository.UpdateClient(client);
                else _clientRepository.CreateClient(client);

                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}