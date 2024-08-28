namespace StudentsData
{
    public class Students
    {
        public static IList<Student> SeedData()
        {
            IList<Student> Students = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StudentId = 6, StudentName = "Ram" , Age = 18 }
            };

            return Students;
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

}
