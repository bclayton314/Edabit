using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Edabit_Medium
{
    
    class Medium_LvlProb
    {
        static void Main(string[] args)
        {
            
        }

        //Find the Largest Numbers in a Group of Arrays
        public static double[] FindLargest(double[][] values)
        {
            double[] maxNumbers = new double[values.Length];

            int i = 0;
            foreach (double[] array in values)
            {
                maxNumbers[i] = array.Max();
                i++;
            }

            return maxNumbers;
        }

        //Reverse the Case
        public static string ReverseString(string str1)
        {
            string result = "";
            char[] inputArray = str1.ToCharArray();

            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += c.ToString().ToUpper();
                else if (char.IsUpper(c))
                    result += c.ToString().ToLower();
                else
                    result += c.ToString();
            }

            return result;
        }

        //Total of Even Numbers
        public static int EvenNum(int[] arr1)
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i]%2 == 0)
                {
                    sum += arr1[i];
                }
            return sum;
        }

        //LeetCode #206 - Reverse Linked List
        

        //Is Unique?
        public static bool UniqueCharacters(string str1)
        {
            //HAS TO USE A SORT TOO
            // If at any time we encounter 2 
            // same characters, return false 
            for (int i = 0; i < str1.Length; i++)
                for (int j = i + 1; j < str1.Length; j++)
                    if (str1[i] == str1[j])
                        return false;

            // If no duplicate characters 
            // encountered, return true 
            return true;
        }
        //IS UNIQUE? 2
        static bool isUnique(string s)
        {
            int[] count = new int[256];

            Array.Clear(count, 0, count.Length - 1);

            foreach (char c in s)
            {
                if (++count[c] > 1)
                    return false;
            }
            return true;
        }

        //Find the Most Repeated Character in a String
        static char MostRepeatedChar(string str1)
        {
            int[] count = new int[256];
            int max = 0;
            Char result = Char.MinValue;
            Array.Clear(count, 0, count.Length - 1);


            foreach (char c in str1) 
                if (++count[c] > max)
                {
                    max = count[c];
                    result = c;
                }
            return result;
        }

        //Remove Duplicates from an Unsorted list
        public static void deleteDuplicate()
        {
           
            
        }
        



        //Reverse the order of a string
    }
}
