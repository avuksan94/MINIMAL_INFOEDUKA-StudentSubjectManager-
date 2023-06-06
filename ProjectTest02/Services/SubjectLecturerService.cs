using ProjectTest02.Models;
using ProjectTest02.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02
{
    public class SubjectLecturerService
    {
        UserService _userService = new UserService();

        private const char DELIMITER = '|';
        private List<Subject> _subjects;
        private List<Lecturer> _lecturers;
        private List<SubjectLecturer> _subjectLecturers;


        private const string SUBJECT_COUNTER = "SubjectCounter.txt";
        private const string LECTURER_COUNTER = "LecturerCounter.txt";
        private const string SUBJECTS_FILE_NAME = "Subjects.txt";
        private const string LECTURERS_FILE_NAME = "Lecturers.txt";
        private const string SUBJECTS_LECTURERS_FILE_NAME = "subjectLecturers.txt";


        private static string SubjectsCounterFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SUBJECT_COUNTER);
        private static string LecturersCounterFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), LECTURER_COUNTER);
        string SubjectsFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SUBJECTS_FILE_NAME);
        string LecturersFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), LECTURERS_FILE_NAME);
        string SubjectLecturersFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SUBJECTS_LECTURERS_FILE_NAME);

        //ID COUNTER 

        private Counter _counterSubjects;
        private Counter _counterLecturers;
        //-------------------------------------------------------------------------------------------

        public SubjectLecturerService()
        {
            CheckIfFilesExist();
            _subjects = new List<Subject>();
            _lecturers = new List<Lecturer>();
            _subjectLecturers = new List<SubjectLecturer>();
            _counterSubjects = new Counter(SubjectsCounterFileName);
            _counterLecturers = new Counter(LecturersCounterFileName);
        }

        // CRUD for Subjects

        public IEnumerable<Subject> GetAllSubjects() 
        {
            try
            {
                if (_subjects != null)
                {
                    LoadAllSubjects();
                    return _subjects;
                }
                //samo da se ne razleti vrati nesta
                return new List<Subject> ();
               
            }
            catch (Exception)
            {
                throw new Exception("Error occured loading all subjects");
            }
        }

        public Subject GetSubject(int id)
        {
            LoadAllSubjects();
            return _subjects.FirstOrDefault(s => s.Id == id);
        }

        public int GetSubjectId(string name) 
        {
            LoadAllSubjects();
            int subjectId = _subjects.Where(s => s.Name == name)
                         .Select(s => s.Id)
                         .FirstOrDefault();
            return subjectId;
        }

        public List<ValidationResult> AddSubject(Subject subject)
        {
            LoadAllSubjects();

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(subject, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(subject, validationContext, validationResults, true);

            if (isValid)
            {
                subject.Id = _counterSubjects.GetNextId();
                _subjects.Add(subject);
                SaveSubjectsData();
            }
            return validationResults;
        }

        //public void AddSubject(Subject subject)
        //{
        //    LoadAllSubjects();
        //
        //    var validationResults = new List<ValidationResult>();
        //    var validationContext = new ValidationContext(subject, serviceProvider: null, items: null);
        //    Validator.TryValidateObject(subject, validationContext, validationResults, true);
        //

        //    if (validationResults.Any())
        //    {

        //        foreach (var error in validationResults)
        //        {
        //            Console.WriteLine(error.ErrorMessage);
        //        }
        //    }
        //    else
        //    {
        //        subject.Id = _counterSubjects.GetNextId();
        //        _subjects.Add(subject);
        //        SaveSubjectsData();
        //    }
        //}

        public void UpdateSubject(int id, Subject subject)
        {
            LoadAllSubjects();
            var existingSubject = GetSubject(id);
            if (existingSubject != null)
            {
                existingSubject.Name = subject.Name;
                existingSubject.Carrier = subject.Carrier;
                existingSubject.Ects = subject.Ects;
            }
            SaveSubjectsData();

        }

        public void DeleteSubject(int id)
        {
            LoadAllSubjects();
            LoadAllSubjectLecturers();
            var subject = GetSubject(id);
            if (subject != null)
            {
                _subjects.Remove(subject);
                _subjectLecturers.RemoveAll(sl => sl.SubjectId == id);
            }
            SaveSubjectsData();
            SaveSubjectLecturerData();
        }

        //Check if subject exists
        public bool SubjectExists(string name) 
        {
            IList<Subject> allSubjects = GetAllSubjects().ToList();

            foreach (var subject in allSubjects) 
            {
                if (subject.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        // CRUD for Lecturers

        public IEnumerable<Lecturer> GetAllLecturers()
        {
            LoadAllLecturers();
            return _lecturers;
        }

        public int GetLecturerId(string email)
        {
            LoadAllLecturers();
            int lecturerId = _lecturers.Where(l => l.Email == email)
                         .Select(l => l.Id)
                         .FirstOrDefault();
            return lecturerId;
        }

        public Lecturer GetLecturer(int id)
        {
            LoadAllLecturers();
            return _lecturers.FirstOrDefault(l => l.Id == id);
        }

        public List<ValidationResult> AddLecturer(Lecturer lecturer)
        {
            LoadAllLecturers();

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(lecturer, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(lecturer, validationContext, validationResults, true);

            if (isValid)
            {
                lecturer.Id = _counterLecturers.GetNextId();
                _lecturers.Add(lecturer);
                SaveLecturersData();

                _userService.CreateLecturerUserPassword(lecturer);
            }
            return validationResults;
        }

        //public void AddLecturer(Lecturer lecturer)
        //{
        //    LoadAllLecturers();
        //    
        //    var validationResults = new List<ValidationResult>();
        //    var validationContext = new ValidationContext(lecturer, serviceProvider: null, items: null);
        //    Validator.TryValidateObject(lecturer, validationContext, validationResults, true);
        //
   
        //    if (validationResults.Any())
        //    {

        //        foreach (var error in validationResults)
        //        {
        //            Console.WriteLine(error.ErrorMessage);
        //        }
        //    }
        //    else 
        //    {
        //        lecturer.Id = _counterLecturers.GetNextId();
        //        _lecturers.Add(lecturer);
        //        SaveLecturersData();
        //
        //        _userService.CreateLecturerUserPassword(lecturer);
        //    }
        //    
        //}

        public void UpdateLecturer(int id,Lecturer lecturer)
        {
            LoadAllLecturers();
            var existingLecturer = GetLecturer(id);
            if (existingLecturer != null)
            {
                existingLecturer.Name = lecturer.Name;
                existingLecturer.Surname= lecturer.Surname;
                existingLecturer.Email = lecturer.Email;
            }
            SaveLecturersData();
        }

        public void DeleteLecturer(int id)
        {
            LoadAllLecturers();
            LoadAllSubjectLecturers();
            var lecturer = GetLecturer(id);
            if (lecturer != null)
            {
                _lecturers.Remove(lecturer);
                _subjectLecturers.RemoveAll(sl => sl.LecturerId == id);
            }
            SaveLecturersData();
            SaveSubjectLecturerData();
        }

        //Check if subject exists
        public bool LecturerExists(string email)
        {
            IList<Lecturer> allLecturers = GetAllLecturers().ToList();

            foreach (var lecturer in allLecturers)
            {
                if (lecturer.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        // CRUD for SubjectLecturer
        public void AssignLecturerToSubject(int subjectId, int lecturerId)
        {
            LoadDataFromFile();

            var subjectLecturer = new SubjectLecturer
            {
                SubjectId = subjectId,
                LecturerId = lecturerId
            };
            _subjectLecturers.Add(subjectLecturer);

            SaveDataToFile();
        }

        public void RemoveLecturerFromSubject(int subjectId, int lecturerId)
        {
            LoadDataFromFile();
            var subjectLecturer = _subjectLecturers.FirstOrDefault(sl => sl.SubjectId == subjectId && sl.LecturerId == lecturerId);
            if (subjectLecturer != null)
            {
                _subjectLecturers.Remove(subjectLecturer);
            }

            SaveDataToFile();
        }

        public List<Lecturer> GetLecturersForSubject(int subjectId)
        {
            LoadDataFromFile();
            return _subjectLecturers.Where(sl => sl.SubjectId == subjectId)
                                    .Select(sl => sl.Lecturer)
                                    .ToList();
        }

        public string GetLecturersString(List<Lecturer> lecturers)
        {
            if (lecturers == null || lecturers.Count == 0)
            {
                return "";
            }

            return string.Join(", ", lecturers.Select(l => l.ToString()));
        }

        public List<Subject> GetSubjectsForLecturer(int lecturerId)
        {
            LoadDataFromFile();
            return _subjectLecturers.Where(sl => sl.LecturerId == lecturerId)
                                    .Select(sl => sl.Subject)
                                    .ToList();
        }

        public string GetSubjectsString(List<Subject> subjects)
        {
            if (subjects == null || subjects.Count == 0)
            {
                return "";
            }

            return string.Join(", ", subjects.Select(l => l.ToString()));
        }

        //SAVE and Load

        public void SaveDataToFile()
        {
            File.WriteAllLines(SubjectsFileName, _subjects.Select(s => $"{s.Id}{DELIMITER}{s.Name}{DELIMITER}{s.Carrier}{DELIMITER}{s.Ects}"));
            File.WriteAllLines(LecturersFileName, _lecturers.Select(l => $"{l.Id}{DELIMITER}{l.Name}{DELIMITER}{l.Surname}{DELIMITER}{l.Email}"));
            File.WriteAllLines(SubjectLecturersFileName, _subjectLecturers.Select(sl => $"{sl.SubjectId}{DELIMITER}{sl.LecturerId}"));

            _counterSubjects.SaveCounterToFile();
            _counterLecturers.SaveCounterToFile();

        }

        //Zasebni SAVE
        public void SaveSubjectsData() 
        {
            File.WriteAllLines(SubjectsFileName, _subjects.Select(s => $"{s.Id}{DELIMITER}{s.Name}{DELIMITER}{s.Carrier}{DELIMITER}{s.Ects}"));
            _counterSubjects.SaveCounterToFile();
        }
        public void SaveLecturersData()
        {
            File.WriteAllLines(LecturersFileName, _lecturers.Select(l => $"{l.Id}{DELIMITER}{l.Name}{DELIMITER}{l.Surname}{DELIMITER}{l.Email}"));
            _counterLecturers.SaveCounterToFile();
        }
        public void SaveSubjectLecturerData() => File.WriteAllLines(SubjectLecturersFileName, _subjectLecturers.Select(sl => $"{sl.SubjectId}{DELIMITER}{sl.LecturerId}"));


        public void LoadDataFromFile()
        {
            if (File.Exists(SubjectsFileName))
            {
                var subjectsData = File.ReadAllLines(SubjectsFileName);
                _subjects = subjectsData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Subject 
                    { 
                        Id = int.Parse(parts[0]), 
                        Name = parts[1],
                        Carrier = parts[2],
                        Ects = int.Parse(parts[3])
                    };
                }).ToList();
            }

            if (File.Exists(LecturersFileName))
            {
                var lecturersData = File.ReadAllLines(LecturersFileName);
                _lecturers = lecturersData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Lecturer { 
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Surname = parts[2],
                        Email = parts[3]
                    };
                }).ToList();
            }

            if (File.Exists(SubjectLecturersFileName))
            {
                var subjectLecturersData = File.ReadAllLines(SubjectLecturersFileName);
                _subjectLecturers = subjectLecturersData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new SubjectLecturer
                    {
                        SubjectId = int.Parse(parts[0]),
                        Subject = _subjects.FirstOrDefault(s => s.Id == int.Parse(parts[0])),
                        LecturerId = int.Parse(parts[1]),
                        Lecturer = _lecturers.FirstOrDefault(l => l.Id == int.Parse(parts[1]))
                    };
                }).ToList();
            }
        }

        //ZASEBNI LOAD 
        public void LoadAllSubjects() 
        {
            if (File.Exists(SubjectsFileName))
            {
                var subjectsData = File.ReadAllLines(SubjectsFileName);
                _subjects = subjectsData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Subject
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Carrier = parts[2],
                        Ects = int.Parse(parts[3])
                    };
                }).ToList();
            }
        }

        public void LoadAllLecturers() 
        {
            if (File.Exists(LecturersFileName))
            {
                var lecturersData = File.ReadAllLines(LecturersFileName);
                _lecturers = lecturersData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Lecturer
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Surname = parts[2],
                        Email = parts[3]
                    };
                }).ToList();
            }
        }

        public void LoadAllSubjectLecturers() 
        {
            if (File.Exists(SubjectLecturersFileName))
            {
                var subjectLecturersData = File.ReadAllLines(SubjectLecturersFileName);
                _subjectLecturers = subjectLecturersData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new SubjectLecturer
                    {
                        SubjectId = int.Parse(parts[0]),
                        Subject = _subjects.FirstOrDefault(s => s.Id == int.Parse(parts[0])),
                        LecturerId = int.Parse(parts[1]),
                        Lecturer = _lecturers.FirstOrDefault(l => l.Id == int.Parse(parts[1]))
                    };
                }).ToList();
            }
        }

        public void CheckIfFilesExist() 
        {
            if (!File.Exists(SubjectsFileName))
            {
                File.Create(SubjectsFileName).Close();
            }
            if (!File.Exists(LecturersFileName))
            {
                File.Create(LecturersFileName).Close();
            }
            if (!File.Exists(SubjectLecturersFileName))
            {
                File.Create(SubjectLecturersFileName).Close();
            }
            if (!File.Exists(SubjectLecturersFileName))
            {
                File.Create(SubjectLecturersFileName).Close();
            }
            //counters
            if (!File.Exists(SubjectsCounterFileName))
            {
                File.Create(SubjectsCounterFileName).Close();
                File.WriteAllText(SubjectsCounterFileName, "0");
            }
            if (!File.Exists(LecturersCounterFileName))
            {
                File.Create(LecturersCounterFileName).Close();
                File.WriteAllText(LecturersCounterFileName, "0");
            }

        }
    }
}

