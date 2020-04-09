using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notaufnahme_Ticketsystem
{
    class Logindaten
    {
        // Datenfleder
        private int id;
        private String vorname;
        private String nachname;
        private String personal;
        private String benutzer;
        private String passwort;
        

        // Konstruktor
        public Logindaten(int id, String vorname, String nachname, String personal, String benutzer, String passwort)
        {
            this.id = id;
            this.vorname = vorname;
            this.nachname = nachname;
            this.personal = personal;
            this.benutzer = benutzer;
            this.passwort = passwort;
        }

        // Getter/Setter
        public int Id { get => id; set => id = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Personal { get => personal; set => personal = value; }
        public string Benutzer { get => benutzer; set => benutzer = value; }
        public string Passwort { get => passwort; set => passwort = value; }
        
        
    }
}
