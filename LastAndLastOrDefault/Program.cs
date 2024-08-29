using StudentsData;

namespace LastAndLastOrDefault
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            // USING METHOD SYNTAX - LAST

            Console.WriteLine("USING METHOD SYNTAX - LAST");
            
            var lastOrDefault = data.Last();
         
            Console.WriteLine(lastOrDefault.StudentName);


            var lastOrDefault2 = data.Last(x => x.StudentName.Contains("R"));

            Console.WriteLine(lastOrDefault2.StudentName);





            // USING METHOD SYNTAX - LASTORDEFAULT
            Console.WriteLine("\nUSING METHOD SYNTAX - LASTORDEFAULT");

            var lastOrDefault3= data.LastOrDefault();

            Console.WriteLine(lastOrDefault.StudentName);


            var lastOrDefault4 = data.LastOrDefault(x => x.StudentName.Contains("R"));

            Console.WriteLine(lastOrDefault2.StudentName);
        }
    }
}