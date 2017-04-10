namespace LibraryManagementSystem
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
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
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
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
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::LibraryManagementSystem.Resource._Previous;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(77, 22);
            this.btnPrevious.Text = "&Previous";
            // 
            // btnNext
            // 
            this.btnNext.Image = global::LibraryManagementSystem.Resource._Next;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 22);
            this.btnNext.Text = "Ne&xt";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::LibraryManagementSystem.Resource._Edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 22);
            this.btnEdit.Text = "&Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::LibraryManagementSystem.Resource._Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 22);
            this.btnDelete.Text = "&Delete";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LibraryManagementSystem.Resource._Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 22);
            this.btnSave.Text = "&Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LibraryManagementSystem.Resource._Cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 22);
            this.btnCancel.Text = "&Cancel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 521);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 28);
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
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
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
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 153);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(357, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(357, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(97, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(357, 27);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 27);
            this.txtName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 27);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Public Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // frmBook
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
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book\'s Information";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdNationality;
        private System.Windows.Forms.DataGridViewImageColumn rdPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdActive;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}