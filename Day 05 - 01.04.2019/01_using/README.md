# `using` 
* Every class that implements the `IDisposable` interface (built-in in c#) - must implement the `Dispose` function

```csharp
    //
    // Summary:
    //     Provides a mechanism for releasing unmanaged resources.
    public interface IDisposable
    {
        //
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or resetting
        //     unmanaged resources.
        void Dispose();
    }
}
```

* In open connection we use a `SqlConnection` object.    
    * The defenition of `SqlConnection` is:
    ```
    public sealed class SqlConnection : DbConnection, ICloneable
    ```
    * The defenition of `DbConnection`  is:
    ```
    public abstract class DbConnection : Component, IDbConnection, IDisposable
    ```
* Every time that we create an object of the `SqlConnection` class - we need to remember to call the `Dispose` function - to free all the resources

## The problem

* we have to open the connection
```csharp
// Summary:
//     Opens a database connection with the property settings specified by the System.Data.SqlClient.SqlConnection.ConnectionString.
//
// Exceptions:
//      T:System.InvalidOperationException: Cannot open a connection without specifying a data source or server.
//   T:System.Data.SqlClient.SqlException:
sql.Open();
```
* at the end - we have to close the connection
```csharp
// Summary:
//     Closes the connection to the database. This is the preferred method of closing
//     any open connection.
//
// Exceptions:
//   T:System.Data.SqlClient.SqlException:
//     The connection-level error that occurred while opening the connection.
public override void Close();
```
```csharp
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
                sql = new SqlConnection(connectionString))
                
                sql.Open();

                /* here the connection is open - and we can run CRUD*/


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sql.State != ConnectionState.Closed)
                {
                    sql.Dispose();
                }
            }
        }
    }
}

```

### The solution
```csharp
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
                using (sql = new SqlConnection(connectionString)){               
                    sql.Open();

                    /* here the connection is open - and we can run CRUD*/
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
```