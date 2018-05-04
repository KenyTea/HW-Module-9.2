using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{
    /*Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа,
при этом если есть прицеп, то грузоподъемность увеличивается в два раза) 
со своими методами вывода информации на экран, и определения грузоподъемности.*/

    public class Track : Trans
    {
        public int Trailer;

        public override int CarryingCapacity()
        {
            if ((Trailer = r.Next(0, 1)) == 1)
            {

                return CarryCap *= 2;
            }
            else
            {
                return CarryCap = r.Next(100, 1000);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Track's Marks " + Marcs);
            Console.WriteLine("Track's Number " + Number);
            Console.WriteLine("Track's Speed" + Speed);
            Console.WriteLine("Track's Carrying Capacity" + CarryingCapacity());
        }
    }
}
