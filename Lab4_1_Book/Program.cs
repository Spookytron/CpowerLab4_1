using System;

namespace Lab4_1_Book
{
    class Book
    {
        public string fname;
        public string lname;
        public string id;
        public string pubname;
        public int copsold;

        public int Sell(int s)
        {
            return copsold= copsold + s;
        }
        public void DoPrint(Book n)
        {
            Console.WriteLine("Here are the requested statistics of this book.");
            Console.WriteLine($"Author's name is {n.fname} {n.lname}");
            Console.WriteLine($"The ID of this book is {n.id}");
            Console.WriteLine($"The amount of copies sold is currently {n.copsold}");

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book() { fname = "Frank", lname = "Lloyd", copsold = 100, id = "8675309", pubname = "Totally Real Publishing" };
            Book book2 = new Book() { fname = "Potato", lname = "Johnson", copsold = 50, id = "13543214", pubname = "Totally Real Publishing" };
            Book book3 = new Book() { fname = "Human", lname = "Person", copsold = 30, id = "15169251", pubname = "Totally Real Publishing" };



            book1.DoPrint(book1);
            book1.Sell(40);
            book1.DoPrint(book1);
            book2.DoPrint(book2);
            book2.Sell(10);
            book2.DoPrint(book2);
            book3.DoPrint(book3);
            book3.Sell(10);
            book3.DoPrint(book3);
        }
    }
}
