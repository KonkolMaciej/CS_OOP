﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Instrumenty {
    class Program {
        static void Main(string[] args) {
            Instrument instr = new Instrument();
            Console.WriteLine("A - trąba");
            Console.WriteLine("B - bęben");
            char c = Console.ReadKey().KeyChar;
            instr.Graj2();
            switch (c) {
                case 'a':
                    instr = new Traba();
                    break;
                case 'b':
                    instr = new Beben();
                    break;
            }

            instr.Graj1();		//zawsze Cisza
            instr.Graj2();		// nie wiadomo, "użytkownik wybiera"
            Console.WriteLine("{0}", ((Instrument)instr).GetType());

            //Traba tr = new Traba();
            //tr.Graj1();
        }
    }
}
