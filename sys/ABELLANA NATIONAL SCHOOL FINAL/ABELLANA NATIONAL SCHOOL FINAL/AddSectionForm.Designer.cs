namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class AddSectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSectionForm));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.cmbadvisory = new System.Windows.Forms.ComboBox();
            this.viewGetTHNAMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNS_DATABASEDataSet10 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet10();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.aNS_DATABASEDataSet8 = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet8();
            this.tBLTEACHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_TEACHERTableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet8TableAdapters.TBL_TEACHERTableAdapter();
            this.view_GetTHNAMETableAdapter = new ABELLANA_NATIONAL_SCHOOL_FINAL.ANS_DATABASEDataSet10TableAdapters.View_GetTHNAMETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetTHNAMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEACHERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(626, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 183;
            this.label8.Text = "SECTION";
            // 
            // dgvSection
            // 
            this.dgvSection.AllowUserToAddRows = false;
            this.dgvSection.AllowUserToDeleteRows = false;
            this.dgvSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSection.BackgroundColor = System.Drawing.Color.White;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Location = new System.Drawing.Point(547, 74);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.ReadOnly = true;
            this.dgvSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSection.Size = new System.Drawing.Size(766, 381);
            this.dgvSection.TabIndex = 198;
            this.dgvSection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSection_CellContentClick);
            this.dgvSection.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSection_CellContentDoubleClick);
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
            this.Button3.TabIndex = 195;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(87, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 105);
            this.groupBox2.TabIndex = 211;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(269, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 59);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(102, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 59);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTID);
            this.groupBox1.Controls.Add(this.cmbadvisory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSecID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecCap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsname);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(87, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 175);
            this.groupBox1.TabIndex = 210;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Section";
            // 
            // txtTID
            // 
            this.txtTID.Enabled = false;
            this.txtTID.Location = new System.Drawing.Point(432, 114);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(12, 27);
            this.txtTID.TabIndex = 9;
            this.txtTID.Visible = false;
            // 
            // cmbadvisory
            // 
            this.cmbadvisory.DataSource = this.viewGetTHNAMEBindingSource;
            this.cmbadvisory.DisplayMember = "Fullname";
            this.cmbadvisory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadvisory.FormattingEnabled = true;
            this.cmbadvisory.Location = new System.Drawing.Point(180, 115);
            this.cmbadvisory.Name = "cmbadvisory";
            this.cmbadvisory.Size = new System.Drawing.Size(250, 26);
            this.cmbadvisory.TabIndex = 8;
            this.cmbadvisory.ValueMember = "T_ID";
            // 
            // viewGetTHNAMEBindingSource
            // 
            this.viewGetTHNAMEBindingSource.DataMember = "View_GetTHNAME";
            this.viewGetTHNAMEBindingSource.DataSource = this.aNS_DATABASEDataSet10;
            // 
            // aNS_DATABASEDataSet10
            // 
            this.aNS_DATABASEDataSet10.DataSetName = "ANS_DATABASEDataSet10";
            this.aNS_DATABASEDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Advisory Section :";
            // 
            // txtSecID
            // 
            this.txtSecID.Enabled = false;
            this.txtSecID.Location = new System.Drawing.Point(432, 37);
            this.txtSecID.Name = "txtSecID";
            this.txtSecID.Size = new System.Drawing.Size(14, 27);
            this.txtSecID.TabIndex = 6;
            this.txtSecID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Section Capacity :";
            // 
            // txtSecCap
            // 
            this.txtSecCap.Location = new System.Drawing.Point(180, 76);
            this.txtSecCap.Name = "txtSecCap";
            this.txtSecCap.Size = new System.Drawing.Size(250, 27);
            this.txtSecCap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Section Name :";
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(180, 37);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(250, 27);
            this.txtsname.TabIndex = 0;
            // 
            // aNS_DATABASEDataSet8
            // 
            this.aNS_DATABASEDataSet8.DataSetName = "ANS_DATABASEDataSet8";
            this.aNS_DATABASEDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLTEACHERBindingSource
            // 
            this.tBLTEACHERBindingSource.DataMember = "TBL_TEACHER";
            this.tBLTEACHERBindingSource.DataSource = this.aNS_DATABASEDataSet8;
            // 
            // tBL_TEACHERTableAdapter
            // 
            this.tBL_TEACHERTableAdapter.ClearBeforeFill = true;
            // 
            // view_GetTHNAMETableAdapter
            // 
            this.view_GetTHNAMETableAdapter.ClearBeforeFill = true;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "AddSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StudentSection";
            this.Load += new System.EventHandler(this.StudentSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGetTHNAMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNS_DATABASEDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEACHERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSection;
        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtSecID;
        private System.Windows.Forms.ComboBox cmbadvisory;
        private System.Windows.Forms.Label label3;
        private ANS_DATABASEDataSet8 aNS_DATABASEDataSet8;
        private System.Windows.Forms.BindingSource tBLTEACHERBindingSource;
        private ANS_DATABASEDataSet8TableAdapters.TBL_TEACHERTableAdapter tBL_TEACHERTableAdapter;
        private ANS_DATABASEDataSet10 aNS_DATABASEDataSet10;
        private System.Windows.Forms.BindingSource viewGetTHNAMEBindingSource;
        private ANS_DATABASEDataSet10TableAdapters.View_GetTHNAMETableAdapter view_GetTHNAMETableAdapter;
        private System.Windows.Forms.TextBox txtTID;
    }
}