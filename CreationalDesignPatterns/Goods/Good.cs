using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Goods
{
    public abstract class Good
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string ClassificationNumber { get; protected set; }
        public Good(string name, decimal price, string classificationNumber)
        {
            Name = name;
            Price = price;
            ClassificationNumber = classificationNumber;
        }
        public abstract void Info();
    }
}
