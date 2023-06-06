namespace Minimal_Infoeduka
{
    partial class SubjectsControl
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
            this.lbSubjectData = new System.Windows.Forms.ListBox();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbSubjectData
            // 
            this.lbSubjectData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjectData.FormattingEnabled = true;
            this.lbSubjectData.ItemHeight = 20;
            this.lbSubjectData.Location = new System.Drawing.Point(177, 3);
            this.lbSubjectData.Name = "lbSubjectData";
            this.lbSubjectData.Size = new System.Drawing.Size(700, 84);
            this.lbSubjectData.TabIndex = 0;
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSendNotification.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSendNotification.Location = new System.Drawing.Point(883, 30);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(137, 29);
            this.btnSendNotification.TabIndex = 2;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditSubject.Location = new System.Drawing.Point(22, 30);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(137, 29);
            this.btnEditSubject.TabIndex = 4;
            this.btnEditSubject.Text = "Edit Subject";
            this.btnEditSubject.UseVisualStyleBackColor = false;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(1060, 33);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(18, 17);
            this.cbDelete.TabIndex = 5;
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // SubjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.lbSubjectData);
            this.Name = "SubjectsControl";
            this.Size = new System.Drawing.Size(1116, 89);
            this.Load += new System.EventHandler(this.SubjectsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbSubjectData;
        private Button btnSendNotification;
        private Button btnEditSubject;
        private CheckBox cbDelete;
    }
}
