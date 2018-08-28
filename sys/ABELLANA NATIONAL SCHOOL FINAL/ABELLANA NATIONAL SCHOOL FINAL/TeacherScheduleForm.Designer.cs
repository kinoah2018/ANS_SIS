namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class TeacherScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherScheduleForm));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbsection = new System.Windows.Forms.ComboBox();
            this.tBLSECTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet13 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet13();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbStartEnd = new System.Windows.Forms.ComboBox();
            this.viewCombScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet12 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet12();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeachername = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aNS_DATABASEDataSet11 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet11();
            this.viewCombScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_CombScheduleTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet11TableAdapters.View_CombScheduleTableAdapter();
            this.view_CombScheduleTableAdapter1 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet12TableAdapters.View_CombScheduleTableAdapter();
            this.aNS_DATABASEDataSet4 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet4();
            this.aNSDATABASEDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet3 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet3();
            this.aNSDATABASEDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SECTIONTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet13TableAdapters.TBL_SECTIONTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSECTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCombScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCombScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "TEACHER SCHEDULE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(108, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 121);
            this.groupBox2.TabIndex = 202;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(7, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 62);
            this.btnSave.TabIndex = 191;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(210, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 62);
            this.btnUpdate.TabIndex = 192;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbsection);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cmbStartEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTeachername);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 244);
            this.groupBox1.TabIndex = 200;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Schedule";
            // 
            // cmbsection
            // 
            this.cmbsection.DataSource = this.tBLSECTIONBindingSource;
            this.cmbsection.DisplayMember = "SEC_NAME";
            this.cmbsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsection.FormattingEnabled = true;
            this.cmbsection.Location = new System.Drawing.Point(154, 116);
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(202, 26);
            this.cmbsection.TabIndex = 198;
            this.cmbsection.ValueMember = "SEC_ID";
            // 
            // tBLSECTIONBindingSource
            // 
            this.tBLSECTIONBindingSource.DataMember = "TBL_SECTION";
            this.tBLSECTIONBindingSource.DataSource = this.aNS_DATABASEDataSet13;
            // 
            // aNS_DATABASEDataSet13
            // 
            this.aNS_DATABASEDataSet13.DataSetName = "ANS_DATABASEDataSet13";
            this.aNS_DATABASEDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(358, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 26);
            this.button2.TabIndex = 193;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbStartEnd
            // 
            this.cmbStartEnd.DataSource = this.viewCombScheduleBindingSource1;
            this.cmbStartEnd.DisplayMember = "SCHEDULE";
            this.cmbStartEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartEnd.FormattingEnabled = true;
            this.cmbStartEnd.Location = new System.Drawing.Point(154, 187);
            this.cmbStartEnd.Name = "cmbStartEnd";
            this.cmbStartEnd.Size = new System.Drawing.Size(202, 26);
            this.cmbStartEnd.TabIndex = 197;
            this.cmbStartEnd.ValueMember = "TIME_ID";
            // 
            // viewCombScheduleBindingSource1
            // 
            this.viewCombScheduleBindingSource1.DataMember = "View_CombSchedule";
            this.viewCombScheduleBindingSource1.DataSource = this.aNS_DATABASEDataSet12;
            // 
            // aNS_DATABASEDataSet12
            // 
            this.aNS_DATABASEDataSet12.DataSetName = "ANS_DATABASEDataSet12";
            this.aNS_DATABASEDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(15, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 196;
            this.label6.Text = "Subject Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 194;
            this.label1.Text = "Section Name :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 39);
            this.button1.TabIndex = 193;
            this.button1.Text = "Select Teacher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 189;
            this.label3.Text = "Time Start/End:";
            // 
            // txtsubject
            // 
            this.txtsubject.Enabled = false;
            this.txtsubject.Location = new System.Drawing.Point(154, 151);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(202, 27);
            this.txtsubject.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 187;
            this.label2.Text = "Teacher Name :";
            // 
            // txtTeachername
            // 
            this.txtTeachername.Enabled = false;
            this.txtTeachername.Location = new System.Drawing.Point(154, 82);
            this.txtTeachername.Name = "txtTeachername";
            this.txtTeachername.Size = new System.Drawing.Size(255, 27);
            this.txtTeachername.TabIndex = 185;
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(1320, 12);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 31);
            this.Button3.TabIndex = 203;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(963, 41);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 25);
            this.txtSearch.TabIndex = 205;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(535, 72);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(755, 371);
            this.dgvSchedule.TabIndex = 204;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1258, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.TabIndex = 206;
            this.pictureBox1.TabStop = false;
            // 
            // aNS_DATABASEDataSet11
            // 
            this.aNS_DATABASEDataSet11.DataSetName = "ANS_DATABASEDataSet11";
            this.aNS_DATABASEDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewCombScheduleBindingSource
            // 
            this.viewCombScheduleBindingSource.DataMember = "View_CombSchedule";
            this.viewCombScheduleBindingSource.DataSource = this.aNS_DATABASEDataSet11;
            // 
            // view_CombScheduleTableAdapter
            // 
            this.view_CombScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // view_CombScheduleTableAdapter1
            // 
            this.view_CombScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // aNS_DATABASEDataSet4
            // 
            this.aNS_DATABASEDataSet4.DataSetName = "ANS_DATABASEDataSet4";
            this.aNS_DATABASEDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNSDATABASEDataSet4BindingSource
            // 
            this.aNSDATABASEDataSet4BindingSource.DataSource = this.aNS_DATABASEDataSet4;
            this.aNSDATABASEDataSet4BindingSource.Position = 0;
            // 
            // aNS_DATABASEDataSet3
            // 
            this.aNS_DATABASEDataSet3.DataSetName = "ANS_DATABASEDataSet3";
            this.aNS_DATABASEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNSDATABASEDataSet3BindingSource
            // 
            this.aNSDATABASEDataSet3BindingSource.DataSource = this.aNS_DATABASEDataSet3;
            this.aNSDATABASEDataSet3BindingSource.Position = 0;
            // 
            // tBL_SECTIONTableAdapter
            // 
            this.tBL_SECTIONTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "TeacherScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TeacherSchedule";
            this.Load += new System.EventHandler(this.TeacherScheduleForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSECTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCombScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCombScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSDATABASEDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbStartEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbsection;
        private ANS_DATABASEDataSet11 aNS_DATABASEDataSet11;
        private System.Windows.Forms.BindingSource viewCombScheduleBindingSource;
        private ANS_DATABASEDataSet11TableAdapters.View_CombScheduleTableAdapter view_CombScheduleTableAdapter;
        private ANS_DATABASEDataSet12 aNS_DATABASEDataSet12;
        private System.Windows.Forms.BindingSource viewCombScheduleBindingSource1;
        private ANS_DATABASEDataSet12TableAdapters.View_CombScheduleTableAdapter view_CombScheduleTableAdapter1;
        private ANS_DATABASEDataSet4 aNS_DATABASEDataSet4;
        private System.Windows.Forms.BindingSource aNSDATABASEDataSet4BindingSource;
        private ANS_DATABASEDataSet3 aNS_DATABASEDataSet3;
        private System.Windows.Forms.BindingSource aNSDATABASEDataSet3BindingSource;
        private ANS_DATABASEDataSet13 aNS_DATABASEDataSet13;
        private System.Windows.Forms.BindingSource tBLSECTIONBindingSource;
        private ANS_DATABASEDataSet13TableAdapters.TBL_SECTIONTableAdapter tBL_SECTIONTableAdapter;
        public System.Windows.Forms.TextBox txtTeachername;
        public System.Windows.Forms.TextBox txtsubject;
        public System.Windows.Forms.DataGridView dgvSchedule;
        public System.Windows.Forms.TextBox txtSearch;
    }
}