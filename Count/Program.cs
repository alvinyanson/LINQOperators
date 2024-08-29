using StudentsData;

namespace Count
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var data = Students.SeedData();

            // USING METHOD SYNTAX

            Console.WriteLine("USING METHOD SYNTAX");
            var count = data.Count(x => x.Age > 20);

            Console.WriteLine(count);


            // USING QUERY SYNTAX

            Console.WriteLine("\nUSING QUERY SYNTAX");

            var count2 = (from s in data where s.Age > 20 select s).Count();

            Console.WriteLine(count2);
        }
    }
}