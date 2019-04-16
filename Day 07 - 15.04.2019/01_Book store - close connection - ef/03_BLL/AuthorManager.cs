using _01_DAL;
using _02_BOL;
using System.Collections.Generic;

namespace _03_BLL
{
    public class AuthorManager
    {
        public static List<AuthorModel> GetAllAuthors()
        {
            List<AuthorModel> authors = new List<AuthorModel>();

            using(BookStoreEntities ef=new BookStoreEntities())
            {
                foreach (Author item in ef.Authors)
                {
                    authors.Add(new AuthorModel {
                        AuthorName=item.AuthorName,
                        AuthorAge=item.AuthorAge,
                        AuthorImage=item.AuthorImage
                    });
                }
            }
            return authors;
        }
    }
}
