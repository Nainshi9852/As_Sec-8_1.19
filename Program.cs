using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        public static void runApp()
        {
            string[] students = new string[10];
            Console.WriteLine("After Bubble Sorting:-");
            students[0] = "Sam";
            students[1] = "Markes";
            students[2] = "Adil";
            students[3] = "Sana";
            students[4] = "Naina";
            students[5] = "Fareen";
            students[6] = "Tanya";
            students[7] = "Guruey";
            students[8] = "Chandan";
            students[9] = "Kamleshwar";

            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }

    }
}
