using ProjectTest02;
using ProjectTest02.Models;
using ProjectTest02.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal_Infoeduka.NotificationSubForms
{
    public partial class SendNotification : Form
    {
        SubjectNotificationService _notificationService;
        SubjectLecturerService _subjectLecturerService;

        string name;
        public SendNotification(string subjectName)
        {
            _notificationService = new SubjectNotificationService();
            _subjectLecturerService= new SubjectLecturerService();
            name = subjectName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification()
            {
                PostTime = DateTime.Now,
                Title = rtbNotificationTitle.Text,
                Description = rtbNotificationDescription.Text,
                ExperationTime = DateTime.Now.AddDays(14)
            };

            var validationContext = new ValidationContext(notification, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(notification, validationContext, validationResults, true);

            if (!isValid)
            {
                string errors = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show("Error: " + errors);
            }
            else
            {
                _notificationService.AddNotification(notification);

                int subjectId = _subjectLecturerService.GetSubjectId(name);
                int notificationId = _notificationService.GetNotificationId(rtbNotificationTitle.Text);

                _notificationService.AssignNotificationToSubject(subjectId, notificationId);

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendNotification_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData() 
        {
            lbSubjectName.Text = name;
        }
    }
}
