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
                Person currentPerson = Act.NewPerson(i);
                Act._persons.Add(currentPerson);
            }
            Act.ShowPersons(Act._persons);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Всего: {count}");
            Console.Write("Выберите работу (0-3):");
            int work = int.Parse(Console.ReadLine());
            Console.Write("Выберите город (0-3):");
            int city = int.Parse(Console.ReadLine());
            Act.ShowPersons(Act._persons, (Work)work, (City)city);
        }
        

    }
}
