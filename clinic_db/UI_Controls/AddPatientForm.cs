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
    public partial class AddPatientForm : Form
    {
        private Control _parent;
        public AddPatientForm()
        {
            InitializeComponent();
        }

        public AddPatientForm(Control parent)
        {
            InitializeComponent();
            _parent = parent;
            this.FormClosing += AddPatientForm_FormClosing;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            values.Add(String.Format("\"{0}\"", NameBox.Text));
            values.Add(String.Format("{0}", AgeBox.Text));
            values.Add(String.Format("\"{0}\"", PhoneBox.Text));
            values.Add(String.Format("\"{0}\"", AddressBox.Text));
            values.Add("0");
            DbConnector.GetInstance().AddEntry("patient", values);
            this._parent.Enabled = true;
            PatientList list = (PatientList)this._parent;
            list.LoadEntries();
            this.Close();
        }

        void AddPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._parent.Parent.Parent.Enabled = true;
        }
    }
}
