namespace ArrayAndStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringMethods
            //Test("Hello World");
            //int result = Sum(5, 15);
            //Console.WriteLine(Sum(25,12));
            //Console.WriteLine(Multiply(10,12,4));

            string str = "dgldfmglkmfglmszmcvnmn";
            //str[0] = 'a';

            //Console.WriteLine(str.Contains("d"));
            //Console.WriteLine(str.Length);
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Concat("salam"));
            //Console.WriteLine(str.GetType().Name);
            //Console.WriteLine(str.IndexOf("f"));
            //Console.WriteLine(str.LastIndexOf("d",0));
            //str = str.Remove(0, 2);
            //Console.WriteLine(str);
            //str = str.Replace("dg","gd");
            //Console.WriteLine(str);

            //string name = "Zarafat";
            //Console.WriteLine(name.Replace("a",""));

            //string sentence = "Salam gencler, bu gunku dersimiz metodlardir";
            //var result = sentence.Split(" ");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(result.Length);

            //Console.WriteLine(str.StartsWith('b'));

            //Console.WriteLine("    salam    "+"a");
            //Console.WriteLine("    salam    ".TrimStart() + "a"); // salam
            //Console.WriteLine("    salam    ".TrimEnd() + "a");
            //Console.WriteLine("    salam    ".Trim() + "a");

            //"version" // tolower "version"

            //Console.WriteLine(str.Substring(1, 5));

            //Console.WriteLine(CustomIndexOf(str, 'a'));
            //GetAllIndex(str,"d");

            string empty = "   ";
            string @null = null;
            //Console.WriteLine(string.IsNullOrEmpty(@null));
            //Console.WriteLine(string.IsNullOrEmpty(empty));
            //Console.WriteLine(string.IsNullOrWhiteSpace(@null));
            //Console.WriteLine(string.IsNullOrWhiteSpace(empty));
            #endregion


            #region ArrayMethods
            int[] numbers = new int[] {14,9,5,2,8,-3,9,11 };
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.GetType().Name);
            //Console.WriteLine(numbers.Contains(4));
            //Console.WriteLine(numbers.Sum());
            //var firstTwo = numbers.Skip(2).Take(2);
            //foreach (int number in firstTwo)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers[0]

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine(Array.IndexOf(numbers, 9, 5));
            string[] names = new string[] { "Emin", "Ruslan", "Ramin","Emin", "Rehim", "Nigar", "Sadig" };
            //Console.WriteLine(CustomContains(names,"Emin"));
            //Console.WriteLine(CustomContains(names,"Nahid"));
            //Console.WriteLine(LastIndex(names,"Emin"));

            #endregion
        }

        static void Test(string word)
        {
            Console.WriteLine(word);
        }

        static int Sum(int a, int b)
        {
            return b+a;
        }

        static int Multiply(int a, int b,int c) 
        {
            return a * b * c;
        }

        static bool CustomContains(string[] words,string word)
        {
            foreach (string item in words)
            {
                if(item == word) return true;   
            }
            return false;
        }

        static int LastIndex(string[] words, string word)
        {
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (word == words[i]) return i;
            }
            return -1;
        }

        //static int CustomIndexOf(string word,char ch)
        //{
        //    int index = -1;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == ch)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    return index;
        //}

        //static void GetAllIndex(string word,string part)
        //{
        //    int index = -1;

        //    while (word.IndexOf(part,index+1) != -1)
        //    {
        //        index = word.IndexOf(part,index+1);
        //        Console.WriteLine(index);
        //    }
        //}
    }
}