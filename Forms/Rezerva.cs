using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_de_pretutindeni.Models;
using Turismul_de_pretutindeni.SqlDataAccess;

namespace Turismul_de_pretutindeni.Forms
{
    public partial class Rezerva : Form
    {
        public VacantaModel vacanta = new VacantaModel();
        public UserModel user = new UserModel();
        public Rezerva()
        {
            InitializeComponent();
        }

        private void Rezerva_Load(object sender, EventArgs e)
        {
            labelDetalii.Text += vacanta.Name + "\r\n" + vacanta.Pret + " lei \r\n" + vacanta.NrLocuri + " locuri \r\n" + vacanta.Description ;

        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            DateTime dateTimeSf = dateTimeSfarsit.Value;
            DateTime dateTimeIn = dateTimeInceput.Value;
            bool disponibil = DatabaseHelper.Verificare(dateTimeSf, dateTimeIn, vacanta, Convert.ToInt32(textBoxNr.Text));
            int zile= (dateTimeSf - dateTimeIn).Days+1;
            textBoxSuma.Text = (Convert.ToInt32(textBoxNr.Text) * vacanta.Pret*zile ).ToString();
            if (disponibil) { buttonRezerva.Enabled = true; }
            else { MessageBox.Show("Nu mai sunt locuri!"); }
           
        }

        private void buttonRezerva_Click(object sender, EventArgs e)
        {
            RezervaModel rezervare= new RezervaModel();
            rezervare.IdVacanta = vacanta.Id;
            rezervare.IdUser = user.Id;
            rezervare.DataIn = dateTimeInceput.Value;
            rezervare.DataOut = dateTimeSfarsit.Value;
            rezervare.NrPers = Convert.ToInt32(textBoxNr.Text);
            rezervare.PretTotal = Convert.ToInt32(textBoxSuma.Text);
            DatabaseHelper.AddRezervare(rezervare);
           
            buttonRezerva.Enabled=false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();
             textBoxNr.Text = "";
            textBoxSuma.Text = "";

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            Brush brush= new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            FontFamily fontFamily = FontFamily.GenericMonospace;
            Font Font = new Font(fontFamily, 25);
           
            e.Graphics.DrawString(user.Name.Trim() + "    "+user.Email , Font, brush, 10, 10);
            e.Graphics.DrawString(dateTimeInceput.Value+ " "+dateTimeSfarsit.Value, Font, brush, 10, 60);
            e.Graphics.DrawString(textBoxSuma.Text, Font, brush, 10, 120); 
            e.Graphics.DrawString(labelDetalii.Text, Font, brush, 10, 200);
        }
    }
}
