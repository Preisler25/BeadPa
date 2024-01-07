using System;
namespace BeadPa
{
	public class StudentService : ObjService
	{
        List<Student> students = new List<Student>();

        public void Add()
        {
            string name = Util.Read("Name: ");
            DateTime birthDate = Util.ReadDate("Birth date: ");
            Student student = new Student(name, birthDate);
            students.Add(student);
        }

        public void Remove()
        {
            string name = Util.Read("Name: ");
            students.RemoveAll(s => s.Name == name);
        }

        public void Update()
        {
            string name = Util.Read("Name: ");
            Student student = students.Find(s => s.Name == name);
            if (student != null)
            {
                string newName = Util.Read("New name: ");
                DateTime newBirthDate = Util.ReadDate("New birth date: ");
                student.Name = newName;
                student.BirthDate = newBirthDate;
            }
        }

        public List<Student> ListAll()
        {
            foreach (var student in students)
            {
                student.Hello();
            }
        }
    }
}
