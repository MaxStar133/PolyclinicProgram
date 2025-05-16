using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class MainWindow : Form
    {
        Query query = new Query();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
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

    }
}
