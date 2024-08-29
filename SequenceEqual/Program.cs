using StudentsData;

namespace SequenceEqual
{
    public class Program
    {
        public static void Main()
        {


            // USING METHOD SYNTAX - PRIMITIVE DATA
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            bool isEqual = strList1.SequenceEqual(strList2);
            Console.WriteLine(isEqual);




            // USING METHOD SYNTAX - COMPLEX OBJECT
            var data1 = Students.SeedData();
            var data2 = Students.SeedData4();

            bool isEqual2 = data1.SequenceEqual(data2, new StudentComparer());

            Console.WriteLine(isEqual2);
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}