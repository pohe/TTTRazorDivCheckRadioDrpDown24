namespace TTTRazorDivCheckRadioDrpDown24.Models
{
    public class Teacher
    {
        private static int nextId = 0;
        public int Id { get; set; }
        public String Name { get; set; }
        public bool IsMale { get; set; }
        public List<String> Courses { get; }

        public string GetCoursesText
        {
            get { return "[ " + String.Join(",", Courses) + " ]"; }
        }
        public String WorkingLocation { get; set; }

        public Teacher() : this("Peter", true, "Roskilde")
        {
        }

        public Teacher(string name, bool isMale, string workingLocation)
        {
            Name = name;
            IsMale = isMale;
            WorkingLocation = workingLocation;

            Courses = new List<string>();
            Id = ++nextId;
        }
    }
}
