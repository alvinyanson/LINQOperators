using StudentsData;

namespace Concat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data1 = Students.SeedData();
            var data2 = Students.SeedData4();


            // USING METHOD SYNTAX
            var allStudents = data1.Concat(data2);

            foreach (var student in allStudents)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}