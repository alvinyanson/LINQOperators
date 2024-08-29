using StudentsData;

namespace ConversionAsAndToAndCast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = Students.SeedData();


            // USING METHOD SYNTAX - ASENUMERABLE AND ASQUERYABLE
            ReportTypeProperties(data);

            Console.WriteLine("USING METHOD SYNTAX - ASENUMERABLE AND ASQUERYABLE");
            ReportTypeProperties(data.AsEnumerable());
            ReportTypeProperties(data.AsQueryable());


            // USING METHOD SYNTAX - CAST
            Console.WriteLine("USING METHOD SYNTAX - CAST");
            ReportTypeProperties(data.Cast<Student>());


            // USING METHOD SYNTAX - TOARRAY AND TOLIST

            Console.WriteLine("USING METHOD SYNTAX - TOARRAY AND TOLIST");

            IList<string> strList = new List<string>() {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Three"
                                            };

            string[] strArray = strList.ToArray<string>();

            IList<string> list = strArray.ToList<string>();

            ReportTypeProperties(strArray);
            ReportTypeProperties(list);


            // USING METHOD SYNTAX - TODICTIONARY

            Console.WriteLine("USING METHOD SYNTAX - TODICTIONARY");

            IDictionary<int, Student> studentDict =
                                            data.ToDictionary<Student, int>(s => s.StudentId);

            foreach (var key in studentDict.Keys)
                Console.WriteLine("Key: {0}, Value: {1}",
                                            key, (studentDict[key] as Student).StudentName);
        }

        static void ReportTypeProperties<T>(T obj)
        {
            Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
            Console.WriteLine("Actual type: {0}\n", obj.GetType().Name);
        }
    }
}