using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class HardDriveFactory : OnlineComputerStore
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string ClassificationNumber { get; protected set; }
        public string Capacity { get; private set; }
        public double Speed { get; private set; }
        public string ConnectionInterface { get; private set; }
        public HardDriveFactory(string name, decimal price, string classificationNumber, string capacity, double speed,
            string connectionInterface)
        {
            Name = name;
            Price = price;
            ClassificationNumber = classificationNumber;
            Capacity = capacity;
            Speed = speed;
            ConnectionInterface = connectionInterface;
        }
        public override Good GetGood()
        {
            return new HardDrive(Name, Price, ClassificationNumber, Capacity, Speed, ConnectionInterface);
        }
    }
}
