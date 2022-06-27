using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.FactoryMethod;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineComputerStore goods = new RAMFactory("1",11,"11",12,"sd",21.2,23);
            OnlineComputerStore goods2 = new ProcessorFactory("2", 12, "3223", "32323", 2, 32.4);
            List<Good> Goods = new List<Good>{
                goods.GetGood(),
                goods2.GetGood()
            };
            for (int i = 0; i < 2; i++)
            {
                Goods[i].Info();
                Console.WriteLine();
            }
        }
    }

}
