
using PublicAssembly;

namespace OOP_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //Student student = new Student("Nigar", "Qurbanova", "STD001",20);
            //Student student2 = new Student();
            //student = new Student();
            //student.FirstName = "Nigar";
            //student.LastName = "Qurbanova";
            //student.Age = 20;
            //student.StudentNumber = "STD001";

            //student.SetScore(120);
            //Console.WriteLine(student.ExamLetter());

            //Person person = new Person("Sadig","Aliyev",24);
            //Console.WriteLine(person.GetFullInfo());

            //Student student = new Student("Emin","Nagiyev",20,"STD001",85);
            //Console.WriteLine(student.GetFullInfo());
            //Console.WriteLine(student.ExamLetter());

            Student student = new Student("Ruslan","Tagizade",20,"STD001",75);
            Console.WriteLine(student.Score);
            //Console.WriteLine(student._id); // cause of private
            //Console.WriteLine(student is Person);

            //Group group = new Group();
            //student.setId(10);
            student.Id = 25;
        }
    }
}