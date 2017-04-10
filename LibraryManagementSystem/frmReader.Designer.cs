namespace LibraryManagementSystem
{
    partial class frmReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReader));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripcbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSNationality = new System.Windows.Forms.TextBox();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSGender = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.rdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.rdActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.7F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnPrevious,
            this.btnNext,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.toolStripLabel1,
            this.toolStripcbo,
            this.btnReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.7F);
            this.btnNew.Image = global::LibraryManagementSystem.Resource._New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 22);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::LibraryManagementSystem.Resource._Previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(77, 22);
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::LibraryManagementSystem.Resource._Next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 22);
            this.btnNext.Text = "Ne&xt";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::LibraryManagementSystem.Resource._Edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 22);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::LibraryManagementSystem.Resource._Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 22);
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LibraryManagementSystem.Resource._Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LibraryManagementSystem.Resource._Cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 22);
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "Filter";
            // 
            // toolStripcbo
            // 
            this.toolStripcbo.Name = "toolStripcbo";
            this.toolStripcbo.Size = new System.Drawing.Size(75, 25);
            this.toolStripcbo.TextChanged += new System.EventHandler(this.toolStripcbo_TextChanged);
            // 
            // btnReport
            // 
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(68, 22);
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSNationality);
            this.groupBox1.Controls.Add(this.txtSPhone);
            this.groupBox1.Controls.Add(this.txtSAddress);
            this.groupBox1.Controls.Add(this.txtSGender);
            this.groupBox1.Controls.Add(this.txtSName);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Controls.Add(this.dGV1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 521);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtSNationality
            // 
            this.txtSNationality.Location = new System.Drawing.Point(635, 225);
            this.txtSNationality.Name = "txtSNationality";
            this.txtSNationality.Size = new System.Drawing.Size(119, 27);
            this.txtSNationality.TabIndex = 18;
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(518, 225);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(118, 27);
            this.txtSPhone.TabIndex = 18;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(400, 225);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(119, 27);
            this.txtSAddress.TabIndex = 18;
            // 
            // txtSGender
            // 
            this.txtSGender.Location = new System.Drawing.Point(283, 225);
            this.txtSGender.Name = "txtSGender";
            this.txtSGender.Size = new System.Drawing.Size(118, 27);
            this.txtSGender.TabIndex = 18;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(165, 225);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(119, 27);
            this.txtSName.TabIndex = 18;
            this.txtSName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSName_KeyUp);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(47, 225);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(119, 27);
            this.txtSID.TabIndex = 18;
            this.txtSID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSID_KeyUp);
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(302, 86);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(152, 27);
            this.dtp1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(535, 16);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(152, 192);
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdID,
            this.rdName,
            this.rdGender,
            this.rdDOB,
            this.rdAddress,
            this.rdPhone,
            this.rdNationality,
            this.rdPhoto,
            this.rdActive});
            this.dGV1.Location = new System.Drawing.Point(6, 252);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV1.Size = new System.Drawing.Size(748, 263);
            this.dGV1.TabIndex = 13;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            // 
            // rdID
            // 
            this.rdID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdID.HeaderText = "Reader\'s ID";
            this.rdID.Name = "rdID";
            this.rdID.ReadOnly = true;
            // 
            // rdName
            // 
            this.rdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdName.HeaderText = "Name";
            this.rdName.Name = "rdName";
            this.rdName.ReadOnly = true;
            // 
            // rdGender
            // 
            this.rdGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdGender.HeaderText = "Gender";
            this.rdGender.Name = "rdGender";
            this.rdGender.ReadOnly = true;
            // 
            // rdDOB
            // 
            this.rdDOB.HeaderText = "Date of Birth";
            this.rdDOB.Name = "rdDOB";
            this.rdDOB.ReadOnly = true;
            this.rdDOB.Visible = false;
            // 
            // rdAddress
            // 
            this.rdAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdAddress.HeaderText = "Address";
            this.rdAddress.Name = "rdAddress";
            this.rdAddress.ReadOnly = true;
            // 
            // rdPhone
            // 
            this.rdPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdPhone.HeaderText = "Phone";
            this.rdPhone.Name = "rdPhone";
            this.rdPhone.ReadOnly = true;
            // 
            // rdNationality
            // 
            this.rdNationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rdNationality.HeaderText = "Nationality";
            this.rdNationality.Name = "rdNationality";
            this.rdNationality.ReadOnly = true;
            // 
            // rdPhoto
            // 
            this.rdPhoto.HeaderText = "Photo";
            this.rdPhoto.Name = "rdPhoto";
            this.rdPhoto.ReadOnly = true;
            this.rdPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rdPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rdPhoto.Visible = false;
            // 
            // rdActive
            // 
            this.rdActive.HeaderText = "Active";
            this.rdActive.Name = "rdActive";
            this.rdActive.ReadOnly = true;
            this.rdActive.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(460, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(358, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(358, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(96, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(358, 27);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(358, 27);
            this.txtName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(96, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(106, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader\'s Information";
            this.Load += new System.EventHandler(this.frmReader_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdNationality;
        private System.Windows.Forms.DataGridViewImageColumn rdPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdActive;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ToolStripComboBox toolStripcbo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txtSNationality;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSGender;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.ToolStripButton btnReport;
    }
}