namespace StaticModifier
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const int a = 0;
            Student student = new Student("Sadig", "Aliyev");
            Student student1 = new Student("Sadig", "Aliyev");
            Console.WriteLine(Object.ReferenceEquals(student,student1));
            //Console.WriteLine("Hello, World!");

            //Calculator calc = new Calculator();

            //Console.WriteLine(Calculator.Calc(10, 8));

            //Program program = new Program();
            ////program.Calc(10, 8);
            //Calc(10, 8);

            //Console.WriteLine(Calculator.Calc(5, 10));



            //Student student = new Student("Emin", "Nagiyev");
            //Student student2 = new Student("Ruslan", "Tagizade");
            //Student student3 = new Student("Ramin", "Emrahli");
            //Student student4 = new Student("Rehim", "Rehimov");
            //Console.WriteLine(student.ToString());
            //Console.WriteLine(student2.ToString());
            //Console.WriteLine(student3.ToString());
            //Console.WriteLine(student4.ToString());
            student.Id = 5;

            int number = 20;
            string word = "Hello";
            Console.WriteLine(word.RemoveLetter('l'));
            Console.WriteLine(number.Cube(10));
            Console.WriteLine(number.Square());
            Console.WriteLine(Calculator.Sum(1,4,7,10,12));
        }

        static int Calc(int x, int y)
        {
            return (int)(x * y);
        }
    }
}