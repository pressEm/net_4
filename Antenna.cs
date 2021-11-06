using System;
using System.Collections.Generic;
using System.Text;

namespace net_4
{
    public class Antenna
    {
        private double d;
        private string material;
        private int price;
        private double Q;

        public Antenna(double d, string material, int price)
        {
            this.d = d;
            this.material = material;
            this.price = price;
            this.Q = calculateQ();
        }

        public double calculateQ()
        {
            return d / price;
        }

        public void printInfo()
        {
            Console.WriteLine("Diametr = " + d + "\nMaterial = " + material + "\nPrice = " + price + "\nQ = " + Q);
        }

    }
}
