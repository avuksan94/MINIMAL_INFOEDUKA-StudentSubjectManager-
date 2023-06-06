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

namespace Minimal_Infoeduka.SubjectSubForms
{
    public partial class DisplaySubjectData : Form
    {
        SubjectLecturerService _subjectLecturer;
        IList<Lecturer> allLecturers;
        IList<Lecturer> lecturersForSubject;
        private ConnectionWatchDog _watchDog;

        public int subjectId;
        public DisplaySubjectData(string subjectName)
        {
            _subjectLecturer = new SubjectLecturerService();
            allLecturers = new List<Lecturer>();
            lecturersForSubject = new List<Lecturer>();
            subjectId = _subjectLecturer.GetSubjectId(subjectName);
            _watchDog = new ConnectionWatchDog();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void DisplaySubjectData_Load(object sender, EventArgs e)
        {
            LoadSubjectData();
        }

        public void LoadSubjectData() 
        {
            lbUsername.Text = _watchDog.GetUsername();
            Subject subject = _subjectLecturer.GetSubject(subjectId);
            lbSubjectInfo.Text = subject.Name;
            rtbEcts.Text = subject.Ects.ToString();
            lbDisplaySubjectCarrier.Text = subject.Carrier;

            allLecturers = _subjectLecturer.GetAllLecturers().ToList();
            lecturersForSubject = _subjectLecturer.GetLecturersForSubject(subjectId);

            foreach (var lecturer in lecturersForSubject)
            {
                lboxLecturers.Items.Add(lecturer.Name + " " + lecturer.Surname + ", Email: " + lecturer.Email);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
