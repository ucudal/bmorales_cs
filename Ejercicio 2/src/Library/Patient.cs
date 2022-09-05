using System;

namespace Library
{    public class Patient
    {
        public string Name { get ; set ; }

        public Patient(String name)
        {
            this.Name = name;
            Console.WriteLine($"Patient name: {name}");
        }
    }
}