namespace Minimal_Infoeduka.NotificationSubForms
{
    partial class SendNotification
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbNotificationDescription = new System.Windows.Forms.RichTextBox();
            this.rtbNotificationTitle = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.lbNotificationDescription = new System.Windows.Forms.Label();
            this.lbNotificationTitle = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.rtbNotificationDescription);
            this.panel2.Controls.Add(this.rtbNotificationTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSendNotification);
            this.panel2.Controls.Add(this.lbNotificationDescription);
            this.panel2.Controls.Add(this.lbNotificationTitle);
            this.panel2.Location = new System.Drawing.Point(202, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 507);
            this.panel2.TabIndex = 7;
            // 
            // rtbNotificationDescription
            // 
            this.rtbNotificationDescription.Location = new System.Drawing.Point(212, 157);
            this.rtbNotificationDescription.Name = "rtbNotificationDescription";
            this.rtbNotificationDescription.Size = new System.Drawing.Size(911, 81);
            this.rtbNotificationDescription.TabIndex = 7;
            this.rtbNotificationDescription.Text = "";
            // 
            // rtbNotificationTitle
            // 
            this.rtbNotificationTitle.Location = new System.Drawing.Point(212, 42);
            this.rtbNotificationTitle.Name = "rtbNotificationTitle";
            this.rtbNotificationTitle.Size = new System.Drawing.Size(911, 87);
            this.rtbNotificationTitle.TabIndex = 6;
            this.rtbNotificationTitle.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(609, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 73);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.BackColor = System.Drawing.Color.Black;
            this.btnSendNotification.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendNotification.ForeColor = System.Drawing.Color.White;
            this.btnSendNotification.Location = new System.Drawing.Point(362, 389);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(208, 73);
            this.btnSendNotification.TabIndex = 4;
            this.btnSendNotification.Text = "Send";
            this.btnSendNotification.UseVisualStyleBackColor = false;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // lbNotificationDescription
            // 
            this.lbNotificationDescription.AutoSize = true;
            this.lbNotificationDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbNotificationDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNotificationDescription.ForeColor = System.Drawing.Color.White;
            this.lbNotificationDescription.Location = new System.Drawing.Point(27, 157);
            this.lbNotificationDescription.Name = "lbNotificationDescription";
            this.lbNotificationDescription.Size = new System.Drawing.Size(152, 37);
            this.lbNotificationDescription.TabIndex = 1;
            this.lbNotificationDescription.Text = "Description";
            // 
            // lbNotificationTitle
            // 
            this.lbNotificationTitle.AutoSize = true;
            this.lbNotificationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbNotificationTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNotificationTitle.ForeColor = System.Drawing.Color.White;
            this.lbNotificationTitle.Location = new System.Drawing.Point(27, 66);
            this.lbNotificationTitle.Name = "lbNotificationTitle";
            this.lbNotificationTitle.Size = new System.Drawing.Size(124, 37);
            this.lbNotificationTitle.TabIndex = 0;
            this.lbNotificationTitle.Text = "    Title    ";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjectName.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectName.ForeColor = System.Drawing.Color.White;
            this.lbSubjectName.Location = new System.Drawing.Point(675, 119);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(284, 60);
            this.lbSubjectName.TabIndex = 8;
            this.lbSubjectName.Text = "SubjectName";
            // 
            // SendNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.lbSubjectName);
            this.Controls.Add(this.panel2);
            this.Name = "SendNotification";
            this.Text = "SendNotification";
            this.Load += new System.EventHandler(this.SendNotification_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private RichTextBox rtbNotificationDescription;
        private Button btnCancel;
        private Button btnSendNotification;
        private Label lbNotificationDescription;
        private Label lbNotificationTitle;
        private Label lbSubjectName;
        private RichTextBox rtbNotificationTitle;
    }
}