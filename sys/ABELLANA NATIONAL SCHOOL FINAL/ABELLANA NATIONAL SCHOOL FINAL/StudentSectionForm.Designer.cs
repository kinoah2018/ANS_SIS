namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class StudentSectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSectionForm));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.Button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
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
            this.dgvSection.Location = new System.Drawing.Point(360, 107);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.ReadOnly = true;
            this.dgvSection.Size = new System.Drawing.Size(741, 321);
            this.dgvSection.TabIndex = 198;
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
            // StudentSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 467);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 223);
            this.Name = "StudentSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StudentSection";
            this.Load += new System.EventHandler(this.StudentSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSection;
        internal System.Windows.Forms.Button Button3;
    }
}