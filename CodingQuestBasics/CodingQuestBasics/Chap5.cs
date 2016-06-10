using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace CodingQuestBasics
{
    // ***  Primitive Types ***
    // 5.1 Computing the parity of a word. . . . . . . . . . . . . . . . . . . . . . . . . . . . . 41 - Done
    // 5.2 Swap bits . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 43 - Done
    // 5.3 Reverse bits . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 44- Done
    // 5.4 Find a closest integer with the same weight . . . . . . . . . . . . . . . . . . . . . . 45- Done
    // 5.5 Compute x * y without arithmetical operators . . . . . . . . . . . . . . . . . . . . 46- Done
    // 5.6 Compute x/y. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 47- Done
    // 5.7 Compute x power y . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 48- Done
    // 5.8 Reverse digits . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 49- Done
    // 5.9 Check if a decimal integer is a palindrome . . . . . . . . . . . . . . . . . . . . . . . 50- Done
    // 5.10 Generate uniform random numbers . . . . . . . . . . . . . . . . . . . . . . . . . . 51- Done
    // 5.11 Rectangle intersection . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 52
    class Chap5
    {

        // Method to compute parity of a word
        public bool _5_1_ComputeParity(int number)
        {

            var value = Convert.ToString(number, 2);
            bool result = true;

            for(int i =0;i<value.Length;i++)
            {
                if(value[i] == '1')
                {
                    result = !result;
                }
            }

            return result;

        }

        // method to swap bits of int value, X needs to be swaped with y
        public int _5_2_Swapbit(int number,int x,int y)
        {
            string values = Convert.ToString(number, 2);

            StringBuilder value = new StringBuilder();
            value.Append(values);

            char valueatx = value[x];
            char valueaty = value[y];

            value[x] = valueaty;
            value[y] = valueatx;


            values = value.ToString();
            int temp = Convert.ToInt32(values,2);

            return temp;
        }

        //method to Reverse bits
        public int _5_3_reversebits(int number)
        {
            string values = Convert.ToString(number, 2);

            string result = "";

            for(int i= values.Length-1; i>=0;i--)
            {

                result += values[i];

            }

            int results = Convert.ToInt32(result, 2);

            return results;

        }

        //method to find the closest integer with the same weight
        public int _5_4_Closestint(int number)
        {
            string values = Convert.ToString(number, 2);

            int countofone = values.Count(x => x == '1');

            for(int i=1;i<=number;i++)
            {
                int number1 = number - i;
                int number2 = number + i;

                string value1 = Convert.ToString(number1, 2);
                string value2 = Convert.ToString(number2, 2);

                if(value1.Count(x=>x=='1') == countofone)
                {
                    return number1;
                    
                }
                else if(value2.Count(x => x == '1') == countofone)
                {
                    return number2;
                }


            }

            return -1;

        }

        //method to x * y without arithmetical operators, handles both Postive and Negative -Used Recursion
        public int _5_5_Product(int x,int y)
        {
            if (x < y)
            {
                return _5_5_Product(y, x);
            }
            else if (y < 0)
            {
                return -_5_5_Product(x, -y);
            }
            else if (y != 0)
            {
                return x + _5_5_Product(x, y - 1);
            }
            else
            {
                return 0;
            }

        }

        //method to Compute x/y without arithmetical operators, handles both Postive and Negative -Used Recursion
        public int _5_6_Divde(int x,int y,int result)
        {
            if(x<0)
            {
                return -_5_6_Divde(-x, y,result);
            }
            else if(y<0)
            {
                return -_5_6_Divde(x, -y, result);
            }
            else if(x<0 & y<0)
            {
                return _5_6_Divde(-x, -y, result);
            }
            else if(x>=y)
            {
                result++;
                return _5_6_Divde(x-y,y, result);
            }
            else
            {
                return result;
            }

        }

        //method to compute x power y
        public int _5_7_xpowery(int x,int y)
        {
            if(y==1)
            {
                return x;
            }
            else
            {
                return x * _5_7_xpowery(x, y - 1);
            }

        }

        //method to compute Reverse digits
        public int _5_8_ReverseDigit(int x,int rev)
        {
            if(x<0)
            {
                return -_5_8_ReverseDigit(-x,rev);
            }
            else if(x==0)
            {
                return rev;
            }
            else
            {
                
                return _5_8_ReverseDigit(x / 10,rev*10+x%10);
            }

        }

        //check if the give number is palindrome
        public bool _5_9_ispalindrome(int x)
        {
            int rev = _5_8_ReverseDigit(x,0);

            if(rev == x)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // method to random numbers
        public int _5_10_RandomNub(int x,int y)
        {

            Random r1 = new Random();
            return r1.Next(x, y);



        }




    }
}
