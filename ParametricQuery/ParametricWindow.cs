using System;
using System.Windows.Forms;

namespace ParametricQuery
{
    public partial class ParametricWindow : Form
    {
        public string SurName { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }

        public ParametricWindow()
        {
            InitializeComponent();
        }

        private void buttonEndEdit_Click(object sender, EventArgs e)
        {
            SurName = SurnameText.Text;
            FirstName = FirstNameText.Text;
            MiddleName = MiddleNameText.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
