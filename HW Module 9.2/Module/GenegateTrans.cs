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

        public void GeneratorCar() // генерирует автомобить
        {
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                car.Marcs = (Vehicale)rand.Next(0, 4);
                car.Number = Convert.ToString(rand.Next(1000, 9999));
                car.Speed = rand.Next(60, 150);
                car.CarryCap = car.CarryingCapacity();
                transport.Add(car); // закидываем в лист
            }
        }

        public void GeneranorCycle() // генерируем мото
        {
            for (int i = 0; i < 5; i++)
            {
                Motorcycle cycle = new Motorcycle();
                cycle.Marcs = (Vehicale)rand.Next(0, 4);
                cycle.Number = Convert.ToString(rand.Next(1000, 9999));
                cycle.Speed = rand.Next(60, 250);
                cycle.CarryCap = cycle.CarryingCapacity();
                transport.Add(cycle); // закидываем в лист
            }
        }

        public void GeneranorTrack() // генерируем мото
        {
            for (int i = 0; i < 5; i++)
            {
                Track track = new Track();
                track.Marcs = (Vehicale)rand.Next(0, 4);
                track.Number = Convert.ToString(rand.Next(1000, 9999));
                track.Speed = rand.Next(60, 250);
                track.CarryCap = track.CarryingCapacity();
                transport.Add(track); // закидываем в лист
            }
        }

        public void PrintAll()
        { 
            
            foreach (Trans item in transport)
            {
                Console.WriteLine("Marcs - " + item.Marcs);
                Console.WriteLine("Number - " + item.Number);
                Console.WriteLine("Speed - " + item.Speed);
                Console.WriteLine("Capasity - " + item.CarryCap);
                Console.WriteLine(" ");
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
