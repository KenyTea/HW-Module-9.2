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

        public void Generator()
        {
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Car car = new Car();
                temp = rand.Next(0, 4);
                car.Marcs = temp;
            }
        }
    }
}
