using System;
using System.Collections.Generic;
using System.Text;

namespace LearningUWP_XAML.Models
{
    public class BookManager
    {
        public List<Book> Books { get; set; }
        public BookManager()
        {
            Books = new List<Book>();
            Books.Add(
                new Book {
                    Title = "Harry Potter and the Philosopher's Stone",
                    Author = "J. K. Rowling",
                    Rating = 4,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                    "when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the " +
                    "leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets " +
                    "containing Lorem Ipsum passages, and more recently with desktop publishing " +
                    "software like Aldus PageMaker including versions of Lorem Ipsum." }
            );
            Books.Add(
                new Book
                {
                    Title = "The Catcher in the Rye",
                    Author = "J. D. Salinger",
                    Rating = 4,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                    "when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the " +
                    "leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets " +
                    "containing Lorem Ipsum passages, and more recently with desktop publishing " +
                    "software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            );
            Books.Add(
                new Book
                {
                    Title = "The Great Gatsby",
                    Author = "F.Scott Fitzgerald",
                    Rating = 3,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                    "when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the " +
                    "leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets " +
                    "containing Lorem Ipsum passages, and more recently with desktop publishing " +
                    "software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            );
            Books.Add(
                new Book
                {
                    Title = "Twilight",
                    Author = "Stephenie Meyer",
                    Rating = 2,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                    "when an unknown printer took a galley of type and scrambled it to make a " +
                    "type specimen book. It has survived not only five centuries, but also the " +
                    "leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of Letraset sheets " +
                    "containing Lorem Ipsum passages, and more recently with desktop publishing " +
                    "software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            );
        }

        public Book AddBook(Book book)
        {
            if (book.GetType() == typeof(Book))
            {
                Books.Add(book);
                return book;
            }
            return null;
        }
    }
}
