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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimal_Infoeduka.SubjectSubForms
{
    public partial class EditSubject : Form
    {
        SubjectLecturerService? _subjectLecturer;
        List<Lecturer>? allLecturers;
        List<Lecturer>? lecturersForSubject;
        private ConnectionWatchDog _watchDog;

        List<int>? addSubjectToLecturerRelation;
        List<int>? removeSubjectToLecturerRelation;

        private int subjectId;

        public EditSubject(string subjectName)
        {
            _subjectLecturer = new SubjectLecturerService();
            allLecturers = new List<Lecturer>();
            addSubjectToLecturerRelation = new List<int>();
            removeSubjectToLecturerRelation = new List<int>();
            _watchDog = new ConnectionWatchDog();

            subjectId = _subjectLecturer.GetSubjectId(subjectName);

            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();
        }

        private void EditSubject_Load(object sender, EventArgs e)
        {
            lbUsername.Text = _watchDog.GetUsername();
            Subject subject = _subjectLecturer.GetSubject(subjectId);
            rtbSubjectName.Text = subject.Name;
            rtbEcts.Text = subject.Ects.ToString();

            allLecturers = _subjectLecturer.GetAllLecturers().ToList();
            lecturersForSubject = _subjectLecturer.GetLecturersForSubject(subjectId);

            foreach (var lecturer in lecturersForSubject)
            {
                lboxLecturers.Items.Add(lecturer.Name + " " + lecturer.Surname + ", Email: " + lecturer.Email);
            }

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

            string carrierString = subject.Carrier.ToString();
            var carrierToSelect = cbSubjectCarrier.Items.OfType<string>()
                                                       .FirstOrDefault(s => s == carrierString);

            if (carrierToSelect != null)
            {
                cbSubjectCarrier.SelectedItem = carrierToSelect;
            }

            cbGetAllLecturers.Refresh();
            cbSubjectCarrier.Refresh();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(rtbEcts.Text, out int ects))
            {
                MessageBox.Show("Invalid ECTS value. Please enter a valid number.");
                return;
            }

            Subject subject = new Subject()
            {
                Name = rtbSubjectName.Text,
                Ects = ects,
                Carrier = cbSubjectCarrier.SelectedItem?.ToString()
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(subject, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(subject, validationContext, validationResults, true);

            if (!isValid)
            {
                string errors = string.Join(Environment.NewLine, validationResults.Select(vr => vr.ErrorMessage));
                MessageBox.Show("ERROR: \n" + errors);
            }
            else
            {
                _subjectLecturer.UpdateSubject(subjectId, subject);
                this.Close();
            }
        }

        private void cbGetAllLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbGetAllLecturers.SelectedIndex;
            int lecturerId;

            if (selectedIndex >= 0 && selectedIndex < allLecturers.Count)
            {
                Lecturer selectedLecturer = allLecturers[selectedIndex];

                if (IsLecturerInListBox(selectedLecturer))
                {
                    MessageBox.Show("Lecturer is already on the list!");
                    return;
                }

                lboxLecturers.Items.Add(selectedLecturer.Name + " " + selectedLecturer.Surname + ", Email: " + selectedLecturer.Email);
                lecturerId = _subjectLecturer.GetLecturerId(selectedLecturer.Email);

                addSubjectToLecturerRelation?.Add(lecturerId);
            }
        }

        private void EditSubject_FormClosed(object sender, FormClosedEventArgs e)
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

        private bool IsLecturerInListBox(Lecturer lecturer)
        {
            foreach (object item in lboxLecturers.Items)
            {
                string itemText = item.ToString();
               
                if (itemText.Contains(lecturer.Email))
                {
                    return true;
                }
            }
            return false; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addSubjectToLecturerRelation.Clear();
            removeSubjectToLecturerRelation.Clear();
            Close();
        }
    }
}
