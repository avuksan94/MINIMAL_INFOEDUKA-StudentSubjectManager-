namespace Minimal_Infoeduka
{
    partial class LecturerSubjects
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
            this.btnSubjectName = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubjectName
            // 
            this.btnSubjectName.BackColor = System.Drawing.Color.Black;
            this.btnSubjectName.ForeColor = System.Drawing.Color.White;
            this.btnSubjectName.Location = new System.Drawing.Point(65, 15);
            this.btnSubjectName.Name = "btnSubjectName";
            this.btnSubjectName.Size = new System.Drawing.Size(656, 44);
            this.btnSubjectName.TabIndex = 0;
            this.btnSubjectName.Text = "Subject";
            this.btnSubjectName.UseVisualStyleBackColor = false;
            this.btnSubjectName.Click += new System.EventHandler(this.btnSubjectName_Click);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.BackColor = System.Drawing.Color.Black;
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Location = new System.Drawing.Point(741, 15);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(352, 44);
            this.btnSendNotification.TabIndex = 1;
            this.btnSendNotification.Text = "Send notification";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // LecturerSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.btnSubjectName);
            this.Name = "LecturerSubjects";
            this.Size = new System.Drawing.Size(1116, 74);
            this.Load += new System.EventHandler(this.LecturerSubjects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSubjectName;
        private Button btnSendNotification;
    }
}
