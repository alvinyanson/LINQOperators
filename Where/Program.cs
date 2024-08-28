namespace LINQOperators
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


            // QUERY SYNTAX
            var result = from s in Students

                             // <--- LAMBDA EXPRESSION PASSED AS PREDICATE FUNCTION
                             // Func<TSource, bool>
                         where s.Age > 12 && s.Age < 20

                         select s;




            // METHOD SYNTAX
            var result2 = Students
                .Where(s => s.Age > 12 && s.Age < 20)
                .Select(s => s);

            foreach (var s in result)
            {
                Console.WriteLine($"USING QUERY SYNTAX: \n{s.StudentName}");
            }

            foreach (var s in result2)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"USING METHOD SYNTAX: \n{s.StudentName}");
            }





            // FILTER OUT USING THE 2ND METHOD OVERLOAD OF METHOD SYNTAX WITH INDEX
            var result3 = Students
                .Where((s, i) =>
                {
                    if (i % 2 == 0)
                        return true;

                    return false;
                });


            Console.WriteLine($"\nUSING METHOD SYNTAX WITH INDEX:");
            foreach (var s in result3)
            {
                Console.WriteLine($"{s.StudentName}");
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


//POINTS TO REMEMBER

//Where is used for filtering the collection based on given criteria.

//Where extension method has two overload methods. Use a second overload method to know the index of current element in the collection.

//Method Syntax requires the whole lambda expression in Where extension method whereas Query syntax requires only expression body.

//Multiple Where extension methods are valid in a single LINQ query.
