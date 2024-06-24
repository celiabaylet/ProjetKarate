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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Création frm = new Création();
            frm.Show();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Modifier frm = new Modifier();
            frm.Show();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Modifier frm = new Modifier();
            frm.Show(); 
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
    }
}
