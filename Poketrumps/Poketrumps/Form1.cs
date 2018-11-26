using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poketrumps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayCreateAccount_Click(object sender, EventArgs e)
        {
            grdCreateAccount.Visible = true;
            btnDisplayCreateAccount.Visible = false;
            btnDisplayLogin.Visible = true;
            grdLogin.Visible = false;
        }

        private void btnDisplayLogin_Click(object sender, EventArgs e)
        {
            grdCreateAccount.Visible = false;
            btnDisplayCreateAccount.Visible = true;
            btnDisplayLogin.Visible = false;
            grdLogin.Visible = true;
        }
    }
}
