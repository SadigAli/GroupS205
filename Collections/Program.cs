using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string number = "dflkdjfl";
            //object obj = number; //
            //object o = "Salam";
            //string word = (string)o;

            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //arrayList.Add("Test");
            //arrayList.Add(true);
            //arrayList.Add(new[] { 1, 5, 8, 11 });
            //arrayList.Add('a');
            ////arrayList.Remove(true);
            ////arrayList.RemoveAt(2);
            //arrayList.AddRange(new[] { 5, 10, 15 });
            //arrayList.InsertRange(2, new[] { "A", "B", "C" });
            //arrayList.Insert(0, new { Message = "Ok" });
            //arrayList.RemoveRange(1, 5);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<int> list = new List<int>();
            //list.Add(3);
            //list.Add(5);
            //list.Add(-7);
            //list.Add(1);
            //list.Add(15);
            //list.Add(-7);
            //list.Add(8);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Average());
            //Console.WriteLine(list.Sum());
            //list.Sort();
            //list.Reverse();
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(list.Contains(5));
            //Console.WriteLine(list.LastIndexOf(-7));
            //foreach (int item in list.Take(5))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(list.Min());

            //List<Student> students = new List<Student>();
            //students.Add(new Student("Rehim", "Rehimli"));
            //students.Add(new Student("Emin","Nagiyev"));
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}

            #endregion

            #region Sorted List
            //Dictionary<int, string> map = new Dictionary<int, string>();
            //map.Add(25, "Ramin");
            //map.Add(15, "Ruslan");
            //map.Add(8, "Nigar");
            //map.Add(9, "Sadig");
            //Console.WriteLine(map[5]);

            //SortedList<int, string> map = new SortedList<int, string>();
            //map.Add(25, "Ramin");
            //map.Add(15, "Ruslan");
            //map.Add(8, "Nigar");
            //map.Add(9, "Sadig");
            //foreach (var i in map.Keys)
            //{
            //    Console.WriteLine(map[i]);
            //}
            #endregion

            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add("test", "ok");
            //ht.Add(1, "test");
            //foreach (var s in ht.Keys)
            //{
            //    Console.WriteLine(ht[s]);
            //}
            #endregion

            #region Queue And Stack
            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(1);
            //numbers.Push(5);
            //numbers.Push(8);
            ////foreach (int i in numbers)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //numbers.Pop();
            //Console.WriteLine(numbers.Peek());

            //Stack elements = new Stack();
            //elements.Push(1);
            //elements.Push("alalala");
            //foreach (var element in elements)
            //{
            //    Console.WriteLine(element);
            //}

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("a");
            //queue.Enqueue("b");
            //queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}