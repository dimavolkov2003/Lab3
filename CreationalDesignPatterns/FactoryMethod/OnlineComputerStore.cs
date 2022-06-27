using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns.FactoryMethod
{
    public abstract class OnlineComputerStore
    {
        public abstract Good GetGood();
    }
}
