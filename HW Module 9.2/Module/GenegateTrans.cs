using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2.Module
{
    

    public class GenegateTrans
    {
        private Random rand = new Random();
        public List<Trans> transport;
        public GenegateTrans()
        {
            transport = new List<Trans>();

        }

        public void GeneratorCar()
        {
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                temp = rand.Next(0, 4);
                car.Marcs = (Vehicale)temp;
                car.Number = Convert.ToString(rand.Next(1000, 9999));
                car.Speed = rand.Next(60, 200);
                car.CarryCap = car.CarryingCapacity();
                transport.Add(car);
            }
        }
    }
}
