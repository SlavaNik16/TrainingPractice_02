using System;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class MainForm : Form
    {
        private string count;
        public MainForm()
        {
            InitializeComponent();
            Validates();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {

            count = txtCount.Text.ToString();
            Validates();
        }

        private void butStart_Click(object sender, EventArgs e)
        {

        }

        private void Validates()
        {
            butStart.Enabled =
                !string.IsNullOrWhiteSpace(txtCount.Text) &&
                (int.Parse(txtCount.Text.ToString()) < 25) ;
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) || (txtCount.Text.Length >= 2 && (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
    }
}
