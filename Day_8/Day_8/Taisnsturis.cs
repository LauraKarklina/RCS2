using System;
using System.Collections.Generic;
using System.Text;

namespace Day_8
{
    class Taisnsturis
    {
        private int _garums;
        public int garums
        {
            get
            {
                return _garums;
            }
            set
            {
                if (value >= 1)
                {
                    _garums = value;
                }

                else
                {
                    Console.WriteLine("Nederīga vērtība");
                }
            }
        }

        private int _augstums;
        public int augstums
        {
            get
            {
                return _augstums;
            }
            set
            {
                if (value >= 1)
                {
                    _augstums = value;
                }
                
                else
                {
                    Console.WriteLine("Nederīga vērtība");
                }
            }
        }

        public Taisnsturis(int garums, int augstums)
        {
            this.garums = garums;
            this.augstums = augstums;
            

        }
        public void PrintInfo()
        {
            Console.WriteLine(garums*augstums);
        }
    }
}
