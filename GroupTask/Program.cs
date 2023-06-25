using System.Text.RegularExpressions;

namespace GroupTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            int result = Enter();
            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        Group group = EnterGroupDetails();
                        groups.Add(group);
                        Console.WriteLine("Qrup elave olundu");
                        GetGroups(groups);
                        break;
                    case 2:
                        Student student = EnterStudentDetails();
                        GetGroups(groups);
                        Group gr = GetGroup(groups);
                        while(gr is null)
                        {
                            Console.WriteLine("Bele qrup tapilmadi");
                            gr = GetGroup(groups);
                        }
                        gr.AddStudent(student);
                        gr.GetStudents();
                        break;
                    case 3:
                        Group grup = GetGroup(groups);
                        Filter filter = EnterFilterData();
                        List<Student> students = grup.FilterStudent(grup.Students,filter);
                        foreach (Student stu in students)
                        {
                            Console.WriteLine(stu);
                        }
                    break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        break;
                }
                result = Enter();
            }
        }

        public static int Enter()
        {
            Console.WriteLine("Cixis etmek ucun 0-a klikleyin");
            Console.WriteLine("Qrup elave etmek ucun 1-e klikleyin");
            Console.WriteLine("Telebe elave etmek ucun 2-e klikleyin");
            Console.WriteLine("Filter emeliyyati aparmaq ucun 3-e klikleyin");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static Group GetGroup(List<Group> groups)
        {
            Console.Write("Qrupu secin : ");
            int groupId = Convert.ToInt32(Console.ReadLine());
            Group group = groups.FirstOrDefault(x => x.Id == groupId);
            return group;
        }


        public static Group EnterGroupDetails()
        {
            Console.Write("Qrupun adini daxil edin : ");
            string name = Console.ReadLine();
            Console.Write("Qrupun limitini daxil edin : ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qrupun kredit sayini daxil edin : ");
            int credit = Convert.ToInt32(Console.ReadLine());
            return new Group(name, limit, credit);
        }

        public static Student EnterStudentDetails()
        {
            Console.Write("Telebenin adini daxil edin : ");
            string firstname = Console.ReadLine();
            Console.Write("Telebenin soyadini daxil edin : ");
            string lastname = Console.ReadLine();
            Console.Write("Telebenin nomresini daxil edin : ");
            string studentNumber = Console.ReadLine();
            Console.Write("Telebenin ortalamasini daxil edin : ");
            double gpa = double.Parse(Console.ReadLine());
            return new Student(firstname, lastname, studentNumber, gpa);



        }

        public static void GetGroups(List<Group> groups)
        {
            foreach (Group group in groups)
            {
                Console.WriteLine(group.GetFullInfo());
            }
        }

        public static Filter EnterFilterData()
        {
            Console.Write("Axtaris edin : ");
            string search = Console.ReadLine();
            Console.Write("Minimum bali daxil edin : ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maksimum bali daxil edin : ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Siralama deyerini daxil edin : ");
            string order_column = Console.ReadLine();
            Console.Write("Siralama istiqametini daxil edin : ");
            string direction = Console.ReadLine();
            return new Filter(search,min,max,order_column,direction);
        }
    }
}