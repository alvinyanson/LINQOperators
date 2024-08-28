using StudentsData;

namespace ThenBy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            var result = data.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            //var result = data.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            // USING METHOD SYNTAX
            foreach (var student in result)
            {
                Console.WriteLine($"{student.StudentName} {student.Age}");
            }
        }
    }
}


//Points to Remember :

//OrderBy and ThenBy sorts collections in ascending order by default.

//ThenBy or ThenByDescending is used for second level sorting in method syntax.

//ThenByDescending method sorts the collection in decending order on another field.

//ThenBy or ThenByDescending is NOT applicable in Query syntax.

//Apply secondary sorting in query syntax by separating fields using comma.
