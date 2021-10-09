using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Menu : Form
    {
        public bool isclose = false;
        Form1 form1;
        task1 form3;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form3 = new task1();
            form3.Show();
            Hide();
        }
    }
}
