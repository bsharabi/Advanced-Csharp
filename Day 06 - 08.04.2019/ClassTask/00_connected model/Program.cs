//ActiveX Data Objects (ADO)

using System;
using System.Data.SqlClient;

namespace _00_connected_model
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=LAPTOP-NG4TFN0K\\SQLEXPRESS;Initial Catalog=task;Integrated Security=True";
            SqlConnection sql = null;


            try
            {
                using (sql = new SqlConnection(connectionString))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand("SELECT * FROM [dbo].[Author]", sql);

                    object result = query.ExecuteScalar();

                   // query.CommandText = "INSERT INTO [dbo].[Categories] ([CategoryName],[Description],[Picture]) VALUES ('Tech','Computers and more',NULL)";

                    int rowsAffected = query.ExecuteNonQuery();
                    //query.CommandText = "INSERT INTO [dbo].[Author]([AuthorName],[AuthorAge],[AuthorImage])VALUES('Naor',25,'https://24.media.tumblr.com/tumblr_lrd7olQSxF1qm2jvyo1_500.jpg');";

                    query.CommandText = "SELECT * FROM [dbo].[Author]";


                    
                    SqlDataReader dataReader = query.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int fieldCount = dataReader.VisibleFieldCount;

                        for (int i = 0; i < fieldCount; i++)
                            Console.Write(dataReader.GetValue(i) + " | ");
                      

                        Console.WriteLine("\n_________________________________________________________________________________");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
      
        }
    }
}


/*
 OUTPUT:
 _______________________
1 | Beverages | Soft drinks, coffees, teas, beers, and ales | System.Byte[] |
______________________________________________________
2 | Condiments | Sweet and savory sauces, relishes, spreads, and seasonings | System.Byte[] |
______________________________________________________
3 | Confections | Desserts, candies, and sweet breads | System.Byte[] |
______________________________________________________
4 | Dairy Products | Cheeses | System.Byte[] |
______________________________________________________
5 | Grains/Cereals | Breads, crackers, pasta, and cereal | System.Byte[] |
______________________________________________________
6 | Meat/Poultry | Prepared meats | System.Byte[] |
______________________________________________________
7 | Produce | Dried fruit and bean curd | System.Byte[] |
______________________________________________________
8 | Seafood | Seaweed and fish | System.Byte[] |
______________________________________________________
9 | Tech | The real life |  |
*/
