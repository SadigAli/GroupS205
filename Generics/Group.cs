using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Group
    {
        public int Limit { get; set; }
        public string Name { get; set; }
        public Student[] Students = { };
        public Group(string name,int limit)
        {
            Limit = limit;
            Name = name;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void RemoveStudent(int id) 
        {
            Student student = this.GetStudent(id);
            if(student == null)
            {
                Console.WriteLine("This student didn't found");
                return;
            }
            Student[] newStudents = { };

            foreach (Student item in Students)
            {
                if(item.Id != student.Id)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[newStudents.Length - 1] = item;
                }
            }
            Students = newStudents;
        }

        public Student GetStudent(int id) 
        { 
            foreach (Student student in Students)
            {
                if(student.Id == id) return student;
            }
            return null;
        }
        public void UpdateStudent(int id,Student student) { }
        public void GetStudents()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
