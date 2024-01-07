using System;
namespace BeadPa
{
    public class Instructor : Obj
    {
        public List<Course> Courses { get; set; } = new List<Course>();

        public Instructor(string name) : base(name) { }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void ListCourses()
        {
            Console.WriteLine($"List of Courses taught by {Name}:");
            foreach (var course in Courses)
            {
                Console.WriteLine($"Name: {course.Name}, Description: {course.Description}");
            }
        }
    }

}

