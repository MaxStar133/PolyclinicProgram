using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using ParametricQuery;
using AboutProgram;
using System.ComponentModel;
namespace Polyclinic
{
    public partial class MainWindow : Form
    {
        Query query = new Query();
        public MainWindow()
        {
            InitializeComponent();
            ButtonDisabled();
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ButtonDisabled();
            if (e.Node.Text == "Врачи")
            {
                DataTable data = query.GetData("Врачи");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Диагнозы")
            {
                DataTable data = query.GetData("Диагнозы");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
                dataGridView1.Sort(dataGridView1.Columns["Id_диагноза"], ListSortDirection.Ascending);
            }

            else if (e.Node.Text == "Записи в медкарте")
            {
                DataTable data = query.GetData("Записи_в_медкарте");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Запись на приём")
            {
                DataTable data = query.GetData("Запись_на_приём");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Кабинеты")
            {
                DataTable data = query.GetData("Кабинеты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Лекарства")
            {
                DataTable data = query.GetData("Лекарства");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Медицинские услуги")
            {
                DataTable data = query.GetData("Медицинские_услуги");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Медкарты")
            {
                DataTable data = query.GetData("Медкарты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Оказанные услуги")
            {
                DataTable data = query.GetData("Оказанные_услуги");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Отделения")
            {
                DataTable data = query.GetData("Отделения");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Пациенты")
            {
                DataTable data = query.GetData("Пациенты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Платежи")
            {
                DataTable data = query.GetData("Платежи");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Приёмы врачей")
            {
                DataTable data = query.GetData("Приёмы_врачей");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Рецепты")
            {
                DataTable data = query.GetData("Рецепты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

            else if (e.Node.Text == "Специальности")
            {
                DataTable data = query.GetData("Специальности");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }

        }
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Создаем новую строку
                DataRow newRow = dataTable.NewRow();
                dataTable.Rows.Add(newRow);
                // Переходим в режим редактирования новой строки
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                dataGridView1.BeginEdit(true);
                ButtonEnabled();
            }
            else
            {
                MessageBox.Show("DataGridView не привязан к DataTable!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Принудительно завершаем редактирование
                if (dataGridView1.IsCurrentCellInEditMode)
                {
                    dataGridView1.EndEdit();
                }

                // Получаем последнюю добавленную строку
                DataRow currentRow = dataTable.Rows[dataTable.Rows.Count - 1];
                try
                {
                    string tableName = treeView1.SelectedNode.Text.Replace(" ", "_");
                    // Сохраняем в БД - если будет исключение, код ниже не выполнится
                    query.SaveChangesToDB(dataTable, tableName);
                    // Только если SaveChangesToDB выполнилось без исключений:
                    dataGridView1.EndEdit();
                    ButtonDisabled();
                }
                catch (OleDbException ex)
                {
                    string errorMessage = "Ошибка базы данных:\n";
                    foreach (OleDbError error in ex.Errors)
                    {
                        errorMessage += $"- {error.Message}\n";
                    }
                    MessageBox.Show(errorMessage, "Ошибка сохранения",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonEnabled();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Отменяем изменения
                dataTable.RejectChanges();
                ButtonDisabled();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для редактирования", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            dataGridView1.BeginEdit(true);
            ButtonEnabled();
        }
        private void ButtonEnabled()
        {
            buttonAddition.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEndEdit.Enabled = true;
            buttonCancelEdit.Enabled = true;
            dataGridView1.ReadOnly = false;
        }
        private void ButtonDisabled()
        {
            buttonEdit.Enabled = true;
            buttonAddition.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEndEdit.Enabled = false;
            buttonCancelEdit.Enabled = false;
            dataGridView1.ReadOnly = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранная строка
            if (dataGridView1.SelectedRows.Count == 0) return;

            // Простое подтверждение удаления
            if (MessageBox.Show("Удалить запись?", "Подтверждение",
                               MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            // Получаем выбранную строку
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Удаляем строку из DataTable
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                try
                {
                    // Удаление строки
                    ((DataRowView)selectedRow.DataBoundItem).Row.Delete();

                    // Сохраняем изменения в БД
                    query.SaveChangesToDB(dataTable, treeView1.SelectedNode.Text.Replace(" ", "_"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                    dataTable.RejectChanges(); // Откатываем изменения при ошибке
                }
            }
        }
     
        
        private void оплаченныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.PaymentsQuery("Оплачено");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
        private void неоплаченныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.PaymentsQuery("Не оплачено");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
        private void ожидаютсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.PaymentsQuery("Ожидается");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void зToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.MakeAnAppointmentQuery("Завершён");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
        private void отменённыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.MakeAnAppointmentQuery("Отменён");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void ожидаютсяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable data = query.MakeAnAppointmentQuery("Запланирован");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void мужчиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.GenderQuery("М");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;        
        }

        private void женщиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = query.GenderQuery("Ж");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем введенные данные
                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetPatientsByFIO(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void поискПоФИОToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetDoctorsByFIO(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void записиВМедкартеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetMedicalRecordsByFIO(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void записиНаПриёмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetMakeAnAppointment(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abouutPogram = new AboutProgramWindow();
            abouutPogram.ShowDialog();
        }

        private void рецептыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetRecipes(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void оказанныеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetServicesProvided(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }       
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetPayments(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void приёмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetAppointments(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void оказанныеУслугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var searchForm = new ParametricWindow())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                    string lastName = searchForm.SurName;
                    string firstName = searchForm.FirstName;
                    string middleName = searchForm.MiddleName;

                    try
                    {
                        DataTable result = query.GetServicesProvidedDoctors(lastName, firstName, middleName);
                        dataGridView1.DataSource = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка поиска: {ex.Message}", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 