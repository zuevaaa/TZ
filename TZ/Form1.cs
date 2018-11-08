using System;
using System.Windows.Forms;


namespace TZ
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            string text1 = textBox1.Text;

            if (text1 is null || text1.Length <= 0)
            {
                MessageBox.Show("Пустое поле ввода!");
                return;
            }
            int control_number = countWordsStartWithT(text1);

            if (control_number == 0)
            {
                MessageBox.Show("Нет слов начинающихся с буквы Т!");
            }
            else
            {
                MessageBox.Show("Количество слов начинающихся с буквы Т = " + control_number.ToString());
            }
        }

        public static int countWordsStartWithT(string text1)
        {
            int control_number = 0;
            if (((text1[0] == 'T') || (text1[0] == 't') || (text1[0] == 'Т') || (text1[0] == 'т')))
            {
                control_number++;
            }

            for (int i = 1; i < text1.Length; i++)
            {
                if ((text1[i - 1] == ' ') && ((text1[i] == 'T') || (text1[i] == 't') || (text1[i] == 'Т') || (text1[i] == 'т')))
                {
                    control_number++;
                }
            }

            return control_number;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
