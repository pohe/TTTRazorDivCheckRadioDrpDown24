namespace TTTRazorDivCheckRadioDrpDown24.MockData
{
    public class LocationService
    {
        private static List<string> locations = new List<string>()
        {
            "Køge", "Roskilde", "Slagelse", "Næstved", "Nykøbing F", "Holbæk"
        };

        public static List<string> Locations => locations;
    }
}
