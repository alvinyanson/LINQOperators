using StudentsData;

namespace Select
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();


            // USING QUERY SYNTAX
            Console.WriteLine("USING QUERY SYNTAX");
            var result = from s in data
                         select new { s.StudentId, s.StudentName };


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            // USING METHOD SYNTAX
            Console.WriteLine("\nUSING METHOD SYNTAX");

            var result2 = data.Select(s => new { s.StudentId, s.StudentName });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
