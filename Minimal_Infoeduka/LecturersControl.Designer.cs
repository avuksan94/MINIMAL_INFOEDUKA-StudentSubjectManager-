namespace Minimal_Infoeduka
{
    partial class LecturersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDeleteLecturer = new System.Windows.Forms.CheckBox();
            this.btnEditLecturer = new System.Windows.Forms.Button();
            this.lbLecturerData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbDeleteLecturer
            // 
            this.cbDeleteLecturer.AutoSize = true;
            this.cbDeleteLecturer.Location = new System.Drawing.Point(1057, 36);
            this.cbDeleteLecturer.Name = "cbDeleteLecturer";
            this.cbDeleteLecturer.Size = new System.Drawing.Size(18, 17);
            this.cbDeleteLecturer.TabIndex = 9;
            this.cbDeleteLecturer.UseVisualStyleBackColor = true;
            // 
            // btnEditLecturer
            // 
            this.btnEditLecturer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditLecturer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditLecturer.Location = new System.Drawing.Point(23, 29);
            this.btnEditLecturer.Name = "btnEditLecturer";
            this.btnEditLecturer.Size = new System.Drawing.Size(137, 29);
            this.btnEditLecturer.TabIndex = 8;
            this.btnEditLecturer.Text = "Edit Lecturer";
            this.btnEditLecturer.UseVisualStyleBackColor = false;
            this.btnEditLecturer.Click += new System.EventHandler(this.btnEditLecturer_Click);
            // 
            // lbLecturerData
            // 
            this.lbLecturerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturerData.FormattingEnabled = true;
            this.lbLecturerData.ItemHeight = 20;
            this.lbLecturerData.Location = new System.Drawing.Point(178, 2);
            this.lbLecturerData.Name = "lbLecturerData";
            this.lbLecturerData.Size = new System.Drawing.Size(841, 84);
            this.lbLecturerData.TabIndex = 6;
            // 
            // LecturersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDeleteLecturer);
            this.Controls.Add(this.btnEditLecturer);
            this.Controls.Add(this.lbLecturerData);
            this.Name = "LecturersControl";
            this.Size = new System.Drawing.Size(1116, 89);
            this.Load += new System.EventHandler(this.LecturersControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbDeleteLecturer;
        private Button btnEditLecturer;
        private ListBox lbLecturerData;
    }
}
