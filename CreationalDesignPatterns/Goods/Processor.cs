using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Goods
{
    public class Processor : Good
    {
        public string ConnectorType { get; private set; }
        public int NumberOfCores { get; private set; }
        public double ClockFrequency { get; private set; }
        public Processor(string name, decimal price, string classificationNumber, string connectorType,
            int numberOfCores, double clockFrequency) : base(name, price, classificationNumber)
        {
            ConnectorType = connectorType;
            NumberOfCores = numberOfCores;
            ClockFrequency = clockFrequency;
        }
        public override void Info()
        {
            Console.WriteLine("Name - {0}\nPrice - {1}\nClassificationNumber - {2}\n" +
                "ConnectorType - {3}\nNumberOfCores - {4}\nClockFrequency - {5} ", Name, Price, ClassificationNumber,
                ConnectorType, NumberOfCores, ClockFrequency);
        }
    }
}
