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
    public partial class ProceduresList : UserControl
    {
        private List<ProcedureModel> procs;

        public ProceduresList()
        {
            InitializeComponent();
        }

        private void ProceduresList_Load(object sender, EventArgs e)
        {
            LoadEntries();
        }

        public void LoadEntries()
        {
            this.ProceduresTable.Controls.Clear();
            procs = DbConnector.GetInstance().GetProceduresList();
            this.ProceduresTable.RowCount = procs.Count;
            this.ProceduresTable.Update();
            for (int i = 0; i < procs.Count; i++)
            {
                TextBox lb = new TextBox(); lb.Text = procs[i].Name; lb.Show();
                TextBox lb1 = new TextBox(); lb1.Text = procs[i].Duration.ToString(); lb1.Show();
                TextBox lb2 = new TextBox(); lb2.Text = procs[i].Cost.ToString(); lb2.Show();
                DeleteButton b = new DeleteButton(procs[i].id, "proc");
                b.Click += b_Click;
                this.ProceduresTable.Controls.Add(lb, 0, i);
                this.ProceduresTable.Controls.Add(lb1, 1, i);
                this.ProceduresTable.Controls.Add(lb2, 2, i);
                this.ProceduresTable.Controls.Add(b, 3, i);
            }
        }
        void b_Click(object sender, EventArgs e)
        {
            DeleteButton b = (DeleteButton)sender;
            b.ExecuteDeletion();
            LoadEntries();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<string> entry = new List<string>(){"\"\"","0","0"};
            DbConnector.GetInstance().AddEntry("proc", entry);
            LoadEntries();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DbConnector db = DbConnector.GetInstance();
            for (int i = 0; i < ProceduresTable.RowCount; i++)
            {
                procs[i].Name = ProceduresTable.GetControlFromPosition(0,i).Text;
                procs[i].Duration = int.Parse(ProceduresTable.GetControlFromPosition(1,i).Text);
                procs[i].Cost = int.Parse(ProceduresTable.GetControlFromPosition(2,i).Text);
                db.UpdateProcedure(procs[i]);
            }
        }
    }
}
