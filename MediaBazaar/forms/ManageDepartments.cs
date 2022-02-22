using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.forms
{
    public partial class ManageDepartments : Form
    {
        public ManageDepartments()
        {
            InitializeComponent();
        }

        private void ManageDepartments_Load(object sender, EventArgs e)
        {
            string[] row = { "1", "Sports"};
            ListViewItem item = new ListViewItem(row);
            lvDepartments.Items.Add(item);

            row = new [] { "2", "Electronics"};
            item = new ListViewItem(row);
            lvDepartments.Items.Add(item);

            row = new[] { "3", "Kitchen" };
            item = new ListViewItem(row);
            lvDepartments.Items.Add(item);

            row = new[] { "4", "Hardware" };
            item = new ListViewItem(row);
            lvDepartments.Items.Add(item);
        }
    }
}
