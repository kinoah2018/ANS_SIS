namespace ABELLANA_NATIONAL_SCHOOL_FINAL
{
    partial class View_Student1Form
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
            this.Button3 = new System.Windows.Forms.Button();
            this.dgvStudView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudView)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Red;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(756, 12);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 31);
            this.Button3.TabIndex = 184;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dgvStudView
            // 
            this.dgvStudView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudView.Location = new System.Drawing.Point(54, 69);
            this.dgvStudView.Name = "dgvStudView";
            this.dgvStudView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudView.Size = new System.Drawing.Size(712, 362);
            this.dgvStudView.TabIndex = 185;
            this.dgvStudView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudView_CellContentClick);
            this.dgvStudView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudView_CellContentDoubleClick);
            // 
            // View_Student1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.dgvStudView);
            this.Controls.Add(this.Button3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(565, 223);
            this.Name = "View_Student1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View_Student1Form";
            this.Load += new System.EventHandler(this.View_Student1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        private System.Windows.Forms.DataGridView dgvStudView;
    }
}