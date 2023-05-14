namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tasks for 12.05.2023

            // Task - 1

            //string[] names = new string[] { "ramazan","messi","ronaldo","anastasiya","berlin" };
            //char letter = ' ';
            //string word = "";
            //int max = 0;
            //foreach (string name in names)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        int count = 0;
            //        for (int j = 0; j < name.Length; j++)
            //        {
            //            if (name[i] == name[j])
            //            {
            //                count++;
            //            }
            //        }
            //        if (count > max)
            //        {
            //            max = count;
            //            letter = name[i];
            //            word = name;
            //        }
            //    }
            //}

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter) continue;
            //    Console.Write(word[i]);
            //}

            // Task - 5
            //int[] numbers = new int[] { 111,224,421,850,149,71 };
            //int max = 0;
            //int num = 0;

            //foreach (int number in numbers) 
            //{
            //    int sum = 0;
            //    int temp = number;
            //    while (temp > 0)
            //    {
            //        sum+=temp%10;
            //        temp /= 10;
            //    }

            //    if(sum> max)
            //    {
            //        max = sum;
            //        num = number;
            //    }
            //}

            //Console.WriteLine(num);
            #endregion

            #region TwoDimensionalArray
            //Console.WriteLine(tableInt.Length);

            //for (int i = 0; i < tableInt.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tableInt.GetLength(1); j++)
            //    {
            //        Console.Write(tableInt[i,j]+" ");
            //    }
            //    Console.WriteLine("");
            //}

            // 5 4 2 7 
            // 2 8 3 9
            // 7 11 5 2
            // -1 4 9 6

            int[,] tableInt = new int[4, 4] {
                { 5, 4, 2, 7}, // 0+3=3
                { 2, 8, 3, 9}, // 1+2=3
                { 7, 11, 5, 2},// 2+1=3
                {-1, 4, 9, 6 } // 3+0=3
            };

            int sum = 0;

            //for (int i = 0; i<tableInt.GetLength(0); i++)
            //{
            //    for (int j = 0; j<tableInt.GetLength(1); j++)
            //    {
            //        if(i == j) sum+= tableInt[i,j];
            //    }
            //}

            //for (int i = 0; i < tableInt.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tableInt.GetLength(1); j++)
            //    {
            //        if (i + j == tableInt.GetLength(0) - 1) sum += tableInt[i, j];
            //    }
            //}

            //Console.WriteLine(sum);
            #endregion

            #region JaggedArray
            var jagged = new int[2][]
            {
                new int[] { 1, 2, },
                new int[] { 1, 2,5,12,8},
            };

            //Console.WriteLine(jagged[1][1]);

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for(int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j]+" ");
            //    }
            //    Console.WriteLine("");
            //}
            #endregion

            // salam usaqlar, necesiniz?
        }
    }
}