using System;

namespace Library
{    public class Doctor
    {
        public string Name { get ; set ; }

        public Doctor(String name)
        {
            this.Name = name;
            Console.WriteLine($"Doctor name: {name}");
        }
    }
}