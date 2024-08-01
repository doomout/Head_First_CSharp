namespace _13_MenuItem
{
    public class MenuItem
    {
        public static Random Randmizer = new Random();
        public string[] Proteins = { "구운 소고기", "살라미", "칠면조", "햄", "파스트라미", "두부" };
        public string[] Condiments = { "노란 머스타드", "갈색 머스타드", "허니 머스타드", "마요네즈", "케챱", "프렌치 드레싱" };
        public string[] Breads = { "호밀", "쌀", "밀", "호밀 가루", "롤" };

        public string Description = "";
        public string Price = "";

        public void Generate()
        {
            string randomProtein = Proteins[Randmizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randmizer.Next(Condiments.Length)];
            string randomBread = Breads[Randmizer.Next(Breads.Length)];
            Description = randomProtein + " + " + randomCondiment + " + " + randomBread;

            decimal bucks = Randmizer.Next(2, 5);
            decimal cents = Randmizer.Next(1, 98);
            decimal price = bucks + (cents * 0.01M);
            Price = price.ToString("C2", new System.Globalization.CultureInfo("en-US"));
        }
    }
}
