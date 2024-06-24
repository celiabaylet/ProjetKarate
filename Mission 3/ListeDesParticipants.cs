using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission_3
{
    public partial class ListeDesParticipants : Form
    {
        String date_valeur;
        public ListeDesParticipants(string date_valeur)
        {
            InitializeComponent();
            this.date_valeur = date_valeur;
        }

        private void ListeDesParticipants_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "SELECT * FROM `membre` INNER JOIN inscription ON membre.NUM_LICENCE= inscription.NUM_LICENCE INNER JOIN competition ON competition.NUM_COMPETITION = inscription.NUM_COMPETITION WHERE year(DATE_COMPETITION) = @saison";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@saison", date_valeur);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewListeParticipant.Rows.Add(reader["NUM_LICENCE"], reader["NOM_MEMBRE"], reader["PRENOM_MEMBRE"], reader["DATE_NAISSANCE"], reader["ADR_RUE_MEMBRE"], reader["CODE_POST_MEMBRE"], reader["ADR_VILLE_MEMBRE"]);
            }
            conn.Close();
        }

        private void Suite_Click(object sender, EventArgs e)
        {
            Bilan_saison frm = new Bilan_saison(dataGridViewListeParticipant.CurrentRow.Cells["NUM_LICENCE"].Value.ToString());
            frm.Show();
        }
    }
}
