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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mission_3
{
    public partial class Page_Modification : Form
    {
        string valeur_entraineur;
        public Page_Modification(string NUM_Entraineur)
        {
            InitializeComponent();
            this.valeur_entraineur = NUM_Entraineur;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuméroModif_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Page_Modification_Load(object sender, EventArgs e)
        {
            Modifier modif = new Modifier();
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            MySqlConnection conn2 = basedd.ConnectBD();
            conn2.Open();
            string sql2 = "SELECT * FROM entraineur WHERE NUM_ENTRAINEUR = @numentraineur";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn2);
            cmd2.Parameters.AddWithValue("@numentraineur", valeur_entraineur);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            string sql = "SELECT * FROM club ORDER BY NOM_CLUB";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string numéroClub = reader2["NUM_CLUB"].ToString();
            while (reader.Read())
            {
                dataGridViewNumClub.Rows.Add(reader["NUM_CLUB"], reader["NOM_CLUB"], reader["ADR_RUE_CLUB"], reader["ADR_VILLE_CLUB"]);
                if (reader2["NUM_CLUB"].ToString() == reader["NUM_CLUB"].ToString())
                {
                    foreach (DataGridViewRow row in dataGridViewNumClub.Rows)
                    {
                        DataGridViewCell cell = row.Cells[0];
                        if (cell.Value != null && cell.Value.ToString() == numéroClub)
                        {
                            dataGridViewNumClub.CurrentCell = cell;
                            break;
                        }
                    }
                }
            }
            NomModif.Text = reader2["NOM_ENTRAINEUR"].ToString();
            PrénomModif.Text = reader2["PRENOM_ENTRAINEUR"].ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void conclure_Click(object sender, EventArgs e)
        {
            Modifier modif = new Modifier();
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql2 = "UPDATE entraineur SET NUM_ENTRAINEUR = @numentraineur, NUM_CLUB = @numclub, NOM_ENTRAINEUR = @nomentraineur, PRENOM_ENTRAINEUR = @prenomentraineur WHERE NUM_ENTRAINEUR = @numentraineur";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@numclub", dataGridViewNumClub.CurrentRow.Cells["NUM_CLUB"].Value);
            cmd2.Parameters.AddWithValue("@nomentraineur", NomModif.Text);
            cmd2.Parameters.AddWithValue("@prenomentraineur", PrénomModif.Text);
            cmd2.Parameters.AddWithValue("@numentraineur", valeur_entraineur);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Entraineur modifié");
            conn.Close();
        }
    }
}
