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
    public partial class Uebersicht : Form
    {
        public Uebersicht()
        {
            InitializeComponent();
        }

        List<Patient> patientenliste;

        internal List<Patient> Patientenliste { get => patientenliste; set => patientenliste = value; }

        private void test_Load(object sender, EventArgs e)
        {
            CreateMyListView();
            createMyGroupBoxes();
        }

        private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 210), new Size(1200, 800));
            this.Size = new Size(1240, 850);

            // Set the view to show details.
            listView1.View = View.Details;

            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            //listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("", 0);
            // Place a check mark next to the item.
            //item1.Checked = true;
            item1.SubItems.Add("In 0 Min.");
            item1.SubItems.Add("08:00");
            item1.SubItems.Add("In Behandlung");
            item1.SubItems.Add("10");
            item1.SubItems.Add("Max Mustermann");
            item1.SubItems.Add("30");
            item1.SubItems.Add("1");
            item1.SubItems.Add("Husten, Schnupfen, Gliederschmerzen");
            item1.SubItems.Add("Grippaler Infekt");

            ListViewItem item2 = new ListViewItem("", 1);
            //item2.Checked = true;
            item2.SubItems.Add("In 10 Min");
            item2.SubItems.Add("08:30");
            item2.SubItems.Add("In Behandlung");
            item2.SubItems.Add("11");
            item2.SubItems.Add("Anton Becker");
            item2.SubItems.Add("18");
            item2.SubItems.Add("2");
            item2.SubItems.Add("Schmerzen beim Schlucken, Halsschmerzen");
            item2.SubItems.Add("Erkältung");

            ListViewItem item3 = new ListViewItem("", 2);
            // Place a check mark next to the item.
            //item3.Checked = true;
            item3.SubItems.Add("In 30 Min");
            item3.SubItems.Add("09:00");
            item3.SubItems.Add("Im Wartezimmer");
            item3.SubItems.Add("12");
            item3.SubItems.Add("Jessica Schäfer");
            item3.SubItems.Add("85");
            item3.SubItems.Add("0");
            item3.SubItems.Add("Schwindel, Unwohlsein");
            item3.SubItems.Add("Bluthochdruck");

            ListViewItem item4 = new ListViewItem("", 3);
            // Place a check mark next to the item.
            //item3.Checked = true;
            item4.SubItems.Add("In 90 Min");
            item4.SubItems.Add("09:30");
            item4.SubItems.Add("Im Wartezimmer");
            item4.SubItems.Add("13");
            item4.SubItems.Add("Marina Schmidt");
            item4.SubItems.Add("14");
            item4.SubItems.Add("0");
            item4.SubItems.Add("Zu niedrige Zuckerwerte");
            item4.SubItems.Add("Unterzuckerung");

            ListViewItem item5 = new ListViewItem("", 4);
            // Place a check mark next to the item.
            //item3.Checked = true;
            item5.SubItems.Add("In 120 Min");
            item5.SubItems.Add("10:00");
            item5.SubItems.Add("Im Wartezimmer");
            item5.SubItems.Add("15");
            item5.SubItems.Add("Murat Yildirim");
            item5.SubItems.Add("40");
            item5.SubItems.Add("0");
            item5.SubItems.Add("Husten, Schnupfen, Gliederschmerzen");
            item5.SubItems.Add("Grippaler Infekt");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Priorität", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Neubewertung", 110, HorizontalAlignment.Center);
            listView1.Columns.Add("Ankunft", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Status", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Patienten ID", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Patientenname", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Alter", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Behandlungszimmer", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Beschwerde", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Diagnose", -2, HorizontalAlignment.Left);
            //listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Rot.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Orange.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Gelb.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Gruen.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Blau.png"));

            //Assign the ImageList objects to the ListView.
            imageListSmall.ImageSize = new Size(50, 15);
            
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            //listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }

        public void createMyGroupBoxes()
        {
            //GroupBox1++
            GroupBox groupBoxStatus = new GroupBox();
            groupBoxStatus.Text = "Status";
            groupBoxStatus.Location = new Point(20, 20);
            groupBoxStatus.AutoSize = false;
            groupBoxStatus.Size = new Size(200, 180);
            this.Controls.Add(groupBoxStatus);

            //RadioButton1
            RadioButton radioCmdInBehandlung = new RadioButton();
            radioCmdInBehandlung.Text = "In Behandlung";
            radioCmdInBehandlung.Location = new Point(30,30);
            groupBoxStatus.Controls.Add(radioCmdInBehandlung);

            //RadioButton2
            RadioButton radioCmdImWartezimmer = new RadioButton();
            radioCmdImWartezimmer.Text = "Im Wartezimmer";
            radioCmdImWartezimmer.Location = new Point(30, 60);
            groupBoxStatus.Controls.Add(radioCmdImWartezimmer);

            //RadioButton3
            RadioButton radioCmdAmbulant = new RadioButton();
            radioCmdAmbulant.Text = "Ambulant";
            radioCmdAmbulant.Location = new Point(30,90);
            groupBoxStatus.Controls.Add(radioCmdAmbulant);

            //RadioButton4
            RadioButton radioCmdStationaer = new RadioButton();
            radioCmdStationaer.Text = "Stationär";
            radioCmdStationaer.Location = new Point(30, 120);
            groupBoxStatus.Controls.Add(radioCmdStationaer);

            //GroupBox2++
            GroupBox groupBoxTicketsystem = new GroupBox();
            groupBoxTicketsystem.Text = "Ticketsystem";
            groupBoxTicketsystem.Location = new Point(250, 20);
            groupBoxTicketsystem.AutoSize = false;
            groupBoxTicketsystem.Size = new Size(230, 180);

            this.Controls.Add(groupBoxTicketsystem);

            //Button1
            Button cmdPatientAufnehmen = new Button();
            cmdPatientAufnehmen.Location = new Point(30, 30);
            cmdPatientAufnehmen.Text = "Patient aufnehmen";
            cmdPatientAufnehmen.Size = new Size(155, 25);
            cmdPatientAufnehmen.Click += new EventHandler(cmdPatientAufnehmen_Click);
            groupBoxTicketsystem.Controls.Add(cmdPatientAufnehmen);

            //Button2
            Button cmdPatientStationaerAufnehmen = new Button();
            cmdPatientStationaerAufnehmen.Location = new Point(30, 70);
            cmdPatientStationaerAufnehmen.Text = "Patient stationär aufnehmen";
            cmdPatientStationaerAufnehmen.Size = new Size(155, 25);
            cmdPatientStationaerAufnehmen.Click += new EventHandler(cmdPatientStationaerAufnehmen_Click);
            groupBoxTicketsystem.Controls.Add(cmdPatientStationaerAufnehmen);

            //Button3
            Button cmdPatientEntlassen = new Button();
            cmdPatientEntlassen.Location = new Point(30, 110);
            cmdPatientEntlassen.Text = "Patient entlassen";
            cmdPatientEntlassen.Size = new Size(155, 25);
            cmdPatientEntlassen.Click += new EventHandler(cmdPatientEntlassen_Click);
            groupBoxTicketsystem.Controls.Add(cmdPatientEntlassen);

            // GroupBox3++
            GroupBox groupBoxPatientendatenAendern = new GroupBox();
            groupBoxPatientendatenAendern.Text = "Patientendaten";
            groupBoxPatientendatenAendern.Location = new Point(510, 20);
            groupBoxPatientendatenAendern.AutoSize = false;
            groupBoxPatientendatenAendern.Size = new Size(250, 180);
            this.Controls.Add(groupBoxPatientendatenAendern);

            //Button1
            Button cmdPatientendatenAendern = new Button();
            cmdPatientendatenAendern.Location = new Point(30, 30);
            cmdPatientendatenAendern.Text = "Patientendaten ändern";
            cmdPatientendatenAendern.Size = new Size(155, 25);
            groupBoxPatientendatenAendern.Controls.Add(cmdPatientendatenAendern);

            //Button2
            Button cmdPatientendatenLoeschen = new Button();
            cmdPatientendatenLoeschen.Location = new Point(30, 70);
            cmdPatientendatenLoeschen.Text = "Patientendaten löschen";
            cmdPatientendatenLoeschen.Size = new Size(155, 25);
            groupBoxPatientendatenAendern.Controls.Add(cmdPatientendatenLoeschen);

            //Button3
            Button cmdPatientendatenAktualisieren = new Button();
            cmdPatientendatenAktualisieren.Location = new Point(30, 110);
            cmdPatientendatenAktualisieren.Text = "Patientendaten aktualisieren";
            cmdPatientendatenAktualisieren.Size = new Size(155, 25);
            groupBoxPatientendatenAendern.Controls.Add(cmdPatientendatenAktualisieren);

            // GroupBox4++
            GroupBox groupBoxPrioritaetAendern = new GroupBox();
            groupBoxPrioritaetAendern.Text = "Priorität ändern";
            groupBoxPrioritaetAendern.Location = new Point(800, 20);
            groupBoxPrioritaetAendern.AutoSize = false;
            groupBoxPrioritaetAendern.Size = new Size(270, 180);
            this.Controls.Add(groupBoxPrioritaetAendern);

            //PictureBox1
            PictureBox pb = new PictureBox();
            pb.Location = new Point(35, 20);
            pb.Size = new Size(200, 115);
            pb.Image = Image.FromFile("C:\\Users\\egrad\\source\\repos\\Notaufnahme Ticketsystem\\Notaufnahme Ticketsystem\\Stufen Priorität.PNG");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            groupBoxPrioritaetAendern.Controls.Add(pb);

            //Button1
            Button cmdStatusAendern = new Button();
            cmdStatusAendern.Location = new Point(60, 145);
            cmdStatusAendern.Text = "Prioriät ändern";
            cmdStatusAendern.Size = new Size(155, 25);
            cmdStatusAendern.Click += new EventHandler(cmdStatusAendern_Click);
            groupBoxPrioritaetAendern.Controls.Add(cmdStatusAendern);
        }

        private void cmdPatientAufnehmen_Click(object sender, EventArgs e)
        {
            Patientenregister pRegister = new Patientenregister();
            pRegister.Show();
        }

        private void cmdPatientEntlassen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPatientStationaerAufnehmen_Click(object sender, EventArgs e)
        {

        }

        private void cmdStatusAendern_Click(object sender, EventArgs e)
        {

        }

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    System.Threading.Thread.Sleep(10000);
        //}
    }
}
