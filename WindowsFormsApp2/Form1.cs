using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private AppDBContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testBD1DataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.testBD1DataSet1.Employees);
            // TODO: This line of code loads data into the 'testBD1DataSet.Organizations' table. You can move, or remove it, as needed.
            this.organizationsTableAdapter.Fill(this.testBD1DataSet.Organizations);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new AppDBContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Organizations.Load();

            this.organizationsBindingSource.DataSource = dbContext.Organizations.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
        private void dataGridViewOrganizations_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var organizations = (Organizations)this.dataGridViewOrganizations.CurrentRow.DataBoundItem;

                if (organizations != null)
                {
                    this.dbContext.Entry(organizations).Collection(emp => emp.Employees).Load();
                }
            }
        }
    }
}
