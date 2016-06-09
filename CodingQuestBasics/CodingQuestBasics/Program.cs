using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            var number = P.Product(-3, -4);

            P.swap(3, 4);

        }


        //Product of two numbers without using *
        public int Product(int x,int y)
        {
            if(x<y)
            {
                return Product(y, x);
            }
            else if(y<0)
            {
                return -Product(x, -y);
            }
            else if(y!=0)
            {
                return x + Product(x, y - 1);
            }
            else
            {
                return 0;
            }

        }


        //Swap of two number without using Temp Variable

        public void swap(int x,int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

        }

    }
}
