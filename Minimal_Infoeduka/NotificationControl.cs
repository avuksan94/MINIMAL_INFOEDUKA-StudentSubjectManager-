using Minimal_Infoeduka.NotificationSubForms;
using Minimal_Infoeduka.SubjectSubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal_Infoeduka
{
    public partial class NotificationControl : UserControl
    {
        public event Action RefreshAllData;
        public string notificationTitle;
        public NotificationControl()
        {
            InitializeComponent();
            rtbDescription.ReadOnly = true;
        }

        public bool IsCheckBoxChecked
        {
            get { return cbDelete.Checked; }
        }

        public string NotificationTitle
        {
            get { return notificationTitle; }
        }


        public void SetNotificationData(string subjectName,string title, string description, string postDate, string expirationDate)
        {
            rtbSubjectName.Text= subjectName;
            btnTitle.Text = title;
            rtbDescription.Text = description;
            lbDisplayPostDate.Text = postDate;
            lbDisplayExpirationDay.Text = expirationDate;

            notificationTitle = title;
        }

        private void NotificationControl_Load(object sender, EventArgs e)
        {

        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            EditNotification editNotification = new EditNotification(notificationTitle);
            editNotification.FormClosed += EditNotification_FormClosed;
            editNotification.Show();
        }

        private void EditNotification_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshAllData?.Invoke();
        }
    }
}
