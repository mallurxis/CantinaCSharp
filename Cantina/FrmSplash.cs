﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pctSplash_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            //frmLogin abrir = new frmLogin();
            //abrir.Show();
            //pgbSplash.Value = pgbSplash.Value + 1;
            //lblValor.Text = pgbSplash.Value.ToString();
            if (pgbSplash.Maximum < 100)
            {
                pgbSplash.Value = pgbSplash.Value + 1;
                    lblValor.Text = pgbSplash.Value.ToString();
            }
            else {
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
                tmrSplash.Enabled = false;
              
            }
        }
    }
}
