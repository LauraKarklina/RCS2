using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    class Taisnsturis
    {
        private double _garums;
        public double garums
        {
            get
            {
                return _garums;
            }
            set
            {
                if (value > 0)
                {
                    _garums = value;
                }

                else
                {
                    Console.WriteLine("Nederīga vērtība");
                }
            }
        }

        private double _augstums;
        public double augstums
        {
            get
            {
                return _augstums;
            }
            set
            {
                if (value > 0)
                {
                    _augstums = value;
                }
                
                else
                {
                    Console.WriteLine("Nederīga vērtība");
                }
            }
        }

        public Taisnsturis(double garums, double augstums)
        {
            this.garums = garums;
            this.augstums = augstums;
            

        }
        public double Laukums()
        {
            return garums*augstums;
        }
    }
}
