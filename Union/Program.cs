using StudentsData;

namespace Union
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USING METHOD SYNTAX - PRIMITIVE DATA TYPES

            Console.WriteLine("USING METHOD SYNTAX - PRIMITIVE DATA TYPES");
            IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
            IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

            var result = strList1.Union(strList2);

            foreach (string str in result)
                Console.WriteLine(str);


            // USING METHOD SYNTAX - COMPLEX DATA TYPES

            Console.WriteLine("\nUSING METHOD SYNTAX - COMPLEX DATA TYPES");

            var data1 = Students.SeedData();
            var data2 = Students.SeedData4();

            var union = data1.Union(data2, new StudentComparer());

            foreach (var item in union)
                Console.WriteLine(item.StudentName);
        }
    }
}
