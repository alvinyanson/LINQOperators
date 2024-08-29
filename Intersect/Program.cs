using StudentsData;

namespace Intersect
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USING METHOD SYNTAX - PRIMITIVE DATA TYPES

            Console.WriteLine("USING METHOD SYNTAX - PRIMITIVE DATA TYPES");

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Intersect(strList2);

            foreach (string str in result)
                Console.WriteLine(str);



            // USING METHOD SYNTAX - COMPLEX DATA TYPES

            Console.WriteLine("\nUSING METHOD SYNTAX - COMPLEX DATA TYPES");

            var data1 = Students.SeedData();
            var data2 = Students.SeedData4();

            var intersectCollection = data1.Intersect(data2, new StudentComparer());

            foreach(var item in intersectCollection)
                Console.WriteLine(item.StudentName);
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId &&
                            x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentId.GetHashCode();
        }
    }
}