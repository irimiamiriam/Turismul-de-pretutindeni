using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Turismul_de_pretutindeni.Models;
using Turismul_de_pretutindeni.SqlDataAccess;

namespace Turismul_de_pretutindeni.Forms
{
    public partial class FrmVacanta : Form
    {
        public UserModel user= new UserModel();
        List<Bitmap> images = new List<Bitmap>();
        List<VacantaModel> vacantaModels = new List<VacantaModel>();
        int ind = 0;
        public FrmVacanta()
        {
            InitializeComponent();
        }

        private void FrmVacanta_Load(object sender, EventArgs e)
        {   
            menuStrip1.Items[2].Text = user.Email.Trim();
            if (user.Tip == 1) {
                menuStrip1.Items.RemoveAt(0);
             }
            SlideShow();

           
        }

        private void SlideShow()
        {
            images = new List<Bitmap>();
            vacantaModels = DatabaseHelper.GetVacante();
            labelDescriere.Text = "";
            labelDescriere.Text = vacantaModels[0].Description;
            pictureBoxShow.Image = null;
            foreach(VacantaModel vacanta in  vacantaModels)
            {
                Image image = Image.FromFile(vacanta.Cale);
                Bitmap bmp =new Bitmap(pictureBoxShow.Width, pictureBoxShow.Height);
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.DrawImage(image, 0, 0, pictureBoxShow.Width, pictureBoxShow.Height);
                FontFamily fontfam = FontFamily.GenericSansSerif;
                Font font = new Font(fontfam, 10);
                Brush brush = new SolidBrush(Color.Black);
                graphics.DrawString(vacanta.Name, font, brush, 10, 10);
                graphics.DrawString(vacanta.Pret+" lei", font, brush, 10, 30);
                graphics.DrawString(vacanta.NrLocuri+" locuri", font, brush, 10, 50);
                
                images.Add(bmp);
            }
            pictureBoxShow.Image = images[0];

        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            ind++;
            if (ind == images.Count)
            {
                ind = 0;
                pictureBoxShow.Image = images[ind];
                labelDescriere.Text = vacantaModels[ind].Description;
            }
            else { pictureBoxShow.Image = images[ind];
                labelDescriere.Text = vacantaModels[ind].Description;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            ind--;
            if (ind == -1)
            {
                ind = images.Count-1;
                pictureBoxShow.Image = images[ind];
                labelDescriere.Text= vacantaModels[ind].Description;
            }
            else { pictureBoxShow.Image = images[ind];
                labelDescriere.Text = vacantaModels[ind].Description;
            }
        }

        private void checkBoxAutoPlay_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoPlay.Checked)
            {
                buttonNext.Enabled = buttonPrev.Enabled = false;
                timerShow.Start();

            }else
            {
                buttonNext.Enabled = buttonPrev.Enabled = true;
                timerShow.Stop();
            }
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            ind++;
            if (ind == images.Count)
            {
                ind = 0;
                pictureBoxShow.Image = images[ind];
                labelDescriere.Text = vacantaModels[ind].Description;
            }
            else { pictureBoxShow.Image = images[ind];
                labelDescriere.Text = vacantaModels[ind].Description;
            }

        }

        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRezerva_Click(object sender, EventArgs e)
        {
            VacantaModel vacanta = vacantaModels[ind];
            Rezerva rezerva = new Rezerva();
            rezerva.vacanta= vacanta;
            rezerva.user = user;
            this.Hide();
            rezerva.ShowDialog();
            this.Show();
        }

        private void adaugaAdminNouToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaVacanteNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start( @"C:\Users\Miriam\Documents\Aplicatii C\CSHARP Nationala\Turismul de pretutindeni\Resurse\Vacante.txt");
            DatabaseHelper.ReInitialisation();
            SlideShow();
        }

        private void vacanteleMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacanteleMele vacanteleMele = new VacanteleMele();
            vacanteleMele.user = user;
            this.Hide();
            vacanteleMele.ShowDialog();
            this.Show();
        }

        private void buttonPoster_Click(object sender, EventArgs e)
        {
            Image imageSelected = Image.FromFile(vacantaModels[ind].Cale);
            Bitmap bitmap = new Bitmap(imageSelected.Width, imageSelected.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(imageSelected, 0,0, bitmap.Width, bitmap.Height);
            int[][] matriceLuminozitate = new int[bitmap.Height+1][];
            int[][] maximLuminozitate = new int[bitmap.Height + 1][];
            for (int i = 0; i < bitmap.Height + 1; i++)
            {
                matriceLuminozitate[i] = new int[bitmap.Width + 1]; 
            }
            for (int i = 0; i < bitmap.Height; i++)
            {
                matriceLuminozitate[i][0] = 0;    
            }
            for (int i = 0; i < bitmap.Width; i++)
            {
                matriceLuminozitate[0][i] = 0;
            }

            for (int i=0; i<bitmap.Height; i++)
            {
                for(int j=0; j<bitmap.Width; j++)
                {
                    Color pixelColor = bitmap.GetPixel(j,i);
                    double lum = Math.Sqrt(0.241*pixelColor.R* pixelColor.R + 0.691*pixelColor.G* pixelColor.G+ 0.068* pixelColor.B* pixelColor.B);
                    if (lum > 200)
                    {
                        matriceLuminozitate[i+1][j+1] = 1;
                    }
                }
            }

            for (int i = 1; i < bitmap.Height; i++)
            {
                for (int j = 1; j < bitmap.Width; j++)
                {
                    matriceLuminozitate[i][j] = matriceLuminozitate[i - 1][j] + matriceLuminozitate[i][j - 1] - matriceLuminozitate[i - 1][j - 1] + matriceLuminozitate[i][j];
                }
            }
           
            int widthRectangle = 10 * (vacantaModels[ind].Name.Length);
            int heightRectangle = 30;
            int maximValue = int.MinValue;
            Point rectanglePosition = new Point();

            for (int i = heightRectangle+1; i < bitmap.Height; i++)
            {
                for (int j = widthRectangle+1; j < bitmap.Width; j++)
                {
                    int luminRect = matriceLuminozitate[i][j] - matriceLuminozitate[i-heightRectangle][j]- matriceLuminozitate[i][j-widthRectangle]+ matriceLuminozitate[i - heightRectangle][j-widthRectangle];
                    if(luminRect > maximValue)
                    {
                        maximValue = luminRect;
                        rectanglePosition.X = j-widthRectangle;
                        rectanglePosition.Y = i-heightRectangle;
                    }
                }
            }
            Rectangle rectangle = new Rectangle(rectanglePosition.X,rectanglePosition.Y, widthRectangle,heightRectangle);
            FontFamily fontFamily = FontFamily.GenericSansSerif;
            Font font = labelDescriere.Font;
            Brush brush = new SolidBrush(Color.Black);
            graphics.DrawString(vacantaModels[ind].Name, font,brush, rectangle);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Files|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }


        }
    }
}
