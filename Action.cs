using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab010721
{
    class Action
    {
        public List<Person> _persons = new List<Person>();
        public Person NewPerson()
        {
            /*Console.WriteLine("Введите Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип работы (int): ");
            int work = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите город (int): ");
            int city = int.Parse(Console.ReadLine());*/
            string name = "Подопытный_" + (new Random().Next(0,100));
            int age = (new Random().Next(0, 100));
            int work = (new Random()).Next((int)Work.Unemployed, (int)Work.Seller + 1);
            int city = (new Random()).Next((int)City.SPb, (int)City.TUL + 1);
            string guid = Guid.NewGuid().ToString();
            Person Pers = new Person(name, guid, age, (Work)work, (City)city);
            return new Person(name, guid, age, (Work)work, (City)city);
        }
        
        public void ShowPersons(List<Person> _persons, Work currentWork = Work.Undefiend, City currentCity = City.Undefiend)
        {
            //var showPersons = _persons; 
            var showPersons = _persons
                .Where((x, y) => ((x.ReturnWork == currentWork) || (currentWork == Work.Undefiend)))
                .Where(y=> y.ReturnCity == currentCity || currentCity == City.Undefiend).ToList();

            foreach (var showPerson in showPersons)
            {
                showPerson.ShowInfo();                
            }
        }
    }
}
