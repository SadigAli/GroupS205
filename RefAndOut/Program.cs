using System.Text;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RefAndOut
            //int num = 15;
            //Console.WriteLine(num);
            //IncreaseValue(out num);
            //Console.WriteLine(num);
            #endregion
            int[] numbers = { 5, 12, 9, 4,17,8,-4,6 };
            //numbers[4] = 1; //--runtime - error
            //Array.Resize(ref numbers, 7);
            //int[] numbers2 = new int[] { };
            //numbers[6] = 27;

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            #region Array Resize 1
            //Console.WriteLine("Elave edeceyiniz sozlerin sayini daxil edin :");
            //int number = int.Parse(Console.ReadLine());
            //int temp = 0;
            //int[] nums = { };
            //string[] words = { };
            //while (temp < number)
            //{
            //    temp++;
            //    Console.WriteLine("Sozu daxil edin");
            //    string word = Console.ReadLine();
            //    int num;
            //    bool result = int.TryParse(word, out num);
            //    if (result)
            //    {
            //        Array.Resize(ref nums, nums.Length + 1);
            //        nums[nums.Length - 1] = num;
            //    }
            //    else
            //    {
            //        Array.Resize(ref words, words.Length + 1);
            //        words[words.Length - 1] = word;
            //    }
            //}

            //Console.WriteLine("Eded arrayinin uzunlugu : " + nums.Length);
            //Console.WriteLine("String arrayinin uzunlugu : " + words.Length);
            #endregion
            #region Array Resize 2
            //CustomResize(ref numbers, 7);
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //SkipTake(numbers, 2, 3);
            #endregion

            string str1 = "Hello";
            string str2 = "World";
            //string str = "HelloWorld";
            //Console.WriteLine(str1 + str2);

            //str1+"World"
            StringBuilder stringBuilder = new StringBuilder("Hello");
            //stringBuilder.Append(str2);
            //stringBuilder.AppendLine();
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine("asfnsdlk");

            //stringBuilder.Insert(1,"a",2);
            //stringBuilder.Remove(0, 4);
            //stringBuilder.Replace("el","a");
            //Console.WriteLine(stringBuilder);

            //var nums =  {1,2,3 };

            //dynamic num = "";
            //num = 5;
            //Console.WriteLine(num);

            string str = null;
            //int num =5;
            Nullable<int> num = 12;
            int? num2 = num ?? 5;
            //num2 = num.HasValue ? num : 5;
            Console.WriteLine(num2);
            //Console.WriteLine(num.Value);
            Console.WriteLine(str?.Replace("a", "b"));
            //str == null ? str : str.Replace("a","b");
        }

        //static void IncreaseValue(out int number)
        //{
        //    number = 40;
        //    Console.WriteLine(number);
        //}

        static void CustomResize(ref int[] numbers,int length) 
        {
            int[] newArr = new int[length];
            int iterator = numbers.Length > length ? length : numbers.Length;
            for (int i = 0; i < iterator; i++)
            {
                newArr[i] = numbers[i];
            }
            numbers = newArr;
        }

        static int[] SkipTake(int[] arr,int skip,int take)
        {
            int[] nums = { };
            int iterator = skip + take > arr.Length ? arr.Length : skip + take;
            for (int i = skip; i< iterator; i++)
            {
                Array.Resize(ref nums, nums.Length+1);
                nums[nums.Length-1] = arr[i];
            }
            return nums;
        }
    }
}