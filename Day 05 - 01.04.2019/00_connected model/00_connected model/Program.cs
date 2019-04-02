//ActiveX Data Objects (ADO)

using System;
using System.Data.SqlClient;

namespace _00_connected_model
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=DESKTOP-N3K7TRI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sql = null;


            try
            {
                using (sql = new SqlConnection(connectionString))
                {

                    sql.Open();

                    SqlCommand query = new SqlCommand("SELECT ProductName FROM Products WHERE ProductId=1", sql);
                   
                    // Executes the query, and returns the first column of the first row in the result set returned by the query. 
                    // Additional columns or rows are ignored.
                    object result = query.ExecuteScalar();

                    query.CommandText = "INSERT INTO [dbo].[Categories] ([CategoryName],[Description],[Picture]) VALUES ('Tech','Computers and more',NULL)";

                    // Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                    int rowsAffected = query.ExecuteNonQuery();

                    query.CommandText = "SELECT * FROM [dbo].[Categories]";

                    // Sends the CommandText to Sql Connection and builds a SqlDataReader.
                    SqlDataReader dataReader = query.ExecuteReader();



                    //Read() - Advances the SqlDataReader to the next record.
                    // Returns true if there are more rows; otherwise false.
                    while (dataReader.Read())
                    {


                        //Gets the number of fields in the System.Data.SqlClient.SqlDataReader that are not hidden.
                        int fieldCount = dataReader.VisibleFieldCount;

                        for (int i = 0; i < fieldCount; i++)
                        {
                            //GetValue() = Gets the value of the specified column in its native format.
                            Console.Write(dataReader.GetValue(i) + " | ");
                        }

                        Console.WriteLine("\n______________________________________________________");
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
