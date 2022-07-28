using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6classes
{
    public class Mobile
    {
        private double _weight;
        public Mobile(string number, string model, double weight)
        {
            Weight = weight;
            Model = model;
            Number = number;
        }
       

       
        public double Weight  
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value < 0)
                {
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }

            }

        }

        public string Model
        {
            get;
            private set;
        }
        public string Number
        {
            get;
            set;
        }
        

        public void RecieveCall (string zvonok)
        {
            Console.WriteLine($"{zvonok} is calling you....");
        }
        
        public void SuperLoto (int index)
        {
            var random = new Random();
            var list = new List<string> { "Iphone", "Motorolla", "Pocophone", "Nokia" };
            index = random.Next(list.Count);
            Console.WriteLine(list[index]);

        }


    }
}
