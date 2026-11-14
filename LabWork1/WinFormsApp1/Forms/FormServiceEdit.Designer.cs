namespace LabWork1.Forms
{
    partial class FormServiceEdit
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownCost;
        private Button ButtonSave;
        private Button ButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            numericUpDownCost = new NumericUpDown();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 1;
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.Location = new Point(100, 60);
            numericUpDownCost.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(200, 27);
            numericUpDownCost.TabIndex = 3;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(50, 120);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(103, 43);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Сохранить";
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(180, 120);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(102, 43);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // FormServiceEdit
            // 
            ClientSize = new Size(381, 175);
            Controls.Add(textBoxName);
            Controls.Add(numericUpDownCost);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCancel);
            Name = "FormServiceEdit";
            Text = "Услуга";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}