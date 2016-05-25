using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    public partial class StaffProfile : UserControl
    {
        private string _profileName;
        private EmployeeModel _profile;

        public StaffProfile()
        {
            InitializeComponent();
        }
        public StaffProfile(string name)
        {
            InitializeComponent();
            this._profileName = name;
        }

        private void StaffProfile_Load(object sender, EventArgs e)
        {
            _profile = DbConnector.GetInstance().GetEmployeeProfile(_profileName);
            NameTextBox.Text = _profile.Name;
            SpecialtyTextBox.Text = _profile.Specialty;
            YoeTextBox.Text = _profile.HourSalary.ToString();
            SalaryTextBox.Text = _profile.YearsOfExpirience.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
            this.Dispose();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _profile.Name = NameTextBox.Text;
            _profile.Specialty = SpecialtyTextBox.Text;
            _profile.YearsOfExpirience = int.Parse(YoeTextBox.Text);
            _profile.HourSalary = int.Parse(SalaryTextBox.Text);
            DbConnector.GetInstance().UpdateEmployeeProfile(_profile);
        }
    }
}
