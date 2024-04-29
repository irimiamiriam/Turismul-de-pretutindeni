using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_de_pretutindeni.SqlDataAccess;

namespace Turismul_de_pretutindeni.Forms
{
    public partial class AdminNou : Form
    {
        List<string> emails = new List<string>();
        public AdminNou()
        {
            InitializeComponent();
        }

        private void AdminNou_Load(object sender, EventArgs e)
        {
            comboBoxEmails.Items.Clear();
            emails = DatabaseHelper.GetUsers();
            foreach(var email in emails) { 
                comboBoxEmails.Items.Add(email);
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (comboBoxEmails.SelectedItem != null || emails.Find(i => i == comboBoxEmails.Text) != null)
            {
                DatabaseHelper.UpdateUser(comboBoxEmails.SelectedItem.ToString());
            }
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            if(emails.Find(i => i == comboBoxEmails.Text) != null)
           { FrmInregistrare frmInregistrare = new FrmInregistrare();
                frmInregistrare.textBoxEmail.Text = comboBoxEmails.Text;
                this.Hide();
                frmInregistrare.ShowDialog();
                 this.Show();
                comboBoxEmails.Items.Clear();
                emails = DatabaseHelper.GetUsers();
                foreach (var email in emails)
                {
                    comboBoxEmails.Items.Add(email);
                }
            }

        }
    }
}
