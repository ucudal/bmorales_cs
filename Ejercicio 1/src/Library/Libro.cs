using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            Console.WriteLine($"Title: {title}, Author: {author}, Code: {code}");
        }

        // ShelveBook should be a constructor of another class
        // public void ShelveBook(String sector, String shelve)
        // {
        //     this.LibrarySector = sector;
        //     this.LibraryShelve = shelve;
        // }

    }
}
