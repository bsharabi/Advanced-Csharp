using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class BookManager
    {

        //the UIL will call this function and send a BOL object
        //the BLL will add the object t the EF
        //and save the changes to the DAL
        public static void InsertBookByDbSet(BookModel newBook)
        {
            DbManager.ExecDb($"insert into dbo.Books(BookName, BookPrice, AuthorID) values ('{newBook.BookName}',{newBook.BookPrice},{newBook.AuthorID})");
        }

    }
}

