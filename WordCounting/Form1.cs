using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounting
{
    public partial class MainViev : Form
    {
        Logic lg = new Logic();
        public MainViev()
        {
            InitializeComponent();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lg.Separator = txbSeparator.Text;
            lg.FillSeparator();
        }

        private void btnSeparate_Click(object sender, EventArgs e)
        {
            lg.Text = rTxbSourceText.Text;
            dgvSeparateList.DataSource = lg.CountWord();
        }
    }
}
