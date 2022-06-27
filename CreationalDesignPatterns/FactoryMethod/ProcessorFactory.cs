using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class ProcessorFactory : OnlineComputerStore
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string ClassificationNumber { get; protected set; }
        public string ConnectorType { get; private set; }
        public int NumberOfCores { get; private set; }
        public double ClockFrequency { get; private set; }
        public ProcessorFactory(string name, decimal price, string classificationNumber, string connectorType,
            int numberOfCores, double clockFrequency)
        {
            Name = name;
            Price = price;
            ClassificationNumber = classificationNumber;
            ConnectorType = connectorType;
            NumberOfCores = numberOfCores;
            ClockFrequency = clockFrequency;
        }
        public override Good GetGood()
        {
            return new Processor(Name, Price, ClassificationNumber, ConnectorType, NumberOfCores, ClockFrequency);
        }
    }
}
