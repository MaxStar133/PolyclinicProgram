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
            if (e.Node.Text == "Пациенты")
            {
                DataTable patientsData = query.GetPatientsData();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = patientsData;
            }

        }

    }
}
