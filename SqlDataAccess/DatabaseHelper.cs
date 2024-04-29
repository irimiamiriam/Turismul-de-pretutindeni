using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turismul_de_pretutindeni.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Turismul_de_pretutindeni.SqlDataAccess
{
    public class DatabaseHelper
    {
        private static readonly string _connectionstring = DataAccess.GetConnectionPath();
        private static readonly string _vacantepath = DataAccess.GetVacantePath();

        public static void Initialisation()
        {
            DeleteData();
            InsertVacante();
            UserModel user = new UserModel();
            user.Name = "admin";
            user.Surname= "admin";
            user.Email= "admin@oti.ro";
            user.Password = "oti2017";
            user.Tip = 0;
            InsertNewUser(user);
        }

        public static void ReInitialisation()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                SqlCommand cmdDel2 = new SqlCommand("Delete from Vacante", con);
                SqlCommand cmdDel3 = new SqlCommand("Delete from Rezervari", con);
                SqlCommand cmdReseed2 = new SqlCommand("DBCC CHECKIDENT(Vacante, RESEED,0)", con);
                SqlCommand cmdReseed3 = new SqlCommand("DBCC CHECKIDENT(Rezervari, RESEED,0)", con);
                cmdDel2.ExecuteNonQuery();
                cmdDel3.ExecuteNonQuery();
                cmdReseed2.ExecuteNonQuery();
                cmdReseed3.ExecuteNonQuery();

            }
            InsertVacante();
        }


        public static void InsertNewUser(UserModel user)
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Utilizatori (Nume, Prenume, Email, Parola, TipCont) values (@nume, @prenum, @email,@parola, @tip)";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@nume", user.Name);
                    cmd.Parameters.AddWithValue("@prenum", user.Surname);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                    cmd.Parameters.AddWithValue("@tip", user.Tip);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void InsertVacante()
        {
            string workingDirectory= Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resurse\Imagini");
            string[] imaginiPaths = Directory.GetFiles(path);
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Vacante (NumeVacanta, Descriere, CaleFisier,Pret, NrLocuri) values(@nume,@desc,@cale,@pret, @locuri)";
                using (StreamReader reader = new StreamReader(_vacantepath))
                {
                 
                    while (reader.Peek() >= 0) { 
                    string line = reader.ReadLine();
                        var split = line.Split('|');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("@nume", split[0]);
                        cmd.Parameters.AddWithValue("@desc", split[1]);
                        cmd.Parameters.AddWithValue("@pret", Convert.ToDouble(split[2]));
                        cmd.Parameters.AddWithValue("@locuri", Convert.ToInt32(split[3]));
                        string cale = "C:\\Users\\Miriam\\Documents\\Aplicatii C\\CSHARP Nationala\\Turismul de pretutindeni\\Resurse\\Imagini\\implicit.jpg";
                        foreach(var file in imaginiPaths)
                            {
                                if (file.Contains(split[0]))
                                {
                                    cale = file;
                                }
                            }
                            cmd.Parameters.AddWithValue("@cale", cale);
                            cmd.ExecuteNonQuery();

                        }

                    }
                }
            }
        }

        private static void DeleteData()
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                SqlCommand cmdDel1 = new SqlCommand("Delete from Utilizatori", con);
                SqlCommand cmdDel2 = new SqlCommand("Delete from Vacante", con);
                SqlCommand cmdDel3 = new SqlCommand("Delete from Rezervari", con);
                SqlCommand cmdReseed1 = new SqlCommand("DBCC CHECKIDENT(Utilizatori, RESEED,0)", con);
                SqlCommand cmdReseed2 = new SqlCommand("DBCC CHECKIDENT(Vacante, RESEED,0)", con);
                SqlCommand cmdReseed3 = new SqlCommand("DBCC CHECKIDENT(Rezervari, RESEED,0)", con);
                cmdDel1.ExecuteNonQuery();
                cmdDel2.ExecuteNonQuery();
                cmdDel3.ExecuteNonQuery();
                cmdReseed1.ExecuteNonQuery();
                cmdReseed2.ExecuteNonQuery();
                cmdReseed3.ExecuteNonQuery();

            }
        }

        internal static UserModel SearchUser(UserModel user)
        {
            UserModel userGasit = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where Email=@email and Parola=@parola";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                   using(SqlDataReader  reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if(reader.HasRows)
                        {
                            userGasit.Id = Convert.ToInt32(reader[0]);
                            userGasit.Name = reader[1].ToString();
                            userGasit.Surname = reader[2].ToString();
                            userGasit.Email= user.Email;
                            userGasit.Password= user.Password;
                            userGasit.Tip = Convert.ToInt32(reader[5]);
                        }
                    }
                }
            }
            return userGasit;
        }

        internal static bool SearchUserByEmail(string email)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where Email=@email";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else return false;
                    }
                }
            }
        }

        internal static List<VacantaModel> GetVacante()
        {
            List<VacantaModel> vacante = new List<VacantaModel>();
            using(SqlConnection  con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Vacante";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VacantaModel vacanta = new VacantaModel();
                            vacanta.Id = Convert.ToInt32(reader[0].ToString());
                            vacanta.Name= reader[1].ToString();
                            vacanta.Description= reader[2].ToString();
                            vacanta.Cale= reader[3].ToString();
                            vacanta.Pret = Convert.ToDouble(reader[4].ToString());
                            vacanta.NrLocuri = Convert.ToInt32(reader[5].ToString()); 
                            vacante.Add(vacanta);
                        }
                    }
                }
            }
            return vacante;
        }

        internal static bool Verificare(DateTime dateTimeSf, DateTime dateTimeIn, VacantaModel vacanta, int nr)
        {
            
            int rezervariRamase=0;
            int rezervariFacute=0;
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdRezervari = "Select * from Rezervari where IdVacanta=@id and DataInceput<=@data1 and DataSfarsit>=@data2";
                using (SqlCommand cmd = new SqlCommand(cmdRezervari, con))
                {
                    cmd.Parameters.AddWithValue("@id", vacanta.Id);
                    cmd.Parameters.AddWithValue("@data1", dateTimeIn);
                    cmd.Parameters.AddWithValue("@data2", dateTimeSf);
                    using(SqlDataReader reader = cmd.ExecuteReader()){
                        while (reader.Read())
                        {
                            rezervariFacute += Convert.ToInt32(reader[5]);
                        }
                    }
                }
            }
            rezervariRamase = vacanta.NrLocuri - rezervariFacute - nr ;
            if (rezervariRamase >= 0) { return true; }
            else return false;
        }

        internal static void AddRezervare(RezervaModel rezervare)
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Rezervari (IdVacanta, IdUser, DataInceput, DataSfarsit,NrPersoane,PretTotal) values (@idv, @idu, @di, @ds, @nr,@pret)";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@idv", rezervare.IdVacanta);
                    cmd.Parameters.AddWithValue("@idu", rezervare.IdUser);
                    cmd.Parameters.AddWithValue("@di", rezervare.DataIn);
                    cmd.Parameters.AddWithValue("@ds", rezervare.DataOut);
                    cmd.Parameters.AddWithValue("@nr", rezervare.NrPers);
                    cmd.Parameters.AddWithValue("@pret", rezervare.PretTotal);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        internal static List<string> GetUsers()
        {
            List<string> email = new List<string>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select Email from Utilizatori";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            email.Add(reader[0].ToString());
                        }
                    }
                }
            }
            return email;
        }

        internal static void UpdateUser(string email)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = " Update Utilizatori set TipCont=@tip where Email=@email";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", 0);
                    cmd.Parameters.AddWithValue("@email", email);
                   cmd.ExecuteNonQuery();
                }
            }
        }

        internal static List<RezervaModel> GetRezervari(int id)
        {
           List<RezervaModel> rezervari = new List<RezervaModel>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdRezervari = "Select * from Rezervari where IdUser=@id";
                using (SqlCommand cmd = new SqlCommand(cmdRezervari, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           RezervaModel rezervare = new RezervaModel();
                            rezervare.IdVacanta = Convert.ToInt32(reader[1]);
                            rezervare.DataIn= DateTime.Parse(reader[3].ToString());
                            rezervare.DataOut = DateTime.Parse(reader[4].ToString());
                            rezervare.NrPers= Convert.ToInt32(reader[5].ToString());
                            rezervare.PretTotal= Convert.ToInt32(reader[6].ToString());
                            rezervari.Add(rezervare);
                        }
                    }
                }
            }
            return rezervari;
        }

        internal static string GetVacantaRez(int idVacanta)
        {
            string vacanta = "";
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select * from Vacante where IdVacanta=@id";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@id", idVacanta);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                         while (reader.Read())
                        {
                           vacanta = reader[0].ToString();
                        }
                    }
                }
            }
            return vacanta;
        }

        internal static void DeleteRow(int idUser, int idVacanta)
        {
           using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Delete from Rezervari where IdUser=@idUser and IdVacanta=@idVac";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@idVac", idVacanta);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
