using StudentsData;

namespace SingleAndSingleOrDefault
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();

            var single = data.Single(x => x.StudentName == "John");

            Console.WriteLine(single.StudentName);


            var singleOrDefault = data.SingleOrDefault(x => x.StudentName == "John");

            Console.WriteLine(singleOrDefault.StudentName);
        }
    }
}


//Points to Remember :

//Single() expects one and only one element in the collection.

//Single() throws an exception when it gets no element or more than one elements in the collection.

//If specified a condition in Single() and result contains no element or more than one elements then it throws an exception.

//SingleOrDefault() will return default value of a data type of generic collection if there is no elements in a colection or for the specified condition.

//SingleOrDefault() will throw an exception if there is more than one elements in a colection or for the specified condition.