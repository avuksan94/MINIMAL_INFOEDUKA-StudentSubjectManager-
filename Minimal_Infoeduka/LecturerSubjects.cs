using Minimal_Infoeduka.NotificationSubForms;
using Minimal_Infoeduka.SubjectSubForms;
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

namespace Minimal_Infoeduka
{
    public partial class LecturerSubjects : UserControl
    {
        SubjectLecturerService _subjectLecturerService;
        public string subjectName;
        public LecturerSubjects()
        {
            _subjectLecturerService= new SubjectLecturerService();
            InitializeComponent();
        }

        public void SetSubjectData(string name)
        {
            btnSubjectName.Text = name;

            subjectName = name;
        }

        private void LecturerSubjects_Load(object sender, EventArgs e)
        {

        }

        private void btnSubjectName_Click(object sender, EventArgs e)
        {
            DisplaySubjectData displayData = new DisplaySubjectData(subjectName);
            displayData.Show();
        }

        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            SendNotification newNotification = new SendNotification(subjectName);
            newNotification.Show();
        }
    }
}
