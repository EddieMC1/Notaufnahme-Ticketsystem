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
    public partial class Patientenregister : Form
    {
        public Patientenregister()
        {
            InitializeComponent();
        }

        List<Patient> patientenliste = new List<Patient>();

        internal List<Patient> Patientenliste { get => patientenliste; set => patientenliste = value; }

        private void CmdRegistrieren_Click(object sender, EventArgs e)
        {
            //Patient p = new Patient();

            //this.Patientenliste.Add(p);


        }

        private void CmdAbrechen_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            comboBoxAnrede.Text = "";
            txtVorname.Text = "";
            txtNachname.Text = "";
            dateTimePickerGeburtsdatum.Text = "";

        }

        private void Patientenregister_Load(object sender, EventArgs e)
        {
            //if (globalPers.Beruf.Equals("Schwester"))
            //{
            //    ausblenden von bestimmten Objekten, die eine Schwester nicht sehen darf
            //}
        }

        private void groupBoxPriorität_Enter(object sender, EventArgs e)
        {

        }


    }
}
