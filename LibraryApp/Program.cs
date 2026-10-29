using System;


namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Library library = new Library();

                library.AddBook(new Book { Id = 1, Title = "Война и мир", Author = "Л. Толстой" });
                library.AddBook(new Book { Id = 2, Title = "Преступление и наказание", Author = "Ф. Достоевский" });
                library.AddBook(new Book { Id = 3, Title = "Мастер и Маргарита", Author = "М. Булгаков" });


                library.BorrowBook(1);
                library.ReturnBook(1);


                library.BorrowBook(2);
                library.BorrowBook(2);


                library.ReturnBook(3);


                library.BorrowBook(99);

                Console.ReadKey();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Ошибка: передан пустой объект. " + ex.Message);
            }
        }
    }
}
