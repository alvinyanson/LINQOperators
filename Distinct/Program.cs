using StudentsData;

namespace Distint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // USING METHOD SYNTAX - PRIMITIVE DATA TYPE

            IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

            IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

            var distinctList1 = strList.Distinct();

            foreach(var item in distinctList1)
                Console.WriteLine(item);

            var distinctList2 = intList.Distinct();

            foreach(var item in distinctList2)
                Console.WriteLine(item);



            // USING METHOD SYNTAX - COMPLEX DATA TYPE
            var data = Students.SeedData();

            var distinctList3 = data.Distinct(new StudentComparer());

            foreach(var item in distinctList3)
                Console.WriteLine(item.StudentName);
        }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId
                    && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentId.GetHashCode();
        }
    }
}