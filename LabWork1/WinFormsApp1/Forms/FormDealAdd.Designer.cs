namespace LabWork1.Forms
{
    partial class FormDealAdd
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxClient;
        private ComboBox comboBoxApartment;
        private DataGridView dataGridViewServices;
        private DataGridViewComboBoxColumn ColumnService;
        private DataGridViewTextBoxColumn ColumnCount;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxClient = new ComboBox();
            comboBoxApartment = new ComboBox();
            dataGridViewServices = new DataGridView();
            ColumnService = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();

            // comboBoxClient
            comboBoxClient.Location = new Point(100, 20);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(200, 28);
            comboBoxClient.TabIndex = 1;

            // comboBoxApartment
            comboBoxApartment.Location = new Point(100, 60);
            comboBoxApartment.Name = "comboBoxApartment";
            comboBoxApartment.Size = new Size(200, 28);
            comboBoxApartment.TabIndex = 3;

            // dataGridViewServices
            dataGridViewServices.ColumnHeadersHeight = 29;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { ColumnService, ColumnCount });
            dataGridViewServices.Location = new Point(20, 100);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(400, 150);
            dataGridViewServices.TabIndex = 4;

            // ColumnService
            ColumnService.HeaderText = "Услуга";
            ColumnService.MinimumWidth = 6;
            ColumnService.Name = "ColumnService";
            ColumnService.Width = 200;

            // ColumnCount
            ColumnCount.HeaderText = "Количество";
            ColumnCount.MinimumWidth = 6;
            ColumnCount.Name = "ColumnCount";

            // ButtonSave
            ButtonSave.Location = new Point(100, 270);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(100, 40);
            ButtonSave.TabIndex = 5;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;

            // ButtonCancel
            ButtonCancel.Location = new Point(230, 270);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(100, 40);
            ButtonCancel.TabIndex = 6;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;

            // FormDealAdd
            ClientSize = new Size(450, 330);
            Controls.Add(comboBoxClient);
            Controls.Add(comboBoxApartment);
            Controls.Add(dataGridViewServices);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCancel);
            Name = "FormDealAdd";
            Text = "Сделка";
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
        }
    }
}