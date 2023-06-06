namespace Minimal_Infoeduka
{
    partial class LecturerDashboard
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.flpDisplaySubjects = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1608, 95);
            this.panel1.TabIndex = 10;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Black;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(14, 26);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(144, 32);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "@Username";
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.Black;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Location = new System.Drawing.Point(1086, 151);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(208, 73);
            this.btnNotifications.TabIndex = 12;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lblSubjects.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubjects.ForeColor = System.Drawing.Color.White;
            this.lblSubjects.Location = new System.Drawing.Point(178, 178);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(145, 46);
            this.lblSubjects.TabIndex = 11;
            this.lblSubjects.Text = "Subjects";
            // 
            // flpDisplaySubjects
            // 
            this.flpDisplaySubjects.AutoScroll = true;
            this.flpDisplaySubjects.BackColor = System.Drawing.SystemColors.Control;
            this.flpDisplaySubjects.Location = new System.Drawing.Point(178, 244);
            this.flpDisplaySubjects.Name = "flpDisplaySubjects";
            this.flpDisplaySubjects.Size = new System.Drawing.Size(1116, 693);
            this.flpDisplaySubjects.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1409, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 64);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LecturerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1582, 973);
            this.Controls.Add(this.flpDisplaySubjects);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.panel1);
            this.Name = "LecturerDashboard";
            this.Text = "LecturerDashboard";
            this.Load += new System.EventHandler(this.LecturerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbUsername;
        private Button btnNotifications;
        private Label lblSubjects;
        private FlowLayoutPanel flpDisplaySubjects;
        private Button btnExit;
    }
}