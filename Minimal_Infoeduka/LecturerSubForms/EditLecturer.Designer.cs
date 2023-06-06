namespace Minimal_Infoeduka.LecturerSubForms
{
    partial class EditLecturer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbLecturerEmail = new System.Windows.Forms.RichTextBox();
            this.lbLecturerEmail = new System.Windows.Forms.Label();
            this.lboxSubjects = new System.Windows.Forms.ListBox();
            this.cbGetAllSubjects = new System.Windows.Forms.ComboBox();
            this.rtbLecturerSurname = new System.Windows.Forms.RichTextBox();
            this.rtbLecturerName = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lbSubjects = new System.Windows.Forms.Label();
            this.lbLecturerSurname = new System.Windows.Forms.Label();
            this.lbLecturerName = new System.Windows.Forms.Label();
            this.lbLecturerInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 114);
            this.panel1.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Black;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(26, 30);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(144, 32);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "@Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.rtbLecturerEmail);
            this.panel2.Controls.Add(this.lbLecturerEmail);
            this.panel2.Controls.Add(this.lboxSubjects);
            this.panel2.Controls.Add(this.cbGetAllSubjects);
            this.panel2.Controls.Add(this.rtbLecturerSurname);
            this.panel2.Controls.Add(this.rtbLecturerName);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSaveChanges);
            this.panel2.Controls.Add(this.lbSubjects);
            this.panel2.Controls.Add(this.lbLecturerSurname);
            this.panel2.Controls.Add(this.lbLecturerName);
            this.panel2.Location = new System.Drawing.Point(146, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 507);
            this.panel2.TabIndex = 6;
            // 
            // rtbLecturerEmail
            // 
            this.rtbLecturerEmail.Location = new System.Drawing.Point(277, 178);
            this.rtbLecturerEmail.Name = "rtbLecturerEmail";
            this.rtbLecturerEmail.Size = new System.Drawing.Size(846, 36);
            this.rtbLecturerEmail.TabIndex = 13;
            this.rtbLecturerEmail.Text = "";
            // 
            // lbLecturerEmail
            // 
            this.lbLecturerEmail.AutoSize = true;
            this.lbLecturerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturerEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerEmail.ForeColor = System.Drawing.Color.White;
            this.lbLecturerEmail.Location = new System.Drawing.Point(27, 177);
            this.lbLecturerEmail.Name = "lbLecturerEmail";
            this.lbLecturerEmail.Size = new System.Drawing.Size(82, 37);
            this.lbLecturerEmail.TabIndex = 12;
            this.lbLecturerEmail.Text = "Email";
            // 
            // lboxSubjects
            // 
            this.lboxSubjects.FormattingEnabled = true;
            this.lboxSubjects.ItemHeight = 20;
            this.lboxSubjects.Location = new System.Drawing.Point(273, 243);
            this.lboxSubjects.Name = "lboxSubjects";
            this.lboxSubjects.Size = new System.Drawing.Size(592, 84);
            this.lboxSubjects.TabIndex = 11;
            this.lboxSubjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxSubjects_MouseClick);
            // 
            // cbGetAllSubjects
            // 
            this.cbGetAllSubjects.FormattingEnabled = true;
            this.cbGetAllSubjects.Location = new System.Drawing.Point(871, 243);
            this.cbGetAllSubjects.Name = "cbGetAllSubjects";
            this.cbGetAllSubjects.Size = new System.Drawing.Size(252, 28);
            this.cbGetAllSubjects.TabIndex = 10;
            this.cbGetAllSubjects.Text = "List all subjects";
            this.cbGetAllSubjects.SelectedIndexChanged += new System.EventHandler(this.cbGetAllSubjects_SelectedIndexChanged);
            // 
            // rtbLecturerSurname
            // 
            this.rtbLecturerSurname.Location = new System.Drawing.Point(277, 115);
            this.rtbLecturerSurname.Name = "rtbLecturerSurname";
            this.rtbLecturerSurname.Size = new System.Drawing.Size(846, 36);
            this.rtbLecturerSurname.TabIndex = 7;
            this.rtbLecturerSurname.Text = "";
            // 
            // rtbLecturerName
            // 
            this.rtbLecturerName.Location = new System.Drawing.Point(277, 44);
            this.rtbLecturerName.Name = "rtbLecturerName";
            this.rtbLecturerName.Size = new System.Drawing.Size(846, 36);
            this.rtbLecturerName.TabIndex = 6;
            this.rtbLecturerName.Text = "";
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
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(362, 389);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(208, 73);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lbSubjects
            // 
            this.lbSubjects.AutoSize = true;
            this.lbSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjects.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjects.ForeColor = System.Drawing.Color.White;
            this.lbSubjects.Location = new System.Drawing.Point(27, 243);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(115, 37);
            this.lbSubjects.TabIndex = 2;
            this.lbSubjects.Text = "Subjects";
            // 
            // lbLecturerSurname
            // 
            this.lbLecturerSurname.AutoSize = true;
            this.lbLecturerSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturerSurname.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerSurname.ForeColor = System.Drawing.Color.White;
            this.lbLecturerSurname.Location = new System.Drawing.Point(27, 114);
            this.lbLecturerSurname.Name = "lbLecturerSurname";
            this.lbLecturerSurname.Size = new System.Drawing.Size(220, 37);
            this.lbLecturerSurname.TabIndex = 1;
            this.lbLecturerSurname.Text = "Lecturer surname";
            // 
            // lbLecturerName
            // 
            this.lbLecturerName.AutoSize = true;
            this.lbLecturerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerName.ForeColor = System.Drawing.Color.White;
            this.lbLecturerName.Location = new System.Drawing.Point(27, 43);
            this.lbLecturerName.Name = "lbLecturerName";
            this.lbLecturerName.Size = new System.Drawing.Size(185, 37);
            this.lbLecturerName.TabIndex = 0;
            this.lbLecturerName.Text = "Lecturer name";
            // 
            // lbLecturerInfo
            // 
            this.lbLecturerInfo.AutoSize = true;
            this.lbLecturerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturerInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturerInfo.ForeColor = System.Drawing.Color.White;
            this.lbLecturerInfo.Location = new System.Drawing.Point(26, 145);
            this.lbLecturerInfo.Name = "lbLecturerInfo";
            this.lbLecturerInfo.Size = new System.Drawing.Size(232, 32);
            this.lbLecturerInfo.TabIndex = 5;
            this.lbLecturerInfo.Text = "Lecturer Information";
            // 
            // EditLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbLecturerInfo);
            this.Controls.Add(this.panel1);
            this.Name = "EditLecturer";
            this.Text = "EditLecturer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditLecturer_FormClosed);
            this.Load += new System.EventHandler(this.EditLecturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbUsername;
        private Panel panel2;
        private RichTextBox rtbLecturerEmail;
        private Label lbLecturerEmail;
        private ListBox lboxSubjects;
        private ComboBox cbGetAllSubjects;
        private RichTextBox rtbLecturerSurname;
        private RichTextBox rtbLecturerName;
        private Button btnCancel;
        private Button btnSaveChanges;
        private Label lbSubjects;
        private Label lbLecturerSurname;
        private Label lbLecturerName;
        private Label lbLecturerInfo;
    }
}