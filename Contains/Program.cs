using StudentsData;
using System.Diagnostics.CodeAnalysis;

namespace Contains
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            var toFind = new Student() { StudentId = 3, StudentName = "Bill" };

            bool result = data.Contains(toFind, new StudentComparer());

            Console.WriteLine(result);
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
            return obj.GetHashCode();
        }
    }
}

//Points to Remember :

//All, Any & Contains are quantifier operators in LINQ.

//All checks if all the elements in a sequence satisfies the specified condition.

//Any check if any of the elements in a sequence satisfies the specified condition

//Contains operator checks whether specified element exists in the collection or not.

//Use custom class that derives IEqualityOperator with Contains to check for the object in the collection.

//All, Any & Contains are not supported in query syntax in C# or VB.Net.
