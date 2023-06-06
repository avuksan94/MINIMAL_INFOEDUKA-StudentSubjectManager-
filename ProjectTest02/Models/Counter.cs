using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Models
{
    public class Counter
    {
        private int _counter = 0;
        private readonly string _counterFileName;

        public Counter(string counterFileName)
        {
            _counterFileName = counterFileName;
            LoadCounterFromFile();
        }

        public int GetNextId()
        {
            _counter++;
            SaveCounterToFile();
            return _counter;
        }

        private void LoadCounterFromFile()
        {
            if (File.Exists(_counterFileName))
            {
                var counterData = File.ReadAllText(_counterFileName);
                int.TryParse(counterData, out _counter);
            }
        }

        public void SaveCounterToFile()
        {
            File.WriteAllText(_counterFileName, _counter.ToString());
        }
    }
}
