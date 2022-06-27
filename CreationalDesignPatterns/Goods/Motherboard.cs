using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Goods
{
    public class Motherboard : Good
    {
        public string SocketType { get; private set; }
        public string Сhipset { get; private set; }
        public int NumberOfProcessors { get; private set; }
        public string TypeOfRAM { get; private set; }
        public double FrequencySystemBus { get; private set; }
        public Motherboard(string name, decimal price, string classificationNumber, string socketType,
            string chipset, int numberOfProcessors, string typeOfRAM, double frequencySystemBus) : base(name, price, classificationNumber)
        {
            SocketType = socketType;
            Сhipset = chipset;
            NumberOfProcessors = numberOfProcessors;
            TypeOfRAM = typeOfRAM;
            FrequencySystemBus = frequencySystemBus;
        }
        public override void Info()
        {
            Console.WriteLine("Name - {0}\nPrice - {1}\nClassificationNumber - {2}\n" +
                "SocketType - {3}\nСhipset - {4}\nNumberOfProcessors - {5}\nTypeOfRAM - {6}\nFrequencySystemBus - {7}", 
                Name, Price, ClassificationNumber, SocketType, Сhipset, NumberOfProcessors, TypeOfRAM, FrequencySystemBus);
        }
    }
}
