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

namespace Minimal_Infoeduka.LecturerSubForms
{
    public partial class AddLecturer : Form
    {
        SubjectLecturerService _subjectLecturer;
        List<Subject> allSubjects;

        List<int> addLecturerToSubjectRelation;
        List<int>? removeLecturerToSubjectRelation;

        private ConnectionWatchDog _watchDog;

        private int lecturerId;

        public AddLecturer()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            lboxSubjects.MouseClick += lboxSubjects_Click;
            _subjectLecturer = new SubjectLecturerService();
            allSubjects = new List<Subject>();
            addLecturerToSubjectRelation = new List<int>();
            removeLecturerToSubjectRelation = new List<int>();
            _watchDog = new ConnectionWatchDog();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer()
            {
                Name = rtbLecturerName.Text,
                Surname = rtbLecturerSurname.Text,
                Email = rtbLecturerEmail.Text
            };

            if (_subjectLecturer.LecturerExists(lecturer.Email))
            {
                MessageBox.Show("WARNING! - Lecturer with this email already exists!!");
            }
            else
            {
                var validationResults = _subjectLecturer.AddLecturer(lecturer);

                if (validationResults.Any())
                {
                    // Display an error message to the user
                    string errors = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                    MessageBox.Show("Error: " + errors);
                }
                else
                {
                    lecturerId = _subjectLecturer.GetLecturerId(lecturer.Email);
                    this.Close();
                }
            }
        }

        private void cbGetAllSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbGetAllSubjects.SelectedIndex;
            int subjectId;

            if (selectedIndex >= 0 && selectedIndex < allSubjects.Count)
            {
                Subject selectedSubject = allSubjects[selectedIndex];

                if (IsSubjectInListBox(selectedSubject))
                {
                    MessageBox.Show("Subject has already been added to the list!");
                    return; 
                }

                lboxSubjects.Items.Add(selectedSubject.Name);
                subjectId = _subjectLecturer.GetSubjectId(selectedSubject.Name);

                addLecturerToSubjectRelation.Add(subjectId);
            }
        }

        private void AddLecturer_Load(object sender, EventArgs e)
        {
            lbUsername.Text = _watchDog.GetUsername();
            allSubjects = _subjectLecturer.GetAllSubjects().ToList();

            if (allSubjects.Any())
            {
                cbGetAllSubjects.Items.Clear();

                foreach (var subject in allSubjects)
                {
                    if (!string.IsNullOrEmpty(subject.ToString()))
                    {
                        cbGetAllSubjects.Items.Add(subject.Name);
                    }
                }
            }

            cbGetAllSubjects.Refresh();
        }

        private void AddLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (int subjectId in addLecturerToSubjectRelation)
            {
                _subjectLecturer.AssignLecturerToSubject(subjectId,lecturerId);
            }
            foreach (int subjectId in removeLecturerToSubjectRelation)
            {
                _subjectLecturer.RemoveLecturerFromSubject(subjectId, lecturerId);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addLecturerToSubjectRelation.Clear();
            removeLecturerToSubjectRelation.Clear();
            this.Close();
        }

        private void lboxSubjects_Click(object sender, MouseEventArgs e)
        {
            int subjectId;
            if (e.Button == MouseButtons.Left)
            {
                int selectedIndex = lboxSubjects.SelectedIndex;

                if (selectedIndex != -1)
                {
                    string? selectedItemText = lboxSubjects.SelectedItem.ToString();
                    subjectId = _subjectLecturer.GetSubjectId(selectedItemText);
                    removeLecturerToSubjectRelation.Add(subjectId);
                    lboxSubjects.Items.RemoveAt(selectedIndex);

                    lboxSubjects.Refresh();
                }
            }
        }

        private bool IsSubjectInListBox(Subject subject)
        {
            foreach (object item in lboxSubjects.Items)
            {
                string itemText = item.ToString();
                if (itemText.Trim() == subject.Name)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
    
}
