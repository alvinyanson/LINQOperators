namespace StudentsData
{
    public class Students
    {
        public static IList<Student> SeedData()
        {
            IList<Student> Students = new List<Student>()
            {
                new Student() { StandardId = 1, StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StandardId = 1, StudentId = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StandardId = 1, StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StandardId = 2, StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StandardId = 3, StudentId = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StandardId = 3, StudentId = 6, StudentName = "Ram" , Age = 18 }
            };

            return Students;
        }

        public static IList<Student> SeedData4()
        {
            IList<Student> Students = new List<Student>()
            {
                new Student() { StandardId = 1, StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StandardId = 1, StudentId = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StandardId = 1, StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StandardId = 2, StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StandardId = 3, StudentId = 5, StudentName = "Ron" , Age = 19 },
                new Student() { StandardId = 3, StudentId = 6, StudentName = "Ram" , Age = 18 }
            };

            return Students;
        }

        public static IList<Standard> SeedData2()
        {
            IList<Standard> StandardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 4, StandardName="Standard 4"}
            };

            return StandardList;
        }

        public static IList<string> SeedData3()
        {
            IList<string> StudentNames = new List<string>()
            {
                "John", "Steve", "Bill", "Ram", "Ron"
            };

            return StudentNames;
        }
    }

    public class Student : IComparable<Student>
    {
        public int StandardId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;

            return 0;
        }
    }


    public class Standard
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
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
            return obj.StudentId.GetHashCode();
        }
    }
}
