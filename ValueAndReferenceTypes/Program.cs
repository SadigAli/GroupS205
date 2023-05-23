namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int x = 10;
            //int y = 20;
            //x += y; // x = 30, y = 20
            //y = x - y; // x = 30, y = 10
            //x = x - y; // x = 20, y =10
            //Console.WriteLine($"x : {x}");
            //Console.WriteLine($"y : {y}");
            #endregion

            //int[] arr = { 4, 9, 12, 5, 8, 7, 3 };
            //GreaterThan(arr, 15);
            //Swap(arr);

            #region Task 2
            //int[] numbers = { 12,9,4,8,5,10 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i+1;j<numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] > 20) Console.WriteLine($"{numbers[i]} {numbers[j]}");
            //    }
            //}
            #endregion

            #region Task 3
            //int[] numbers = { 7, 9, 5, 2, 1 };
            //int temp = 0;
            //temp = numbers[0];
            //numbers[0] = numbers[numbers.Length-1];
            //numbers[numbers.Length-1] = temp;
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Task 4
            //.WriteLine(ProbNumber(37));
            //int n = int.Parse(Console.ReadLine());
            //int cem = Pilleken(n);
            //Console.WriteLine(cem);
            //static int Pilleken(int n)
            //{
            //    if (n==1)
            //    {
            //        return 1;
            //    }
            //    else if (n==2)
            //    {
            //        return 2;
            //    }
            //    else if (n==3)
            //    {
            //        return 4;
            //    }
            //    else if (n > 3)
            //    {
            //        return Pilleken(n - 1) + Pilleken(n - 2) + Pilleken(n - 3);
            //    }
            //    return 0;
            //}
            #endregion

            //int number = 10;
            //Console.WriteLine(number);
            //Console.WriteLine(ChangeValue(number));
            //Console.WriteLine(number);

            //string str = "Sadig";
            //Console.WriteLine(str);
            //ChangeValue(str);
            //Console.WriteLine(str);

            Person person = new Person();
            person.Name = "Sadig";
            person.Lastname = "Aliyev";
            Console.WriteLine(person.Name + " " + person.Lastname);
            ChangeName(person);
            Console.WriteLine(person.Name + " " + person.Lastname);

        }



        //static void ChangeValue(string str)
        //{
        //    str = "aaa";
        //    Console.WriteLine(str);
        //}

        static void ChangeName(Person person)
        {
            person.Name = "Allahverdi";
            Console.WriteLine(person.Name + " " + person.Lastname);
        }
        static void GreaterThan(int[] array,int limit)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j= i+1; j< array.Length; j++)
                {
                    if (array[i] + array[j] > limit) Console.WriteLine($"{array[i]} {array[j]}");
                }
            }
        }

        static void Swap(int[] array)
        {
            int temp = 0;
            temp = array[0]; // 5
            array[0] = array[array.Length-1]; // 9
            array[array.Length - 1] = temp; // 5

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        //static int ProbNumber(int number)
        //{
        //    if(number <=0) return 0;
        //    if (number == 1) return 1;
        //    if (number == 2) return 2;
        //    if (number == 3) return 4;

        //    int current = 3;
        //    int[] probs = { 1, 2, 4 };

        //    for(int i = current; i < number; i++)
        //    {
        //        int total = probs[0] + probs[1] + probs[2];
        //        probs[0] = probs[1];
        //        probs[1] = probs[2];
        //        probs[2] = total;
        //    }
        //    return probs[2];
        //}

    }

    internal class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}