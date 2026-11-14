namespace LabWork1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem квартирыToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private ToolStripMenuItem сделкиToolStripMenuItem;
        private ToolStripMenuItem оказанныеУслугиToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStripMain = new MenuStrip();
            this.справочникиToolStripMenuItem = new ToolStripMenuItem();
            this.операцииToolStripMenuItem = new ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new ToolStripMenuItem();
            this.квартирыToolStripMenuItem = new ToolStripMenuItem();
            this.услугиToolStripMenuItem = new ToolStripMenuItem();
            this.сделкиToolStripMenuItem = new ToolStripMenuItem();
            this.оказанныеУслугиToolStripMenuItem = new ToolStripMenuItem();

            this.menuStripMain.Items.AddRange(new ToolStripItem[] {
                this.справочникиToolStripMenuItem,
                this.операцииToolStripMenuItem,
                this.отчетыToolStripMenuItem});
            this.menuStripMain.Location = new Point(0, 0);
            this.menuStripMain.Size = new Size(800, 24);

            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.клиентыToolStripMenuItem,
                this.квартирыToolStripMenuItem,
                this.услугиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Text = "Справочники";

            this.операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.сделкиToolStripMenuItem,
                this.оказанныеУслугиToolStripMenuItem});
            this.операцииToolStripMenuItem.Text = "Операции";

            this.отчетыToolStripMenuItem.Text = "Отчеты";

            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new EventHandler(this.ClientsMenuItem_Click);

            this.квартирыToolStripMenuItem.Text = "Квартиры";
            this.квартирыToolStripMenuItem.Click += new EventHandler(this.ApartmentsMenuItem_Click);

            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new EventHandler(this.ServicesMenuItem_Click);

            this.сделкиToolStripMenuItem.Text = "Сделки";
            this.сделкиToolStripMenuItem.Click += new EventHandler(this.DealsMenuItem_Click);

            this.оказанныеУслугиToolStripMenuItem.Text = "Оказанные услуги";
            this.оказанныеУслугиToolStripMenuItem.Click += new EventHandler(this.ProvidedServicesMenuItem_Click);

            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Text = "Агентство недвижимости";
            this.Size = new Size(800, 450);
        }
    }
}