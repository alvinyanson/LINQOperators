using StudentsData;
using System.ComponentModel;

namespace Join
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<string> StringList1 = new List<string>() 
            { "One", "Two", "Three", "Four", "Five" };

            IList<string> StringList2 = new List<string>()
            { "One", "Two", "Three", "Six", "Seven" };


            var result = StringList1
                .Join(
                StringList2, 
                str1 => str1, 
                str2 => str2, 
                (str1, str2) => str1);
             

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }




            // USING METHOD SYNTAX
            Console.WriteLine("\nUSING METHOD SYNTAX");
            
            var result2 = Students.SeedData() // outer sequence
                .Join(Students.SeedData2(), // inner sequence
                student => student.StandardId, // outer key selector
                standard => standard.StandardID, // inner key selector
                (student, standard) => new // result selector
                {
                    StudentName = student.StudentName,
                    StandardName = standard.StandardName
                });


            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            // USING QUERY SYNTAX
            Console.WriteLine("\nUSING QUERY SYNTAX");

            var result3 = from student in Students.SeedData() // outer sequence
                
                join standard in Students.SeedData2() // inner sequence
                
                on student.StandardId equals standard.StandardID // outer left key, inner right key
                
                select new // result
                {
                    StudentName = student.StudentName,
                    StandardName = standard.StandardName
                };

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
        }
    }
}


//Points to Remember :

//Join and GroupJoin are joining operators.

//Join is like inner join of SQL. It returns a new collection that contains common elements from two collections whosh keys matches.

//Join operates on two sequences inner sequence and outer sequence and produces a result sequence.

//Join query syntax:

//from... in outerSequence
//join... in innerSequence
//on  outerKey equals innerKey
//select ...