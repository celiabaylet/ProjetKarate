﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Suppression_Click(object sender, EventArgs e)
        {
            modifcompet creacompet = new modifcompet();
            creacompet.Show();
        }

        private void Creation_Click(object sender, EventArgs e)
        {
            creationcompet creacompet = new creationcompet();
            creacompet.Show();
        }
    }
}
