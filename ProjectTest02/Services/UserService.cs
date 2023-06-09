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
    public class UserService
    {
        private const char DELIMITER = '|';
        private List<User> _users;

        private const string USERS_FILENAME = "Users.txt";

        string UsersFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), USERS_FILENAME);

        public UserService() 
        {
            CheckIfFilesExist();
            _users = new List<User>();
        }

        public User CreateAdmin() 
        {
            User admin = new User
            {
                Username = "admin",
                Password = "Pa$$W0rd",
                Email = "admin@testing.com",
                Role = UserRole.Administrator,
                HasAccess = true
            };

            return admin;
        }

        public void CreateLecturerUserPassword(Lecturer lecturer) 
        {
            LoadAllUsers();
            StringBuilder sb = new StringBuilder();
            sb.Append(lecturer.Name[0]);
            sb.Append(lecturer.Surname);

            string username = sb.ToString().ToLower();

            AddUser(new User() 
            {
                Role = UserRole.Lecturer,
                Email = lecturer.Email,
                Username = username,
                Password = "1234",
                HasAccess = true
            });

            SaveUsersData();
        }

        public bool AuthenticateUser(string username, string password)
        {
            LoadAllUsers();
            User user = GetUser(username);

            if (user != null && user.Username == username && user.Password == password)
            {
                return true;
            }

            return false;
        }

        public UserRole GetUserRole(string username) 
        {
            LoadAllUsers();
            User user = GetUser(username);

            return user.Role;
        }

        //public void DisableAccount(Lecturer lecturer) 
        //{
        //    LoadAllUsers();
        //
        // 
        //
        //    SaveUsersData();
        //}

        public string GetMailForUser(string username)
        {
            LoadAllUsers();
            User user = GetUser(username);
            return user.Email;
        }

        //CRUD
        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                if (_users != null)
                {
                    LoadAllUsers();
                    return _users;
                }
                //samo da se ne razleti vrati nesta
                return new List<User>();

            }
            catch (Exception)
            {
                throw new Exception("Error occured loading all Users");
            }
        }

        public User GetUser(string username)
        {
            LoadAllUsers();
            return _users.FirstOrDefault(s => s.Username == username);
        }

        public void AddUser(User user)
        {
            LoadAllUsers();

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(user, serviceProvider: null, items: null);
            Validator.TryValidateObject(user, validationContext, validationResults, true);
            if (validationResults.Any())
            {
                foreach (var error in validationResults)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                _users.Add(user);
                SaveUsersData();
            }
        }

        public void UpdateUser(User user)
        {
            LoadAllUsers();
            var existingUser = GetUser(user.Username);
            if (existingUser != null)
            {
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.Role= user.Role;
                existingUser.Email = user.Email;
                existingUser.HasAccess = user.HasAccess;
            }
            SaveUsersData();
        }

        public void DeleteUser(string username)
        {
            LoadAllUsers();
            var user = GetUser(username);
            if (user != null)
            {
                _users.Remove(user);
            }
            SaveUsersData();
        }


        //SAVE and LOAD
        public void SaveUsersData() => File.WriteAllLines(UsersFileName, _users.Select(s => $"{s.Role}{DELIMITER}{s.Email}{DELIMITER}{s.Username}{DELIMITER}{s.Password}{DELIMITER}{s.HasAccess}"));

        public void LoadAllUsers()
        {
            if (File.Exists(UsersFileName))
            {
                var usersData = File.ReadAllLines(UsersFileName);
                _users = usersData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new User
                    {
                        Role = (UserRole)Enum.Parse(typeof(UserRole), parts[0]),
                        Email = parts[1],
                        Username = parts[2],
                        Password = parts[3],
                        HasAccess = bool.Parse(parts[4])
                    };
                }).ToList();
            }
        }

        public void CheckIfFilesExist()
        {
            if (!File.Exists(UsersFileName))
            {
                File.Create(UsersFileName).Close();
                File.WriteAllText(UsersFileName, "Administrator|admin@gmail.com|admin|admin|True");
            }
        }
    }
}
