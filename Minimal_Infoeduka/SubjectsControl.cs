using Minimal_Infoeduka.NotificationSubForms;
using Minimal_Infoeduka.SubjectSubForms;
using ProjectTest02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Minimal_Infoeduka
{
    public partial class SubjectsControl : UserControl
    {
        public event Action RefreshAllData;

        SubjectLecturerService _subjectLecturerService;
        public string subjectName;

        public bool IsCheckBoxChecked
        {
            get { return cbDelete.Checked; }
        }

        public string GetSubjectName
        {
            get { return subjectName; }
        }
        public SubjectsControl()
        {
            _subjectLecturerService= new SubjectLecturerService();
            InitializeComponent();
        }

        public void SetSubjectData(string name, string carrier, int ects, string lecturers)
        {
            lbSubjectData.Items.Add("Subject name: " + name);
            lbSubjectData.Items.Add("Subject Carrier: " + carrier);
            lbSubjectData.Items.Add("ECTS points: " +  ects);
            lbSubjectData.Items.Add("Lecturers: " + lecturers);

            subjectName = name;
        }

        private void SubjectsControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            SendNotification newNotification = new SendNotification(subjectName);
            newNotification.Show();
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            EditSubject editSubject = new EditSubject(subjectName);
            editSubject.FormClosed += EditSubject_FormClosed;
            editSubject.Show();
        }

        private void EditSubject_FormClosed(object? sender, FormClosedEventArgs e)
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

            lbSubjectData.Items.Clear(); 

            int subjectId = _subjectLecturerService.GetSubjectId(subjectName);
            Subject subject = _subjectLecturerService.GetSubject(subjectId);

            if (subject == null)
            {
                return;
            }

            List<Lecturer> lecturersForSubjects = _subjectLecturerService.GetLecturersForSubject(subjectId);

            lbSubjectData.Items.Add("Subject name: " + subject.Name);
            lbSubjectData.Items.Add("Subject Carrier: " + subject.Carrier);
            lbSubjectData.Items.Add("ECTS points: " + subject.Ects);

            string lecturersString = _subjectLecturerService.GetLecturersString(lecturersForSubjects);
            if (lecturersString == null)
            {
                lecturersString = "No lecturers found";
            }
            lbSubjectData.Items.Add("Lecturers: " + lecturersString);
        }
    }
}
