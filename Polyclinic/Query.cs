using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Polyclinic
{
    public class Query
    {
        private string connectionString;

        public void SetConnectionString(string path)
        {
            connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""{path}"";Persist Security Info=False;";
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

        public DataTable GenderQuery(string type)
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

                    string query = $"SELECT * FROM Пациенты WHERE Пол = '{type.Replace("'", "''")}'";

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
        public DataTable GetPatientsByFIO(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = @"SELECT * FROM Пациенты 
                         WHERE Фамилия LIKE ? 
                         AND  Имя LIKE ? 
                         AND Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                // Добавляем параметры с подстановкой % для LIKE
                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetDoctorsByFIO(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = @"SELECT * FROM Врачи 
                         WHERE Фамилия LIKE ? 
                         AND  Имя LIKE ? 
                         AND Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public DataTable GetMedicalRecordsByFIO(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Записи_в_медкарте.*
                                    FROM (Записи_в_медкарте
                                    INNER JOIN МедКарты ON Записи_в_медкарте.Id_медкарты = МедКарты.Id_медкарты)
                                    INNER JOIN Пациенты ON МедКарты.Id_пациента = Пациенты.Id_пациента
                                    WHERE Пациенты.Фамилия LIKE ?
                                    AND Пациенты.Имя LIKE ?
                                    AND Пациенты.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetMakeAnAppointment(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Запись_на_приём.*
                                FROM (Запись_на_приём
                                INNER JOIN Пациенты ON Запись_на_приём.Id_пациента = Пациенты.Id_пациента)
                                WHERE Пациенты.Фамилия LIKE ?
                                AND Пациенты.Имя LIKE ?
                                AND Пациенты.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetRecipes(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Рецепты.*
                                FROM ((Рецепты
                                INNER JOIN Записи_в_медкарте ON Рецепты.Id_записи_в_медкарте = Записи_в_медкарте.Id_записи_в_медкарте)
                                INNER JOIN МедКарты ON Записи_в_медкарте.Id_медкарты = МедКарты.Id_медкарты)
                                INNER JOIN Пациенты ON МедКарты.Id_пациента = Пациенты.Id_пациента
                                WHERE Пациенты.Фамилия LIKE ?
                                AND Пациенты.Имя LIKE ?
                                AND Пациенты.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetServicesProvided(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Оказанные_услуги.*
                                    FROM (Оказанные_услуги
                                    INNER JOIN Запись_на_приём ON Оказанные_услуги.Id_записи_на_приём = Запись_на_приём.Id_записи_на_приём)
                                    INNER JOIN Пациенты ON Запись_на_приём.Id_пациента = Пациенты.Id_пациента
                                    WHERE Пациенты.Фамилия LIKE ?
                                    AND Пациенты.Имя LIKE ?
                                    AND Пациенты.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetPayments(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Платежи.*
                                FROM ((Платежи
                                INNER JOIN Оказанные_услуги ON Платежи.Id_оказанной_услуги = Оказанные_услуги.Id_оказанной_услуги)
                                INNER JOIN Запись_на_приём ON Оказанные_услуги.Id_записи_на_приём = Запись_на_приём.Id_записи_на_приём)
                                INNER JOIN Пациенты ON Запись_на_приём.Id_пациента = Пациенты.Id_пациента
                                WHERE Пациенты.Фамилия LIKE ?
                                AND Пациенты.Имя LIKE ?
                                AND Пациенты.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        public DataTable GetAppointments(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Приёмы_врачей.*
                                FROM (Приёмы_врачей
                                INNER JOIN Врачи ON Приёмы_врачей.Id_врача = Врачи.Id_врача)
                                WHERE Врачи.Фамилия LIKE ?
                                AND Врачи.Имя LIKE ?
                                AND Врачи.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }


        public DataTable GetServicesProvidedDoctors(string surName, string firstName, string middleName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {

                string query = @"SELECT Оказанные_услуги.*
                                FROM ((Оказанные_услуги
                                INNER JOIN Запись_на_приём ON Оказанные_услуги.Id_записи_на_приём = Запись_на_приём.Id_записи_на_приём)
                                INNER JOIN Приёмы_врачей ON Запись_на_приём.Id_приёма_врача = Приёмы_врачей.Id_приёма_врача)
                                INNER JOIN Врачи ON Приёмы_врачей.Id_врача = Врачи.Id_врача
                                WHERE Врачи.Фамилия LIKE ?
                                AND Врачи.Имя LIKE ?
                                AND Врачи.Отчество LIKE ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);


                cmd.Parameters.AddWithValue("", $"%{surName}%");
                cmd.Parameters.AddWithValue("", $"%{firstName}%");
                cmd.Parameters.AddWithValue("", $"%{middleName}%");

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);

                    Console.WriteLine($"Найдено записей: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }
    }

}
