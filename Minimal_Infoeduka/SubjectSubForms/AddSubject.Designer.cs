namespace Minimal_Infoeduka.SubjectSubForms
{
    partial class AddSubject
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
            this.lbSubjectInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lboxLecturers = new System.Windows.Forms.ListBox();
            this.cbGetAllLecturers = new System.Windows.Forms.ComboBox();
            this.rtbEcts = new System.Windows.Forms.RichTextBox();
            this.rtbSubjectName = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lbECTS = new System.Windows.Forms.Label();
            this.lbLecturers = new System.Windows.Forms.Label();
            this.lbSubjectCarrier = new System.Windows.Forms.Label();
            this.lbSubjectName = new System.Windows.Forms.Label();
            this.cbSubjectCarrier = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 85);
            this.panel1.TabIndex = 0;
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
            // lbSubjectInfo
            // 
            this.lbSubjectInfo.AutoSize = true;
            this.lbSubjectInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjectInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectInfo.ForeColor = System.Drawing.Color.White;
            this.lbSubjectInfo.Location = new System.Drawing.Point(25, 123);
            this.lbSubjectInfo.Name = "lbSubjectInfo";
            this.lbSubjectInfo.Size = new System.Drawing.Size(225, 32);
            this.lbSubjectInfo.TabIndex = 1;
            this.lbSubjectInfo.Text = "Subject Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.cbSubjectCarrier);
            this.panel2.Controls.Add(this.lboxLecturers);
            this.panel2.Controls.Add(this.cbGetAllLecturers);
            this.panel2.Controls.Add(this.rtbEcts);
            this.panel2.Controls.Add(this.rtbSubjectName);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAddSubject);
            this.panel2.Controls.Add(this.lbECTS);
            this.panel2.Controls.Add(this.lbLecturers);
            this.panel2.Controls.Add(this.lbSubjectCarrier);
            this.panel2.Controls.Add(this.lbSubjectName);
            this.panel2.Location = new System.Drawing.Point(202, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 507);
            this.panel2.TabIndex = 2;
            // 
            // lboxLecturers
            // 
            this.lboxLecturers.FormattingEnabled = true;
            this.lboxLecturers.ItemHeight = 20;
            this.lboxLecturers.Location = new System.Drawing.Point(238, 185);
            this.lboxLecturers.Name = "lboxLecturers";
            this.lboxLecturers.Size = new System.Drawing.Size(592, 84);
            this.lboxLecturers.TabIndex = 11;
            this.lboxLecturers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxLecturers_MouseClick);
            // 
            // cbGetAllLecturers
            // 
            this.cbGetAllLecturers.FormattingEnabled = true;
            this.cbGetAllLecturers.Location = new System.Drawing.Point(836, 186);
            this.cbGetAllLecturers.Name = "cbGetAllLecturers";
            this.cbGetAllLecturers.Size = new System.Drawing.Size(252, 28);
            this.cbGetAllLecturers.TabIndex = 10;
            this.cbGetAllLecturers.Text = "List all lecturers";
            this.cbGetAllLecturers.SelectedIndexChanged += new System.EventHandler(this.cbGetAllLecturers_SelectedIndexChanged);
            // 
            // rtbEcts
            // 
            this.rtbEcts.Location = new System.Drawing.Point(238, 295);
            this.rtbEcts.Name = "rtbEcts";
            this.rtbEcts.Size = new System.Drawing.Size(40, 36);
            this.rtbEcts.TabIndex = 9;
            this.rtbEcts.Text = "";
            // 
            // rtbSubjectName
            // 
            this.rtbSubjectName.Location = new System.Drawing.Point(238, 44);
            this.rtbSubjectName.Name = "rtbSubjectName";
            this.rtbSubjectName.Size = new System.Drawing.Size(907, 36);
            this.rtbSubjectName.TabIndex = 6;
            this.rtbSubjectName.Text = "";
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
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.Black;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.Location = new System.Drawing.Point(362, 389);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(208, 73);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lbECTS
            // 
            this.lbECTS.AutoSize = true;
            this.lbECTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbECTS.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbECTS.ForeColor = System.Drawing.Color.White;
            this.lbECTS.Location = new System.Drawing.Point(27, 295);
            this.lbECTS.Name = "lbECTS";
            this.lbECTS.Size = new System.Drawing.Size(75, 37);
            this.lbECTS.TabIndex = 3;
            this.lbECTS.Text = "ECTS";
            // 
            // lbLecturers
            // 
            this.lbLecturers.AutoSize = true;
            this.lbLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbLecturers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLecturers.ForeColor = System.Drawing.Color.White;
            this.lbLecturers.Location = new System.Drawing.Point(27, 186);
            this.lbLecturers.Name = "lbLecturers";
            this.lbLecturers.Size = new System.Drawing.Size(123, 37);
            this.lbLecturers.TabIndex = 2;
            this.lbLecturers.Text = "Lecturers";
            // 
            // lbSubjectCarrier
            // 
            this.lbSubjectCarrier.AutoSize = true;
            this.lbSubjectCarrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjectCarrier.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectCarrier.ForeColor = System.Drawing.Color.White;
            this.lbSubjectCarrier.Location = new System.Drawing.Point(27, 114);
            this.lbSubjectCarrier.Name = "lbSubjectCarrier";
            this.lbSubjectCarrier.Size = new System.Drawing.Size(190, 37);
            this.lbSubjectCarrier.TabIndex = 1;
            this.lbSubjectCarrier.Text = "Subject Carrier";
            // 
            // lbSubjectName
            // 
            this.lbSubjectName.AutoSize = true;
            this.lbSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbSubjectName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSubjectName.ForeColor = System.Drawing.Color.White;
            this.lbSubjectName.Location = new System.Drawing.Point(27, 43);
            this.lbSubjectName.Name = "lbSubjectName";
            this.lbSubjectName.Size = new System.Drawing.Size(177, 37);
            this.lbSubjectName.TabIndex = 0;
            this.lbSubjectName.Text = "Subject name";
            // 
            // cbSubjectCarrier
            // 
            this.cbSubjectCarrier.FormattingEnabled = true;
            this.cbSubjectCarrier.Location = new System.Drawing.Point(238, 123);
            this.cbSubjectCarrier.Name = "cbSubjectCarrier";
            this.cbSubjectCarrier.Size = new System.Drawing.Size(332, 28);
            this.cbSubjectCarrier.TabIndex = 12;
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbSubjectInfo);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddSubject_FormClosed);
            this.Load += new System.EventHandler(this.AddSubject_Load);
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
        private Label lbSubjectInfo;
        private Panel panel2;
        private Button btnAddSubject;
        private Label lbECTS;
        private Label lbLecturers;
        private Label lbSubjectCarrier;
        private Label lbSubjectName;
        private Button btnCancel;
        private RichTextBox rtbEcts;
        private RichTextBox rtbSubjectName;
        private ComboBox cbGetAllLecturers;
        private ListBox lboxLecturers;
        private ComboBox cbSubjectCarrier;
    }
}