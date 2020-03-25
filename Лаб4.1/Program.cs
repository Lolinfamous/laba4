using System;

namespace Лаб4._1
{
    class Program
    {
        class Student
        {
            private string name;
            private int sumb;
            private Random rnd = new Random();
            public static Student[] InitAr(Student[] Mass)
            {
                for (int i = 0; i < Mass.Length; i++)
                {
                    Mass[i] = new Student();
                }
                return Mass;
            }
            public void SetValue(string stroka)
            {
                this.name = stroka;
                this.sumb = rnd.Next(2,5);
            }
            public void Info()
            {
                Console.WriteLine("Имя = {0}, Средний балл = {1}", this.name, this.sumb);
            }
        }
        static void Main()
        {
            Student[] stud = new Student[3];
            for (int i = 0; i < 3; i++)
                Student.InitAr(stud);
            stud[0].SetValue("Студент_1");
            stud[1].SetValue("Студент_2");
            stud[2].SetValue("Студент_3");
            for (int i = 0; i < 3; i++)
                stud[i].Info();
        }
    }
}
