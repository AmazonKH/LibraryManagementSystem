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
    public partial class frmStaff : Form
    {
        SqlConnection cnn = sqlcnn.getConnection();
        string save = "";
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadData();
            enableButton(false);
            btnNew.Enabled = true;
            enableTextBox(false);
            try
            {
                cnn.Open();
                MessageBox.Show("Successfully!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            loadData();
            dGV1.ClearSelection();
            pic1.ImageLocation = @"D:\C# Programming\WinForms\LibraryManagementSystem\LibraryManagementSystem\Resources\blank.png";
            enableButton(false);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            save = "New";
            clearTextBox();
            generateID();
            enableTextBox(true);
            txtID.Focus();
            radioButton1.Checked = true;
            Nationality();
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
            setData("DeleteStaff");
            loadData();
            enableButton(false);
            btnNew.Enabled = true;
            clearTextBox();
            enableTextBox(false);
            MessageBox.Show("Deleted sucessfully!");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (save == "New")
            {
                save = "";
                setData("InsertStaff");
                loadData();
                MessageBox.Show("Saved sucessfully!");

            }
            else
            {
                setData("UpdateStaff");
                loadData();
                MessageBox.Show("Updated sucessfully!");
            }
            enableButton(false);
            btnNew.Enabled = true;
            enableTextBox(false);
            clearTextBox();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            save = "";
            enableButton(false);
            btnNew.Enabled = true;
            clearTextBox();
            enableTextBox(false);
        }
        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.getStaff() WHERE stActive = 'TRUE'", cnn);
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
                dGV1.Rows[n].Cells[6].Value = item[6];
                dGV1.Rows[n].Cells[7].Value = item[7].ToString();
            }
            dt.Dispose();
            da.Dispose();
        }
        private void setData(string d)
        {
            SqlCommand cmm = new SqlCommand(d, cnn);
            cmm.CommandType = CommandType.StoredProcedure;
            cmm.Parameters.AddWithValue("@i", txtID.Text);
            cmm.Parameters.AddWithValue("@n", txtName.Text);
            cmm.Parameters.AddWithValue("@g", gender());
            cmm.Parameters.AddWithValue("@a", txtAddress.Text);
            cmm.Parameters.AddWithValue("@p", txtPhone.Text);
            cmm.Parameters.AddWithValue("@na", comboBox1.Text);
            cmm.Parameters.AddWithValue("@ph", saveImage());
            cmm.Parameters.AddWithValue("@ac", checkBox1.Checked);
            cmm.ExecuteNonQuery();
            cmm.Dispose();
        }
        byte[] saveImage()
        {
            MemoryStream ms = new MemoryStream();
            pic1.Image.Save(ms, pic1.Image.RawFormat);
            return (ms.GetBuffer());
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
        void Nationality()
        {
            comboBox1.Items.Clear();
            foreach(DataGridViewRow dgr in dGV1.Rows)
            {
                comboBox1.Items.Add(dgr.Cells[5].Value.ToString());
            }
        }
        void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            radioButton1.Checked = true;
            txtAddress.Clear();
            txtPhone.Clear();
            comboBox1.Items.Clear();
            pic1.Image = null;
            checkBox1.Checked = true;
        }
        void generateID()
        {
            if (dGV1.Rows.Count > 0)
            {
                int n = int.Parse(dGV1.Rows[dGV1.RowCount - 1].Cells[0].Value.ToString()) + 1;
                txtID.Text = n.ToString();
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
            checkBox1.Checked = b;
            checkBox1.Enabled = b;
            
            txtName.Enabled = b;
            groupBox2.Enabled = b;
            txtAddress.Enabled = b;
            txtPhone.Enabled = b;
            comboBox1.Enabled = b;
            pic1.Enabled = b;
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

                txtAddress.Text = dGV1.SelectedRows[0].Cells[3].Value.ToString();
                txtPhone.Text = dGV1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dGV1.SelectedRows[0].Cells[5].Value.ToString();

                try
                {
                    MemoryStream ms = new MemoryStream((byte[])dGV1.SelectedRows[0].Cells[6].Value);
                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Image = Image.FromStream(ms);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                checkBox1.Checked = bool.Parse(dGV1.SelectedRows[0].Cells[7].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please fitler the data!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            //if (dGV1.CurrentRow == null) return;
            try
            {
                if (dGV1.CurrentRow.Index < dGV1.Rows.Count - 1)
                {
                    dGV1.CurrentCell = dGV1.Rows[dGV1.CurrentRow.Index + 1].Cells[0];
                    dGV1.Rows[dGV1.CurrentCell.RowIndex].Selected = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGV1.CurrentRow.Index -1 >= 0)
                {
                    dGV1.CurrentCell = dGV1.Rows[dGV1.CurrentRow.Index - 1].Cells[0];
                    dGV1.Rows[dGV1.CurrentCell.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
