using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class RAMFactory : OnlineComputerStore
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string ClassificationNumber { get; protected set; }
        public int Memory { get; private set; }
        public string Type { get; private set; }
        public double Frequency { get; private set; }
        public int NumberOfSlats { get; private set; }
        public RAMFactory(string name, decimal price, string classificationNumber, int memory, string type,
            double frequency, int numberOfSlats)
        {
            Name = name;
            Price = price;
            ClassificationNumber = classificationNumber;
            Memory = memory;
            Type = type;
            Frequency = frequency;
            NumberOfSlats = numberOfSlats;
        }
        public override Good GetGood()
        {
            return new RAM(Name, Price, ClassificationNumber, Memory, Type, Frequency, NumberOfSlats);
        }
    }
}
