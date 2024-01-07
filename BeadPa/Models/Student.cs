using System;
namespace BeadPa
{
	public class Student : Obj
	{
        public DateTime BirthDate { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public Student(string name, DateTime birthDate) : base(name)
        {
            BirthDate = birthDate;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double GetAverageGrade()
        {
            return Grades.Count > 0 ? Grades.Average() : 0;
        }
    }
}

