using System;

 public class Job
    {
        public string _companyName = "";
        public string _jobTitle = "";
        public int _startYear;
        public int _endYear;

        public void DispalyJob()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}.");
        }
    }
