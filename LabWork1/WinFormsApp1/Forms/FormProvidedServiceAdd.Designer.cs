namespace LabWork1.Forms
{
    partial class FormProvidedServiceAdd 
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxDeal;
        private ComboBox comboBoxService;
        private NumericUpDown numericUpDownQuantity;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxDeal = new ComboBox();
            comboBoxService = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();

            // comboBoxDeal
            comboBoxDeal.Location = new Point(100, 20);
            comboBoxDeal.Name = "comboBoxDeal";
            comboBoxDeal.Size = new Size(200, 28);
            comboBoxDeal.TabIndex = 1;

            // comboBoxService
            comboBoxService.Location = new Point(100, 60);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(200, 28);
            comboBoxService.TabIndex = 3;

            // numericUpDownQuantity
            numericUpDownQuantity.Location = new Point(100, 100);
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(200, 27);
            numericUpDownQuantity.TabIndex = 5;

            // ButtonSave
            ButtonSave.Location = new Point(50, 150);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(100, 40);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;

            // ButtonCancel
            ButtonCancel.Location = new Point(180, 150);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(100, 40);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;

            // FormProvidedServiceAdd
            ClientSize = new Size(350, 230);
            Controls.Add(comboBoxDeal);
            Controls.Add(comboBoxService);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCancel);
            Name = "FormProvidedServiceAdd";
            Text = "Добавить услугу";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
        }
    }
}