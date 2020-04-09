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
    public partial class Personalregister : Form
    {
        public Personalregister()
        {
            InitializeComponent();
        }

        DBHandler handler;
        List<Logindaten> loginList;

        private void Personalregister_Load(object sender, EventArgs e)
        {
            this.handler = new DBHandler();
            this.handler.GetDB();
            this.loginList = handler.LoginData;
        }

        private void cmdRegistrierung_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Registrierung war erfolgreich.", "Registrierung", MessageBoxButtons.OK, MessageBoxIcon.Information);

            switch (result)
            {
                case DialogResult.OK:

                    loginList.Clear();

                    handler.SetDB(txtVorname.Text, txtNachname.Text, comboBoxRolle.SelectedItem.ToString(), txtBenutzer.Text, txtNachname.Text);

                    handler.GetDB();

                    this.loginList = handler.LoginData;
                    break;
            }
        }

        private void cmdAbbruch_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
