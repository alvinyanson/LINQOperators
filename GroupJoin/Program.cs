using StudentsData;

namespace GroupJoin
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // USING METHOD SYNTAX
            Console.WriteLine("\nUSING METHOD SYNTAX");
            var data = Students.SeedData2() // outer sequence

                .GroupJoin(Students.SeedData(), // inner sequence
                
                standard => standard.StandardID, // outer key selector
                
                student => student.StandardId, // inner key selector
                
                (std, studentGroup) => new // result selector
                {
                    Students = studentGroup,
                    StandardFullName = std.StandardName
                });


            foreach (var student in data)
            {
                Console.WriteLine(student.StandardFullName);

                foreach(var s in student.Students)
                    Console.WriteLine(s.StudentName);

                Console.WriteLine("\n");
            }


            // USING QUERY SYNTAX
            Console.WriteLine("\nUSING QUERY SYNTAX");
            var data2 = from s in Students.SeedData2() // outer sequence

                        join st in Students.SeedData() // inner sequence

                        on s.StandardID equals st.StandardId // left - outer key selector, right - inner key selector

                        into studentGroup

                        select new // result selector
                        {
                            Students = studentGroup,
                            StandardFullName = s.StandardName
                        };

            foreach (var student in data2)
            {
                Console.WriteLine(student.StandardFullName);

                foreach (var s in student.Students)
                    Console.WriteLine(s.StudentName);

                Console.WriteLine("\n");
            }
        }
    }
}