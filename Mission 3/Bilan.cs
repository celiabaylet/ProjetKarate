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
    public partial class Bilan : Form
    {
        public Bilan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SuiteVersParticipants_Click(object sender, EventArgs e)
        {
            ListeDesParticipants frm = new ListeDesParticipants(textBoxDateSaison.Text.ToString());
            frm.Show();
        }
    }
}
