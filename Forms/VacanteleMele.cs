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
    public partial class VacanteleMele : Form
    {   
        public UserModel user = new UserModel();
        List<int> vacantaId = new List<int>();
        public VacanteleMele()
        {
            InitializeComponent();
        }

        private void VacanteleMele_Load(object sender, EventArgs e)
        {
            dataGridViewRezervari.Columns.Add("Vacanta", "Vacanta");    
            dataGridViewRezervari.Columns.Add("DataInceput", "Data Inceput");
            dataGridViewRezervari.Columns.Add("DataSfarist", "Data Sfarsit");
            dataGridViewRezervari.Columns.Add("NrPersoane", "Nr Persoane");
            dataGridViewRezervari.Columns.Add("PretTotal", "Pret Total");
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Sterge";
            buttonColumn.HeaderText = "Sterge";
            dataGridViewRezervari.Columns.Add(buttonColumn);

            List<RezervaModel> rezervari = DatabaseHelper.GetRezervari(user.Id);

            foreach(var r in  rezervari)
            {
                vacantaId.Add(r.IdVacanta);
                string vacanta = DatabaseHelper.GetVacantaRez(r.IdVacanta);
                dataGridViewRezervari.Rows.Add(vacanta, r.DataIn, r.DataOut, r.NrPers, r.PretTotal);
            }

        }

        private void dataGridViewRezervari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DatabaseHelper.DeleteRow(user.Id,vacantaId[e.RowIndex]);
                vacantaId.RemoveAt(e.RowIndex);
                dataGridViewRezervari.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
