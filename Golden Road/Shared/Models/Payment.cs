using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public long Broj_Racuna_Primaoca { get; set; }
        public int Model { get; set; }
        public long Poziv_Na_Broj { get; set; }
        public decimal Iznos { get; set; }
        public string Svrha_Uplate { get; set; }
        public DateTime Datum { get; set; }
    }
}
