using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission_3
{
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }

        private void dataGridViewEntraineur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "SELECT * FROM entraineur ORDER BY NOM_ENTRAINEUR";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewEntraineur.Rows.Add(reader["NUM_ENTRAINEUR"], reader["NUM_CLUB"], reader["NOM_ENTRAINEUR"], reader["PRENOM_ENTRAINEUR"]);
            }
            conn.Close();
        }

        private void Suppr_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = basedd.ConnectBD();
            conn.Open();
            string sql = "DELETE FROM entraineur WHERE NUM_ENTRAINEUR = @numentraineur ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@numentraineur", dataGridViewEntraineur.CurrentRow.Cells["NUM_ENTRAINEUR"].Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entraineur supprimé");
            conn.Close();
        }

        private void Modif_Click(object sender, EventArgs e)
        {
            Page_Modification frm = new Page_Modification(dataGridViewEntraineur.CurrentRow.Cells["NUM_ENTRAINEUR"].Value.ToString());
            frm.Show();
        }
    }
}
