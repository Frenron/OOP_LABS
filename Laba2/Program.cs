using System;

namespace Laba2
{
    partial class Student
    {
        public readonly int id = ON + 1;
        private static int ON = 0;
        private string lastName;
        private string firstName;
        private string patronymic;
        private (int? day, int? month, int? year) birthday;
        private long? phone;
        private string faculty;
        private int? course;
        private int? group;
        public const string University = "BSTU";

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
            }
        }

        public string Patronymic
        {
            get => patronymic;
            set
            {
                patronymic = value;
            }
        }

        public long? Phone
        {
            get => phone;
            set
            {
                phone = value;
            }
        }

        public string Faculty
        {
            get => faculty;
            set
            {
                switch (value)
                {
                    case "IT":
                    case "HTIT":
                    case "PIM":
                        faculty = value;
                        break;
                }
            }
        }

        public int? Course
        {
            get => course;
            set
            {
                if(value>=1 && value <= 5)
                {
                    course = value;
                }
            }
        }

        public int? Group
        {
            get => group;
            set
            {
                if(value>=1 && value <= 12)
                {
                    group = value;
                }
            }
        }

        public (int? day, int? month, int? year) Birthday
        {
            get => birthday;
            set
            {
                if ((value.day >= 1 && value.day <= 31) && (value.month >= 1 && value.month <= 12) && (value.year >= 1900 && value.year <= 2006))
                {
                    birthday = value;
                }
            }
        }

        public Student()
        {
            lastName = null;
            firstName = null;
            patronymic = null;
            birthday = (null, null, null);
            phone = null;
            faculty = null;
            course = null;
            group = null;

            ON++;
        }

        public Student(string lastName=null, string firstName = null, string patronymic = null, int? day =null, int? month=null, int? year=null, long? phone=null, string faculty=null, int? course=null, int? group=null)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Birthday = (day, month, year);
            Phone = phone;
            Faculty = faculty;
            Course = course;
            Group = group;
            ON++;
        }

        static Student()
        {
            Console.WriteLine("Constructor start: ");
        }

        private Student(string lastName, string firstName)
        {
            Console.WriteLine("Private Constructor:");
            LastName = lastName;
            FirstName = firstName;
            Patronymic = null;
            Birthday = (null, null, null);
            Phone = null;
            Faculty = null;
            Course = null;
            Group = null;
            ON++;
        }

        public void scale()
        {
            Console.WriteLine($"\nConstructors: {ON}\n");
        }

        public static void getInfo()
        {
            Student MSTkrut2 = new Student("Rodin", "Anton");
            Console.WriteLine($"LastName: {MSTkrut2.lastName};\nFirstName: {MSTkrut2.firstName}");
            Console.WriteLine($" All constructors: {ON}");
        }

       
    }
    class Program
    {
        static void Main(string [] args)
        {
            Student Dantey = new Student();
            Student Ren4L = new Student("Isakov", "Vladislav", "Alexeyevich", 10, 03, 2003, 375338436456, "IT", 2, 10);
            Student Hobbit = new Student("Shcherbakov", "Artem", "Alexeyevich", 29, 03, 2003, 375338434456, "IT", 2, 10);
            Student M = new Student("Shveikus", "Mikhail", "Yurievich", 16, 01, 2003, 375332436456, "PIM", 1, 3);
            Student M2 = new Student("Misko", "Ilya", "Yurievich", 16, 01, 2003, 375338436457, "PIM", 1, 3);
            Student[] arr = { Dantey, Ren4L, Hobbit, M, M2 };
            Console.WriteLine($"Ren4L: {Ren4L.FirstName};\nGetHashCode: {Dantey.GetHashCode()};\nM: {M.Equals(M2)}\n");

            Student.FindFaculty(ref arr, "PIM");
            Console.WriteLine();
            Student.List(ref arr, 2, 10);

            var anonym = new
            {
                id = 6,
                LastName = "Аноним",
                FirstName = "Анонимов",
                Patronymic = "Анонимович",
                Birthday = (1, 1, 1970),
                Phone = 375298045763,
                Faculty = "IT",
                Course = 5,
                Group = 10
            };
            Console.WriteLine(anonym);
        }
    }
}
