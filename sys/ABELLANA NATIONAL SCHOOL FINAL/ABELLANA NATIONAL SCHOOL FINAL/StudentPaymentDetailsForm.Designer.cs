namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class StudentPaymentDetailsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPaymentDetailsForm));
            this.Button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPayDetails = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSYID = new System.Windows.Forms.Label();
            this.cmbPayfor = new System.Windows.Forms.ComboBox();
            this.lbPYID = new System.Windows.Forms.Label();
            this.cmbSY = new System.Windows.Forms.ComboBox();
            this.tBLSCHOOLYEARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet5 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aNSDATABASEDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SCHOOLYEARTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet5TableAdapters.TBL_SCHOOLYEARTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPay = new System.Windows.Forms.Button();
            this.aNS_DATABASEDataSet6 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet6();
            this.tBLPAYMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_PAYMENTTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet6TableAdapters.TBL_PAYMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSCHOOLYEARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPAYMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(1324, 12);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 31);
            this.Button3.TabIndex = 184;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "PAYMENT DETAILS";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(955, 63);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 25);
            this.txtSearch.TabIndex = 205;
            // 
            // dgvPayDetails
            // 
            this.dgvPayDetails.AllowUserToAddRows = false;
            this.dgvPayDetails.AllowUserToDeleteRows = false;
            this.dgvPayDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayDetails.Location = new System.Drawing.Point(581, 94);
            this.dgvPayDetails.Name = "dgvPayDetails";
            this.dgvPayDetails.ReadOnly = true;
            this.dgvPayDetails.Size = new System.Drawing.Size(688, 347);
            this.dgvPayDetails.TabIndex = 204;
            this.dgvPayDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayDetails_CellContentClick);
            this.dgvPayDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayDetails_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(107, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 104);
            this.groupBox3.TabIndex = 208;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(125, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 46);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(284, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPay);
            this.groupBox2.Controls.Add(this.lbSYID);
            this.groupBox2.Controls.Add(this.cmbPayfor);
            this.groupBox2.Controls.Add(this.lbPYID);
            this.groupBox2.Controls.Add(this.cmbSY);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(107, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 138);
            this.groupBox2.TabIndex = 207;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Payment";
            // 
            // lbSYID
            // 
            this.lbSYID.AutoSize = true;
            this.lbSYID.Location = new System.Drawing.Point(221, 60);
            this.lbSYID.Name = "lbSYID";
            this.lbSYID.Size = new System.Drawing.Size(0, 18);
            this.lbSYID.TabIndex = 29;
            this.lbSYID.Visible = false;
            // 
            // cmbPayfor
            // 
            this.cmbPayfor.DataSource = this.tBLPAYMENTBindingSource;
            this.cmbPayfor.DisplayMember = "PAYMENT_NAME";
            this.cmbPayfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayfor.FormattingEnabled = true;
            this.cmbPayfor.Location = new System.Drawing.Point(134, 62);
            this.cmbPayfor.Name = "cmbPayfor";
            this.cmbPayfor.Size = new System.Drawing.Size(280, 26);
            this.cmbPayfor.TabIndex = 28;
            this.cmbPayfor.ValueMember = "PAYMENT_ID";
            // 
            // lbPYID
            // 
            this.lbPYID.AutoSize = true;
            this.lbPYID.Location = new System.Drawing.Point(23, 101);
            this.lbPYID.Name = "lbPYID";
            this.lbPYID.Size = new System.Drawing.Size(0, 18);
            this.lbPYID.TabIndex = 27;
            this.lbPYID.Visible = false;
            // 
            // cmbSY
            // 
            this.cmbSY.DataSource = this.tBLSCHOOLYEARBindingSource;
            this.cmbSY.DisplayMember = "SCHOOLYEAR";
            this.cmbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSY.FormattingEnabled = true;
            this.cmbSY.Location = new System.Drawing.Point(134, 29);
            this.cmbSY.Name = "cmbSY";
            this.cmbSY.Size = new System.Drawing.Size(328, 26);
            this.cmbSY.TabIndex = 26;
            this.cmbSY.ValueMember = "SCHOOLYEAR_ID";
            // 
            // tBLSCHOOLYEARBindingSource
            // 
            this.tBLSCHOOLYEARBindingSource.DataMember = "TBL_SCHOOLYEAR";
            this.tBLSCHOOLYEARBindingSource.DataSource = this.aNS_DATABASEDataSet5;
            // 
            // aNS_DATABASEDataSet5
            // 
            this.aNS_DATABASEDataSet5.DataSetName = "ANS_DATABASEDataSet5";
            this.aNS_DATABASEDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "School Year :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Payment For :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(134, 96);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(328, 27);
            this.txtAmount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount :";
            // 
            // aNSDATABASEDataSet5BindingSource
            // 
            this.aNSDATABASEDataSet5BindingSource.DataSource = this.aNS_DATABASEDataSet5;
            this.aNSDATABASEDataSet5BindingSource.Position = 0;
            // 
            // tBL_SCHOOLYEARTableAdapter
            // 
            this.tBL_SCHOOLYEARTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1238, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.TabIndex = 211;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPay
            // 
            this.btnAddPay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPay.ForeColor = System.Drawing.Color.White;
            this.btnAddPay.Location = new System.Drawing.Point(416, 60);
            this.btnAddPay.Name = "btnAddPay";
            this.btnAddPay.Size = new System.Drawing.Size(46, 28);
            this.btnAddPay.TabIndex = 14;
            this.btnAddPay.Text = "...";
            this.btnAddPay.UseVisualStyleBackColor = false;
            this.btnAddPay.Click += new System.EventHandler(this.btnAddPay_Click);
            // 
            // aNS_DATABASEDataSet6
            // 
            this.aNS_DATABASEDataSet6.DataSetName = "ANS_DATABASEDataSet6";
            this.aNS_DATABASEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPAYMENTBindingSource
            // 
            this.tBLPAYMENTBindingSource.DataMember = "TBL_PAYMENT";
            this.tBLPAYMENTBindingSource.DataSource = this.aNS_DATABASEDataSet6;
            // 
            // tBL_PAYMENTTableAdapter
            // 
            this.tBL_PAYMENTTableAdapter.ClearBeforeFill = true;
            // 
            // StudentPaymentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPayDetails);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "StudentPaymentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.StudentPaymentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSCHOOLYEARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPAYMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPayDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSY;
        private System.Windows.Forms.Label label1;
        private ANS_DATABASEDataSet5 aNS_DATABASEDataSet5;
        private System.Windows.Forms.BindingSource aNSDATABASEDataSet5BindingSource;
        private System.Windows.Forms.BindingSource tBLSCHOOLYEARBindingSource;
        private ANS_DATABASEDataSet5TableAdapters.TBL_SCHOOLYEARTableAdapter tBL_SCHOOLYEARTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPYID;
        private System.Windows.Forms.ComboBox cmbPayfor;
        private System.Windows.Forms.Label lbSYID;
        private System.Windows.Forms.Button btnAddPay;
        private ANS_DATABASEDataSet6 aNS_DATABASEDataSet6;
        private System.Windows.Forms.BindingSource tBLPAYMENTBindingSource;
        private ANS_DATABASEDataSet6TableAdapters.TBL_PAYMENTTableAdapter tBL_PAYMENTTableAdapter;

    }
}