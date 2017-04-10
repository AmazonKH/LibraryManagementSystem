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
    public partial class frmReprt : Form
    {
        public frmReprt()
        {
            InitializeComponent();
        }

        private void frmReprt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LMSDataSet.tblReader' table. You can move, or remove it, as needed.
            this.tblReaderTableAdapter.Fill(this.LMSDataSet.tblReader);

            this.reportViewer1.RefreshReport();
        }
    }
}
