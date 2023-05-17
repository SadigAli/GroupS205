namespace EnumAndDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            // Sort
            #endregion

            #region Task2
            //
            #endregion

            #region Task3
            /*
                  *  
                 *** 
                *****
             */

            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{   
            //    for (int j = 1; j<= number-i; j++) Console.Write("1");
            //    for (int k = 0; k< i+1;k++) Console.Write("* "); 
            //    Console.WriteLine("");
            //}
            #endregion

            #region Task4
            // contains
            //Console.WriteLine(CustomContains("alma", 'b'));
            #endregion

            #region Task5
            // substring
            //Console.WriteLine(CustomSubStr("Almani at",5,9));
            #endregion

            #region Task6
            /* Salam
             * S : 1
             * a : 2
             * l : 1
             * m : 1
             */
            //LetterCount("Salam");

            #endregion

            #region DateTime
            //DateTime dt = new DateTime(2012,10,12,11,12,13);
            //DateTime now = DateTime.UtcNow;
            // 46432113513133_sekil.png
            //Console.WriteLine(now.AddDays(-10));
            //Console.WriteLine(now.AddMonths(10));
            //DateTime RuslansBirth = new DateTime(2003, 10, 26,12,0,0);
            //DateTime EminsBirth = new DateTime(2002, 12, 20,11,36,12);
            //var difference = RuslansBirth.Subtract(EminsBirth);
            //difference = EminsBirth - RuslansBirth;
            //Console.WriteLine(difference.TotalDays);

            //DateTime WC = new DateTime(2022, 12, 18);
            //Console.WriteLine(new DateTime(638069184000000000));

            //DateTime now = new DateTime(2023,10,5);
            //Console.WriteLine(now.ToString("yyyy.MM.dd HH:mm"));
            #endregion

            Console.WriteLine((Status)12);
        }

        #region Tasks
        //static bool CustomContains(string str,char ch)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (ch == str[i]) return true;
        //    }
        //    return false;
        //}

        //static string CustomSubStr(string str,int index,int len)
        //{
        //    string newStr = "";
        //    if (len + index > str.Length) len = str.Length - index;
        //    // 4 5 6 7 8
        //    // asdgkf
        //    // 6 - 4 = 2
        //    for (int i = index;i < index + len;i++) 
        //        newStr+= str[i];

        //    return newStr;
        //}

        //static void LetterCount(string str)
        //{
        //    while (str.Length > 0)
        //    {
        //        int count = 0;
        //        foreach (char ch in str)
        //        {
        //            if (ch == str[0]) count++;
        //        }
        //        Console.Write($"{str[0]} : {count}");
        //        Console.WriteLine("");
        //        str = str.Replace(str[0].ToString(), string.Empty); // salams
        //    }
        //}
        #endregion


    }

    enum Status
    {
        Pending = 12,
        Accepted,
        Rejected = 12,
        Executed = 105
    }
}