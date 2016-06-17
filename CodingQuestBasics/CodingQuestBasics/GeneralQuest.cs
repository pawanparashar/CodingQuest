using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestBasics
{
    class GeneralQuest
    {


        //Product of two numbers without using *
        public int Product(int x, int y)
        {
            if (x < y)
            {
                return Product(y, x);
            }
            else if (y < 0)
            {
                return -Product(x, -y);
            }
            else if (y != 0)
            {
                return x + Product(x, y - 1);
            }
            else
            {
                return 0;
            }

        }


        //Swap of two number without using Temp Variable
        public void swap(int x, int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

        }

        //sum of two numbers without using +
        public int Sum(int x, int y)
        {

            if (x == 0)
            {
                return y;
            }
            else
            {
                return Sum((x & y) << 1, x ^ y);
            }

        }


        //bitwise Add
        public int bitsum(int x,int y)
        {
            while (y != 0)
            {
                int carry = x & y;
                x = x ^ y;
                y = carry << 1;
            }
            return x;
        }

        //Reverse a String
        public string Reverse(string str)
        {
            string result = "";

            for(int i= str.Length-1 ; i>=0;i--)
            {
                result = result + str[i];

            }
            return result;
        }
      

        //remove duplicates from string 

        public string RemoveDuplicates(string str)
        {
            List<char> temp = new List<char>();
            int i = 0;
            string result = "";
            while(i<str.Length)
            {
                if(temp.Contains(str[i]))
                {
                    i++;
                }
                else
                {                    temp.Add(str[i]);
                    result += str[i].ToString();
                    i++;

                }


            }

            return result;

        }


        //char and count of number of times it repeats 

        public string CharandNumberofTimes(string str)
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            int i = 0;
            string result="";
            
            while(i<str.Length)
            {
                if(d1.ContainsKey(str[i]))
                {
                    d1[str[i]]++;
                    i++;

                }
                else
                {
                    d1.Add(str[i], 1);
                    i++;
                }
            }

           foreach(KeyValuePair<char,int> temp in d1)
            {

                result += temp.Key.ToString() + temp.Value;
            }
            return result;
        }

        //merge two sorted int array

        public int[] MergetwosortedArray(int[] a,int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            while (i<a.Length && j<b.Length)
            {
                if(a[i]>b[j])
                {
                    result[k++] = b[j++];
                }
                else
                {
                    result[k++] = a[i++];
                }


            }

            while(i<a.Length)
            {
                result[k++] = a[i++];
            }
            while (j < b.Length)
            {
                result[k++] = b[j++];
            }

            return result;


        }


    }
}
