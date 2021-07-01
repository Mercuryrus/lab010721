using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace lab010721
{
    class Program
    {
        static void Main()
        {
            Action Act = new Action();
            Console.WriteLine("Кол-во человек: ");
            int count = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < count; i++)
            {
                Person currentPerson = Act.NewPerson();
                Act._persons.Add(currentPerson);
            }
            Console.Clear();
            Act.ShowPersons(Act._persons);
            Console.WriteLine("Выберите работу (0-3):");
            int work = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите город (0-3):");
            int city = int.Parse(Console.ReadLine());
            Act.ShowPersons(Act._persons, (Work)work, (City)city);
        }
        

    }
}
