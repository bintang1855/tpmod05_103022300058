﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod05_103022300058
{
    class Program
    {
        static void Main(string[] args)
        
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Bintang");

            DataGeneric<string> dataNIM = new DataGeneric<string>("103022300058");
            dataNIM.PrintData();
        }
    }
}
