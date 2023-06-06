namespace Minimal_Infoeduka.NotificationSubForms
{
    partial class SelectiveViewNotifications
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
            this.pnlDecorationOne = new System.Windows.Forms.Panel();
            this.btnDeleteNotifications = new System.Windows.Forms.Button();
            this.lbAllNotifications = new System.Windows.Forms.Label();
            this.flpDisplayAllNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDecorationOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDecorationOne
            // 
            this.pnlDecorationOne.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDecorationOne.Controls.Add(this.btnDeleteNotifications);
            this.pnlDecorationOne.Location = new System.Drawing.Point(1309, 113);
            this.pnlDecorationOne.Name = "pnlDecorationOne";
            this.pnlDecorationOne.Size = new System.Drawing.Size(246, 82);
            this.pnlDecorationOne.TabIndex = 13;
            // 
            // btnDeleteNotifications
            // 
            this.btnDeleteNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnDeleteNotifications.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNotifications.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNotifications.Location = new System.Drawing.Point(21, 6);
            this.btnDeleteNotifications.Name = "btnDeleteNotifications";
            this.btnDeleteNotifications.Size = new System.Drawing.Size(208, 73);
            this.btnDeleteNotifications.TabIndex = 6;
            this.btnDeleteNotifications.Text = "Delete";
            this.btnDeleteNotifications.UseVisualStyleBackColor = false;
            this.btnDeleteNotifications.Click += new System.EventHandler(this.btnDeleteNotifications_Click);
            // 
            // lbAllNotifications
            // 
            this.lbAllNotifications.AutoSize = true;
            this.lbAllNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(70)))));
            this.lbAllNotifications.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAllNotifications.ForeColor = System.Drawing.Color.White;
            this.lbAllNotifications.Location = new System.Drawing.Point(607, 21);
            this.lbAllNotifications.Name = "lbAllNotifications";
            this.lbAllNotifications.Size = new System.Drawing.Size(335, 60);
            this.lbAllNotifications.TabIndex = 12;
            this.lbAllNotifications.Text = "All Notifications";
            // 
            // flpDisplayAllNotifications
            // 
            this.flpDisplayAllNotifications.AutoScroll = true;
            this.flpDisplayAllNotifications.BackColor = System.Drawing.SystemColors.Control;
            this.flpDisplayAllNotifications.Location = new System.Drawing.Point(24, 201);
            this.flpDisplayAllNotifications.Name = "flpDisplayAllNotifications";
            this.flpDisplayAllNotifications.Size = new System.Drawing.Size(1531, 647);
            this.flpDisplayAllNotifications.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(687, 888);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 73);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SelectiveViewNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1582, 973);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flpDisplayAllNotifications);
            this.Controls.Add(this.pnlDecorationOne);
            this.Controls.Add(this.lbAllNotifications);
            this.Name = "SelectiveViewNotifications";
            this.Text = "SelectiveViewNotifications";
            this.Load += new System.EventHandler(this.SelectiveViewNotifications_Load);
            this.pnlDecorationOne.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlDecorationOne;
        private Button btnDeleteNotifications;
        private Label lbAllNotifications;
        private FlowLayoutPanel flpDisplayAllNotifications;
        private Button btnClose;
    }
}