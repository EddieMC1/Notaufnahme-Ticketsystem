using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notaufnahme_Ticketsystem
{
    class Personal
    {
        // Datenfelder
        private string vorname;
        private string nachname;
        private string beruf;

        // Konstruktor
        public Personal(string vorname, string nachname, string beruf)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.beruf = beruf;
        }

        // Getter
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Beruf { get => beruf; set => beruf = value; }
    }
}
