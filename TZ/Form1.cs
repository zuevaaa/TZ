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

                if (((text1[0] == 'T') || (text1[0] == 't') || (text1[0] == 'Т') || (text1[0] == 'т')))
                { control_number++; }


                for (i = 1; i < text1.Length; i++)
                    {
                        if ((text1[i - 1] == ' ') && ((text1[i] == 'T') || (text1[i] == 't') || (text1[i] == 'Т') || (text1[i] == 'т')))
                        {
                            control_number++;
                        }
                    }

                   
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
