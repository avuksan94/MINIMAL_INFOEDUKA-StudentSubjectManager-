using Minimal_Infoeduka.NotificationSubForms;
using ProjectTest02;
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

namespace Minimal_Infoeduka
{
    public partial class LecturerDashboard : Form
    {
        private UserService _userService;
        private SubjectLecturerService _subjectLecturerService;
        private ConnectionWatchDog _watchDog;
        private IList<Subject> _allSubjects;
        private string lecturerEmail;
        private int lecturerId;

        private string displayUsername;

        public LecturerDashboard(string username)
        {
            try
            {
                InitializeComponent();
                _userService = new UserService();
                _subjectLecturerService = new SubjectLecturerService();
                _allSubjects = new List<Subject>();
                _watchDog = new ConnectionWatchDog();

                lecturerEmail = _userService.GetMailForUser(username);
                displayUsername= username;


                this.StartPosition = FormStartPosition.CenterScreen;
                this.ControlBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                lbUsername.Text = displayUsername;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing LecturerDashboard: {ex.Message}");
            }
        }

        public void LoadLecturerDashboardData()
        {
            try
            {
                lbUsername.Text = _watchDog.GetUsername();
                flpDisplaySubjects.Controls.Clear();
                lecturerId = _subjectLecturerService.GetLecturerId(lecturerEmail);

                _allSubjects = _subjectLecturerService.GetSubjectsForLecturer(lecturerId);

                foreach (var subject in _allSubjects)
                {
                    int subjectId = _subjectLecturerService.GetSubjectId(subject.Name);
                    List<Lecturer> lecturersForSubjects = _subjectLecturerService.GetLecturersForSubject(subjectId);

                    var subjectControl = new LecturerSubjects();
                    subjectControl.SetSubjectData(subject.Name);
                    //subjectControl.RefreshAllData += LoadAdminDashboardData;

                    flpDisplaySubjects.Controls.Add(subjectControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading LecturerDashboard data: {ex.Message}");
            }
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            LoadLecturerDashboardData();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            SelectiveViewNotifications selectNotifications = new SelectiveViewNotifications(lecturerEmail);
            selectNotifications.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _watchDog.ClearFileContent();
            Close();
        }
    }
}
