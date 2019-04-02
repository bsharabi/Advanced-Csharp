### `C` - create
when we run a `insert` query we get as result - the number of rows (int)
### `R` - read
when we run a `select` query we get as result:
    * one or more records (for example: get all the details of the user that has id 2, or get all the details of all the users)
    * one element (for example: get the name of the user that has id 2)
### `U` - update
when we run a `update` query we get as result - the number of rows (int)
### `D` - delete
when we run a `delete` query we get as result - the number of rows (int)


# Execute query with SqlCommand in csharp
* ExecuteNonQuery (for: create, update, delete)
```csharp
   // Summary:
    //     Executes a Transact-SQL statement against the connection and returns the number of rows affected.
    public override int ExecuteNonQuery();
```
`SqlCommand` has 3 options to run query:
* ExecuteScalar  (for: read - one element)
```csharp
    // Summary:
    //     Executes the query, and returns the first column of the first row in the result set returned by the query. Additional columns or rows are ignored.

    public override object ExecuteScalar();
```
* ExecuteReader (for: read)
```csharp
 // Summary:
    //     Sends the System.Data.SqlClient.SqlCommand.CommandText to the System.Data.SqlClient.SqlCommand.Connection
    //     and builds a System.Data.SqlClient.SqlDataReader.
    //
    // Returns:
    //     A System.Data.SqlClient.SqlDataReader object.
    //
    public SqlDataReader ExecuteReader();
```