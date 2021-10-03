using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ankkabase
{
    public partial class formMain : Form // Määritetän ja Avataan yhteys tietokantaan -->
    {
        SqlConnection connection;
        string connectionString;

        public formMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Ankkabase.Properties.Settings.AnkkabaseConnectionString"].ConnectionString;
        }
        // <--- määritys loppuu

        private void formMain_Load(object sender, EventArgs e) //suoritetaan ohejlman ikkunan käynnistyessä
        {
            PopulateYritykset();
            
        }

        private void PopulateYritykset() // Hakee tietokannasta taulukosta Yritys kaikki teidot ja siirtä ne taulukkomuuttujaan yritysTable 
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Yritys", connection))
            {
                DataTable yritysTable = new DataTable(); //Siirretään sadut tiedot taulukomuuttujaan
                adapter.Fill(yritysTable);

                // Ohjelman obejktiin listYritykset kirjoitetaan taulukosta Yritys-sarakkeen tiedot. Taulukossa on sarake Id joka on yksilölllinen arvo jokaiselle riville
                listYritykset.DisplayMember = "Yritys";
                listYritykset.ValueMember = "Id";
                listYritykset.DataSource = yritysTable;
            }
            
            
        }

        

        private void PopulateTyontekijat() // Tämä scripti ajetaan kun lisYritykset valinta muuttuu
                                           // Hakee tietokannasta Taulukosta Nimi sarakkeet Etunimi, Sukunimi ja Osoite. Siellä on paljon muutakin.
                                           // Jos halutaan kaikki tiedot, niin käytetään SELECT * FROM Nimi. 
                                           // YritysNimet on taulukko, jossa on yhdistetty Nimi taulukon ja Yritys taulukon Id numeroita muodostaen taulukon joka kertoo kuka
                                           // kuuluu mihinkin työpaikkaan.
                                           // Esim Taulukon Nimi Mummo Ankalla on Id 5 ja Taulokon Yritys Mummo Ankan Maatilalla on iD 3
                                           // Taulukossa YritysNimet on kerrttu että Nimi Id3 kuuluu Yritys Id 5.
                                           
        {
            string query = "SELECT a.Etunimi, a.Sukunimi, a.Osoite FROM Nimi a " +
                "INNER JOIN YritysNimet b ON a.Id = b.NimiId " +
                "WHERE b.YritysId = @YritysId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@YritysId", listYritykset.SelectedValue);

                DataTable nimiTable = new DataTable(); //Siirretään saadut teidot taulukkomuuttujaan
                adapter.Fill(nimiTable);

                // Ohjelman obejktiin listNimet kirjoitetaan taulukosta Etunimi-sarakkeen tiedot. Taulukossa on sarake Id joka on yksilölllinen arvo jokaiselle riville
                listNimet.DisplayMember = "Etunimi";
                listNimet.ValueMember = "Id";
                listNimet.DataSource = nimiTable;

                // taulukko objektiin dataGridView1 tulostetaan koko nimiTablen sisältö. Se näppärästi näyttää taulukon ninkuin taulukko kuuluu näyttää
                dataGridView1.DataSource = nimiTable;
                                 

            }


        }

        
        private void listYritykset_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTyontekijat();
        }


    }
}
