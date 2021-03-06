﻿using HW_Module_9._2.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_9._2
{
    /*Задание 2
1.	Создать абстрактный класс Trans с методами позволяющим вывести на экран информацию о транспортном средстве,
а также определить грузоподъемность транспортного средства.
2.	Создать производные классы: Легковая_машина (марка, номер, скорость, грузоподъемность),
Мотоцикл (марка, номер, скорость, грузоподъемность, наличие коляски, при этом если коляска отсутствует,
то грузоподъемность равна 0), Грузовик (марка, номер, скорость, грузоподъемность, наличие прицепа,
при этом если есть прицеп, то грузоподъемность увеличивается в два раза) 
со своими методами вывода информации на экран, и определения грузоподъемности.
3.	Создать базу (массив) из n машин, вывести полную информацию из базы на экран, 
а также организовать поиск машин, удовлетворяющих требованиям грузоподъемности.

*/
    class Program
    {
        static void Main(string[] args)
        {
            List<Trans> tr = new List<Trans>();
            GenegateTrans gen = new GenegateTrans();
            gen.GeneratorCar();
            gen.GeneranorCycle();
            gen.GeneranorTrack();
            gen.PrintAll();

            Console.WriteLine("Введите объём груза ");
            int temp = Int32.Parse(Console.ReadLine());
            
            gen.Found(temp);
        }
    }
}

