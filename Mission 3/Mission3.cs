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
    public partial class Mission3 : Form
    {
        public Mission3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GestionEntraineur_Click(object sender, EventArgs e)
        {
            Accueil frm = new Accueil();
            frm.Show();
        }

        private void AffectationEntraîneurs_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void AffichageBilan_Click(object sender, EventArgs e)
        {
            Bilan frm = new Bilan();
            frm.Show();
        }
    }
}
