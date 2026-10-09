using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MARTYNOVA_PR07_GIT
{
    public partial class AdminForm : Form
    {


        public AdminForm()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мартынова Алёна Алексеевна", "Группа ИС-24А",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
