using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Polyclinic
{
    public class Query
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\ov4in\OneDrive\Рабочий стол\К.р. проект. бд\Поликлиника.mdb"";Persist Security Info=False;";

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
    }
}
