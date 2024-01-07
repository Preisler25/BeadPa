using System;
namespace BeadPa
{
    public class CourseService : ObjService
    {
        List<Course> Courses { get; set; } = new List<Course>();

        public void Add()
        {
            string name = Util.Read("Course name: ");
            Course course = new Course(name);
            Courses.Add(course);
        }

        public void Remove()
        {
            Util.Clear();
            Util.Print("All courses:");
            ListAll();
            string name = Util.Read("Course name: ");
            Courses.RemoveAll(c => c.Name == name);
        }

        public void Update()
        {
            Util.Clear();
            Util.Print("All courses:");
            ListAll();
            string name = Util.Read("Course name: ");
            Course course = Courses.Find(c => c.Name == name);
            if (course != null)
            {
                string newName = Util.Read("New course name: ");
                course.Name = newName;
            }
        }

        public void ListAll()
        {
            Util.Clear();
            Console.WriteLine("List of courses:");
            foreach (var course in Courses)
            {
                course.Self();
            }
            Util.Wait("Press any key to continue...", ConsoleColor.Green);
        }
    }