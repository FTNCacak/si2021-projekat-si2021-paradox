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
        public long Broj_Racuna_Uplatioca { get; set; }

        public Payment () { }

        public Payment(string naziv, long broj_Racuna_Primaoca, int model, long poziv_Na_Broj, decimal iznos, string svrha_Uplate, DateTime datum)
        {
            Naziv = naziv;
            Broj_Racuna_Primaoca = broj_Racuna_Primaoca;
            Model = model;
            Poziv_Na_Broj = poziv_Na_Broj;
            Iznos = iznos;
            Svrha_Uplate = svrha_Uplate;
            Datum = datum;
        }
    }
}
