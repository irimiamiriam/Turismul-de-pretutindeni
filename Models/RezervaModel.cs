using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_de_pretutindeni.Models
{
    public class RezervaModel
    {
        public int IdVacanta {  get; set; }
        public int IdUser { get; set; }
        public DateTime DataIn {  get; set; }
        public DateTime DataOut { get; set; }
        public int NrPers {  get; set; }
        public double PretTotal {  get; set; }
    }
}
