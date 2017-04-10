using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff frmStaff = new frmStaff();
            frmStaff.Show();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            frmReader frmReader = new frmReader();
            frmReader.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frmBook = new frmBook();
            frmBook.Show();
        }
    }
}
