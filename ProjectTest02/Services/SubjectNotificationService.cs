using ProjectTest02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Services
{
    public class SubjectNotificationService
    {
        private const char DELIMITER = '|';

        private List<Subject> _subjects;
        private List<Notification> _notifications;
        private List<SubjectNotification> _subjectNotifications;

        private const string NOTIFICATION_COUNTER = "NotificationCounter.txt";
        private const string SUBJECTS_FILE_NAME = "Subjects.txt";
        private const string NOTIFICATIONS_FILE_NAME = "Notifications.txt";
        private const string SUBJECT_NOTIFICATIONS_FILE_NAME = "SubjectsNotifications.txt";


        private static string NotificationsCounterFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), NOTIFICATION_COUNTER);
        string SubjectsFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SUBJECTS_FILE_NAME);
        string NotificationsFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), NOTIFICATIONS_FILE_NAME);
        string SubjectNotificationsFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), SUBJECT_NOTIFICATIONS_FILE_NAME);

        private Counter _counterNotifications;

        public SubjectNotificationService()
        {
            _subjects = new List<Subject> ();
            _notifications = new List<Notification>();
            _subjectNotifications = new List<SubjectNotification>();
            _counterNotifications = new Counter(NotificationsCounterFileName);
        }

        //CRUD NOTIFICATIONS

        public IEnumerable<Notification> GetAllNotifications()
        {
            try
            {
                if (_notifications != null)
                {
                    LoadAllNotifications();
                    return _notifications;
                }
                //samo da se ne razleti vrati nesta
                return new List<Notification>();

            }
            catch (Exception)
            {
                throw new Exception("Error occured loading all notifications");
            }
        }

        public int GetNotificationId(string Title)
        {
            LoadAllNotifications();
            int notificationId = _notifications.Where(n => n.Title == Title)
                         .Select(n => n.Id)
                         .FirstOrDefault();
            return notificationId;
        }

        public Notification GetNotification(int id)
        {
            LoadAllNotifications();
            return _notifications.FirstOrDefault(n => n.Id == id);
        }

        public void AddNotification(Notification notification)
        {
            LoadAllNotifications();
        
            notification.Id = _counterNotifications.GetNextId();
            _notifications.Add(notification);
        
            SaveNotificationsData();
        }

        public void UpdateNotification(int id, Notification notification)
        {
            LoadAllNotifications();
            var existingNotificationt = GetNotification(id);
            if (existingNotificationt != null)
            {
                existingNotificationt.Title = notification.Title;
                existingNotificationt.Description = notification.Description;
            }
            SaveNotificationsData();

        }

        public void DeleteNotification(int id)
        {
            LoadAllNotifications();
            LoadAllSubjectNotifications();
            var notification = GetNotification(id);
            if (notification != null)
            {
                _notifications.Remove(notification);
                _subjectNotifications.RemoveAll(sn => sn.NotificationId == id);
            }
            SaveNotificationsData();
            SaveSubjectsNotificationsData();
        }

        //CRUD ZA SUBJECT NOTIFICATION
        public void AssignNotificationToSubject(int subjectId, int notificationId)
        {
            LoadDataFromFile();

            if (_subjectNotifications.Any(sn => sn.NotificationId == notificationId && sn.SubjectId == subjectId))
            {
                return;
            }
            var subjectNotification = new SubjectNotification
            {
                SubjectId = subjectId,
                NotificationId = notificationId
            };
            _subjectNotifications.Add(subjectNotification);

            SaveDataToFile();
        }

        public List<Notification> GetNotificationsForSubject(int subjectId)
        {

            LoadDataFromFile();

            return _subjectNotifications.Where(sn => sn.SubjectId == subjectId)
                                    .Select(sn => sn.Notification)
                                    .ToList();
        }

        public string GetSubjectNameForNotification(int notificationId)
        {
            LoadDataFromFile();

            var subjectNotification = _subjectNotifications.FirstOrDefault(sn => sn.NotificationId == notificationId);
            if (subjectNotification == null)
            {
                return null;
            }

            var subject = _subjects.FirstOrDefault(s => s.Id == subjectNotification.SubjectId);
            if (subject == null)
            {
                return null;
            }

            return subject.Name;
        }


        //SAVE I LOAD
        public void SaveDataToFile()
        {
            File.WriteAllLines(NotificationsFileName, _notifications.Select(n => $"{n.Id}{DELIMITER}{n.Title}{DELIMITER}{n.Description}{DELIMITER}{n.PostTime}{DELIMITER}{n.ExperationTime}"));
            File.WriteAllLines(SubjectNotificationsFileName, _subjectNotifications.Select(sn => $"{sn.SubjectId}{DELIMITER}{sn.NotificationId}"));
            _counterNotifications.SaveCounterToFile();
        }

        public void SaveNotificationsData() 
        {
            File.WriteAllLines(NotificationsFileName, _notifications.Select(n => $"{n.Id}{DELIMITER}{n.Title}{DELIMITER}{n.Description}{DELIMITER}{n.PostTime}{DELIMITER}{n.ExperationTime}"));
            _counterNotifications.SaveCounterToFile();
        }

        public void SaveSubjectsNotificationsData() 
        {
            File.WriteAllLines(SubjectNotificationsFileName, _subjectNotifications.Select(sn => $"{sn.SubjectId}{DELIMITER}{sn.NotificationId}"));
        }

        public void LoadDataFromFile() 
        {
            LoadAllNotifications();
            LoadAllSubjects();
            LoadAllSubjectNotifications();
        }

        public void LoadAllNotifications()
        {
            if (File.Exists(NotificationsFileName))
            {
                var notificationsData = File.ReadAllLines(NotificationsFileName);
                _notifications = notificationsData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Notification
                    {
                        Id = int.Parse(parts[0]),
                        Title = parts[1],
                        Description = parts[2],
                        PostTime = DateTime.Parse(parts[3]),
                        ExperationTime= DateTime.Parse(parts[4])
                    };
                }).ToList();
            }
        }

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


        public void LoadAllSubjectNotifications()
        {
            if (File.Exists(SubjectNotificationsFileName))
            {
                var subjectNotificationData = File.ReadAllLines(SubjectNotificationsFileName);
                _subjectNotifications = subjectNotificationData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new SubjectNotification
                    {
                        SubjectId = int.Parse(parts[0]),
                        Subject = _subjects.FirstOrDefault(s => s.Id == int.Parse(parts[0])),
                        NotificationId = int.Parse(parts[1]),
                        Notification = _notifications.FirstOrDefault(l => l.Id == int.Parse(parts[1]))
                    };
                }).ToList();
            }
        }

        public void CheckIfFilesExist()
        {
            if (!File.Exists(NotificationsFileName))
            {
                File.Create(NotificationsFileName).Close();
            }
            if (!File.Exists(SubjectNotificationsFileName))
            {
                File.Create(SubjectNotificationsFileName).Close();
            }
            //counters
            if (!File.Exists(NotificationsCounterFileName))
            {
                File.Create(NotificationsCounterFileName).Close();
                File.WriteAllText(NotificationsCounterFileName, "0");
            }
            

        }
    }

}
