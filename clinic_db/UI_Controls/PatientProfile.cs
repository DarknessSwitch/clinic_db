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
    public partial class PatientProfile : UserControl
    {
        private string _profileName;
        private PatientModel _profile;
        private List<CardModel> cards;
        public PatientProfile()
        {
            InitializeComponent();
        }
        public PatientProfile(string name)
        {
            InitializeComponent();
            _profileName = name;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
            this.Dispose();
        }
        public void LoadEntries()
        {
            CardTable.Controls.Clear();
            this.TopLabel.Text = "Profile of " + _profileName;
            _profile = DbConnector.GetInstance().GetPatientProfile(_profileName);
            this.NameBox.Text = _profile.Name;
            this.AddressBox.Text = _profile.Address;
            this.AgeBox.Text = _profile.Age.ToString();
            this.PhoneBox.Text = _profile.PhoneNumber;
            this.SessionsBox.Text = _profile.SessionsTaken.ToString();

            cards = DbConnector.GetInstance().GetCards(_profile.id);
            CardTable.RowCount = cards.Count;
            for (int i = 0; i < cards.Count; i++)
            {
                LinkLabel lb = new LinkLabel(); lb.Font = new Font("Calibri", 12); lb.Text = cards[i].Name; lb.Show();
                Label lb1 = new Label(); lb1.Font = new Font("Calibri", 12); lb1.Text = cards[i].YearsSuffered.ToString(); lb1.Show();
                Label lb2 = new Label(); lb2.Font = new Font("Calibri", 12); lb2.Text = cards[i].Doctor; lb2.Show();
                Label lb3 = new Label(); lb3.Font = new Font("Calibri", 12); lb3.Text = cards[i].Type; lb3.Show();
                DeleteButton b = new DeleteButton(cards[i].id, "medical_card"); b.Click += b_Click;
                lb.Click += lb_Click;
                this.CardTable.Controls.Add(lb, 0, i);
                this.CardTable.Controls.Add(lb1, 1, i);
                this.CardTable.Controls.Add(lb2, 2, i);
                this.CardTable.Controls.Add(lb3, 3, i);
                this.CardTable.Controls.Add(b, 4, i);
            }
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {
            LoadEntries();
        }

        void b_Click(object sender, EventArgs e)
        {
            DeleteButton casted = (DeleteButton)sender;
            casted.ExecuteDeletion();
            LoadEntries();
        }

        void lb_Click(object sender, EventArgs e)
        {
            LinkLabel casted = (LinkLabel)sender;
            CardModel card = cards.Find(c => c.Name == casted.Text);
            CardProfile profile = new CardProfile(_profile, card);
            Form f = new Form(); f.Size = profile.Size; f.Controls.Add(profile);
            f.Show();
            this.Parent.Hide();
            f.FormClosing += f_FormClosing;
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _profile.Name = NameBox.Text;
            _profile.Address = AddressBox.Text;
            _profile.Age = int.Parse(AgeBox.Text);
            _profile.PhoneNumber = PhoneBox.Text;
            _profile.SessionsTaken = int.Parse(SessionsBox.Text);
            DbConnector.GetInstance().UpdatePatientProfile(_profile);
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCard cform = new AddCard(_profile);
            cform.FormClosing += cform_FormClosing;
            cform.Show();
            
        }

        void cform_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            LoadEntries();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Check c = new Check(DateTime.Today,cards,_profile);
            f.Controls.Add(c);
            f.Size = c.Size;
            f.Show();
        }

    }
}
