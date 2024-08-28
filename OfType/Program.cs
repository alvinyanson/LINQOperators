using System.Buffers.Text;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OfType
{
    public class Program
    {
        public static void Main(string[] args)
        {


            IList MixedList = new ArrayList();

            MixedList.Add(1);
            MixedList.Add("Alvin");
            MixedList.Add(3.14);



            // USING QUERY SYNTAX
            var result = from s in MixedList.OfType<string>() 
                        
                         select s;

            foreach (var s in result)
            {
                Console.WriteLine("USING QUERY SYNTAX");
                Console.WriteLine($"{s}");
            }


            
            
            // USING METHOD SYNTAX
            var result2 = MixedList.OfType<string>();
            
            foreach (var s in result)
            {
                Console.WriteLine("\nUSING METHOD SYNTAX");
                Console.WriteLine($"{s}");
            }
        }
    }
}


//Points to Remember :

//The Where operator filters the collection based on a predicate function.

//The OfType operator filters the collection based on a given type

//Where and OfType extension methods can be called multiple times in a single LINQ query.
