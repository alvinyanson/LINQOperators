using StudentsData;

namespace Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            var sum = data.Sum(x =>
            {
                if (x.Age >= 18)
                    return 1;

                return 0;
            });

            Console.WriteLine(sum);


            var sum2 = data.Sum(x => x.Age);

            Console.WriteLine(sum2);
        }
    }
}