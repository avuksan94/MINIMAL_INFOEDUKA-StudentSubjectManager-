using Minimal_Infoeduka.LecturerSubForms;
using Minimal_Infoeduka.NotificationSubForms;
using Minimal_Infoeduka.SubjectSubForms;
using ProjectTest02;
using ProjectTest02.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal_Infoeduka
{
    public partial class AdminDashboard : Form
    {
        private SubjectLecturerService _subjectLecturerService;
        private ConnectionWatchDog _watchDog;
        private IList<Subject> _allSubjects;
        private IList<Lecturer> _allLecturers;

        private int subjectDeleteCounter = 0;
        private int lecturerDeleteCounter = 0;

        string subjectName;
        string lecturerEmail;
        int subjectId;
        int lecturerId;


        public AdminDashboard()
        {
            _subjectLecturerService= new SubjectLecturerService();
            _allSubjects = new List<Subject>();
            _allLecturers = new List<Lecturer>();
            _watchDog = new ConnectionWatchDog();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbUsername.Text = _watchDog.GetUsername();
            LoadAdminDashboardData();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addNew = new AddSubject();
            addNew.Show();
            addNew.FormClosed += AddSubject_FormClosed;
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            AddLecturer addNew = new AddLecturer();
            addNew.Show();
            addNew.FormClosed += AddLecturer_FormClosed;

        }

        private void AddLecturer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ClearControls();
            LoadAdminDashboardData();
        }

        private void AddSubject_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ClearControls();
            LoadAdminDashboardData();
        }

        private void btnDeleteSubjects_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the subject/subject?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var control in flpDisplaySubjects.Controls)
                {
                    if (control is SubjectsControl customControl)
                    {
                        if (customControl.IsCheckBoxChecked)
                        {
                            subjectDeleteCounter++;
                            subjectName = customControl.GetSubjectName;

                            subjectId = _subjectLecturerService.GetSubjectId(subjectName);
                            _subjectLecturerService.DeleteSubject(subjectId);

                            flpDisplaySubjects.Controls.Remove(customControl);

                        }
                    }
                }
                if (subjectDeleteCounter == 0)
                {
                    MessageBox.Show("No items were selected, no changes will be made!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            subjectDeleteCounter = 0;
            ClearControls();
            LoadAdminDashboardData();
        }

        private void btnDeleteLecturers_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the lecturer/lecturers?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var control in flpDisplayLecturers.Controls)
                {
                    if (control is LecturersControl customControl)
                    {
                        if (customControl.IsCheckBoxChecked)
                        {
                            lecturerDeleteCounter++;
                            lecturerEmail = customControl.lecturerEmail;

                            lecturerId = _subjectLecturerService.GetLecturerId(lecturerEmail);
                            _subjectLecturerService.DeleteLecturer(lecturerId);

                            flpDisplayLecturers.Controls.Remove(customControl);

                        }
                    }
                }
                if (lecturerDeleteCounter == 0)
                {
                    MessageBox.Show("No items were selected, no changes will be made!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            lecturerDeleteCounter= 0;
            ClearControls();
            LoadAdminDashboardData();
        }

        public void LoadAdminDashboardData() 
        {
            flpDisplaySubjects.Controls.Clear();
            flpDisplayLecturers.Controls.Clear();

            _allSubjects = _subjectLecturerService.GetAllSubjects().ToList();

            foreach (var subject in _allSubjects)
            {
                int subjectId = _subjectLecturerService.GetSubjectId(subject.Name);
                List<Lecturer> lecturersForSubjects = _subjectLecturerService.GetLecturersForSubject(subjectId);

                var subjectControl = new SubjectsControl();
                subjectControl.SetSubjectData(subject.Name, subject.Carrier, subject.Ects, _subjectLecturerService.GetLecturersString(lecturersForSubjects));
                subjectControl.RefreshAllData += LoadAdminDashboardData;

                flpDisplaySubjects.Controls.Add(subjectControl);
            }

            _allLecturers = _subjectLecturerService.GetAllLecturers().ToList();

            foreach (var lecturer in _allLecturers)
            {
                int lecturerId = _subjectLecturerService.GetLecturerId(lecturer.Email);
                List<Subject> subjectsForLecturers = _subjectLecturerService.GetSubjectsForLecturer(lecturerId);

                var lecturerControl = new LecturersControl();
                lecturerControl.SetLecturerData(lecturer.Name, lecturer.Surname, lecturer.Email, _subjectLecturerService.GetSubjectsString(subjectsForLecturers));
                lecturerControl.RefreshAllData += LoadAdminDashboardData;

                flpDisplayLecturers.Controls.Add(lecturerControl);
            }
        }

        public void ClearControls() 
        {
            var subjectControls = flpDisplaySubjects.Controls.OfType<Control>().ToList();
            var lecturerControls = flpDisplayLecturers.Controls.OfType<Control>().ToList();
            foreach (var control in subjectControls)
            {
                flpDisplaySubjects.Controls.Remove(control);
                control.Dispose();
            }

            foreach (var control in lecturerControls)
            {
                flpDisplayLecturers.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ViewAllNotifications allNotifications = new ViewAllNotifications();
            allNotifications.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _watchDog.ClearFileContent();
            Close();
            
        }
    }
}
