using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notaufnahme_Ticketsystem
{
    class Patient
    {
        // Datenfelder
        public static int patientenID = 0;
        private int alter;
        private int behandlungszimmer;
        private String prioritaet;
        private String status;
        private String patientenname;       
        private String beschwerde;
        private String diagnose;
        private DateTime neubewertung;
        private DateTime ankunft;

        // Construktor
        public Patient(String prioritaet, DateTime neubewertung, String status, String patientenname, int alter, int behandlungszimmer, String beschwerde, String diagnose)
        {
            patientenID += 1;
            this.prioritaet = prioritaet;
            this.neubewertung = neubewertung;
            this.ankunft = new DateTime();
            this.status = status;
            this.patientenname = patientenname;
            this.alter = alter;
            this.behandlungszimmer = behandlungszimmer;
            this.beschwerde = beschwerde;
        }

        // Getter/Setter
        public int PatientenID { get => patientenID; set => patientenID = value; }
        public String Priorität { get => prioritaet; set => prioritaet = value; }
        public DateTime Neubewertung { get => neubewertung; set => neubewertung = value; }
        public DateTime Ankunft { get => ankunft; set => ankunft = value; }
        public string Status { get => status; set => status = value; }
        public string Patientenname { get => patientenname; set => patientenname = value; }
        public int Alter { get => alter; set => alter = value; }
        public int Behandlungszimmer { get => behandlungszimmer; set => behandlungszimmer = value; }
        public string Beschwerde { get => beschwerde; set => beschwerde = value; }
        public string Diagnose { get => diagnose; set => diagnose = value; }
    }
}
