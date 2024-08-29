namespace SkipAndSkipWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // USING METHOD SYNTAX - SKIP

            Console.WriteLine("USING METHOD SYNTAX - SKIP");
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var newList = strList.Skip(2);

            foreach (var str in newList)
                Console.WriteLine(str);



            // USING METHOD SYNTAX - SKIPWHILE

            Console.WriteLine("\nUSING METHOD SYNTAX - SKIPWHILE");
            IList<string> strList2 = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

            var resultList = strList2.SkipWhile(s => s.Length < 4);

            foreach (string str in resultList)
                Console.WriteLine(str);



            // USING METHOD SYNTAX - SKIPWHILE WITH INDEX
            Console.WriteLine("\nUSING METHOD SYNTAX - SKIPWHILE WITH INDEX");

            IList<string> strList3 = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

            var result = strList3.SkipWhile((s, i) => s.Length > i);

            foreach (string str in result)
                Console.WriteLine(str);
        }
    }
}