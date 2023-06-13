namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] { };
            string[] names = { };
            int[] numbers = { };
            Student student = new Student("Nigar", "Qurbanova", "STD001");
            Student student2 = new Student("Ruslan", "Tagizade", "STD002");
            Student student3 = new Student("Emin", "Nagiyev", "STD003");
            #region Students
            //Add(ref students, student);
            //Add(ref students, student2);
            //Add(ref students, student3);
            #endregion

            #region Numbers
            //Add(ref numbers, 10);
            //Add(ref numbers, 15);
            //Add(ref numbers, 18);
            //Add(ref numbers, 12);
            #endregion

            #region Strings
            //Add(ref names, "Ramin");
            //Add(ref names, "Rehim");
            //Add(ref names, "Emin");
            //Add(ref names, "Ruslan");
            //Add(ref names, "Sadig");
            #endregion

            //Console.WriteLine("// Students //");
            //GetElements(students);
            //Console.WriteLine("// Numbers //");
            //GetElements(numbers);
            //Console.WriteLine("// Strings //");
            //GetElements(names);

            //DataControl<Student> controlStudents = new DataControl<Student>();
            //controlStudents.Add(student);
            //controlStudents.Add(student2);
            //controlStudents.Add(student3);
            //controlStudents.Get();

            //DataControl<Teacher> controlTeachers = new DataControl<Teacher>();

            //DataControl<string> controlNames = new DataControl<string>();
            //controlNames.Add("Nigar");
            //controlNames.Add("Ruslan");
            //controlNames.Add("Rehim");
            //controlNames.Add("Sadig");
            //controlNames.Get();

            //DataControl<int> controlNumbers = new DataControl<int>();
            //controlNumbers.Add(1);
            //controlNumbers.Add(5);
            //controlNumbers.Add(10);
            //controlNumbers.Add(12);
            //controlNumbers.Add(3);
            //controlNumbers.Get();

            //DataControl<Group> controlGroup = new DataControl<Group>();

            //GenericTwoType<int, string> genericTwoType = new GenericTwoType<int, string>(1,"Test");
            //GenericTwoType<int, string> genericTwoType2 = new GenericTwoType<int, string>(2, "Test 2");
            //GenericTwoType<int, string> genericTwoType3 = new GenericTwoType<int, string>(3, "Test 3");
            //Console.WriteLine(genericTwoType.Key);
            //Console.WriteLine(genericTwoType.Value);

            Group group = new Group("Group 205",10);
            group.AddStudent(student);
            group.AddStudent(student2);
            group.RemoveStudent(1);
            group.GetStudents();
        }

        #region Non Generic Methods
        //public static void Add(ref Student[] students, Student student)
        //{
        //    Array.Resize(ref students, students.Length + 1);
        //    students[students.Length - 1] = student;
        //}

        //public static void Add(ref string[] names,string name)
        //{
        //    Array.Resize(ref names, names.Length + 1);
        //    names[names.Length - 1] = name;
        //}

        //public static void Add(ref int[] numbers, int number)
        //{
        //    Array.Resize(ref numbers, numbers.Length + 1);
        //    numbers[numbers.Length - 1] = number;
        //}

        //public static void GetElements(Student[] students)
        //{
        //    foreach (Student student in students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}

        //public static void GetElements(string[] names)
        //{
        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        //public static void GetElements(int[] numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
        #endregion
    }
}