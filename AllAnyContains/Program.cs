using StudentsData;

namespace AllAny
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();


            // USING METHOD SYNTAX - ALL
            Console.WriteLine("USING METHOD SYNTAX - ALL");
            
            var result = data.All(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(result);


            // USING METHOD SYNTAX - ANY
            Console.WriteLine("\nUSING METHOD SYNTAX - ANY");
            
            var result2 = data.Any(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(result2);
        }
    }
}