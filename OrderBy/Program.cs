namespace OrderType
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IList<Student> Students = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 18 },
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentId = 4, StudentName = "Ram", Age = 20 },
                new Student() { StudentId = 5, StudentName = "Ron", Age = 31 }
            };


            // USING QUERY SYNTAX
            var result = from s in Students
                         orderby s.Age // descending <-- optional, default is ascending
                         //orderby s.Age, s.StudentName <-- multiple sort
                         select s;

            foreach (var s in result)
            {
                Console.WriteLine("USING QUERY SYNTAX");
                Console.WriteLine($"{s.StudentName} : {s.Age}");
            }



            // USING METHOD SYNTAX
            var result2 = Students.OrderBy(s => s.Age);
            
            // ORDER BY DESCENDING
            //var result2 = Students.OrderByDescending(s => s.Age);

            foreach (var s in result2)
            {
                Console.WriteLine("\nUSING METHOD SYNTAX");
                Console.WriteLine($"{s.StudentName} : {s.Age}");
            }
        }


    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}


//Points to Remember :

//LINQ includes five sorting operators: OrderBy, OrderByDescending, ThenBy, ThenByDescending and Reverse

//LINQ query syntax does not support OrderByDescending, ThenBy, ThenByDescending and Reverse. It only supports 'Order By' clause with 'ascending' and 'descending' sorting direction.

//LINQ query syntax supports multiple sorting fields seperated by comma whereas you have to use ThenBy & ThenByDescending methods for secondary sorting.
