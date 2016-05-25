using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_db
{
    class DeleteButton : Button
    {
        private int id;
        private string tableName;

        public DeleteButton(int id, string tableName) : base()
        {
            this.id = id;
            this.tableName = tableName;
            this.Text = "Delete";
        }

        public void ExecuteDeletion()
        {
            DbConnector.GetInstance().DeleteEntry(this.id, this.tableName);
        }
    }
}
