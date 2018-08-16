namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class AddScheduleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.cmbTimeStartHH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTimeStartMM = new System.Windows.Forms.ComboBox();
            this.cmbTimeEndMM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimeEndHH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsessionstart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbsessEnd = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 33);
            this.panel1.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(267, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "ADD SCHEDULE TIME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbsessEnd);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbsessionstart);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnView);
            this.panel3.Controls.Add(this.btnCLose);
            this.panel3.Controls.Add(this.cmbTimeEndMM);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbTimeEndHH);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbTimeStartMM);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbTimeStartHH);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(161, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 190);
            this.panel3.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Start";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(251, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 44);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLose.ForeColor = System.Drawing.Color.White;
            this.btnCLose.Location = new System.Drawing.Point(251, 126);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(132, 44);
            this.btnCLose.TabIndex = 112;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(251, 72);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(132, 44);
            this.btnView.TabIndex = 88;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cmbTimeStartHH
            // 
            this.cmbTimeStartHH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeStartHH.FormattingEnabled = true;
            this.cmbTimeStartHH.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbTimeStartHH.Location = new System.Drawing.Point(22, 60);
            this.cmbTimeStartHH.Name = "cmbTimeStartHH";
            this.cmbTimeStartHH.Size = new System.Drawing.Size(57, 26);
            this.cmbTimeStartHH.TabIndex = 6;
            this.cmbTimeStartHH.Text = "HH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // cmbTimeStartMM
            // 
            this.cmbTimeStartMM.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeStartMM.FormattingEnabled = true;
            this.cmbTimeStartMM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            ""});
            this.cmbTimeStartMM.Location = new System.Drawing.Point(96, 60);
            this.cmbTimeStartMM.Name = "cmbTimeStartMM";
            this.cmbTimeStartMM.Size = new System.Drawing.Size(57, 26);
            this.cmbTimeStartMM.TabIndex = 8;
            this.cmbTimeStartMM.Text = "MM";
            // 
            // cmbTimeEndMM
            // 
            this.cmbTimeEndMM.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeEndMM.FormattingEnabled = true;
            this.cmbTimeEndMM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            ""});
            this.cmbTimeEndMM.Location = new System.Drawing.Point(96, 124);
            this.cmbTimeEndMM.Name = "cmbTimeEndMM";
            this.cmbTimeEndMM.Size = new System.Drawing.Size(57, 26);
            this.cmbTimeEndMM.TabIndex = 12;
            this.cmbTimeEndMM.Text = "MM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // cmbTimeEndHH
            // 
            this.cmbTimeEndHH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeEndHH.FormattingEnabled = true;
            this.cmbTimeEndHH.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbTimeEndHH.Location = new System.Drawing.Point(22, 124);
            this.cmbTimeEndHH.Name = "cmbTimeEndHH";
            this.cmbTimeEndHH.Size = new System.Drawing.Size(57, 26);
            this.cmbTimeEndHH.TabIndex = 10;
            this.cmbTimeEndHH.Text = "HH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time End";
            // 
            // cmbsessionstart
            // 
            this.cmbsessionstart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsessionstart.FormattingEnabled = true;
            this.cmbsessionstart.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbsessionstart.Location = new System.Drawing.Point(173, 61);
            this.cmbsessionstart.Name = "cmbsessionstart";
            this.cmbsessionstart.Size = new System.Drawing.Size(57, 26);
            this.cmbsessionstart.TabIndex = 113;
            this.cmbsessionstart.Text = "AM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 114;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 116;
            this.label7.Text = ":";
            // 
            // cmbsessEnd
            // 
            this.cmbsessEnd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsessEnd.FormattingEnabled = true;
            this.cmbsessEnd.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbsessEnd.Location = new System.Drawing.Point(173, 124);
            this.cmbsessEnd.Name = "cmbsessEnd";
            this.cmbsessEnd.Size = new System.Drawing.Size(57, 26);
            this.cmbsessEnd.TabIndex = 115;
            this.cmbsessEnd.Text = "AM";
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(341, 230);
            this.Name = "AddScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddScheduleForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbTimeStartMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTimeStartHH;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCLose;
        internal System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cmbTimeEndMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimeEndHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbsessEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsessionstart;
    }
}