namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class BMIComputeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIComputeForm));
            this.dgvViewBmi = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBlood_Cat = new System.Windows.Forms.Label();
            this.lblBmi_Cat = new System.Windows.Forms.Label();
            this.btnSelStud = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfulln = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstcid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewBmi
            // 
            this.dgvViewBmi.AllowUserToAddRows = false;
            this.dgvViewBmi.AllowUserToDeleteRows = false;
            this.dgvViewBmi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewBmi.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewBmi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBmi.Location = new System.Drawing.Point(670, 93);
            this.dgvViewBmi.Name = "dgvViewBmi";
            this.dgvViewBmi.ReadOnly = true;
            this.dgvViewBmi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBmi.Size = new System.Drawing.Size(638, 353);
            this.dgvViewBmi.TabIndex = 124;
            this.dgvViewBmi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewBmi_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(998, 60);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 25);
            this.txtSearch.TabIndex = 126;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1276, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 21);
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "STUDENT BMI";
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
            this.Button3.TabIndex = 132;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(477, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 360);
            this.groupBox3.TabIndex = 134;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(35, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(35, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 38);
            this.button7.TabIndex = 16;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiastolic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBlood_Cat);
            this.groupBox1.Controls.Add(this.lblBmi_Cat);
            this.groupBox1.Controls.Add(this.btnSelStud);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.txtSystolic);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtheight);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfulln);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtstcid);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 360);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Computation";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Enabled = false;
            this.txtDiastolic.Location = new System.Drawing.Point(157, 227);
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(49, 28);
            this.txtDiastolic.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "/";
            // 
            // lblBlood_Cat
            // 
            this.lblBlood_Cat.AutoSize = true;
            this.lblBlood_Cat.Location = new System.Drawing.Point(154, 326);
            this.lblBlood_Cat.Name = "lblBlood_Cat";
            this.lblBlood_Cat.Size = new System.Drawing.Size(31, 20);
            this.lblBlood_Cat.TabIndex = 40;
            this.lblBlood_Cat.Text = "BP";
            this.lblBlood_Cat.Visible = false;
            // 
            // lblBmi_Cat
            // 
            this.lblBmi_Cat.AutoSize = true;
            this.lblBmi_Cat.Location = new System.Drawing.Point(154, 300);
            this.lblBmi_Cat.Name = "lblBmi_Cat";
            this.lblBmi_Cat.Size = new System.Drawing.Size(21, 20);
            this.lblBmi_Cat.TabIndex = 39;
            this.lblBmi_Cat.Text = "B";
            this.lblBmi_Cat.Visible = false;
            // 
            // btnSelStud
            // 
            this.btnSelStud.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelStud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelStud.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelStud.ForeColor = System.Drawing.Color.White;
            this.btnSelStud.Location = new System.Drawing.Point(6, 26);
            this.btnSelStud.Name = "btnSelStud";
            this.btnSelStud.Size = new System.Drawing.Size(422, 38);
            this.btnSelStud.TabIndex = 18;
            this.btnSelStud.Text = "SELECT STUDENT";
            this.btnSelStud.UseVisualStyleBackColor = false;
            this.btnSelStud.Click += new System.EventHandler(this.btnSelStud_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(157, 264);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(123, 28);
            this.txtResult.TabIndex = 38;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(41, 261);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(110, 32);
            this.btnCompute.TabIndex = 37;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtSystolic
            // 
            this.txtSystolic.Enabled = false;
            this.txtSystolic.Location = new System.Drawing.Point(235, 227);
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(45, 28);
            this.txtSystolic.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 230);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "Blood Pressure :";
            // 
            // txtweight
            // 
            this.txtweight.Enabled = false;
            this.txtweight.Location = new System.Drawing.Point(157, 188);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(123, 28);
            this.txtweight.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 20);
            this.label20.TabIndex = 33;
            this.label20.Text = "Weight / Kg :";
            // 
            // txtheight
            // 
            this.txtheight.Enabled = false;
            this.txtheight.Location = new System.Drawing.Point(157, 149);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(123, 28);
            this.txtheight.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Height / Ft :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full Name :";
            // 
            // txtfulln
            // 
            this.txtfulln.Enabled = false;
            this.txtfulln.Location = new System.Drawing.Point(157, 111);
            this.txtfulln.Name = "txtfulln";
            this.txtfulln.Size = new System.Drawing.Size(271, 28);
            this.txtfulln.TabIndex = 6;
            this.txtfulln.TextChanged += new System.EventHandler(this.txtfulln_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student_ID :";
            // 
            // txtstcid
            // 
            this.txtstcid.Enabled = false;
            this.txtstcid.Location = new System.Drawing.Point(158, 72);
            this.txtstcid.Name = "txtstcid";
            this.txtstcid.Size = new System.Drawing.Size(206, 28);
            this.txtstcid.TabIndex = 4;
            // 
            // BMIComputeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvViewBmi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "BMIComputeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BMICOMPUTE";
            this.Load += new System.EventHandler(this.BMIComputeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvViewBmi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnSelStud;
        public System.Windows.Forms.TextBox txtResult;
        public System.Windows.Forms.TextBox txtSystolic;
        public System.Windows.Forms.TextBox txtweight;
        public System.Windows.Forms.TextBox txtheight;
        public System.Windows.Forms.TextBox txtfulln;
        public System.Windows.Forms.TextBox txtstcid;
        private System.Windows.Forms.Label lblBlood_Cat;
        private System.Windows.Forms.Label lblBmi_Cat;
        public System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.Label label3;
    }
}