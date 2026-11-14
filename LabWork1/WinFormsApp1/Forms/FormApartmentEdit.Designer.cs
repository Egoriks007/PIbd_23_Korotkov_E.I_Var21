namespace LabWork1.Forms
{
    partial class FormApartmentEdit
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxAddress;
        private NumericUpDown numericUpDownArea;
        private NumericUpDown numericUpDownPrice;
        private CheckedListBox checkedListBoxRenovation;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxAddress = new TextBox();
            numericUpDownArea = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            checkedListBoxRenovation = new CheckedListBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(120, 20);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(200, 27);
            textBoxAddress.TabIndex = 1;
            // 
            // numericUpDownArea
            // 
            numericUpDownArea.DecimalPlaces = 1;
            numericUpDownArea.Location = new Point(120, 60);
            numericUpDownArea.Name = "numericUpDownArea";
            numericUpDownArea.Size = new Size(200, 27);
            numericUpDownArea.TabIndex = 3;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(120, 100);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 27);
            numericUpDownPrice.TabIndex = 5;
            // 
            // checkedListBoxRenovation
            // 
            checkedListBoxRenovation.Location = new Point(120, 140);
            checkedListBoxRenovation.Name = "checkedListBoxRenovation";
            checkedListBoxRenovation.Size = new Size(210, 70);
            checkedListBoxRenovation.TabIndex = 7;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(60, 240);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(97, 27);
            ButtonSave.TabIndex = 8;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(200, 240);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(83, 27);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormApartmentEdit
            // 
            ClientSize = new Size(418, 279);
            Controls.Add(textBoxAddress);
            Controls.Add(numericUpDownArea);
            Controls.Add(numericUpDownPrice);
            Controls.Add(checkedListBoxRenovation);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCancel);
            Name = "FormApartmentEdit";
            Text = "Квартира";
            ((System.ComponentModel.ISupportInitialize)numericUpDownArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}