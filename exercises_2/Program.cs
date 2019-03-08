using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GivenTheNaturalNumbers();
            //NaturalNumbers();
            //SumOfNaturalNumbers();
            //Numbers();
            //FindTheCube();
            //MultiTable();
            //SumEvenNumbers();
            //Stars();
            //PatternNumbers1();
            //PatternNumbers2();
            //PatternNumbers3();
            //NNumbers();
        }


        public static void NaturalNumbers() //1
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write("{0} ", i);
            }

            int y = 1;
            while (y < 101)
            {
                Console.Write("{0} ", y);
                y++;
            }
        }

        public static void SumOfNaturalNumbers() //1
        {
            int sum = 0;
            for (int i = 0; i < 11; i++)
            {
                sum += i;

            }

            Console.WriteLine("The sum is: {0} ", sum);
        }

        public static void GivenTheNaturalNumbers() //1
        {
            int number, sum = 0;
            Console.WriteLine("Give me the N term");
            Console.Write("N term: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number + 1; i++)
            {
                Console.Write("{0} ", i);

                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: {0} ", sum);

        }

        public static void Numbers() //2
        {
            List<int> lista = new List<int>();
            int number;
            var sum = lista.Sum();
            Console.WriteLine("Give me 10 numbers");

            for (int i = 1; i < 11; i++)
            {
                Console.Write("number {0}: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                lista.Add(number);
            }

            Console.WriteLine("The sum is: {0}", sum);
        }

        public static void FindTheCube() //2
        {
            int number, cube = 0;

            Console.WriteLine("Give me a number to tell you the cube");
            Console.Write("Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number + 1; i++)
            {
                cube = i * i * i;
                Console.WriteLine("The cube of {0} is: {1}", i, cube);
            }
        }

        public static void MultiTable() //2
        {
            Console.WriteLine("Give me a number:");
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} times from {1} = {2}", i, number, i * number);
            }
        }

        public static void SumEvenNumbers() //2
        {
            List<long> lista = new List<long>();
            Random number = new Random();

            for (int i = 0; i < 101; i++)
            {
                int num = number.Next();
                if (num % 2 == 0)
                {
                    lista.Add(num);
                }
            }

            var sum = lista.Sum();
            Console.WriteLine(sum);


        }

        public static void Stars() //2
        {

            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
                Console.Write(" ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public static void PatternNumbers1() //2
        {

            for (int i = 1; i < 5; i++)
            {
                Console.Write(1);
                Console.Write(" ");
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + 1);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public static void PatternNumbers2() //3
        {

            for (int i = 1; i < 5; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        public static void PatternNumbers3() //3
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i+1; k++)
                {
                    Console.Write(" *");
                   
                }
                Console.WriteLine();
            }
        }

        public static void NNumbers() //3
        {
            int number, sum = 0, y = 1;
            Console.WriteLine("Give me the N term");
            Console.Write("N term: ");
            number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} + ", y);
                sum = sum + y;
                y = (y * 10) + 1;
            }

            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
