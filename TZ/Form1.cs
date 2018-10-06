using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TZ
{
    public partial class Form1 : Form
    {
        string[] mas;
        int i;
        int control_number = 0;
         


        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                i = 1;
                string text1 = textBox1.Text;
                if (text1 != "")
                {

                    foreach (char c in text1)
                    {
                        
                        mas[i] = c.ToString();
                        i++;
                    }

                    for (i = 1; i < mas.Length; i++)
                    {
                        if ((mas[i - 1] == " ") && ((mas[i] == "T") || (mas[i] == "t") || (mas[i] == "Т") || (mas[i] == "т")))
                        {
                            control_number++;
                        }
                    }

                    if (((mas[0] == "T") || (mas[0] == "t") || (mas[0] == "Т") || (mas[0] == "т")))
                        { control_number++; }
                    if (control_number == 0)
                        { MessageBox.Show("Нет слов начинающихся с буквы Т!"); }
                    else
                        { MessageBox.Show("Количество слов начинающихся с буквы Т = " + control_number.ToString()); }

                }
                else { MessageBox.Show("Пустое поле ввода!"); }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
