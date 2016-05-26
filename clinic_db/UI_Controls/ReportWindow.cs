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
    public partial class ReportWindow : UserControl
    {
        private string _q;
        public ReportWindow(string title,string query)
        {
            InitializeComponent();
            TopLabel.Text = title;
            _q = query;
            LoadEntries();
        }

        public void LoadEntries()
        {
            DataSet data = DbConnector.GetInstance().GetDataset(_q);
            DataGrid.DataSource = data;
            DataGrid.DataMember = "data";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Form parent = (Form)this.Parent;
            this.Dispose();
            parent.Close();
        }
    }
}
