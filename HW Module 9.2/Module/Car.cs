﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{ /*2.	Создать производные классы: Легковая_машина (марка, номер, скорость, грузоподъемность),
    со своими методами вывода информации на экран, и определения грузоподъемности.*/
    public class Car : Trans
    {
        

        public override double CarryingCapacity()
        {
            return 0;
        }

        public override void PrintInfo()
        {
        
        }
    }
}
