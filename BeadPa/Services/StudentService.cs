using System;
namespace BeadPa
{
	public class StudentService : ObjService
	{
        List<Student> students = new List<Student>();

        public void Add()
        {
            string name = Util.Read("Name: ");
            DateTime birthDate = Util.ReadDate("Birth date (yyyy.mm.dd): ");
            Student student = new Student(name, birthDate);
            students.Add(student);
        }

        public void Remove()
        {
            Util.Clear();
            Util.Print("All student:");
            listAll();
            string name = Util.Read("Name: ");
            students.RemoveAll(s => s.Name == name);
        }

        public void Update()
        {
            Util.Clear();
            Util.Print("All student:");
            listAll();
            string name = Util.Read("Name: ");
            Student student = students.Find(s => s.Name == name);
            if (student != null)
            {
                string newName = Util.Read("New name: ");
                DateTime newBirthDate = Util.ReadDate("New birth date (yyyy.mm.dd): ");
                student.Name = newName;
                student.BirthDate = newBirthDate;
            }
        }

        public void ListAll()
        {
            Util.Clear();
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                student.Self();
            }
            Util.Wait("Press any key to continue...", ConsoleColor.Green);
        }
    }
}

