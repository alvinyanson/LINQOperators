using StudentsData;
using System.Net.NetworkInformation;

namespace Max
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USING METHOD SYNTAX
            Console.WriteLine("USING METHOD SYNTAX");
            var data = Students.SeedData();

            var max = data.Max(x => x.Age);
            Console.WriteLine(max);



            //USING METHOD SYNTAX WITH ICOMPARABLE

            Console.WriteLine("\nUSING METHOD SYNTAX WITH ICOMPARABLE");

            var longestName = data.Max();

            Console.WriteLine(longestName.StudentName);
        }
    }
}