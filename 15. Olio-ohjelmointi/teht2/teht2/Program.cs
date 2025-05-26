using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    public class Person
    {
        private string Name;
        private int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce(Person person)
        {
            Console.WriteLine($"Hello, my name is {Name}, and I'm {Age} years old.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Susanna", 31);
            person.Introduce(person);
        }
    }
}
