using _00_DAL;
using _01_BOL;
using System.Collections.Generic;
using System.Linq;

namespace _02_BLL
{
    public class AuthorManager
    {
        // Create
        public bool AddAuthor(AuthorModel newAuthor)
        {
            using(BookStoreEntities ef=new BookStoreEntities())
            {
                Author author = new Author() {
                    AuthorAge = newAuthor.AuthorAge,
                    AuthorName = newAuthor.AuthorName,
                    AuthorImage = newAuthor.AuthorImage
                };
                ef.Authors.Add(author);

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
        public List<AuthorModel> GetAllAuthors()
        {
            List<AuthorModel> authors = new List<AuthorModel>();
            using (BookStoreEntities ef = new BookStoreEntities())
            {
                foreach (Author item in ef.Authors)
                {
                    authors.Add(new AuthorModel()
                    {
                        AuthorAge=item.AuthorAge,
                        AuthorName=item.AuthorName,
                        AuthorImage=item.AuthorImage
                    });
                }
            }
            return authors;
        }

        public AuthorModel GetAuthorById(int id)
        {
            AuthorModel author = null;
            using (BookStoreEntities ef = new BookStoreEntities())
            {
                Author item = ef.Authors.FirstOrDefault(a => a.AuthorID == id);
                if (item != null)
                {
                    author = new AuthorModel()
                    {
                        AuthorAge = item.AuthorAge,
                        AuthorName = item.AuthorName,
                        AuthorImage = item.AuthorImage
                    };
                }
            }
            return author;
        }

        // Update
        public bool UpdateAuthor(int id,AuthorModel author)
        {
            using (BookStoreEntities ef = new BookStoreEntities())
            {

               Author updatedAuthor= ef.Authors.FirstOrDefault(a => a.AuthorID == id);
               if (updatedAuthor == null)
                    return false;

                updatedAuthor.AuthorAge = author.AuthorAge;
                updatedAuthor.AuthorName = author.AuthorName;
                updatedAuthor.AuthorImage = author.AuthorImage;

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
        public bool DeleteAuthor(int id)
        {
            using (BookStoreEntities ef = new BookStoreEntities())
            {

                Author deletedAuthor = ef.Authors.FirstOrDefault(a => a.AuthorID == id);
                if (deletedAuthor == null)
                    return false;
                ef.Authors.Remove(deletedAuthor);

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
