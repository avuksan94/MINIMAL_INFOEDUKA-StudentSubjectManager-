using ProjectTest02;
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

namespace Minimal_Infoeduka.LecturerSubForms
{
    public partial class EditLecturer : Form
    {
        SubjectLecturerService _subjectLecturer;
        List<Subject> allSubjects;
        List<Subject> subjectsForLecturers;
        private ConnectionWatchDog _watchDog;

        List<int>? addLecturerToSubjectRelation;
        List<int>? removeLecturerToSubjectRelation;

        private int lecturerId;

        public EditLecturer(string lecturerEmail)
        {
            _subjectLecturer = new SubjectLecturerService();
            allSubjects = new List<Subject>();
            addLecturerToSubjectRelation = new List<int>();
            removeLecturerToSubjectRelation = new List<int>();
            _watchDog = new ConnectionWatchDog();

            lecturerId = _subjectLecturer.GetLecturerId(lecturerEmail);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            InitializeComponent();
        }

        private void EditLecturer_Load(object sender, EventArgs e)
        {
            lbUsername.Text = _watchDog.GetUsername();
            Lecturer lecturer = _subjectLecturer.GetLecturer(lecturerId);
            rtbLecturerName.Text = lecturer.Name;
            rtbLecturerSurname.Text = lecturer.Surname;
            rtbLecturerEmail.Text = lecturer.Email;

            allSubjects = _subjectLecturer.GetAllSubjects().ToList();
            subjectsForLecturers = _subjectLecturer.GetSubjectsForLecturer(lecturerId);

            foreach (var subject in subjectsForLecturers)
            {
                lboxSubjects.Items.Add(subject.Name);
            }

            if (allSubjects.Any())
            {
                cbGetAllSubjects.Items.Clear();

                foreach (var subject in allSubjects)
                {
                    if (!string.IsNullOrEmpty(subject.ToString()))
                    {
                        cbGetAllSubjects.Items.Add(subject.ToString());
                    }
                }
            }

            subjectsForLecturers = _subjectLecturer.GetSubjectsForLecturer(lecturerId);
            cbGetAllSubjects.Refresh();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer()
            {
                Name = rtbLecturerName.Text,
                Surname = rtbLecturerSurname.Text,
                Email = rtbLecturerEmail.Text
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(lecturer, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(lecturer, validationContext, validationResults, true);

            if (!isValid)
            {
                string errors = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show("ERROR: \n" + errors);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to make these changes?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _subjectLecturer.UpdateLecturer(lecturerId, lecturer);
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
            addLecturerToSubjectRelation.Clear();
            removeLecturerToSubjectRelation.Clear();
            this.Close();
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

        private void EditLecturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (int subjectId in addLecturerToSubjectRelation)
            {
                _subjectLecturer.AssignLecturerToSubject(subjectId, lecturerId);
            }

            foreach (int subjectId in removeLecturerToSubjectRelation)
            {
                _subjectLecturer.RemoveLecturerFromSubject(subjectId, lecturerId);
            }
        }

        private void lboxSubjects_MouseClick(object sender, MouseEventArgs e)
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
                    //MessageBox.Show(subjectId.ToString());
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
