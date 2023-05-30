using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    internal class Student : Person
    {
        private int _id;
        public int Id { get
            {
                return _id;
            } set
            {
                _id = value;
            }
        }
        public string StudentNumber { get; set; }
        internal int Score { get; set; }

        public Student() : base()
        {
        }

        public Student(string firstname,string lastname,int age,string studentNumber, int score) 
                                    : base(firstname,lastname,age)
        {
            StudentNumber = studentNumber;
            Score = score;
        }

        public void SetScore(int score)
        {
            this.Score = score;
        }

        public string ExamLetter()
        {
            string result = "";
            switch (Score)
            {
                case 0:
                    result = "Telebe hele qiymetlendirilmemisdir";
                    break;
                case <= 50:
                    result = "F";
                    break;
                case <= 60:
                    result = "E";
                    break;
                case <= 70:
                    result = "D";
                    break;
                case <= 80:
                    result = "C";
                    break;
                case <= 90:
                    result = "B";
                    break;
                case <= 100:
                    result = "A";
                    break;
                default:
                    result = "Yanlish qiymet";
                    Score = 0;
                    break;
            }

            return result;
        }

        //public int getId()
        //{
        //    return this._id;
        //}

        //public void setId(int id)
        //{
        //    this._id = id;
        //}
    }
}
