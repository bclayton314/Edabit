using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Easy
{
    class Edabit_Easy
    {
        static void Main(string[] args)
        {

        }
        //CHECK IF THE SAME CASE
        public static bool SameCase(string str1)
        {
            if (str1 == str1.ToUpper())
            {
                return true;
            }
            else if (str1 == str1.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DIVIDES EVENLY
        public static bool dividesEvenly(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //IS THE NUMBER LESS THAN OR EQUAL TO ZERO?
        public static bool lessThanOrEqualToZero(double num1)
        {
            if (num1 <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //COMPARE STRINGS BY COUNT OF CHARACTERS
        public static bool Compare(string str1, string str2)
        {
            int count1 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                count1++;
            }
            int count2 = 0;
            for (int j = 0; j < str2.Length; j++)
            {
                count2++;
            }
            if (count1 == count2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //IS IT TIME FOR MILK AND COOKIES?
        public static bool xmasDate(int year, int month, int day)
        {
            if (month != 12 && day != 24)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //H4CK3R SP34K
        public static string HackerSpeak(string str1)
        {
            str1 = str1.Replace("a", "4");
            str1 = str1.Replace("e", "3");
            str1 = str1.Replace("i", "1");
            str1 = str1.Replace("o", "0");
            str1 = str1.Replace("s", "5");

            return str1;

        }

        //REVERSE STRING
        public static string Reverse(string str1)
        {
            char[] arr1 = str1.ToCharArray();
            int i = 0;
            int j = arr1.Length - 1;
            while (i < j)
            {
                char temp = arr1[i];
                arr1[i++] = arr1[j];
                arr1[j--] = temp;
            }
            return new String(arr1);
        }
    }
}
