using StudentsData;

namespace FirstAndFirstOrDefault
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            // USING METHOD SYNTAX - FIRST
            var first = data.First();

            Console.WriteLine(first.StudentName);

            var first2 = data.First(x => x.StudentName == "Ram");

            Console.WriteLine(first2.StudentName);



            // USING METHOD SYNTAX - FIRSTORDEFAULT

            var first3 = data.FirstOrDefault();

            Console.WriteLine(first3.StudentName);

            var first4 = data.FirstOrDefault(x => x.StudentName == "Ram");

            Console.WriteLine(first4.StudentName);
        }
    }
}