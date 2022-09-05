using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            ShelveBook shelveBook1 = new ShelveBook("A", "7");
            ShelveBook shelveBook2 = new ShelveBook("B", "3");

        }
    }
}