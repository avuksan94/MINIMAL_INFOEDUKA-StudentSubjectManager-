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
    public partial class EditNotification : Form
    {
        SubjectNotificationService _notificationService;


        private int notificationId;
        public EditNotification(string notificationTitle)
        {
            _notificationService= new SubjectNotificationService();
            notificationId = _notificationService.GetNotificationId(notificationTitle);
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void EditNotification_Load(object sender, EventArgs e)
        {
            Notification notification = _notificationService.GetNotification(notificationId);
            rtbNotificationTitle.Text = notification.Title;
            rtbNotificationDescription.Text = notification.Description;
   
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification()
            {
                Title = rtbNotificationTitle.Text,
                Description = rtbNotificationDescription.Text
            };

            // Validate the Notification object
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(notification, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(notification, validationContext, validationResults, true);

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
                MessageBox.Show("Invalid notification data. Please check the input fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _notificationService.UpdateNotification(notificationId, notification);

                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
