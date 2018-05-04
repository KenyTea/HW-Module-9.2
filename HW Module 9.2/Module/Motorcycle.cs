using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{
    /*Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска отсутствует,
то грузоподъемность равна 0)
со своими методами вывода информации на экран, и определения грузоподъемности.*/

    public class Motorcycle : Trans
    {

        public bool Carriage = true;

        public override double CarryingCapacity()
        {
            if (!Carriage)
            {
                return CarryCap = 0;
            }
            else
            {
                return 0; //!!!!!!
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Motorcycle's Marks " + Marcs);
            Console.WriteLine("Motorcycle's Number " + Number);
            Console.WriteLine("Motorcycle's Speed" + Speed);
            Console.WriteLine("Motorcycle's Carrying Capacity " + CarryingCapacity());
        }
    }
}
