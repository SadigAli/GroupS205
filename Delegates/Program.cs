namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegates
            //Calc calc = new Calc(Calculate.Sum);
            //calc += Calculate.Difference;
            //calc += Calculate.Multiply;
            //calc -= Calculate.Difference;
            //calc += delegate (int a, int b)
            //{
            //    Console.WriteLine(2 * a + b);
            //};

            //calc += (int a, int b) =>
            //{
            //    Console.WriteLine(a + 2 * b);
            //};

            //calc -= (int a, int b) =>
            //{
            //    Console.WriteLine(a + 2 * b);
            //};

            //calc -= delegate (int a, int b)
            //{
            //    Console.WriteLine(2 * a + b);
            //};
            //calc(10, 20);

            //Power power = new Power((int x) => x * x);
            //Console.WriteLine(power(20));

            //Func<int, int> func = Calculate.Power;
            //Func<int, int, int> func2 = Calculate.Divide;
            //Console.WriteLine(func(10));
            //Console.WriteLine(func2(10,5));

            //Action action = () => { Console.WriteLine("Hello, World"); };
            //action += delegate ()
            //{
            //    Console.WriteLine("Action with delegate keyword");
            //};
            //action();

            //Action<int, int> action = Calculate.Sum;
            //action(15,25);

            //Predicate<int> predicate = (int a) => a > 50;
            //Console.WriteLine(predicate(25));
            //Console.WriteLine(predicate(75));

            //List<Student> students = new List<Student>();
            //students.Add(new Student("Ruslan","Tagizade"));
            //students.Add(new Student("Ramin", "Emrahli"));
            //students.Add(new Student("Emin", "Nagiyev"));
            //students.Add(new Student("Rehim", "Rehimli"));
            //students.ForEach((Student student) =>
            //{
            //    Console.WriteLine(student.ToString());
            //});

            //Console.WriteLine(students.Exists(x => x.Firstname.Contains('R')));
            //Console.WriteLine(students.All(x => x.Firstname.StartsWith('R')));

            //Console.WriteLine(students.Any(x => x.Firstname.Contains('R')));
            #endregion
            DataProcessor<string> processor = new DataProcessor<string>();
            processor.Process(150);
        }

        public delegate void Calc(int x, int y);
        public delegate int Power(int a);
    }

    internal class DataProcessor<T> : Processor<int>
    {
    }

    internal class Processor<T>
    {
        public void Process(T data)
        {
            Console.WriteLine(data.GetType().Name + " ");
        }
    }
}