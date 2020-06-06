using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit
{
    class Edabit_VeryEasy
    {
        static void Main(string[] args)
        {
        }
        //FIRST EDABIT PROBLEM
        public static bool ReturnTrue()
        {
            return true;
        }
        //RETURN THE REMAINDER FROM TWO NUMBERS
        public static int Remainder(int x, int y)
        {
            int result = (x % y);
            return result;
        }
        //AREA OF A TRIANGLE
        public static int AreaOfTriangle(int base1, int height1)
        {
            int result = (base1 * height1) / 2;
            return result;
        }
        //LESS THAN 100?
        public static bool LessThan100(int num1, int num2)
        {
            int result = num1 + num2;
            if (result < 100)
            {
                return true;
            }
            else {
                return false;
            }
        }
        //MULTIPLE OF 100
        public static bool MultipleOf100(int num1)
        {
            if (num1 % 100 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
