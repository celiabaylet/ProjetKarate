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
    public partial class modifcompet : Form
    {
        public modifcompet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            MySqlConnection conn2 = basedd.ConnectBD();
            conn2.Open();
            string sql2 = "SELECT competition.NUM_COMPETITION, entraineur.NOM_ENTRAINEUR FROM entraineur INNER JOIN juge ON entraineur.NUM_ENTRAINEUR = juge.NUM_ENTRAINEUR INNER JOIN competition ON juge.NUM_COMPETITION = competition.NUM_COMPETITION WHERE entraineur.NUM_ENTRAINEUR = @numEntraineur";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            cmd2.Parameters.AddWithValue("@NumEntraineur", dataGridViewEntraineur2.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            string sql = "SELECT competition.NUM_COMPETITION, competition.DATE_COMPETITION, entraineur.NUM_ENTRAINEUR FROM entraineur INNER JOIN juge ON entraineur.NUM_ENTRAINEUR = juge.NUM_ENTRAINEUR INNER JOIN competition ON juge.NUM_COMPETITION = competition.NUM_COMPETITION WHERE entraineur.NUM_ENTRAINEUR = @numEntraineur";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NumEntraineur", dataGridViewEntraineur2.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            MySqlDataReader reader = cmd.ExecuteReader();
            string numéroCompétition = reader2["NUM_COMPETITION"].ToString();
            while (reader.Read())
            {
                dataGridViewCompetition2.Rows.Add(reader["NUM_COMPETITION"], reader["DATE_COMPETITION"]);
                foreach (DataGridViewRow row in dataGridViewCompetition2.Rows)
                {
                    DataGridViewCell cell = row.Cells[0];
                    if (cell.Value != null && cell.Value.ToString() == numéroCompétition)
                    {
                        dataGridViewCompetition2.CurrentCell = cell;
                        break;
                    }
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "DELETE FROM juge WHERE NUM_ENTRAINEUR = @NumEntraineur AND NUM_COMPETITION = @NumCompetition";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NumEntraineur", dataGridViewEntraineur2.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.Parameters.AddWithValue("@NumCompetition", dataGridViewCompetition2.CurrentRow.Cells["NUM_COMPETITION"].Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Competition enlevé...");
            conn.Close();
        }

        private void modifcompet_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();

            string sql = "SELECT entraineur.NOM_ENTRAINEUR, entraineur.PRENOM_ENTRAINEUR, entraineur.NUM_ENTRAINEUR FROM entraineur ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridViewEntraineur2.Rows.Add(reader["NOM_ENTRAINEUR"], reader["PRENOM_ENTRAINEUR"], reader["NUM_ENTRAINEUR"]);
            }

            conn.Close();
        }
    }
}
