namespace LabWork1.Forms
{
    partial class FormClients
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button ButtonAdd;
        private Button ButtonUpd;
        private Button ButtonDel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewData = new DataGridView();
            ButtonAdd = new Button();
            ButtonUpd = new Button();
            ButtonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.ColumnHeadersHeight = 29;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(333, 353);
            dataGridViewData.TabIndex = 0;
            dataGridViewData.CellContentClick += dataGridViewData_CellContentClick;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Dock = DockStyle.Right;
            ButtonAdd.Location = new Point(333, 0);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(80, 353);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "+";
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonUpd
            // 
            ButtonUpd.Dock = DockStyle.Right;
            ButtonUpd.Location = new Point(413, 0);
            ButtonUpd.Name = "ButtonUpd";
            ButtonUpd.Size = new Size(89, 353);
            ButtonUpd.TabIndex = 2;
            ButtonUpd.Text = "Изменить";
            ButtonUpd.Click += ButtonUpd_Click;
            // 
            // ButtonDel
            // 
            ButtonDel.Dock = DockStyle.Right;
            ButtonDel.Location = new Point(502, 0);
            ButtonDel.Name = "ButtonDel";
            ButtonDel.Size = new Size(80, 353);
            ButtonDel.TabIndex = 3;
            ButtonDel.Text = "-";
            ButtonDel.Click += ButtonDel_Click;
            // 
            // FormClients
            // 
            ClientSize = new Size(582, 353);
            Controls.Add(dataGridViewData);
            Controls.Add(ButtonAdd);
            Controls.Add(ButtonUpd);
            Controls.Add(ButtonDel);
            Name = "FormClients";
            Text = "Клиенты";
            Load += FormClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }
    }
}