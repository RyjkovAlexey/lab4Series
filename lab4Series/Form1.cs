using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Series
{
    public partial class Form1 : Form
    {
        Series series;
        int firstElement = 0;
        int step = 0;
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Поле для получения данных о первом шаге прогрессии
        private void firstStep_TextChanged(object sender, EventArgs e)
        {
            firstElement = Convert.ToInt32(firstStep.Text);
        }

        //Поле для получения количества элементов
        private void numberElement_TextChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numberElement.Text);
        }

        //Поле для получения шага прогрессии
        private void stepProgression_TextChanged(object sender, EventArgs e)
        {
            step = Convert.ToInt32(stepProgression.Text);
        }

        //Кнопка запускающая поиск суммы членов прогресии и поиск N-го члена прогрессии
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (linearRB.Checked)
                {
                    series = new Linear();
                    label5.Text = $"N-ый член последовательности равен {series.memberProgression(firstElement, step, number)}";
                    label6.Text = $"Сумма N-ых членов послеловательности равна {series.sumMemberProgression(firstElement, step, number)}";
                }
                if (exponentialRB.Checked)
                {
                    series = new Exponential();
                    label5.Text = $"N-ый член последовательности равен {series.memberProgression(firstElement, step, number)}";
                    label6.Text = $"Сумма N-ых членов послеловательности равна {series.sumMemberProgression(firstElement, step, number)}";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Обработка отметки выбора типа прогрессии
        private void linearRB_CheckedChanged(object sender, EventArgs e)
        {
            if (exponentialRB.Checked)
            {
                exponentialRB.Checked = false;
                linearRB.Checked = true;
            }
        }

        private void exponentialRB_CheckedChanged(object sender, EventArgs e)
        {
            if (linearRB.Checked)
            {
                linearRB.Checked = false;
                exponentialRB.Checked = true;
            }
        }
    }
}
