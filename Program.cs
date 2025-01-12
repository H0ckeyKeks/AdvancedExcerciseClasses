using System;

namespace AdvancedExcerciseClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO
            Person Person = new Person("John", 30);

            Person.Greet();
        }
    }

    public class Person
    {
        // TODO
        private string _name;
        private int _age;

        public string Name
        {
            get 
            { 
                return _name; 
            }

            set 
            { 
                _name = value; 
            }
        }

        public int Age
        {
            get 
            { 
                return _age; 
            }

            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }
    }
}

