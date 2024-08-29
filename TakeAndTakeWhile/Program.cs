namespace TakeAndTakeWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USING METHOD SYNTAX - TAKE

            Console.WriteLine("USING METHOD SYNTAX - TAKE");

            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var newList = strList.Take(2);

            foreach (var str in newList)
                Console.WriteLine(str);


            // USING METHOD SYNTAX - TAKEWHILE

            Console.WriteLine("\nUSING METHOD SYNTAX - TAKEWHILE");

            IList<string> strList2 = new List<string>() {
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Hundred"  };

            var result = strList2.TakeWhile(s => s.Length > 4);

            foreach (string str in result)
                Console.WriteLine(str);


            // USING METHOD SYNTAX - TAKEWHILE WITH INDEX

            Console.WriteLine("\nUSING METHOD SYNTAX - TAKEWHILE WITH INDEX");

            IList<string> strList3 = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six"  };

            var resultList = strList3.TakeWhile((s, i) => s.Length > i);

            foreach (string str in resultList)
                Console.WriteLine(str);

        }
    }
}