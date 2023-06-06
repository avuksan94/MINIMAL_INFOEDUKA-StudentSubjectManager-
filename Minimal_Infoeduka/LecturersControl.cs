using Minimal_Infoeduka.LecturerSubForms;
using ProjectTest02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Minimal_Infoeduka
{
    public partial class LecturersControl : UserControl
    {
        public event Action RefreshAllData;

        SubjectLecturerService _subjectLecturerService;
        public string lecturerEmail;

        public bool IsCheckBoxChecked
        {
            get { return cbDeleteLecturer.Checked; }
        }

        public string GetLectureEmail
        {
            get { return lecturerEmail; }
        }

        public LecturersControl()
        {
            _subjectLecturerService = new SubjectLecturerService();
            InitializeComponent();
        }

        public void SetLecturerData(string name, string surname, string email, string subjects)
        {
            lbLecturerData.Items.Add("Lecturer name: " + name);
            lbLecturerData.Items.Add("Subject surname: " + surname);
            lbLecturerData.Items.Add("Lecturer email: " + email);
            lbLecturerData.Items.Add("Subjects: " + subjects);

            lecturerEmail = email;
        }

        private void LecturersControl_Load(object sender, EventArgs e)
        {

        }

        private void lbLecturerData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditLecturer_Click(object sender, EventArgs e)
        {
            EditLecturer editLecturer = new EditLecturer(lecturerEmail);
            editLecturer.FormClosed += EditLecturer_FormClosed;
            editLecturer.Show();
        }

        private void EditLecturer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshParentData();
            RefreshAllData?.Invoke();
            Refresh();
        }

        private void RefreshParentData()
        {
            if (_subjectLecturerService == null)
            {
                return;
            }

            lbLecturerData.Items.Clear(); 

            int lecturerId = _subjectLecturerService.GetLecturerId(lecturerEmail);
            Lecturer lecturer = _subjectLecturerService.GetLecturer(lecturerId);

            if (lecturer == null)
            {
                return;
            }

            List<Subject> subjectsForLecturer = _subjectLecturerService.GetSubjectsForLecturer(lecturerId);

            lbLecturerData.Items.Add("Lecturer name: " + lecturer.Name);
            lbLecturerData.Items.Add("Lecturer surname: " + lecturer.Surname);
            lbLecturerData.Items.Add("Lecturer email: " + lecturer.Email);

            string subjectsString = _subjectLecturerService.GetSubjectsString(subjectsForLecturer);
            if (subjectsString == null)
            {
                subjectsString = "No subjects found";
            }
            lbLecturerData.Items.Add("Subjects: " + subjectsString);
        }
    }
}
