namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class ViewTeacherToScheduleForm
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(28, 81);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(748, 362);
            this.dgvTeacher.TabIndex = 187;
            this.dgvTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellContentClick);
            this.dgvTeacher.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudView_CellContentDoubleClick);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(753, 24);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 31);
            this.Button3.TabIndex = 186;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // ViewTeacherToScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(535, 223);
            this.Name = "ViewTeacherToScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewTeacherToScheduleForm";
            this.Load += new System.EventHandler(this.ViewTeacherToScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacher;
        internal System.Windows.Forms.Button Button3;
    }
}