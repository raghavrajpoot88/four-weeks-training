using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Animal
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }
    class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Wooof");
        }

        public void Move()
        {
            Console.WriteLine("Running");
        }
    }
    class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meoow");
        }
        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }
    interface IMovable
    {
        void Move();
    }

