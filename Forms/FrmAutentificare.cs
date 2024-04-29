using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_de_pretutindeni.Models;
using Turismul_de_pretutindeni.SqlDataAccess;

namespace Turismul_de_pretutindeni.Forms
{
    public partial class FrmAutentificare : Form
    {
        public FrmAutentificare()
        {
            InitializeComponent();
        }

        private void FrmAutentificare_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastEnteredEmail))
            {
                textBoxEmail.Text= Properties.Settings.Default.LastEnteredEmail;
            }
         
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Email = textBoxEmail.Text;
            user.Password = textBoxParola.Text;
            user = DatabaseHelper.SearchUser(user);
            if (user.Name != null)
             {
                if (checkBoxRetine.Checked == true)
                {
                    Properties.Settings.Default.LastEnteredEmail=textBoxEmail.Text.Trim();
                    Properties.Settings.Default.Save();

                }
                FrmVacanta frmVacanta = new FrmVacanta();
               frmVacanta.user = user;
                this.Hide();
                frmVacanta.ShowDialog();
              if(Application.OpenForms.Count!=0)  this.Show();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            FrmInregistrare frmInregistrare = new FrmInregistrare();
            this.Hide();
            frmInregistrare.ShowDialog();
            this.Show();
        }
    }
}
