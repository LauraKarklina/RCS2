﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Studenti
    {
        public String vards { get; set; }
        public String uzvards { get; set; }

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

        public Studenti(String vards, String uzvards, int kurss)
        {
            this.vards = vards;
            this.uzvards = uzvards;
            _kurss = kurss;
            
        }
        public Studenti()
        {
            vards = "nav";
            uzvards = "nav";
            _kurss = 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss);
        }


    }
}
