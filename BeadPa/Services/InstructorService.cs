using System;
namespace BeadPa{
    
    class InstructorService : ObjService
    {
        List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public void Add()
        {
            string name = Util.Read("Instructor name: ");
            Instructor instructor = new Instructor(name);
            Instructors.Add(instructor);
        }

        public void ListAll()
        {
            Util.Clear();
            Console.WriteLine("List of instructors:");
            foreach (var instructor in Instructors)
            {
                instructor.Self();
            }
            Util.Wait("Press any key to continue...", ConsoleColor.Green);
        }

        public void Remove()
        {
            Util.Clear();
            Util.Print("All instructors:");
            ListAll();
            string name = Util.Read("Instructor name: ");
            Instructors.RemoveAll(i => i.Name == name);
        }

        public void Update()
        {
            Util.Clear();
            Util.Print("All instructors:");
            ListAll();
            string name = Util.Read("Instructor name: ");
            Instructor instructor = Instructors.Find(i => i.Name == name);
            if (instructor != null)
            {
                string newName = Util.Read("New instructor name: ");
                instructor.Name = newName;
            }
        }
    }

}

