using System;
namespace BeadPa
{
    public class Course : Obj
    {
        public string Description { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Course(string name, string description) : base(name)
        {
            Description = description;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"List of Students in {Name} course:");
            foreach (var student in Students)
            {
                Console.WriteLine($"Name: {student.Name}, BirthDate: {student.BirthDate.ToShortDateString()}, Average Grade: {student.GetAverageGrade()}");
            }
        }
    }
}

