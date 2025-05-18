using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

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

        private void ButtonEnabled()
        {
            buttonAddition.Enabled = false;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEndEdit.Enabled = true;
            buttonCancelEdit.Enabled = true;
        }
        private void ButtonDisabled()
        {
            buttonEdit.Enabled = true;
            buttonAddition.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEndEdit.Enabled = false;
            buttonCancelEdit.Enabled = false;
        }



        private void buttonAddition_Click_1(object sender, EventArgs e)
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

        private void buttonEdit_Click_1(object sender, EventArgs e)
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

        private void buttonDelete_Click_1(object sender, EventArgs e)
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

        private void buttonEndEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCancelEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Устанавливаем фильтр только для файлов .mdb (Access)
                openFileDialog.Filter = "Файлы баз данных (*.mdb)|*.mdb|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1; // По умолчанию выбираем .mdb файлы

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Проверяем расширение файла (дополнительная проверка)
                    if (Path.GetExtension(selectedFilePath).ToLower() == ".mdb")
                    {
                        // Здесь можно использовать выбранный файл .mdb
                        MessageBox.Show($"Выбран файл БД: {selectedFilePath}",
                                      "Файл выбран",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

                        query.SetConnectionString(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите файл с расширением .mdb",
                                      "Неверный формат",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void записиВМедкартеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оплаченныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           query.PaymentsQuery("оплачено");
        }
    }
}
