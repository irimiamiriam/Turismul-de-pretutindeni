using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_de_pretutindeni.Models;
using Turismul_de_pretutindeni.SqlDataAccess;

namespace Turismul_de_pretutindeni.Forms
{
    public partial class FrmInregistrare : Form
    {
        string codCaptcha = "";
        public FrmInregistrare()
        {
            InitializeComponent();
        }
        private bool ValidEmail(string email)
        {

            if (email != null)
            {
                string[] splitByA = email.Split('@');
                if (splitByA.Length == 2 && !string.IsNullOrEmpty(splitByA[0]) && !string.IsNullOrEmpty(splitByA[1]))
                {
                    foreach (char c in splitByA[0])
                    {
                        if (!char.IsLetterOrDigit(c) && c != '.' && c != '_' && c != '-')
                        {
                            return false;
                        }
                    }
                    string[] splitByP = splitByA[1].Split('.');
                    if (splitByP.Length != 2 || string.IsNullOrEmpty(splitByP[0]) || string.IsNullOrEmpty(splitByP[1]) || splitByA[0].First() == '.' || splitByA[0].Last() == '.')
                    {
                        return false;
                    }

                }
                else { return false; }
            }
            else { return false; }
            return true;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInregistrare_Load(object sender, EventArgs e)
        {
            NewCaptcha();
        }

        private void NewCaptcha()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Logare");
            string[] imaginiPaths = Directory.GetFiles(path);
            Random random = new Random();
            int n = random.Next(0, imaginiPaths.Length);
            pictureBoxCaptcha.Image = Image.FromFile(imaginiPaths[n]);
            var split = imaginiPaths[n].Split(new string[] { @"\" }, StringSplitOptions.None);
            var splitByP = split[split.Length - 1].Split('.');
            codCaptcha = splitByP[0];
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
         bool emailExists = DatabaseHelper.SearchUserByEmail(textBoxEmail.Text);
            if (!string.IsNullOrEmpty(textBoxNume.Text)||!string.IsNullOrEmpty(textBoxEmail.Text) || !string.IsNullOrEmpty(textBoxParola.Text) || !string.IsNullOrEmpty(textBoxConf.Text) || !string.IsNullOrEmpty(textBoxPrenume.Text) || !string.IsNullOrEmpty(textBoxCod.Text))
            {
                if(ValidEmail(textBoxEmail.Text.Trim())) { 
                 if(!emailExists)
                {
                        if (textBoxParola.Text.Length >= 3)
                        {
                            if (textBoxConf.Text == textBoxParola.Text)
                            {
                                if (textBoxCod.Text == codCaptcha)
                                {
                                    UserModel user = new UserModel()
                                    {
                                        Name = textBoxNume.Text,
                                        Surname = textBoxPrenume.Text,
                                        Email = textBoxEmail.Text,
                                        Password = textBoxParola.Text,
                                        Tip = 1
                                    };
                                    DatabaseHelper.InsertNewUser(user);
                                    this.Close();

                                }
                                else { MessageBox.Show("Cod captcha gresit!"); textBoxCod.Text = ""; NewCaptcha(); }
                            } else { MessageBox.Show("Confirmarea parolei incorecta!"); textBoxParola.Text = textBoxConf.Text = ""; NewCaptcha(); }
                        }
                        else { MessageBox.Show("Parola trebuie sa aiba minim 3 caractere!"); textBoxParola.Text = ""; NewCaptcha(); }

                    }
                    else { MessageBox.Show("Exista deja un cont cu acest email!"); textBoxEmail.Text = ""; NewCaptcha(); }
                }
                else { MessageBox.Show("Introduceti un email valid!"); textBoxEmail.Text = ""; NewCaptcha(); }

            }else
            {
                MessageBox.Show("Completati toate campurile!");
            }
           
        }
    }
}
