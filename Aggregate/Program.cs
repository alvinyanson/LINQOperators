using StudentsData;

namespace Aggregate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var StudentNames = Students.SeedData3();

            var StudentNamesWithComma = StudentNames.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(StudentNamesWithComma);


            var data = Students.SeedData();


            //Aggregate Method with Seed Value

            string commaSeparatedStudentNames = data.Aggregate<Student, string>(
                            "Student Names: ",  // seed value
                            (str, s) => str += s.StudentName + ",");

            Console.WriteLine(commaSeparatedStudentNames);


            //Aggregate Method with Seed Value
            var sumofStudentsAge = data.Aggregate<Student, int>
                (0, (totalAge, s) => totalAge += s.Age);

            Console.WriteLine(sumofStudentsAge);




            //Aggregate Method with Result Selector
            var commaSeparatedStudentNames2 = Students.SeedData()
                .Aggregate<Student, string, string>(
                                            String.Empty, // seed value
                                            (str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
                                            str => str.Substring(0, str.Length - 1));

            Console.WriteLine(commaSeparatedStudentNames2);

        }
    }
}