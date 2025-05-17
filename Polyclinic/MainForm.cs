using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MainWindow : Form
    {
        Query query = new Query();
        public MainWindow()
        {
            InitializeComponent();
            buttonEndEdit.Enabled = false;
            buttonCancelEdit.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            buttonAddition.Enabled = true;
            buttonEndEdit.Enabled = false;
            buttonCancelEdit.Enabled = false;
            if (e.Node.Text == "Врачи")
            {
                DataTable patientsData = query.GetData("Врачи");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Диагнозы")
            {
                DataTable patientsData = query.GetData("Диагнозы");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Записи в медкарте")
            {
                DataTable patientsData = query.GetData("Записи_в_медкарте");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Запись на приём")
            {
                DataTable patientsData = query.GetData("Запись_на_приём");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Кабинеты")
            {
                DataTable patientsData = query.GetData("Кабинеты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Лекарства")
            {
                DataTable patientsData = query.GetData("Лекарства");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Медицинские услуги")
            {
                DataTable patientsData = query.GetData("Медицинские_услуги");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Медкарты")
            {
                DataTable patientsData = query.GetData("Медкарты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Оказанные услуги")
            {
                DataTable patientsData = query.GetData("Оказанные_услуги");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Отделения")
            {
                DataTable patientsData = query.GetData("Отделения");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Пациенты")
            {
                DataTable patientsData = query.GetData("Пациенты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Платежи")
            {
                DataTable patientsData = query.GetData("Платежи");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Приёмы врачей")
            {
                DataTable patientsData = query.GetData("Приёмы_врачей");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Рецепты")
            {
                DataTable patientsData = query.GetData("Рецепты");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

            else if (e.Node.Text == "Специальности")
            {
                DataTable patientsData = query.GetData("Специальности");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
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

                // Отключаем кнопку добавления
                buttonAddition.Enabled = false;

                buttonEndEdit.Enabled = true;
                buttonCancelEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("DataGridView не привязан к DataTable!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEndEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Получаем последнюю добавленную строку
                DataRow currentRow = dataTable.Rows[dataTable.Rows.Count - 1];

                try
                {
                    string tableName = treeView1.SelectedNode.Text.Replace(" ", "_");

                    // Сохраняем в БД - если будет исключение, код ниже не выполнится
                    query.SaveChangesToDB(dataTable, tableName);

                    // Только если SaveChangesToDB выполнилось без исключений:
                    dataGridView1.EndEdit();
                    buttonAddition.Enabled = true;
                    buttonEndEdit.Enabled = false;

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

                    // Оставляем кнопки в прежнем состоянии (редактирование продолжается)
                    buttonAddition.Enabled = false;
                    buttonEndEdit.Enabled = true;
                }
            }
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Отменяем изменения
                dataTable.RejectChanges();

                // Включаем кнопку добавления
                buttonAddition.Enabled = true;

                // Отключаем кнопки завершения/отмены
                buttonEndEdit.Enabled = false;
                buttonCancelEdit.Enabled = false;
            }
        }
    }
}
