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
    public partial class Création : Form
    {
        public Création()
        {
            InitializeComponent();
        }

        private void Création_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "SELECT * FROM club ORDER BY NUM_CLUB";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewClub.Rows.Add(reader["NUM_CLUB"], reader["NOM_CLUB"]);
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "INSERT INTO entraineur (NUM_CLUB,NOM_ENTRAINEUR,PRENOM_ENTRAINEUR) VALUES(@numclub, @nom, @prenom)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@numclub", dataGridViewClub.CurrentRow.Cells["NUM_CLUB"].Value);
            cmd.Parameters.AddWithValue("@nom", textNom.Text);
            cmd.Parameters.AddWithValue("@prenom", textPrenom.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entraineur inséré");
            conn.Close();
        }
    }
}
