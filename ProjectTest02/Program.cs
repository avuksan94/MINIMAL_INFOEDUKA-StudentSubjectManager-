using ProjectTest02.Models;
using ProjectTest02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            SubjectLecturerService _subjectLecturerService = new SubjectLecturerService();
            SubjectNotificationService _notificationSubjectService = new SubjectNotificationService();
            UserService _userService = new UserService();


            Lecturer lec1 = new Lecturer()
            {
                Name = "Testo",
                Surname = "Testic",
                Email = "Pero@gmail.com"
            };

            Lecturer lec2 = new Lecturer()
            {
                Name = "Darko",
                Surname = "Darkic",
                Email = "DarkoDarkic@gmail.com"
            };

            Subject sub1 = new Subject()
            {
                Name = "OOP",
                Carrier = "Testni1",
                Ects = 2
                
            };

            Subject sub2 = new Subject()
            {
                Name = "SISE",
                Carrier = "Testni2",
                Ects = 5
            };

            Subject sub3 = new Subject()
            {
                Name = "SIS2",
                Carrier = "Testni3",
                Ects = 4
            };

            Subject sub4 = new Subject()
            {
                Name = "OOP novi raspored",
                Carrier = "saddsad",
                Ects = 2
            };

            Subject sub5 = new Subject()
            {
                Name = "123",
                Carrier = "",
                Ects = 60
            };


            Notification notif1 = new Notification()
            {
                Id = 1,
                Title = "ICT Nword Day",
                Description = "Testing some shit",
                PostTime = DateTime.Now,
                ExperationTime = DateTime.Now.AddDays(14)
            };

            Notification notif2 = new Notification()
            {
                Id = 2,
                Title = "ICT Dword Day",
                Description = "Testing some shit also",
                PostTime = DateTime.Now,
                ExperationTime = DateTime.Now.AddDays(14)
            };

            User pperic = new User()
            {
                Email = "pperic@gmail.com",
                Username= "pperic",
                Password = "1234",
                Role = UserRole.Administrator,
                HasAccess= true
            };

            _userService.AddUser(pperic);

            Console.WriteLine(_userService.AuthenticateUser("pperic", "1234"));

            //Console.WriteLine(_userService.GetUser(pperic.Username).ToString());

            //_subjectLecturerService.UpdateSubject(4,sub4);
            //_subjectLecturerService.DeleteSubject(4);

           // Console.WriteLine(_subjectLecturerService.GetSubjectId("SISE"));

            //_subjectLecturerService.AddLecturer(lec2);
            //_subjectLecturerService.AssignLecturerToSubject(1, 1);
            //_subjectLecturerService.AssignLecturerToSubject(2, 1);
            //_subjectLecturerService.AddSubject(sub5);
            //_subjectLecturerService.AddSubject(sub2);
            //_subjectLecturerService.AddSubject(sub4);

            //_notificationSubjectService.AddNotification(notif2);
            //_notificationSubjectService.AssignNotificationToSubject(2,3);
            //_notificationSubjectService.DeleteNotification(1);

            //_notificationSubjectService.GetNotificationsForSubject(1).ForEach(Console.WriteLine);
            //_notificationSubjectService.GetAllNotifications().ToList().ForEach(Console.WriteLine);



        }

    }
}
