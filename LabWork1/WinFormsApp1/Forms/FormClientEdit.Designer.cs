namespace LabWork1.Forms
{
    partial class FormClientEdit
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxFullName;
        private TextBox textBoxPhone;
        private ComboBox comboBoxType;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxFullName = new TextBox();
            textBoxPhone = new TextBox();
            comboBoxType = new ComboBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(100, 20);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(200, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(100, 60);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Location = new Point(100, 100);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(200, 28);
            comboBoxType.TabIndex = 5;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(50, 150);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(104, 33);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(180, 150);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(99, 33);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormClientEdit
            // 
            ClientSize = new Size(382, 211);
            Controls.Add(textBoxFullName);
            Controls.Add(textBoxPhone);
            Controls.Add(comboBoxType);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCancel);
            Name = "FormClientEdit";
            Text = "Клиент";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}