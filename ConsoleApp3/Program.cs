// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ClassA
    {
        public void max()
        {
            Console.WriteLine("To Find maximum number");
            int[] num = new int[10];
            int maxnum;
            Console.WriteLine("Please enter 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            maxnum = num[0];
            for (int i = 1; i < 10; i++)
            {
                if (num[i] > maxnum)
                {
                    maxnum = num[i];
                }
            }
            Console.WriteLine("maximum number is :" + maxnum);
        }

        public void min()
        {
            Console.WriteLine("To find minimum value in a array");
            int[] num = new int[10];
            int minNum;
            Console.WriteLine("Pleasse enter 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            minNum = num[0];
            for (int i = 0; i < 10; i++)
            {
                if (num[i] < minNum)
                {
                    minNum = num[i];
                }
            }
            Console.WriteLine("minimum number is :" + minNum);
        }

        public void firstClass()
        {
            Console.WriteLine("To find the firstclass student ");
            int[] num = new int[10];
            int firstClass = 0;
            Console.WriteLine("Enter student marrks :");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (num[i] >= 60)
                {
                    firstClass++;
                }
            }
            Console.WriteLine("first class students are :" + firstClass);

        }


        public void studentsResults()
        {
            Console.WriteLine("To find the Result of student ");
            int[] marks = new int[10];
            int dist = 0;
            int firstClass = 0;
            int pass = 0;
            int fail = 0;
            Console.WriteLine("Please enter 10 student marks :");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (marks[i] >= 80)
                {
                    dist++;

                }
                else if (marks[i] >= 60)
                {
                    firstClass++;
                }

                else if (marks[i] >= 35)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
            }

            Console.WriteLine("dist studentes are :" + dist);
            Console.WriteLine("first studentes are :" + firstClass);
            Console.WriteLine("pass studentes are :" + pass);
            Console.WriteLine("Fail studentes are :" + fail);

        }

       


        }
}

