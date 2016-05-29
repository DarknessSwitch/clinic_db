using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    public partial class AddEmployeeForm : Form
    {
        private Control _parent;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        public AddEmployeeForm(Control parent)
        {
            InitializeComponent();
            this._parent = parent;
            this.FormClosing += AddEmployeeForm_FormClosing;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            values.Add(String.Format("\"{0}\"", NameBox.Text));
            values.Add(String.Format("\"{0}\"", SpecialtyBox.Text));
            values.Add(String.Format("{0}", SalaryBox.Text));
            values.Add(String.Format("{0}", experienceBox.Text));
            DbConnector.GetInstance().AddEntry("employee", values);
            this._parent.Enabled = true;
            StaffList list = (StaffList)this._parent;
            list.LoadEntries();
            this.Close();
        }

        void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._parent.Parent.Parent.Enabled = true;
        }
    }
}
