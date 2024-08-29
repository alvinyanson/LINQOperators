using StudentsData;

namespace EmptyRangeRepeat
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // USING METHOD SYNTAX - EMPTY
            Console.WriteLine("USING METHOD SYNTAX - EMPTY");

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0}", emptyCollection1.Count());
            Console.WriteLine("Type: {0}", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);



            // USING METHOD SYNTAX - RANGE

            Console.WriteLine("\nUSING METHOD SYNTAX - RANGE");
            
            var rangeCollection = Enumerable.Range(0, 10);
            Console.WriteLine("Total Count: {0}", rangeCollection.Count());

            foreach(var item in rangeCollection)
                Console.WriteLine("{0}", item);


            // USING METHOD SYNTAX - REPEAT
            Console.WriteLine("\nUSING METHOD SYNTAX - REPEAT");

            var repeatCollection = Enumerable.Repeat<string>("Hello", 10);

            Console.WriteLine("Total Count: {0}", repeatCollection.Count());

            foreach(var item in repeatCollection)
                Console.WriteLine("{0}", item);
        }
    }
}