using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Easy2
{
    class Edabit_Easy2
    {
        static void Main(string[] args)
        {

            


        }

        //PALINDRONE - GO THROUGH NOTES
        public static bool Palindrome(string str1)
        {
            int j = str1.Length - 1;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str1[j])
                {

                    return false;
                }
                else
                {
                    j--;
                    return true;
                }
            }
            return false;
        }

        //DOUBLE LETTERS
        public static bool DoubleLetters(string word)
        {
            
            for (int i = 1; i < word.Length; i++)
            {

                if (word[i] == word[i - 1])
                {
                    return true;
                }

            }
            return false;
        }

        //INTRO TO RECURSION
        public static void Factorial(int num1)
        {
            int endOfCountdown = 0;

            if (num1 == endOfCountdown)
            {
                Console.WriteLine("BLAST OFF!");
            }
            else 
            {
                Factorial(num1 - 1);
            }
        }

        //RECURSION AGAIN
        public static int Factorial2(int num1)
        {
            int factNum1 = 0;
            
                factNum1 = num1 * Factorial2(num1 - 1);
                

            return factNum1;
        }

        //COUNT THE A'S
        public static int CountAsInText(string str1)
        {
            //go through each char in str1
            int i = 0;
            int count = 0;
            while (i < str1.Length)
            {
                if (str1[i] == 'a')
                {
                    count++;
                    i++;
                }
                i++;
            }
            return count;
        }

        //LAST DIGIT ULTIMATE
        public static bool DigitUltimate(int a, int b, int c)
        {
            int x, y, z;
            if (a >= 10)
            {
                x = a % 10;
            }
            else
            {
                x = a;
            }

            if (b >= 10)
            {
                y = b % 10;
            }
            else
            {
                y = b;
            }

            if (c >= 10)
            {
                z = c % 10;
            }
            else
            {
                z = c;            
            }
            if ((x*y)%10 == (z%10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //THE FARM PROBLEM
        public static int animals(int chickens, int cows, int pigs)
        {
            int x = chickens * 2;
            int y = cows * 4;
            int z = pigs * 4;
            int total = x + y + z;
            return total;
        }
    }
}
