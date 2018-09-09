namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class ReleasingBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleasingBookForm));
            this.Button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.cmbYearlevel = new System.Windows.Forms.ComboBox();
            this.cmbAvailablebooks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBLSTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet14 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet14();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tBL_STUDENTTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet14TableAdapters.TBL_STUDENTTableAdapter();
            this.aNS_DATABASEDataSet15 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet15();
            this.tBLSTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_STUDENTTableAdapter1 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet15TableAdapters.TBL_STUDENTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet14)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(1322, 7);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 32);
            this.Button3.TabIndex = 211;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtStudID);
            this.groupBox3.Controls.Add(this.cmbYearlevel);
            this.groupBox3.Controls.Add(this.cmbAvailablebooks);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(101, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 229);
            this.groupBox3.TabIndex = 213;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Processing";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(162, 89);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(241, 27);
            this.txtStudentName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student ID :";
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(162, 50);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(241, 27);
            this.txtStudID.TabIndex = 25;
            this.txtStudID.Leave += new System.EventHandler(this.txtStudID_Leave);
            // 
            // cmbYearlevel
            // 
            this.cmbYearlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearlevel.FormattingEnabled = true;
            this.cmbYearlevel.Items.AddRange(new object[] {
            "1ST YEAR",
            "2ND YEAR",
            "3RD YEAR",
            "4TH YEAR"});
            this.cmbYearlevel.Location = new System.Drawing.Point(162, 130);
            this.cmbYearlevel.Name = "cmbYearlevel";
            this.cmbYearlevel.Size = new System.Drawing.Size(179, 26);
            this.cmbYearlevel.TabIndex = 21;
            this.cmbYearlevel.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // cmbAvailablebooks
            // 
            this.cmbAvailablebooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailablebooks.FormattingEnabled = true;
            this.cmbAvailablebooks.Items.AddRange(new object[] {
            "1ST YEAR",
            "2ND YEAR",
            "3RD YEAR",
            "4TH YEAR"});
            this.cmbAvailablebooks.Location = new System.Drawing.Point(162, 171);
            this.cmbAvailablebooks.Name = "cmbAvailablebooks";
            this.cmbAvailablebooks.Size = new System.Drawing.Size(241, 26);
            this.cmbAvailablebooks.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Books Available :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Year Level :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Name :";
            // 
            // tBLSTUDENTBindingSource
            // 
            this.tBLSTUDENTBindingSource.DataMember = "TBL_STUDENT";
            this.tBLSTUDENTBindingSource.DataSource = this.aNS_DATABASEDataSet14;
            // 
            // aNS_DATABASEDataSet14
            // 
            this.aNS_DATABASEDataSet14.DataSetName = "ANS_DATABASEDataSet14";
            this.aNS_DATABASEDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSAVE);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(101, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 148);
            this.groupBox2.TabIndex = 214;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Location = new System.Drawing.Point(9, 43);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(199, 70);
            this.btnSAVE.TabIndex = 19;
            this.btnSAVE.Text = "Released";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 215;
            this.label8.Text = "Transaction Books";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(519, 72);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(788, 383);
            this.dgvBooks.TabIndex = 216;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1276, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.TabIndex = 218;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1031, 41);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 25);
            this.textBox4.TabIndex = 217;
            // 
            // tBL_STUDENTTableAdapter
            // 
            this.tBL_STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // aNS_DATABASEDataSet15
            // 
            this.aNS_DATABASEDataSet15.DataSetName = "ANS_DATABASEDataSet15";
            this.aNS_DATABASEDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSTUDENTBindingSource1
            // 
            this.tBLSTUDENTBindingSource1.DataMember = "TBL_STUDENT";
            this.tBLSTUDENTBindingSource1.DataSource = this.aNS_DATABASEDataSet15;
            // 
            // tBL_STUDENTTableAdapter1
            // 
            this.tBL_STUDENTTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(211, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 70);
            this.button1.TabIndex = 20;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReleasingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "ReleasingBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book_Releasing";
            this.Load += new System.EventHandler(this.ReleasingBookForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet14)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbAvailablebooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private ANS_DATABASEDataSet14 aNS_DATABASEDataSet14;
        private System.Windows.Forms.BindingSource tBLSTUDENTBindingSource;
        private ANS_DATABASEDataSet14TableAdapters.TBL_STUDENTTableAdapter tBL_STUDENTTableAdapter;
        private ANS_DATABASEDataSet15 aNS_DATABASEDataSet15;
        private System.Windows.Forms.BindingSource tBLSTUDENTBindingSource1;
        private ANS_DATABASEDataSet15TableAdapters.TBL_STUDENTTableAdapter tBL_STUDENTTableAdapter1;
        private System.Windows.Forms.ComboBox cmbYearlevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox txtStudentName;
        internal System.Windows.Forms.Button button1;
    }
}