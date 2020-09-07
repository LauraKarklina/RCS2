using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6_objekti
{
    class Studenti
    {
        public String vards;
        public String uzvards;

        private int _kurss;
        public int kurss
        {
            get
            {
                return _kurss;
            }
            set
            {
                if (_kurss > 3)
                {
                    _kurss = 3;
                }
                else if (_kurss < 1)
                {
                    _kurss = 1;
                }
            }
        }


        public void PrintInfo()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss +".kurss");
        }


    }
}
