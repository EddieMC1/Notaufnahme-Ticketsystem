using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notaufnahme_Ticketsystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Uebersicht uebersicht = new Uebersicht();
            uebersicht.Show();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            //Funktion für Abgleich eingegebener Login-Daten mit Datenbank
            //{
                    //Vergleich der eingegebenen Logindaten mit DB-Logindaten (benutzer, pw)
            //}



            //if (Funktion für.... == erfolgreich)
            //{
            //    auslesen von restlichem datensatz -> vorname, nachname, beruf
            //    public Personal globalPers = new Personal(string ausDBausgelesenerVorname, string ausDBausgelesenerNachname, string ausDBausgelesenerBeruf);
            //}
        }

        private void ClearTxt()
        {
            txtBenutzer.Text = "";
            txtPasswort.Text = "";
        }

        private void cmdRegistrieren_Click(object sender, EventArgs e)
        {
            Personalregister register = new Personalregister();
            register.Show();
        }
    }
}
