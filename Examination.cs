using System;

namespace App1
{
    public class Examination : IMarkName
    {
        private int Semester;
        private string Subject;
        private string Teacher;
        public int Grade { get; set; }
        private bool IsDifferentiated;
        private DateTime ExamDate;

        public Examination()
        {
            Semester = 1;
            Subject = "OOP";
            Teacher = "Doe J.J.";
            Grade = 60;
            IsDifferentiated = true;
            ExamDate = DateTime.UnixEpoch;
        }

        public Examination(int semester, string subject, string teacher, int grade, bool isDifferentiated,
            DateTime examDate)
        {
            Semester = semester;
            Subject = subject;
            Teacher = teacher;
            Grade = grade;
            IsDifferentiated = isDifferentiated;
            ExamDate = examDate;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}; Teacher: {Teacher}; Grade: {Grade}";
        }

        public string NationalScaleName()
        {
            return Grade.ToString();
        }

        public string EctsScaleName()
        {
            string ectsGrade;
            switch (Grade)
            {
                case int n when n < 60:
                    ectsGrade = "F";
                    break;
                case int n when n >= 60 && n < 65:
                    ectsGrade = "E";
                    break;
                case int n when n >= 65 && n < 75:
                    ectsGrade = "D";
                    break;
                case int n when n >= 75 && n < 85:
                    ectsGrade = "C";
                    break;
                case int n when n >= 85 && n < 95:
                    ectsGrade = "B";
                    break;
                case int n when n >= 95 && n <= 100:
                    ectsGrade = "A";
                    break;
                default:
                    throw new Exception("Grade out of reasonable range");
            }

            return ectsGrade;
        }
    }
}