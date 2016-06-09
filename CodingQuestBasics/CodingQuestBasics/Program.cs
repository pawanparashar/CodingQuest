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
            GeneralQuest G = new GeneralQuest();

            var product = G.Product(3, 4);

            G.swap(4, 5);

            var sum = G.Sum(7, 8);

        }




    }
}
