using System;
using System.Collections.Generic;
using System.Text;

namespace net_4
{
    class TypedAntenna : Antenna
    {
        private double d;
        private string material;
        private string P;
        private int price;
        private double Q;

        public TypedAntenna(double d, string material, int price, string type) : base(d, material, price)
        {
            this.d = d;
            this.material = material;
            this.price = price;
            this.P = type;
            calculateQ(type);
        }
        private void calculateQ(string type)
        {
            switch (type)
            {
                case "azimythal":
                    this.Q = calculateQ();
                    break;
                case "polar":
                    this.Q = 2*calculateQ();
                    break;
                case "toroidal":
                    this.Q = 2.5*calculateQ();
                    break;
            }
        }
        public void printInfo()
        {
            Console.WriteLine("Diametr = " + d + "\nMaterial = " + material + "\nPrice = " + price + "\nType = " + P + "\nQ = " + Q);
        }

    }
}
