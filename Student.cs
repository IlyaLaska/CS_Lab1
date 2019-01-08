using System;
using System.Collections.Generic;

namespace App1
{
    public class Student : Person
    {
        private Education QualificationLevel;
        private string GroupName;
        public List<Examination> TakenExams { get; set; }
        private int _recordBookNumber;

        private int RecordBookNumber
        {
            set
            {
                const int min = 99999;
                const int max = 99999999;
                if (value <= min || value > max)
                    throw new Exception($"Record-Book number is out of range: [{min}, {max})");
                _recordBookNumber = value;
            }
            get => _recordBookNumber;
        }

        private double AverageGrade
        {
            get
            {
                var grades = 0;
                foreach (var exam in TakenExams)
                {
                    grades += exam.Grade;
                }

                return (double) grades / TakenExams.Count;
            }
        }

        public Student()
        {
            QualificationLevel = Education.Bachelor;
            GroupName = "AA01";
            RecordBookNumber = 100000;
            TakenExams = new List<Examination>();
        }

        public Student(string name, string surname, DateTime birthdate, Education qualificationLevel, string groupName,
            int recordBookNumber) : base(name, surname, birthdate)
        {
            QualificationLevel = qualificationLevel;
            GroupName = groupName;
            RecordBookNumber = recordBookNumber;
            TakenExams = new List<Examination>();
        }

        public Student(Education qualificationLevel, string groupName, int recordBookNumber)
        {
            QualificationLevel = qualificationLevel;
            GroupName = groupName;
            RecordBookNumber = recordBookNumber;
            TakenExams = new List<Examination>();
        }

        public void AddExams(IEnumerable<Examination> examList)
        {
            TakenExams.AddRange(examList);
        }

        public override string ToString()
        {
            return $"Student: {Name} {Surname}; Group: {GroupName}";
        }

        public override void PrintFullInfo()
        {
            base.PrintFullInfo();
            var exams = TakenExams.Count == 0 ? "none" : string.Join("\n", TakenExams);
            Console.WriteLine($"He is studying for a {QualificationLevel} degree in group {GroupName}. " +
                              $"His Record-Book number is {RecordBookNumber}. His exams:\n{exams}");
        }

        // ReSharper disable once InconsistentNaming
        public string GetExamGradeLT(int value)
        {
            var result = "";
            foreach (var exam in TakenExams)
            {
                if (exam.Grade < value) result += exam + "\n";
            }

            return result;
        }
    }
}