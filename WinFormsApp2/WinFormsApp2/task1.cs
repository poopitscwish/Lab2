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
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
            penny.Text = Properties.Settings.Default.penny.ToString();
        }
        private void Doing_Click(object sender, EventArgs e)
        {
            var penny = int.Parse(this.penny.Text); 
            Properties.Settings.Default.penny = penny;
            Properties.Settings.Default.Save();
            this.result.Text = Logic.Mainlogic(penny);
        }
        private void Penny_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doing.Focus();
                Doing_Click(sender, e);
            }
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form menu = Application.OpenForms[0];
            menu.Show();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            this.penny.Text = "1";
            this.result.Text = "";
        }
        public class Logic // класс где будем хранить логику
        { 
                public static string Rub(int integer)
                {
                    string massage = "";
                    if (integer >= 10 && integer <= 20)
                    {
                        massage = (integer + " рублей ");
                    }
                    else if (integer % 10 == 1)
                    {
                        massage = (integer + " рубль ");
                    }

                    else if (integer % 10 == 2 || integer % 10 == 3 || integer % 10 == 4)
                    {
                        massage = (integer + " рубля ");
                    }
                    else
                    {
                        massage = (integer + " рублей ");
                    }
                return massage;
                }
                public static string Penny(int fractional)
                {
                string message = "";
                    if (fractional == 0)
                    {
                    message = "ровно ";
                    }
                    else if (fractional >= 10 && fractional <= 20)
                    {
                    message = (fractional + " копеек ");
                    }
                    else if (fractional % 10 == 1)
                    {
                    message = (fractional + " копейка ");
                    }
                    else if (fractional % 10 == 2 || fractional % 10 == 3 || fractional % 10 == 4)
                    {
                    message = (fractional + " копейки ");
                    }
                    else
                    {
                    message = (fractional + " копеек ");
                    }
                    return message;
                }
                public static string Mainlogic(int price)
                {
                string outMessage = "";
                    if (price > 9999)
                    return outMessage = "> 99 рублей 99 копеек";
                    if (price < 1)
                    return outMessage = "меньше 1 копейки";
                    int integer = price / 100;
                    int fractional = price % 100;
                    outMessage += Rub(integer);
                    outMessage += Penny(fractional);
                    return outMessage;
                }
        }
    }
}
