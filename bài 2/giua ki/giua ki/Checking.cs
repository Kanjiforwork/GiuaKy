using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giua_ki
{
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
        }

        private void Checking_Load(object sender, EventArgs e)
        {

        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }
    }
}
