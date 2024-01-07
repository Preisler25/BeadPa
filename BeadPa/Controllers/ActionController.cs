using System;

namespace BeadPa
{
	public class ActionController
	{
		bool isActiv = true;
        StudentService sS = new StudentService(); 
        CourseService cS = new CourseService();
        InstructorService iS = new InstructorService();

        public ActionController(){}

       
        private void WType()
        {
            Util.Clear();
            Util.Print("Mit szeretnél csinálni?\n\t1 = Student\n\t2 = Course\n\t3 = Instructor\n\t4 = Exit");
            string type = Util.Read();
            switch (type)
            {
                case "1":
                    WAction(sS);
                    break;
                case "2":
                    WAction(cS);
                    break;
                case "3":
                    WAction(iS);
                    break;
                case "4":
                    isActiv = false;
                    break;
                default:
                    Util.Print("Nincs ilyen lehetőség!");
                    break;

            }

        }

        private void WAction (ObjService service){
            Util.Clear();
            Util.Print("Mit szeretnél csinálni?\n\t1 = Add\n\t2 = Remove\n\t3 = Update\n\t4 = ListAll \n\t5 = Exit\n\t6 = Back");
            string action = Util.Read();
            switch (action)
            {
                case "1":
                    service.Add();
                    break;
                case "2":
                    service.Remove();
                    break;
                case "3":
                    service.Update();
                    break;
                case "4":
                    service.ListAll();
                    break;
                case "5":
                    isActiv = false;
                    break;
                case "6":
                    break;
                default:
                    Util.Print("Nincs ilyen lehetőség!");
                    break;
            }
        }

        public void Start()
        {
            while (isActiv)
            {
                WType();
            }
        }
	}
}

