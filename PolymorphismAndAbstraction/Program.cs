using PolymorphismAndAbstraction.Abstraction;

namespace PolymorphismAndAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Ruslan","Tagizade","STD123",85);
            //Console.WriteLine(student.GetFullInfo());
            //Teacher teacher = new Teacher("Sadig","Aliyev","Developer");
            //Console.WriteLine(teacher.GetFullInfo());
            //Person person = new Person("Filankes","Filankesov");
            //Console.WriteLine(person.GetFullInfo());

            //string str = "Salam";
            //str.IndexOf('a',);

            Animal animal = new Dog("Toplan");
            animal.Eat();
            animal.Sound();
        }
    }
}