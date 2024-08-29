using StudentsData;

namespace DefaultIfEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Student> emptyStudentList = new List<Student>();

            var newStudentList1 = emptyStudentList.DefaultIfEmpty(new Student());

            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student()
            {
                StudentId = 0,
                StudentName = ""
            });

            Console.WriteLine("Count: {0} ", newStudentList1.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0).StudentName);

            Console.WriteLine("Count: {0} ", newStudentList2.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).StudentId);
        }
    }
}