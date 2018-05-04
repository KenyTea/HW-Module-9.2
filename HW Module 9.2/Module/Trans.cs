using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{
    /* 1.	Создать абстрактный класс Trans с методами позволяющим вывести на экран информацию о транспортном средстве,
            а также определить грузоподъемность транспортного средства.*/

    public abstract class Trans
    {
        public string Marcs { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public int CarryCap { get; set; }

        public abstract void PrintInfo();

        public abstract double CarryingCapacity();
    }
}
