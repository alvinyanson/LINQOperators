using StudentsData;

namespace Average
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            var average = data.Average(x => x.Age);

            Console.WriteLine(average);
        }
    }

}
