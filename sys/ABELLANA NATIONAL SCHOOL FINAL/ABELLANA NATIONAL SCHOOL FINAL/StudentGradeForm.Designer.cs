namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class StudentGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradeForm));
            this.Button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.SUBJECT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_GRADING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECOND_GRADING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THIRD_GRADING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOURTH_GRADING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLSTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet2 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtscid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewStud = new System.Windows.Forms.Button();
            this.txtsub = new System.Windows.Forms.ComboBox();
            this.tBLSUBJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet1 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet1();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.txtgrper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBL_SUBJECTTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet1TableAdapters.TBL_SUBJECTTableAdapter();
            this.tBL_STUDENTTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet2TableAdapters.TBL_STUDENTTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSUBJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.Button3.TabIndex = 183;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 187;
            this.label4.Text = " GRADE";
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AllowUserToDeleteRows = false;
            this.dgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrade.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SUBJECT_ID,
            this.SUBJECT,
            this.FIRST_GRADING,
            this.SECOND_GRADING,
            this.THIRD_GRADING,
            this.FOURTH_GRADING});
            this.dgvGrade.Enabled = false;
            this.dgvGrade.Location = new System.Drawing.Point(591, 69);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGrade.Size = new System.Drawing.Size(712, 363);
            this.dgvGrade.TabIndex = 189;
            this.dgvGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellContentClick);
            this.dgvGrade.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellContentDoubleClick);
            this.dgvGrade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrade_CellDoubleClick);
            // 
            // SUBJECT_ID
            // 
            this.SUBJECT_ID.HeaderText = "SUBJECT_ID";
            this.SUBJECT_ID.Name = "SUBJECT_ID";
            this.SUBJECT_ID.ReadOnly = true;
            // 
            // SUBJECT
            // 
            this.SUBJECT.HeaderText = "SUBJECT";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.ReadOnly = true;
            // 
            // FIRST_GRADING
            // 
            this.FIRST_GRADING.HeaderText = "First Grading";
            this.FIRST_GRADING.Name = "FIRST_GRADING";
            this.FIRST_GRADING.ReadOnly = true;
            // 
            // SECOND_GRADING
            // 
            this.SECOND_GRADING.HeaderText = "Second Grading";
            this.SECOND_GRADING.Name = "SECOND_GRADING";
            this.SECOND_GRADING.ReadOnly = true;
            // 
            // THIRD_GRADING
            // 
            this.THIRD_GRADING.HeaderText = "Third Grading";
            this.THIRD_GRADING.Name = "THIRD_GRADING";
            this.THIRD_GRADING.ReadOnly = true;
            // 
            // FOURTH_GRADING
            // 
            this.FOURTH_GRADING.HeaderText = "Fourth Grading";
            this.FOURTH_GRADING.Name = "FOURTH_GRADING";
            this.FOURTH_GRADING.ReadOnly = true;
            // 
            // tBLSTUDENTBindingSource
            // 
            this.tBLSTUDENTBindingSource.DataMember = "TBL_STUDENT";
            this.tBLSTUDENTBindingSource.DataSource = this.aNS_DATABASEDataSet2;
            // 
            // aNS_DATABASEDataSet2
            // 
            this.aNS_DATABASEDataSet2.DataSetName = "ANS_DATABASEDataSet2";
            this.aNS_DATABASEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Controls.Add(this.txtscid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnViewStud);
            this.groupBox2.Controls.Add(this.txtsub);
            this.groupBox2.Controls.Add(this.txtgrade);
            this.groupBox2.Controls.Add(this.txtgrper);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(96, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 275);
            this.groupBox2.TabIndex = 196;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Full Name :";
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Location = new System.Drawing.Point(160, 107);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(250, 27);
            this.txtFname.TabIndex = 22;
            // 
            // txtscid
            // 
            this.txtscid.Enabled = false;
            this.txtscid.Location = new System.Drawing.Point(160, 75);
            this.txtscid.Name = "txtscid";
            this.txtscid.Size = new System.Drawing.Size(250, 27);
            this.txtscid.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student ID  :";
            // 
            // btnViewStud
            // 
            this.btnViewStud.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewStud.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStud.ForeColor = System.Drawing.Color.White;
            this.btnViewStud.Location = new System.Drawing.Point(10, 22);
            this.btnViewStud.Name = "btnViewStud";
            this.btnViewStud.Size = new System.Drawing.Size(435, 38);
            this.btnViewStud.TabIndex = 19;
            this.btnViewStud.Text = "SELECT STUDENT";
            this.btnViewStud.UseVisualStyleBackColor = false;
            this.btnViewStud.Click += new System.EventHandler(this.btnViewStud_Click);
            // 
            // txtsub
            // 
            this.txtsub.DataSource = this.tBLSUBJECTBindingSource;
            this.txtsub.DisplayMember = "SUBJECT";
            this.txtsub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtsub.FormattingEnabled = true;
            this.txtsub.Location = new System.Drawing.Point(160, 208);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(250, 26);
            this.txtsub.TabIndex = 14;
            this.txtsub.ValueMember = "SUBJECT_ID";
            this.txtsub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsub_KeyPress);
            // 
            // tBLSUBJECTBindingSource
            // 
            this.tBLSUBJECTBindingSource.DataMember = "TBL_SUBJECT";
            this.tBLSUBJECTBindingSource.DataSource = this.aNS_DATABASEDataSet1;
            // 
            // aNS_DATABASEDataSet1
            // 
            this.aNS_DATABASEDataSet1.DataSetName = "ANS_DATABASEDataSet1";
            this.aNS_DATABASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(160, 241);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(250, 27);
            this.txtgrade.TabIndex = 11;
            this.txtgrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgrade_KeyPress);
            // 
            // txtgrper
            // 
            this.txtgrper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtgrper.FormattingEnabled = true;
            this.txtgrper.Items.AddRange(new object[] {
            "First Grading",
            "Second Grading",
            "Third Grading",
            "Fourth Grading"});
            this.txtgrper.Location = new System.Drawing.Point(160, 174);
            this.txtgrper.Name = "txtgrper";
            this.txtgrper.Size = new System.Drawing.Size(250, 26);
            this.txtgrper.TabIndex = 9;
            this.txtgrper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgrper_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grade  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Grading Period  :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Subject :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(259, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(82, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBL_SUBJECTTableAdapter
            // 
            this.tBL_SUBJECTTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_STUDENTTableAdapter
            // 
            this.tBL_STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(96, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 82);
            this.groupBox3.TabIndex = 197;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "School Year :";
            // 
            // txtSY
            // 
            this.txtSY.Enabled = false;
            this.txtSY.Location = new System.Drawing.Point(160, 140);
            this.txtSY.Name = "txtSY";
            this.txtSY.Size = new System.Drawing.Size(250, 27);
            this.txtSY.TabIndex = 25;
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "StudentGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSUBJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.ComboBox txtgrper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.ComboBox txtsub;
        private ANS_DATABASEDataSet1 aNS_DATABASEDataSet1;
        private System.Windows.Forms.BindingSource tBLSUBJECTBindingSource;
        private ANS_DATABASEDataSet1TableAdapters.TBL_SUBJECTTableAdapter tBL_SUBJECTTableAdapter;
        private ANS_DATABASEDataSet2 aNS_DATABASEDataSet2;
        private System.Windows.Forms.BindingSource tBLSTUDENTBindingSource;
        private ANS_DATABASEDataSet2TableAdapters.TBL_STUDENTTableAdapter tBL_STUDENTTableAdapter;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnViewStud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFname;
        public System.Windows.Forms.TextBox txtscid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_GRADING;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECOND_GRADING;
        private System.Windows.Forms.DataGridViewTextBoxColumn THIRD_GRADING;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOURTH_GRADING;
        public System.Windows.Forms.TextBox txtSY;
        private System.Windows.Forms.Label label3;
    }
}