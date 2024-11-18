namespace TTTRazorDivCheckRadioDrpDown24.MockData
{
    public class CourseServices
    {
        public static class CourseService
        {
            private static List<string> courses = new List<string>()
        {
            "SWC1", "SWC2", "SWD1", "SWD2", "TEK", "SYM", "PROG", "VF"
        };

            public static List<string> Courses => courses;
        }
    }
}
