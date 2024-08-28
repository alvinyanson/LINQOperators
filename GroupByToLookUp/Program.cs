using StudentsData;
using System.Text.RegularExpressions;

namespace GroupByToLookUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();


            // USING QUERY SYNTAX
            Console.WriteLine("USING QUERY SYNTAX");

            var result = from s in data
                         group s by s.Age;

            foreach (var ageGroup in result)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);

                Console.WriteLine("\n");
            }



            // USING METHOD SYNTAX
            Console.WriteLine("USING METHOD SYNTAX");

            var result1 = data.GroupBy(s => s.Age);

            foreach (var ageGroup in result1)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);


                Console.WriteLine("\n");
            }


            // USING METHOD SYNTAX - TOLOOKUP
            Console.WriteLine("USING METHOD SYNTAX - TOLOOKUP");

            var result2 = data.ToLookup(s => s.Age);

            foreach (var ageGroup in result2)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);


                Console.WriteLine("\n");
            }

        }
    }
}



//Points to Remember :

//GroupBy & ToLookup return a collection that has a key and an inner collection based on a key field value.

//The execution of GroupBy is deferred whereas that of ToLookup is immediate.

//A LINQ query syntax can be end with the GroupBy or Select clause.