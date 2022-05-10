using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Lab4SQL
{
    class Program
    {
        static async Task SelectCustomers(SqlConnection sqlConnection)
        {
            string sqlSelectCustomers = "SELECT * FROM CUSTOMERS";

            using (SqlDataReader sqlReader = await (new SqlCommand(sqlSelectCustomers, sqlConnection).ExecuteReaderAsync()))
            {
                if (sqlReader.HasRows)
                {
                    string ColumnName1 = sqlReader.GetName(0);
                    string ColumnName2 = sqlReader.GetName(1);
                    string ColumnName3 = sqlReader.GetName(2);
                    string ColumnName4 = sqlReader.GetName(3);
                    string ColumnName5 = sqlReader.GetName(4);

                    Console.WriteLine($"{ColumnName1}\t{ColumnName2}\t{ColumnName3}\t{ColumnName4}\t{ColumnName5}");

                    while (await sqlReader.ReadAsync())
                    {
                        int CustomerID = sqlReader.GetInt32(0);
                        string FName = sqlReader.GetString(1);
                        string LName = sqlReader.GetString(2);
                        string PName = sqlReader.GetString(3);
                        int PassportID = sqlReader.GetInt32(4);

                        Console.WriteLine($"{CustomerID} \t{FName} \t{LName} \t{PName} \t{PassportID}");
                    }
                }
            }
        }

        static async Task SelectBrigades(SqlConnection sqlConnection)
        {
            string sqlSelectBrigades = "SELECT * FROM Brigades";

            using (SqlDataReader sqlReader = await (new SqlCommand(sqlSelectBrigades, sqlConnection).ExecuteReaderAsync()))
            {
                if (sqlReader.HasRows)
                {
                    string ColumnName1 = sqlReader.GetName(0);
                    string ColumnName2 = sqlReader.GetName(1);
                    string ColumnName3 = sqlReader.GetName(2);

                    Console.WriteLine($"{ColumnName1}\t{ColumnName2}\t{ColumnName3}");

                    while (await sqlReader.ReadAsync())
                    {
                        object BrigadeID = sqlReader.GetValue(0);
                        object BuildingCompanyID = sqlReader.GetValue(1);
                        object WorkersAmmount = sqlReader.GetValue(2);

                        Console.WriteLine($"{BrigadeID} \t{BuildingCompanyID} \t{WorkersAmmount}");
                    }
                }
            }
        }

        static async Task Main(string[] args)
        {
            string connectionString = @"Server=WIN-QDFDQARV5RR;Database=BuildingCompanyDB;Trusted_Connection=True;TrustServerCertificate=True";
            string sqlInsertCustomersExpretion = "INSERT INTO Customers VALUES('Alex', 'Shevchuk', 'Vadimovich', 6)";
            string sqlBrigadesTransactionExpretion = "UPDATE Brigades SET WorkersAmmount = WorkersAmmount + 10";
            string sqUpdateBrigadesExpretion = "UPDATE Brigades SET WorkersAmmount = WorkersAmmount - 10";
            string sqlDeleteCustomersExpretion = "DELETE FROM Customers WHERE PassportID = 6";
            string sqlAVGWorkersAmount = "SELECT AVG(WorkersAmmount) FROM Brigades";
            string MaterialsTotalPriceProc = "MaterialsTotalPriceOut";
            string sqlSelectBrigades = "SELECT * FROM Brigades";
            object avg;


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();

                Console.WriteLine("Customers before Insert:");

                await SelectCustomers(sqlConnection);

                Console.WriteLine("=========");

                SqlCommand sqlCommand = new SqlCommand(sqlInsertCustomersExpretion, sqlConnection);
                await sqlCommand.ExecuteNonQueryAsync();

                Console.WriteLine("Customers after Insert:");

                await SelectCustomers(sqlConnection);

                Console.WriteLine("=========");

                Console.WriteLine("Brigades before Update:");

                await SelectBrigades(sqlConnection);

                sqlCommand.CommandText = sqlAVGWorkersAmount;
                avg = await sqlCommand.ExecuteScalarAsync();

                Console.WriteLine($"AVG Workers Ammount: {avg}");

                sqlCommand.CommandText = sqUpdateBrigadesExpretion;
                await sqlCommand.ExecuteNonQueryAsync();

                Console.WriteLine("=========");

                Console.WriteLine("Brigades after Update:");

                await SelectBrigades(sqlConnection);

                sqlCommand.CommandText = sqlAVGWorkersAmount;
                avg = await sqlCommand.ExecuteScalarAsync();

                Console.WriteLine($"AVG Workers Ammount: {avg}");

                sqlCommand.CommandText = sqlDeleteCustomersExpretion;
                await sqlCommand.ExecuteNonQueryAsync();

                Console.WriteLine("=========");

                Console.WriteLine("Customers after Delete:");

                await SelectCustomers(sqlConnection);

                Console.WriteLine("=========");

                SqlParameter SumMaterialsParametr = new SqlParameter
                {
                    ParameterName = "@TotalPrice",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                sqlCommand.CommandText = MaterialsTotalPriceProc;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(SumMaterialsParametr);

                await sqlCommand.ExecuteNonQueryAsync();
                object sum = sqlCommand.Parameters["@TotalPrice"].Value;
                Console.WriteLine($"Stored Procedure result: {sum}");

                Console.WriteLine("=========");

                sqlCommand.CommandType = CommandType.Text;

                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;

                try
                {
                    sqlCommand.CommandText = sqlBrigadesTransactionExpretion;
                    await sqlCommand.ExecuteNonQueryAsync();

                    await sqlTransaction.CommitAsync();
                    Console.WriteLine("Transaction commited");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    await sqlTransaction.RollbackAsync();
                }

                Console.WriteLine("=========");

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlSelectBrigades, sqlConnection);

                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds);

                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        Console.Write($"{column.ColumnName}\t");
                    }

                    Console.WriteLine();

                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;

                        foreach (object cell in cells)
                        {
                            Console.Write($"{cell}\t");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}