using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Polyclinic
{
    public class Query
    {
        private string connectionString;

        public void SetConnectionString(string path)
        {
            connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""{path}"";Persist Security Info=False;";
        }
        public DataTable GetData(string dataQuery)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {dataQuery}";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public void SaveChangesToDB(DataTable dataTable, string tableName)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT * FROM {tableName}";
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);

                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();

                adapter.Update(dataTable);


            }   
        }

        public DataTable PaymentsQuery(string type)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Статус оплаты не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dataTable;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                 
                    string query = $"SELECT * FROM Платежи WHERE Статус_оплаты = '{type.Replace("'", "''")}'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке платежей: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public DataTable MakeAnAppointmentQuery(string type)
        {
            DataTable dataTable = new DataTable();

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Статус не указан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dataTable;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM Запись_на_приём WHERE Статус = '{type.Replace("'", "''")}'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
