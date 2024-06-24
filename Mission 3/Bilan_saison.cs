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
    public partial class Bilan_saison : Form
    {
        string membre_choisi;
        public Bilan_saison(string membre_choisi)
        {
            InitializeComponent();
            this.membre_choisi = membre_choisi;
        }

        private void Bilan_saison_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "SELECT * FROM `membre` INNER JOIN inscription ON membre.NUM_LICENCE= inscription.NUM_LICENCE INNER JOIN competition ON competition.NUM_COMPETITION = inscription.NUM_COMPETITION INNER JOIN club ON competition.NUM_CLUB = club.NUM_CLUB  WHERE membre.NUM_LICENCE = @membre_choisi";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@membre_choisi", membre_choisi);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["DATE_COMPETITION"], reader["ADR_RUE_CLUB"], reader["CODE_POST_CLUB"], reader["ADR_VILLE_CLUB"], reader["NOTE_GLOBALE"]);
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
