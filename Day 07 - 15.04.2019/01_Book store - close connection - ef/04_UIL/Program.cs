using _02_BOL;
using _03_BLL;
using System;
using System.Collections.Generic;

namespace _04_UIL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AuthorModel> myAuthors = AuthorManager.GetAllAuthors();
            foreach (AuthorModel item in myAuthors)
            {
                Console.WriteLine($"{item.AuthorName} is {item.AuthorAge} years old");
            }
        }
    }
}
