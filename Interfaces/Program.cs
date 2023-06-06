using Interfaces.Abstractions;
using Interfaces.Task1;
using Interfaces.Task2;
using Interfaces.Task3;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Football football = new Football("soccer", "ball", 90);
            //Console.WriteLine(football.WinningType());
            //Judo judo = new Judo("");
            //judo.Fints = new string[] { "wazari", "ippon" };
            //foreach (string item in judo.Fints)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(judo.WinningType());

            //Tennis tennis = new Tennis("", "Roketca");
            //Console.WriteLine(tennis.WinningType());
            #endregion

            #region Task2
            //Triangle triangle = new Triangle(3,5,7);
            //Console.WriteLine(triangle.Perimeter());
            //Console.WriteLine(triangle.Area());

            //Rectangle rectangle = new Rectangle(10,8);
            //Console.WriteLine(rectangle.Area());
            //Console.WriteLine(rectangle.Perimeter());

            //Round round = new Round(4);
            //Console.WriteLine(round.Perimeter());
            //Console.WriteLine(round.Area());
            #endregion

            #region Task3
            //Str str = new Str("Salam");
            //Console.WriteLine(str.IndexOf("ala",2));
            #endregion

            #region Interfaces
            Duck duck = new Duck("");
            duck.Swim();
            duck.Walk();
            duck.Fly();

            Snake snake = new Snake("Black Mamba");
            snake.Swim();
            snake.Reptile();

            //IFly fly = new Fish("");
            #endregion
        }
    }
}