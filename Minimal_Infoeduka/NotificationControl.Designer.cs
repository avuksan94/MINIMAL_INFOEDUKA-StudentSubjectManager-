namespace Minimal_Infoeduka
{
    partial class NotificationControl
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
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnTitle = new System.Windows.Forms.Button();
            this.lbPostDate = new System.Windows.Forms.Label();
            this.lbDisplayPostDate = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbDisplayExpirationDay = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.rtbSubjectName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.Enabled = false;
            this.rtbDescription.ForeColor = System.Drawing.Color.Black;
            this.rtbDescription.Location = new System.Drawing.Point(447, 47);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(542, 87);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(309, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 20);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(655, 24);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Black;
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Location = new System.Drawing.Point(215, 47);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(226, 87);
            this.btnTitle.TabIndex = 4;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.btnTitle_Click);
            // 
            // lbPostDate
            // 
            this.lbPostDate.AutoSize = true;
            this.lbPostDate.Location = new System.Drawing.Point(1059, 50);
            this.lbPostDate.Name = "lbPostDate";
            this.lbPostDate.Size = new System.Drawing.Size(72, 20);
            this.lbPostDate.TabIndex = 6;
            this.lbPostDate.Text = "Post Date";
            // 
            // lbDisplayPostDate
            // 
            this.lbDisplayPostDate.AutoSize = true;
            this.lbDisplayPostDate.Location = new System.Drawing.Point(1040, 80);
            this.lbDisplayPostDate.Name = "lbDisplayPostDate";
            this.lbDisplayPostDate.Size = new System.Drawing.Size(41, 20);
            this.lbDisplayPostDate.TabIndex = 7;
            this.lbDisplayPostDate.Text = "Date";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Location = new System.Drawing.Point(1262, 47);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(56, 20);
            this.lbExpirationDate.TabIndex = 8;
            this.lbExpirationDate.Text = "Expires";
            // 
            // lbDisplayExpirationDay
            // 
            this.lbDisplayExpirationDay.AutoSize = true;
            this.lbDisplayExpirationDay.Location = new System.Drawing.Point(1237, 80);
            this.lbDisplayExpirationDay.Name = "lbDisplayExpirationDay";
            this.lbDisplayExpirationDay.Size = new System.Drawing.Size(41, 20);
            this.lbDisplayExpirationDay.TabIndex = 9;
            this.lbDisplayExpirationDay.Text = "Date";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(1432, 65);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(18, 17);
            this.cbDelete.TabIndex = 10;
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(75, 24);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(58, 20);
            this.lbSubject.TabIndex = 11;
            this.lbSubject.Text = "Subject";
            // 
            // rtbSubjectName
            // 
            this.rtbSubjectName.Enabled = false;
            this.rtbSubjectName.Location = new System.Drawing.Point(20, 50);
            this.rtbSubjectName.Name = "rtbSubjectName";
            this.rtbSubjectName.Size = new System.Drawing.Size(164, 84);
            this.rtbSubjectName.TabIndex = 12;
            this.rtbSubjectName.Text = "";
            // 
            // NotificationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbSubjectName);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.lbDisplayExpirationDay);
            this.Controls.Add(this.lbExpirationDate);
            this.Controls.Add(this.lbDisplayPostDate);
            this.Controls.Add(this.lbPostDate);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.rtbDescription);
            this.Name = "NotificationControl";
            this.Size = new System.Drawing.Size(1531, 154);
            this.Load += new System.EventHandler(this.NotificationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion

        private RichTextBox rtbDescription;
        private Label lbTitle;
        private Label lbDescription;
        private Button btnTitle;
        private Label lbPostDate;
        private Label lbDisplayPostDate;
        private Label lbExpirationDate;
        private Label lbDisplayExpirationDay;
        private CheckBox cbDelete;
        private Label lbSubject;
        private RichTextBox rtbSubjectName;
    }
}
