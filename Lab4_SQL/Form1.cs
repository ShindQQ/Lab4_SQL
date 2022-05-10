﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_SQL
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Server=WIN-QDFDQARV5RR;Database=BuildingCompanyDB;Trusted_Connection=True;TrustServerCertificate=True";
        static public SqlConnection sqlConnection = new SqlConnection(connectionString);
        static DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string sqlInsertCustomersExpretion = "INSERT INTO Customers VALUES('Alex', 'Shevchuk', 'Vadimovich', 6)";
            string sqlSelectCustomers = "SELECT * FROM CUSTOMERS";

            SqlCommand sqlCommand = new SqlCommand(sqlInsertCustomersExpretion, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            adapter = new SqlDataAdapter(sqlSelectCustomers, connectionString);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string sqUpdateBrigadesExpretion = "UPDATE Brigades SET WorkersAmmount = WorkersAmmount - 10";
            string sqlSelectCustomers = "SELECT * FROM Brigades";

            SqlCommand sqlCommand = new SqlCommand(sqUpdateBrigadesExpretion, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            adapter = new SqlDataAdapter(sqlSelectCustomers, connectionString);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string sqlDeleteCustomersExpretion = "DELETE FROM Customers WHERE PassportID = 6";
            string sqlSelectCustomers = "SELECT * FROM CUSTOMERS";

            SqlCommand sqlCommand = new SqlCommand(sqlDeleteCustomersExpretion, sqlConnection);
            sqlCommand.ExecuteNonQuery();

            adapter = new SqlDataAdapter(sqlSelectCustomers, connectionString);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();
        }

        private void Scalar_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string sqlAVGWorkersAmount = "SELECT AVG(WorkersAmmount) AS average_WorkersAmmount FROM Brigades";

            SqlCommand sqlCommand = new SqlCommand(sqlAVGWorkersAmount, sqlConnection);
            sqlCommand.ExecuteScalar();

            adapter = new SqlDataAdapter(sqlAVGWorkersAmount, connectionString);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();
        }

        private void Procedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string MaterialsTotalPriceProc = "MaterialsTotalPriceOut";

            SqlParameter SumMaterialsParametr = new SqlParameter
            {
                ParameterName = "@TotalPrice",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            SqlCommand sqlCommand = new SqlCommand(MaterialsTotalPriceProc, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(SumMaterialsParametr);
            sqlCommand.ExecuteScalar();

            object sum = sqlCommand.Parameters["@TotalPrice"].Value;
            MessageBox.Show($"Stored Procedure result: {sum}");

            sqlConnection.Close();
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            string sqlBrigadesTransactionExpretion = "UPDATE Brigades SET WorkersAmmount = WorkersAmmount + 10";
            string sqlSelectCustomers = "SELECT * FROM Brigades";

            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand(sqlBrigadesTransactionExpretion, sqlConnection);

            sqlCommand.Transaction = sqlTransaction;
            sqlCommand.ExecuteScalar();

            try
            {
                sqlCommand.ExecuteNonQuery();

                sqlTransaction.Commit();
                MessageBox.Show("Transaction commited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlTransaction.Rollback();
            }

            adapter = new SqlDataAdapter(sqlSelectCustomers, connectionString);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            sqlConnection.Close();
        }
    }
}