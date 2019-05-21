using _00_DAL;
using _01_BOL;
using System.Collections.Generic;
using System.Linq;

namespace _02_BLL
{
    public class BookManager
    {
        // Create
        public bool AddBook(BookModel newBook)
        {
            using (BookStoreEntities ef = new BookStoreEntities())
            {
                //we can find the author by name - because the name is unique
                Author author = ef.Authors.FirstOrDefault(
                    a=>a.AuthorName==newBook.BookAuthor.AuthorName
                    );

                Book book = new Book()
                {
                    BookName = newBook.BookName,
                    BookPrice = newBook.BookPrice,
                    AuthorID = author.AuthorID
                };

                ef.Books.Add(book);

                try
                {
                    ef.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        // Read
        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();
            using (BookStoreEntities ef = new BookStoreEntities())
            {
                foreach (Book item in ef.Books)
                {
                    books.Add(
                        new BookModel()
                        {
                            BookName=item.BookName,
                            BookPrice=item.BookPrice,
                            BookAuthor= new AuthorModel()
                            {
                                AuthorAge = item.Author.AuthorAge,
                                AuthorName = item.Author.AuthorName,
                                AuthorImage = item.Author.AuthorImage
                            }
                        }
                        
                        );
                }
            }
            return books;
        }

        public BookModel GetBookById(int id)
        {
            BookModel book = null;
            using (BookStoreEntities ef = new BookStoreEntities())
            {
                Book item = ef.Books.FirstOrDefault(b => b.BookID == id);
                if (item != null)
                {
                    book = new BookModel()
                    {
                        BookName = item.BookName,
                        BookPrice = item.BookPrice,
                        BookAuthor = new AuthorModel()
                        {
                            AuthorAge = item.Author.AuthorAge,
                            AuthorName = item.Author.AuthorName,
                            AuthorImage = item.Author.AuthorImage
                        }
                    };
                }
            }
            return book;
        }

        // Update
        public bool UpdateBook(int id, BookModel book)
        {
            using (BookStoreEntities ef = new BookStoreEntities())
            {

                Book updatedBook = ef.Books.FirstOrDefault(b => b.BookID == id);
                if (updatedBook == null)
                    return false;

                updatedBook.BookName = book.BookName;
                updatedBook.BookPrice = book.BookPrice;

                try
                {
                    ef.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        // Delete
        public bool DeleteBook(int id)
        {
            using (BookStoreEntities ef = new BookStoreEntities())
            {

                Book deletedBook = ef.Books.FirstOrDefault(b => b.BookID == id);
                if (deletedBook == null)
                    return false;
                ef.Books.Remove(deletedBook);

                try
                {
                    ef.SaveChanges();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}
