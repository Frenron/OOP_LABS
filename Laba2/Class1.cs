using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    partial class Student
    {
        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"{lastName}\n{firstName}\n{patronymic}\n{birthday}\n{phone}\n{University}\n{faculty}\n{course}\n{group}";
        }

        public override bool Equals(object obj)
        {
            Student temp = obj as Student;

            if (temp != null)
            {
                if (temp.lastName == this.lastName && temp.firstName == this.firstName && temp.patronymic == this.patronymic && temp.birthday == this.birthday && temp.phone == this.phone && temp.faculty == this.faculty && temp.course == this.course && temp.group == this.group)
                    return true;
                else return false;
            }
            else return false;
        }

        public static Student[] FindFaculty(ref Student[] arr, string faculty)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Faculty == faculty)
                {
                    Console.WriteLine(arr[i].LastName + " " + arr[i].FirstName);
                }
            }
            return arr;
        }

        public static Student[] List(ref Student[] arr, int course, int group)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].course == course && arr[i].group == group)
                {
                    Console.WriteLine(arr[i].LastName + " " + arr[i].FirstName);
                }
            }
            return arr;
        }
    }
}
