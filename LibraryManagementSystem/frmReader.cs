using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class frmReader : Form
    {
        SqlConnection cnn = sqlcnn.getConnection();
        string save = "";
        public frmReader()
        {
            InitializeComponent();
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            toolStripcbo.Items.Add("Active");
            toolStripcbo.Items.Add("Inactive");
            toolStripcbo.Items.Add("All");
            toolStripcbo.Text = "Active";

            //loadData("TRUE");

            enableButton(false);
            btnNew.Enabled = true;

            enableTextBox(false);
        }
        void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            radioButton1.Checked = true;
            dtp1.ResetText();
            txtAddress.Clear();
            txtPhone.Clear();
            comboBox1.Items.Clear();
            pic1.Image = null;
            checkBox1.Checked = true;
        }
        void generateID()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.getReader()", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    int n = int.Parse(item[0].ToString()) + 1;
                    txtID.Text = n.ToString();
                }
            }
            else txtID.Text = "1001";
        }
        void enableButton(bool b)
        {
            btnNew.Enabled = b;
            btnPrevious.Enabled = b;
            btnNext.Enabled = b;
            btnEdit.Enabled = b;
            btnDelete.Enabled = b;
            btnSave.Enabled = b;
            btnCancel.Enabled = b;
        }
        void enableTextBox(bool b)
        {
            checkBox1.Enabled = b;

            txtName.Enabled = b;
            groupBox2.Enabled = b;
            dtp1.Enabled = b;
            txtAddress.Enabled = b;
            txtPhone.Enabled = b;
            comboBox1.Enabled = b;
            pic1.Enabled = b;
        }
        private void setData(string d)
        {
            cnn.Open();
            SqlCommand cmm = new SqlCommand(d, cnn);
            cmm.CommandType = CommandType.StoredProcedure;

            cmm.Parameters.AddWithValue("@i", txtID.Text);
            cmm.Parameters.AddWithValue("@n", txtName.Text);
            cmm.Parameters.AddWithValue("@g", gender());
            cmm.Parameters.AddWithValue("@dob", dtp1.Value);
            cmm.Parameters.AddWithValue("@a", txtAddress.Text);
            cmm.Parameters.AddWithValue("@p", txtPhone.Text);
            cmm.Parameters.AddWithValue("@na", comboBox1.Text);
            cmm.Parameters.AddWithValue("@ph", saveImage());
            cmm.Parameters.AddWithValue("@ac", checkBox1.Checked);

            cmm.ExecuteNonQuery();
            cmm.Dispose();
            cnn.Close();
        }
        private void loadData(string l)
        {
                SqlDataAdapter da = new SqlDataAdapter(l, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGV1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dGV1.Rows.Add();
                    dGV1.Rows[n].Cells[0].Value = item[0].ToString();
                    dGV1.Rows[n].Cells[1].Value = item[1].ToString();
                    dGV1.Rows[n].Cells[2].Value = item[2].ToString();
                    dGV1.Rows[n].Cells[3].Value = item[3].ToString();
                    dGV1.Rows[n].Cells[4].Value = item[4].ToString();
                    dGV1.Rows[n].Cells[5].Value = item[5].ToString();
                    dGV1.Rows[n].Cells[6].Value = item[6].ToString();
                    dGV1.Rows[n].Cells[7].Value = item[7];
                    dGV1.Rows[n].Cells[8].Value = item[8].ToString();
                }
                dt.Dispose();
                da.Dispose();
        }
        string gender()
        {
            string g = null;
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked)
                    g = rb.Text;
            }
            return g;
        }
        byte[] saveImage()
        {
            MemoryStream ms = new MemoryStream();
            pic1.Image.Save(ms, pic1.Image.RawFormat);
            return (ms.GetBuffer());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            save = "New";
            pic1.ImageLocation = @"D:\C# Programming\WinForms\LibraryManagementSystem\LibraryManagementSystem\Resources\blank.png";

            enableButton(false);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            enableTextBox(true);
            clearTextBox();
            generateID();
            radioButton1.Checked = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            save = "";

            enableButton(false);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            enableTextBox(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setData("DeleteReader");
            loadData("SELECT * FROM dbo.getReader() WHERE rdActive = 'TRUE'");

            enableButton(false);
            btnNew.Enabled = true;

            clearTextBox();
            enableTextBox(false);
            MessageBox.Show("Deleted successfully!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (save == "New")
            {
                save = "";
                setData("InsertReader");
                loadData("SELECT * FROM dbo.getReader() WHERE rdActive = 'TRUE'");
                MessageBox.Show("Saved successfully!");
            }
            else
            {
                setData("UpdateReader");
                loadData("SELECT * FROM dbo.getReader() WHERE rdActive = 'TRUE'");
                MessageBox.Show("Update successfully!");
            }

            enableButton(false);
            btnNew.Enabled = true;

            clearTextBox();
            enableTextBox(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save = "";
            enableButton(false);
            btnNew.Enabled = true;

            clearTextBox();
            enableTextBox(false);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG | *.jpg; *.jpeg; *.jpe; *.jfif | All Picture Files | *.*";
            openFileDialog1.FileName = null;
            DialogResult dlr = openFileDialog1.ShowDialog();
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (dlr == DialogResult.OK)
            {
                pic1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                pic1.ImageLocation = @"D:\C# Programming\WinForms\LibraryManagementSystem\LibraryManagementSystem\Resources\blank.png";
            }
        }

        private void dGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            enableButton(true);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            enableTextBox(false);

            if (dGV1.Rows.Count > 0)
            {
                txtID.Text = dGV1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dGV1.SelectedRows[0].Cells[1].Value.ToString();

                foreach (RadioButton rb in groupBox2.Controls)
                {
                    if (rb.Text == dGV1.SelectedRows[0].Cells[2].Value.ToString())
                        rb.Checked = true;
                }

                dtp1.Value = DateTime.Parse(dGV1.SelectedRows[0].Cells[3].Value.ToString());

                txtAddress.Text = dGV1.SelectedRows[0].Cells[4].Value.ToString();
                txtPhone.Text = dGV1.SelectedRows[0].Cells[5].Value.ToString();
                comboBox1.Text = dGV1.SelectedRows[0].Cells[6].Value.ToString();

                try
                {
                    MemoryStream ms = new MemoryStream((byte[])dGV1.SelectedRows[0].Cells[7].Value);
                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                checkBox1.Checked = bool.Parse(dGV1.SelectedRows[0].Cells[8].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please fitler the data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dGV1.CurrentRow.Index < dGV1.Rows.Count - 1)
            {
                dGV1.CurrentCell = dGV1.Rows[dGV1.CurrentRow.Index + 1].Cells[0];
                dGV1.Rows[dGV1.CurrentCell.RowIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("Last record");
            }

            dGV1_CellClick(sender, null);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (dGV1.CurrentRow.Index - 1 >= 0)
            {
                dGV1.CurrentCell = dGV1.Rows[dGV1.CurrentRow.Index - 1].Cells[0];
                dGV1.Rows[dGV1.CurrentCell.RowIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("First record");
            }

            dGV1_CellClick(sender, null);
        }

        private void toolStripcbo_TextChanged(object sender, EventArgs e)
        {
            if (toolStripcbo.Text == "Active")
            {
                loadData("SELECT * FROM dbo.getReader() WHERE rdActive = 'TRUE'");
            }
            else if(toolStripcbo.Text=="Inactive")
            {
                loadData("SELECT * FROM dbo.getReader() WHERE rdActive = 'FALSE'");
            }
            else loadData("SELECT * FROM dbo.getReader()");
        }

        private void txtSID_KeyUp(object sender, KeyEventArgs e)
        {
            if (toolStripcbo.Text == "Active")
            {
                loadData("SELECT * FROM tblReader WHERE rdID LIKE '%' + '" + txtSID.Text + "' + '%' AND rdActive='TRUE'");
            }
            else if (toolStripcbo.Text == "Inactive")
            {
                loadData("SELECT * FROM tblReader WHERE rdID LIKE '%' + '" + txtSID.Text + "' + '%' AND rdActive='FALSE'");
            }
            else loadData("SELECT * FROM tblReader WHERE rdID LIKE '%' + '" + txtSID.Text + "' + '%'");
        }
        private void txtSName_KeyUp(object sender, KeyEventArgs e)
        {
            if (toolStripcbo.Text == "Active")
            {
                loadData("SELECT * FROM tblReader WHERE rdName LIKE '%' + '" + txtSName.Text + "' + '%' AND rdActive='TRUE'");
            }
            else if (toolStripcbo.Text == "Inactive")
            {
                loadData("SELECT * FROM tblReader WHERE rdName LIKE '%' + '" + txtSName.Text + "' + '%' AND rdActive='FALSE'");
            }
            else loadData("SELECT * FROM tblReader WHERE rdName LIKE '%' + '" + txtSName.Text + "' + '%'");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReprt f = new frmReprt();
            f.Show();
        }
    }
}
