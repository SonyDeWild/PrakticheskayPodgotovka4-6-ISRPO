namespace LibraryApp
{
    /// <summary>
    /// Книга в библиотеке.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Уникальный номер книги.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название книги.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Показывает, что книга сейчас в библиотеке (не выдана).
        /// </summary>
        public bool IsAvailable { get; set; } = true;
    }
}