using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask
{
    internal class Group
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public int Credit { get; set; }
        public List<Student> Students = new List<Student>();
        public Group(string name,int limit,int credit)
        {
            Id = ++_id;
            Name = name;
            Limit = limit;
            Credit = credit;
        }

        public void AddStudent(Student student)
        {
            bool isExistStudent = Students.Any(x => x.StudentNumber == student.StudentNumber);
            if (isExistStudent)
            {
                Console.WriteLine("Bu telebe artiq movcuddur");
            }
            else
            {
                if(Students.Count >= Limit)
                {
                    Console.WriteLine("Telebe sayi limitini asirsiniz");
                }
                else
                {
                    Students.Add(student);
                    Console.WriteLine("Telebe elave olundu");
                }
            }
        }

        public void GetStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void UpdateStudent(int id,Student student)
        {
            Student stu = GetStudent(id);
            if(stu == null)
            {
                Console.WriteLine("Bu telebe tapilmadi");
            }
            else
            {
                stu.Firstame = student.Firstame;
                stu.Lastname = student.Lastname;
                stu.GPA = student.GPA;
                Console.WriteLine("Telebe redakte olundu");
            }
        }

        public void DeleteStudent(int id)
        {
            Student student = GetStudent(id);
            if(student is null)
            {
                Console.WriteLine("Telebe tapilmadi");
            }
            else
            {
                Students.Remove(student);
                Console.WriteLine("Telebe silindi");
            }
        }
            
        public Student GetStudent(int id) => Students.Find(x => x.Id == id);

        public string GetFullInfo()
        {
            return $@"Id : {Id}
Adi : {Name}
Kredit : {Credit}
Limit : {Limit}";
        }

        public List<Student> FilterStudent(IEnumerable<Student> students, Filter filter)
        {

            if (!string.IsNullOrEmpty(filter.Search))
            {
                students = students.Where(x => x.Firstame.Contains(filter.Search) ||
                                               x.Lastname.Contains(filter.Search) ||
                                               x.StudentNumber.Contains(filter.Search));
            }

            if(filter.Min > 0 && filter.Max> filter.Min)
            {
                students = students.Where(x=>x.GPA > filter.Min && x.GPA< filter.Max);
            }

            if (!string.IsNullOrEmpty(filter.OrderColumn))
            {
                switch (filter.OrderColumn)
                {
                    case "ad":
                        if(filter.Direction == "desc")
                        {
                            students = students.OrderByDescending(x => x.Firstame);
                        }
                        else
                        {
                            students = students.OrderBy(x => x.Firstame);
                        }
                        break;
                    case "soyad":
                        if (filter.Direction == "desc")
                        {
                            students = students.OrderByDescending(x => x.Lastname);
                        }
                        else
                        {
                            students = students.OrderBy(x => x.Lastname);
                        }
                        break;
                    case "ortalama":
                        if (filter.Direction == "desc")
                        {
                            students = students.OrderByDescending(x => x.GPA);
                        }
                        else
                        {
                            students = students.OrderBy(x => x.GPA);
                        }
                        break;
                    case "telebe nomresi":
                        if (filter.Direction == "desc")
                        {
                            students = students.OrderByDescending(x => x.StudentNumber);
                        }
                        else
                        {
                            students = students.OrderBy(x => x.StudentNumber);
                        }
                        break;
                    default :
                        if (filter.Direction == "desc")
                        {
                            students = students.OrderByDescending(x => x.Id);
                        }
                        else
                        {
                            students = students.OrderBy(x => x.Id);
                        }
                        break;
                }
            }

            return students.ToList();
        }
    }
}
