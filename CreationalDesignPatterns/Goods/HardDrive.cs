using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Goods
{
    public class HardDrive : Good
    {
        public string Capacity { get; private set; }
        public double Speed { get; private set; }
        public string ConnectionInterface { get; private set; }
        public HardDrive(string name, decimal price, string classificationNumber, string capacity, double speed,
            string connectionInterface) : base(name, price, classificationNumber)
        {
            Capacity = capacity;
            Speed = speed;
            ConnectionInterface = connectionInterface;
        }
        public override void Info()
        {
            Console.WriteLine("Name - {0}\nPrice - {1}\nClassificationNumber - {2}\n" +
                "Capacity - {3}\nSpeed - {4}\nConnectionInterface - {5} ", Name, Price, ClassificationNumber,
                Capacity, Speed, ConnectionInterface);
        }
    }
}
