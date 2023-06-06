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
    public partial class AddSubject : Form
    {
        SubjectLecturerService _subjectLecturer;
        List<Lecturer> allLecturers;

        List<int> addSubjectToLecturerRelation;
        List<int>? removeSubjectToLecturerRelation;


        private ConnectionWatchDog _watchDog;

        private int subjectId;
       
        public AddSubject()
        {
            InitializeComponent();
            _subjectLecturer= new SubjectLecturerService();
            allLecturers= new List<Lecturer>();
            addSubjectToLecturerRelation= new List<int>();
            removeSubjectToLecturerRelation = new List<int>();
            _watchDog = new ConnectionWatchDog();
            lboxLecturers.MouseClick += lboxLecturers_MouseClick;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(rtbEcts.Text, out int ects))
            {
                MessageBox.Show("Invalid ECTS value. Please enter a valid number.");
                return;
            }
            Subject subject = new Subject()
            {
                Name = rtbSubjectName.Text,
                Ects = int.Parse(rtbEcts.Text),
                Carrier = cbSubjectCarrier.SelectedItem?.ToString()
            };


            if (_subjectLecturer.SubjectExists(subject.Name))
            {
                MessageBox.Show("WARNING! - Subject already exists!!");
            }
            else
            {
                var validationResults = _subjectLecturer.AddSubject(subject);

                if (validationResults.Any())
                {
                    string errors = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                    MessageBox.Show("ERROR: \n" + errors);
                }
                else
                {
                    subjectId = _subjectLecturer.GetSubjectId(subject.Name);
                    this.Close();
                }
            }
        }


        private void cbGetAllLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbGetAllLecturers.SelectedIndex;
            int lecturerId;

            if (selectedIndex >= 0 && selectedIndex < allLecturers.Count)
            {
                Lecturer selectedLecturer = allLecturers[selectedIndex];
                string lecturerInfo = selectedLecturer.Name + " " + selectedLecturer.Surname + ", Email: " + selectedLecturer.Email;

                if (!lboxLecturers.Items.Contains(lecturerInfo))
                {
                    lboxLecturers.Items.Add(lecturerInfo);
                    lecturerId = _subjectLecturer.GetLecturerId(selectedLecturer.Email);
                    addSubjectToLecturerRelation.Add(lecturerId);
                }
                else 
                {
                    MessageBox.Show("Lecturer is already on the list!");
                    return;
                }
            }
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            lbUsername.Text = _watchDog.GetUsername();
            allLecturers = _subjectLecturer.GetAllLecturers().ToList();

            if (allLecturers.Any())
            {
                cbGetAllLecturers.Items.Clear();
                cbSubjectCarrier.Items.Clear();

                foreach (var lecturer in allLecturers)
                {
                    if (!string.IsNullOrEmpty(lecturer.ToString()))
                    {
                        cbGetAllLecturers.Items.Add(lecturer.ToString());
                        cbSubjectCarrier.Items.Add(lecturer.ToString());
                    }
                }
            }

            cbGetAllLecturers.Refresh();
            cbSubjectCarrier.Refresh();
        }


        private void AddSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var lecturerId in addSubjectToLecturerRelation)
            {
                _subjectLecturer.AssignLecturerToSubject(subjectId, lecturerId);
            }
            foreach (var lecturerId in removeSubjectToLecturerRelation)
            {
                _subjectLecturer.RemoveLecturerFromSubject(subjectId, lecturerId);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addSubjectToLecturerRelation.Clear();
            removeSubjectToLecturerRelation.Clear();
            Close();
        }

        private void lboxLecturers_MouseClick(object sender, MouseEventArgs e)
        {
            int lecturerId;
            if (e.Button == MouseButtons.Left)
            {
                int selectedIndex = lboxLecturers.SelectedIndex;

                if (selectedIndex != -1)
                {
                    string? selectedItemText = lboxLecturers.SelectedItem.ToString();
                    lecturerId = _subjectLecturer.GetLecturerId(ParseEmailFromItem(selectedItemText));
                    lboxLecturers.Items.RemoveAt(selectedIndex);
                    removeSubjectToLecturerRelation.Add(lecturerId);
                    lboxLecturers.Refresh();
                }
            }
        }

        private string ParseEmailFromItem(string itemText)
        {
            const string separator = ", Email: ";
            int separatorIndex = itemText.IndexOf(separator);

            if (separatorIndex != -1)
            {
                return itemText.Substring(separatorIndex + separator.Length);
            }

            return string.Empty; 
        }
    }
}
