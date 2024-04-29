using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_de_pretutindeni.SqlDataAccess
{
    public class DataAccess
    {
        public static string GetConnectionPath()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
        public static string GetVacantePath() {
            return ConfigurationManager.AppSettings["VacantePath"];
        }
    }
}
