using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_Easy3
{
    class Edabit_Easy3
    {
        static void Main(string[] args)
        {
            

        }

        //Xs and Os, Nobody Knows
        public static bool XO(string str1)
        {
            string str2 = str1.ToLower();
            char x = 'x';
            char o = 'o';
            int counter1 = 0;
            int counter2 = 0;
            for (int i = 0; i < str2.Length - 1; i++)
                if (str2[i] == x)
                {
                    counter1++;
                }
                else if(str2[i] == o)
                {
                    counter2++;
                }

            if (counter1 == 0)
                if (counter2 == 0)
                    {
                        return true;
                     }
                else
                {
                    return false;
                }
            else if (counter1 == counter2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int MissingNum(int[] arr1)
        {
            int sumTen = 55;
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                counter += arr1[i];
            }

            int result = sumTen - counter;
            return result;
        }
        //Is the String Empty
        public static bool EmptyString(string str1)
        {
            if (str1 == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Alphabet Soup
        public static string AlphabetSoup(string str1)
        {
           char[] arr1 = str1.ToCharArray();
           char temp;

           for (int i = 1; i < str1.Length; i++)
               for (int j = 0; j < str1.Length - i; j++)

                   if (arr1[j] > arr1[j + 1])
                   {
                       temp = arr1[j];
                       arr1[j] = arr1[j + 1];
                       arr1[j + 1] = temp;
                   }
            return new string(arr1);
        }

        //Convert Minutes into Seconds
        public static int MinToSeconds(int minutes)
        {
            int seconds = minutes * 60;
            return seconds;
            
        }

        //Vowel Replacer
        public static string VowelReplacer(string str1, string ch)
        {
            char a = 'a';
            char e = 'e';
            char i = 'i';
            char o = 'o';
            char u = 'u';

            
            char[] char1 = ch.ToCharArray();
            char[] char2 = str1.ToCharArray();

            for (int j = 0; j < char2.Length; j++)
            {
                if (char2[j] == a)
                {
                    char2[j] = char1[0];
                }
                else if (char2[j] == e)
                {
                    char2[j] = char1[0];
                }
                else if (char2[j] == i)
                {
                    char2[j] = char1[0];
                }
                else if (char2[j] == o)
                {
                    char2[j] = char1[0];
                }
                else if (char2[j] == u)
                {
                    char2[j] = char1[0];
                }
            }
            return new string(char2);
        }

        //Return the Next Integer
        public static int Addition(int num1)
        {
            num1++;
            return num1;
        }

        //Equality of 3 Values
        public static int EqualThree(int a, int b, int c)
        {
            var matches = 0;
            if (a == b)
            {
                matches++;
            }
            if (a == c) 
            {
                matches++;
            }
            if (b == c) 
            {
                matches++;
            }
            if (matches == 1)
            {
                matches = 2;
            }
                
            return matches;
        }
    }
}
