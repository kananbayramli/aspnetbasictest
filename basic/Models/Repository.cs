namespace basic.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses=new();

        static  Repository()
        {
            _courses = new List<Course>(){
        new Course{Id=1, Title="Django kursu", Description="Gozel bir kurs", Image="flutter(1).png", Tags=new string[]{"aspnet", ".Net7", "Fjango"}, isActive=true, isHome=true},
        new Course{Id=2, Title="Python kursu", Description="Boyuk bir kurs", Image="flutter(1).png",Tags=new string[]{"aspnet", ".Net7", "Fjango"}, isActive=true, isHome=true},
        new Course{Id=3, Title="JQuery kursu", Description="Asan bir kurs", Image="flutter(1).png", isActive=true, isHome=false},
        new Course{Id=4, Title="C# kursu", Description="Cetin bir kurs", Image="flutter(1).png",Tags=new string[]{"aspnet", ".Net7", "Fjango"}, isActive=true, isHome=true}
            };
        }

        public static Course? GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }



        public static List<Course> Courses{
            get{ return _courses;}
        }
    }
}