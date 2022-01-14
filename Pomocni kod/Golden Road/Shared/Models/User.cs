using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korisnicki_Id { get; set; }
        public string Lozinka { get; set; }
        public string JMBG { get; set; }
        public string Mail_Adresa { get; set; }
        public string Broj_Telefona { get; set; }
        public string Adresa { get; set; }
        public long Broj_Racuna{ get; set; }
        public decimal Stanje_Na_Racunu { get; set; }

        public User() { }
        public User( string ime, string prezime, string korisnicki_Id, string lozinka, string jMBG, string mail_Adresa, string broj_Telefona, string adresa)
        {
            Ime = ime;
            Prezime = prezime;
            Korisnicki_Id = korisnicki_Id;
            Lozinka = lozinka;
            JMBG = jMBG;
            Mail_Adresa = mail_Adresa;
            Broj_Telefona = broj_Telefona;
            Adresa = adresa;
        }
    }

}
