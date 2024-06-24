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
    public partial class creationcompet : Form
    {
        public creationcompet()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn2 = basedd.ConnectBD();
            conn2.Open();
            string sql2 = "SELECT MAX(NUM_JURY) as maxjury FROM juge WHERE NUM_COMPETITION = @NumCompetition ";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            cmd2.Parameters.AddWithValue("@NumCompetition", dataGridViewCompetition.CurrentRow.Cells["NUM_COMPETITION"].Value);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            int NumJury = Convert.ToInt32(reader2["maxjury"]);


            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "INSERT INTO juge (NUM_COMPETITION, NUM_ENTRAINEUR, NUM_JURY) VALUES(@NumCompetition, @NumEntraineur, @NumJury)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NumCompetition", dataGridViewCompetition.CurrentRow.Cells["NUM_COMPETITION"].Value);
            cmd.Parameters.AddWithValue("@NumEntraineur", dataGridViewEntraineur.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.Parameters.AddWithValue("@NumJury", NumJury + 1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entraineur Ajouté...");
            conn.Close();
        }

        private void creationcompet_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();

            string sql = "SELECT entraineur.NOM_ENTRAINEUR, entraineur.PRENOM_ENTRAINEUR, entraineur.NUM_ENTRAINEUR FROM entraineur";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridViewEntraineur.Rows.Add(reader["NOM_ENTRAINEUR"], reader["PRENOM_ENTRAINEUR"], reader["NUM_ENTRAINEUR"]);
            }

            conn.Close();
            MySqlConnection conn2 = basedd.ConnectBD();
            conn2.Open();

            string sql2 = "SELECT competition.NUM_COMPETITION, competition.DATE_COMPETITION FROM competition";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                dataGridViewCompetition.Rows.Add(reader2["NUM_COMPETITION"], reader2["DATE_COMPETITION"]);
            }

            conn2.Close();
        }
    }
}
