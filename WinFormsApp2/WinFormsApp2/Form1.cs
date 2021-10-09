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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            text1.Text = Properties.Settings.Default.text1;
            text2.Text = Properties.Settings.Default.text2;
        }
        private void Doing_Click_1(object sender, EventArgs e)
        {

            var text1 = this.text1.Text;
            var text2 = this.text2.Text;
            Properties.Settings.Default.text1 = text1;
            Properties.Settings.Default.text2 = text2;
            Properties.Settings.Default.Save();
            this.result.Text = Logic.MainLogic(text1, text2);
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            this.text1.Text = "";
            this.text2.Text = "";
            this.result.Text = "";
        }
        private void text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                text2.Focus();
            }
        }
        private void text2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }
        public class Logic // класс где будем хранить логику
        {
            static public void Set(List<string> str)
            {
                for (int i = 0; i < str.Count; i++)
                    for (int j = i + 1; j < str.Count; j++)
                        if (str[i] == str[j])
                        {
                            str.RemoveAt(j);
                        }
            }
            static public string Reg(string str)
            {
                char[] temp = str.ToCharArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= 'A' && temp[i] <= 'Z')
                    {
                        temp[i] += ' ';
                    }
                    if (temp[i] >= 'А' && temp[i] <= 'Я')
                    {
                        temp[i] += ' ';
                    }
                }
                str = new string(temp);
                str = str.Trim(new Char[] { '\n', '\r' });
                return str;
            }
            public static string MainLogic(string str1, string str2)
            {
                string result = "";
                str1 = Reg(str1);
                str2 = Reg(str2);
                string[] str = str1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var temp = new List<string>(str);
                Set(temp);
                for (int i = 0; i < temp.Count; i++)
                {
                    if (str2.Contains(temp[i]))
                        result += temp[i] + Environment.NewLine;
                }
                return result;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
    }
}
//papa mama misha
//misha papa mama
