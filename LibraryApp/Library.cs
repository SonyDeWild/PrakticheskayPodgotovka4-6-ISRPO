using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    /// <summary>
    /// Библиотека: хранит список книг, выдаёт и принимает книги.
    /// </summary>
    public class Library
    {
        private readonly List<Book> books = new List<Book>();

        /// <summary>
        /// Добавляет книгу в библиотеку.
        /// </summary>
        /// <param name="book">Добавляемая книга.</param>
        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            books.Add(book);
        }

        /// <summary>
        /// Ищет книгу по номеру.
        /// </summary>
        /// <param name="id">Номер книги.</param>
        /// <returns>Найденная книга или null, если её нет.</returns>
        public Book FindBook(int id)
        {
            // FirstOrDefault вернёт null, если книги с таким Id нет
            return books.FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Выдаёт книгу читателю.
        /// </summary>
        /// <param name="id">Номер книги.</param>
        public void BorrowBook(int id)
        {
            Book book = GetBookOrReport(id);
            if (book == null)
            {
                return;
            }

            if (!book.IsAvailable)
            {
                Console.WriteLine("Ошибка: книга \"" + book.Title + "\" уже выдана.");
                return;
            }

            book.IsAvailable = false;
            Console.WriteLine("Книга выдана: " + book.Title);
        }

        /// <summary>
        /// Принимает книгу обратно в библиотеку.
        /// </summary>
        /// <param name="id">Номер книги.</param>
        public void ReturnBook(int id)
        {
            Book book = GetBookOrReport(id);
            if (book == null)
            {
                return;
            }

            if (book.IsAvailable)
            {
                Console.WriteLine("Ошибка: книга \"" + book.Title + "\" не была выдана.");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine("Книга возвращена: " + book.Title);
        }

        /// <summary>
        /// Ищет книгу и выводит сообщение, если она не найдена.
        /// </summary>
        private Book GetBookOrReport(int id)
        {
            Book book = FindBook(id);
            if (book == null)
            {
                Console.WriteLine("Ошибка: книга с Id " + id + " не найдена.");
            }

            return book;
        }
    }
}