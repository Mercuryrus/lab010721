using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab010721
{
    class Person
    {
        private string _name;
        private string _guid;
        private int _age;
        private Work _work { get; }
        private City _city { get; }
        public Work ReturnWork
        {
            get => _work;
        }
        public City ReturnCity
        {
            get => _city;
        }

        public Person(string name, string guid, int age, Work work, City city)
        {
            _name = name;
            _guid = guid;
            _age = age;
            _work = (Work)work;
            _city = (City)city;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {_name} ID: {_guid} Age: {_age} Job: {_work.ToString()} City: {_city.ToString()}");
        }
        
    }
}
