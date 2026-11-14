namespace LabWork1.Forms
{
    partial class FormDeals
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
            this.dataGridViewData = new DataGridView();
            this.ButtonAdd = new Button();
            this.ButtonUpd = new Button();
            this.ButtonDel = new Button();

            this.dataGridViewData.Dock = DockStyle.Fill;
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ReadOnly = true;

            this.ButtonAdd.Text = "+";
            this.ButtonAdd.Dock = DockStyle.Right;
            this.ButtonAdd.Width = 80;
            this.ButtonAdd.Click += new EventHandler(this.ButtonAdd_Click);

            this.ButtonUpd.Text = "Изменить";
            this.ButtonUpd.Dock = DockStyle.Right;
            this.ButtonUpd.Width = 80;
            this.ButtonUpd.Click += new EventHandler(this.ButtonUpd_Click);

            this.ButtonDel.Text = "-";
            this.ButtonDel.Dock = DockStyle.Right;
            this.ButtonDel.Width = 80;
            this.ButtonDel.Click += new EventHandler(this.ButtonDel_Click);

            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonUpd);
            this.Controls.Add(this.ButtonDel);
            this.Text = "Сделки";
            this.Size = new Size(600, 400);
            this.Load += new EventHandler(this.FormDeals_Load);
        }
    }
}