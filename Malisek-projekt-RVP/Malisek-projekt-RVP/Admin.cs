using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malisek_projekt_RVP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SU.TabIndex = 0;
            SZ.TabIndex = 1;
            button1.TabIndex = 2;
            Konec.TabIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formy.adminform.Hide();
            Formy.spravauzform.Show();
        }

        private void SZ_Click(object sender, EventArgs e)
        {
            Formy.adminform.Hide();
            Formy.spravavzform.Show();
        }

        private void Konec_Click(object sender, EventArgs e)
        {
            Program.core.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formy.adminform.Hide();
            Formy.SR.Show();
        }
    }
}
