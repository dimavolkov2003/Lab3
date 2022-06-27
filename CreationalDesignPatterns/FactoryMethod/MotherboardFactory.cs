using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Goods;

namespace CreationalDesignPatterns.FactoryMethod
{
    public class MotherboardFactory : OnlineComputerStore
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string ClassificationNumber { get; protected set; }
        public string SocketType { get; private set; }
        public string Сhipset { get; private set; }
        public int NumberOfProcessors { get; private set; }
        public string TypeOfRAM { get; private set; }
        public double FrequencySystemBus { get; private set; }
        public MotherboardFactory(string name, decimal price, string classificationNumber, string socketType,
            string chipset, int numberOfProcessors, string typeOfRAM, double frequencySystemBus)
        {
            Name = name;
            Price = price;
            ClassificationNumber = classificationNumber;
            SocketType = socketType;
            Сhipset = chipset;
            NumberOfProcessors = numberOfProcessors;
            TypeOfRAM = typeOfRAM;
            FrequencySystemBus = frequencySystemBus;
        }
        public override Good GetGood()
        {
            return new Motherboard(Name, Price, ClassificationNumber, SocketType, Сhipset, NumberOfProcessors, TypeOfRAM, FrequencySystemBus);
        }
    }
}
