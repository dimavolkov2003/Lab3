using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Goods
{
    public class RAM : Good
    {
        public int Memory { get; private set; }
        public string Type { get; private set; }
        public double Frequency { get; private set; }
        public int NumberOfSlats { get; private set; }
        public RAM(string name, decimal price, string classificationNumber, int memory, string type,
            double frequency, int numberOfSlats) : base(name, price, classificationNumber)
        {
            Memory = memory;
            Type = type;
            Frequency = frequency;
            NumberOfSlats = numberOfSlats;
        }
        public override void Info()
        {
            Console.WriteLine("Name - {0}\nPrice - {1}\nClassificationNumber - {2}\n" +
                "Memory - {3}\nType - {4}\nFrequency - {5}\nNumberOfSlats -{6}", Name, Price, ClassificationNumber,
                Memory, Type, Frequency, NumberOfSlats);
        }
    }
}
