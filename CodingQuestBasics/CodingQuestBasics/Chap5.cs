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
    // 5.4 Find a closest integer with the same weight . . . . . . . . . . . . . . . . . . . . . . 45
    // 5.5 Compute x ⇥ y without arithmetical operators . . . . . . . . . . . . . . . . . . . . 46- Done
    // 5.6 Compute x/y. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 47
    // 5.7 Compute xy . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 48
    // 5.8 Reverse digits . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 49
    // 5.9 Check if a decimal integer is a palindrome . . . . . . . . . . . . . . . . . . . . . . . 50
    // 5.10 Generate uniform random numbers . . . . . . . . . . . . . . . . . . . . . . . . . . 51
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

    }
}
