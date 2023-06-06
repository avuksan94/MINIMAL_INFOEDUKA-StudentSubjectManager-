using ProjectTest02;
using ProjectTest02.Models;
using ProjectTest02.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal_Infoeduka.NotificationSubForms
{
    public partial class ViewAllNotifications : Form
    {
        SubjectNotificationService _notificationsService;
        IList<Notification> _allNotifications;

        private int notificationDeleteCounter = 0;

        string notificationTitle;
        int notificationId;
        public ViewAllNotifications()
        {
            _notificationsService = new SubjectNotificationService();
            _allNotifications= new List<Notification>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void ViewAllNotifications_Load(object sender, EventArgs e)
        {
            LoadViewDashboardData();
        }

        public void LoadViewDashboardData()
        {
            flpDisplayAllNotifications.Controls.Clear();

            _allNotifications = _notificationsService.GetAllNotifications().ToList();

            foreach (var notification in _allNotifications)
            {
                int notificationId = _notificationsService.GetNotificationId(notification.Title);
                string subjectName = _notificationsService.GetSubjectNameForNotification(notificationId);

                var notificationControl = new NotificationControl();
                notificationControl.SetNotificationData(subjectName,notification.Title, notification.Description, notification.PostTime.ToString(), notification.ExperationTime.ToString());
                notificationControl.RefreshAllData += LoadViewDashboardData;

                flpDisplayAllNotifications.Controls.Add(notificationControl);
            }
        }

        public void ClearControls()
        {
            var notificationControls = flpDisplayAllNotifications.Controls.OfType<Control>().ToList();
            foreach (var control in notificationControls)
            {
                flpDisplayAllNotifications.Controls.Remove(control);
                control.Dispose();
            }

           
        }

        private void btnDeleteNotifications_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the notification/notifications", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var control in flpDisplayAllNotifications.Controls)
                {
                    if (control is NotificationControl customControl)
                    {
                        if (customControl.IsCheckBoxChecked)
                        {
                            notificationDeleteCounter++;
                            notificationTitle = customControl.notificationTitle;

                            notificationId = _notificationsService.GetNotificationId(notificationTitle);

                            _notificationsService.DeleteNotification(notificationId);


                            flpDisplayAllNotifications.Controls.Remove(customControl);

                        }
                    }
                }
                if (notificationDeleteCounter == 0)
                {
                    MessageBox.Show("No items were selected, no changes will be made!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            notificationDeleteCounter = 0;
            ClearControls();
            LoadViewDashboardData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
