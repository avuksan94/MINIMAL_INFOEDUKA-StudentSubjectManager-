using ProjectTest02.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Services
{
    public class ConnectionWatchDog
    {
        private const char DELIMITER = '|';
        private IList<Connection> _connections;

        private const string CONNECTION_FILENAME = "ConnectedUser.txt";
        private static string ConnectionFileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), CONNECTION_FILENAME);

        public ConnectionWatchDog()
        {
            CheckIfFilesExist();
            _connections= new List<Connection>();
        }

        private void CheckIfFilesExist()
        {
            if (!File.Exists(ConnectionFileName))
            {
                File.Create(ConnectionFileName).Close();
            }
        }

        public void CreateConnection(string username)
        {
            _connections.Clear();
            Connection newConnection = new Connection()
            {
                ConnectedUser = username
            };
            
            _connections.Add(newConnection);

            SaveDataToFile();
        }

        public string GetUsername()
        {
            LoadConnections();

            return _connections.FirstOrDefault()?.ConnectedUser;
        }

        public void SaveDataToFile()
        {
            File.WriteAllLines(ConnectionFileName, _connections.Select(c => $"{c.ConnectedUser}"));
        }

        public void LoadConnections()
        {
            if (File.Exists(ConnectionFileName))
            {
                //Mora biti IEnumerable da se moze linq koristiti
                var ConnectionData = File.ReadAllLines(ConnectionFileName);
                _connections = ConnectionData.Select(line =>
                {
                    var parts = line.Split(DELIMITER);
                    return new Connection
                    {
                       ConnectedUser= parts[0]
                    };
                }).ToList();
            }
        }

        public void ClearFileContent()
        {
            File.WriteAllText(ConnectionFileName, string.Empty);
        }
    }
}
