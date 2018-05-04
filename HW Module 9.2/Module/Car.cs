using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{ /*2.	Создать производные классы: Легковая_машина (марка, номер, скорость, грузоподъемность),
    со своими методами вывода информации на экран, и определения грузоподъемности.*/
    public class Car : Trans
    {
        public override int CarryingCapacity()
        {
          return CarryCap = r.Next(300, 600);
            
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Car's Marks " + Marcs);
            Console.WriteLine("Car's Number " + Number);
            Console.WriteLine("Car's Speed" + Speed);
            Console.WriteLine("Car's Carrying Capacity" + CarryingCapacity());
        }
    }
}
