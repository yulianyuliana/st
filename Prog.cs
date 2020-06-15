using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[2];


            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("Введите имя и инициалы {0}-ого студента: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Введите номер группы {0}-ого студента: ", i + 1);
                int nomber = int.Parse(Console.ReadLine());
                Console.Write("Введите, через запятую, 5 оценок {0}-ого студента: ", i + 1);
                string[] marks = Console.ReadLine().Split(',');

                int[] progress = new int[5];
                for (int a = 0; a < 5; a++)
                    progress[a] = int.Parse(marks[a].ToString());

            }

            Console.WriteLine("\n\nУпорядоченный по номеру группы массив студентов: ");

            for (int i = 0; i < 2; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                    sum += s[i].progress[i];
                s[i].num = sum / 5;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    if (s[i].num < s[k].num)
                    {
                        Student p = s[i];
                        s[i] = s[k];
                        s[k] = p;
                    }
                }
            }
            foreach (Student student in s)
                Console.WriteLine("\n" + student.Name + student.GroupNumber);


            foreach (Student student in s)
            {
                int count = 0;
                for (int i = 0; i < 5; i++)
                {

                    if (student.progress[i] > 3)
                        count++;//Console.WriteLine(удалить count)
                }
                if (count > 5)
                    Console.WriteLine("\n" + student.Name);
            }

            Console.ReadKey();
        }
    }

    struct Student
    {
        public string Name;
        public int GroupNumber;
        public int[] progress;
        public int num;

    }
}
