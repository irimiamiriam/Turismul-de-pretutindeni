using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turismul_de_pretutindeni.Models
{
    public class VacantaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Cale { get; set; }
        public double Pret {  get; set; }
        public int NrLocuri { get; set; }
    }
}
