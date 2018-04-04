using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class f_calc : Form
    {
        class Data //містить 2 числа, дію, знак, результат, відповідь, операцію, роздільник цілої та дробової частини
        {
            public string sign;
            public double first;
            public double second;
            public double rez;
            public bool answer;
            public string separator;
            public string operation;

            public Data()
            {
                this.sign = "+";
                this.first = 0;
                this.second = 0;
                this.rez = 0;
                this.answer = false;
                this.separator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
                this.operation = "";
            }

        public void Clear()
            {
                this.sign = "+";
                this.first = 0;
                this.second = 0;
                this.rez = 0;
                this.answer = false;
                this.operation = "";
            }
        }

        Data data = null;

        public f_calc()
        {
            InitializeComponent();
            data = new Data();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 247;
            btn_cool.Tag = 1;
        }

        private void btn_cool_Click(object sender, EventArgs e)
        {
            if ( btn_cool.Tag.Equals(1) )
            {
                this.Width = 325;
                this.Update();
                btn_cool.Text = "<<";
                btn_cool.Left += 80;
                btn_cool.Tag = 2;
                lbl_mode.Text = "Mode: Cool";
            }
            else
            {
                this.Width = 247;
                btn_cool.Text = ">>";
                btn_cool.Left -= 80;
                btn_cool.Tag = 1;
                lbl_mode.Text = "Mode: Simple";
            }
        }

        private void btn_cool_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btn_cool, "Переключає режими калькулятора");
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            tb_input.Text = "0";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            tb_data.Text = "";
            btn_ce.PerformClick();
            data.Clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string temp = tb_input.Text;
            tb_input.Text = temp.Remove(temp.Length - 1, 1);
            tb_input.Text = (tb_input.Text == "") ? "0" : tb_input.Text;
        }

        private void btn_sing_Click(object sender, EventArgs e)
        {
            string temp = tb_input.Text;

            if (temp.Contains(data.sign))
            {
                temp = temp.Replace(data.sign, (data.sign == "+") ? "-" : "+");
            }
            else
            {
                temp = ((data.sign == "+") ? "-" : "+") + temp;
            }

            data.sign = (data.sign == "+") ?  "-" :  "+";

            tb_input.Text = temp;
        }

        private void btn_separator_Click(object sender, EventArgs e)
        {
            string temp = tb_input.Text;
            if (!temp.Contains(data.separator))
            {
                tb_input.Text = temp + data.separator;
            }
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            AddNumberToInput("0");            
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            AddNumberToInput("1");
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            AddNumberToInput("2");
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            AddNumberToInput("3");
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            AddNumberToInput("4");
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            AddNumberToInput("5");
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            AddNumberToInput("6");
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            AddNumberToInput("7");
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            AddNumberToInput("8");
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            AddNumberToInput("9");
        }

        //додає натиснутий символ до поля введення
        private void AddNumberToInput(string number)
        {
            if (tb_input.Text == "0")
            {
                if (number != "0")
                {
                    tb_input.Text = number;
                }
            }
            else
            {
                tb_input.Text += number;
            }
            tb_input.Modified = true;
            tb_data.Focus();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (!data.answer)
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.first);
                data.operation = "÷";
                tb_data.Text = data.first.ToString() + " ÷ ";
                data.answer = true;
                tb_input.Text = "0";
            }
            else
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                data.operation = "÷";
                tb_data.Text = data.first.ToString() + " ÷ " + data.second.ToString() + " = ";
                data.rez = data.first / data.second;
                tb_data.Text += data.rez.ToString();
                data.first = data.rez;
                data.answer = true;
                tb_input.Text = "0";
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (!data.answer)
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.first);
                data.operation = "x";
                tb_data.Text = data.first.ToString() + " x ";
                data.answer = true;
                tb_input.Text = "0";
            }
            else
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                data.operation = "x";
                tb_data.Text = data.first.ToString() + " x " + data.second.ToString() + " = ";
                data.rez = data.first * data.second;
                tb_data.Text += data.rez.ToString();
                data.first = data.rez;
                data.answer = true;
                tb_input.Text = "0";
            }
        }

        private void btn_substruct_Click(object sender, EventArgs e)
        {
            if (!data.answer)
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.first);
                data.operation = "-";
                tb_data.Text = data.first.ToString() +  " - " ;
                data.answer = true;
                tb_input.Text = "0";
            }
            else
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                data.operation = "-";
                tb_data.Text = data.first.ToString() + " - " + data.second.ToString() + " = ";
                data.rez = data.first - data.second;
                tb_data.Text += data.rez.ToString();
                data.first = data.rez;
                data.answer = true;
                tb_input.Text = "0";
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (!data.answer)
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.first);
                data.operation = "+";
                tb_data.Text = data.first.ToString() + " + " ;
                data.answer = true;
                tb_input.Text = "0";
            }
            else
            {
                Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                data.operation = "+";
                tb_data.Text = data.first.ToString() + " + " + data.second.ToString() + " = ";
                data.rez = data.first + data.second;
                tb_data.Text += data.rez.ToString();
                data.first = data.rez;
                data.answer = true;
                tb_input.Text = "0";
            }
        }

        private void btn_rez_Click(object sender, EventArgs e)
        {
            switch (data.operation)
            {
                case "÷":
                    if (data.answer)
                    {
                        btn_divide.PerformClick();
                    }
                    else
                    {
                        Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                        data.operation = "÷";
                        tb_data.Text = data.first.ToString() + " " + "÷" + data.second.ToString() + " = ";
                        data.rez = data.first / data.second;
                        tb_data.Text += data.rez.ToString();
                        data.first = data.rez;
                        data.answer = true;
                        tb_input.Text = "0";
                    }
                    break;
                case "x":
                    if (data.answer)
                    {
                        btn_multiply.PerformClick();
                    }
                    else
                    {
                        Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                        data.operation = "x";
                        tb_data.Text = data.first.ToString() + " " + "x" + data.second.ToString() + " = ";
                        data.rez = data.first * data.second;
                        tb_data.Text += data.rez.ToString();
                        data.first = data.rez;
                        data.answer = true;
                        tb_input.Text = "0";
                    }                    
                    break;
                case "-":
                    if (data.answer)
                    {
                        btn_substruct.PerformClick();
                    }
                    else
                    {
                        Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                        data.operation = "-";
                        tb_data.Text = data.first.ToString() + " " + "-" + data.second.ToString() + " = ";
                        data.rez = data.first - data.second;
                        tb_data.Text += data.rez.ToString();
                        data.first = data.rez;
                        data.answer = true;
                        tb_input.Text = "0";
                    }
                    break;
                case "+":
                    if (data.answer)
                    {
                        btn_plus.PerformClick();
                    }
                    else
                    {
                        Double.TryParse(TriadaToText(tb_input.Text), out data.second);
                        data.operation = "+";
                        tb_data.Text += data.first.ToString() + " " + "+" + data.second.ToString() + " = ";
                        data.rez = data.first + data.second;
                        tb_data.Text += data.rez.ToString();
                        data.first = data.rez;
                        data.answer = true;
                        tb_input.Text = "0";
                    }                    
                    break;                   
            }
        }

        //Розбиває на тріади
        private string TextToTriada(string _text)
        {
            _text = _text.Replace(" ", "");
            char[] sReverse = _text.ToCharArray();
            Array.Reverse(sReverse);
            _text = new string(sReverse);

            string buff = "";

            for (int i = 0, j = 0; i < _text.Length; i++)
            {
                if (j == 3)
                {
                    buff += " ";
                    j = 0;
                }
                j++;

                buff += _text[i];
            }

            tb_input.Modified = false;
            sReverse = buff.ToCharArray();
            Array.Reverse(sReverse);
            _text = new string(sReverse);
            return _text;
        }

        //Повертає назад просто число
        private string TriadaToText(string _text)
        {
            _text = _text.Replace(" ", "");
            return _text;
        }

        private void tb_input_ModifiedChanged(object sender, EventArgs e)
        {
            if (cb_triada.Checked)
            {
                tb_input.Text = TextToTriada(tb_input.Text);
            }
            else
            {
                tb_input.Text = TriadaToText(tb_input.Text);
            }
        }

        private void cb_triada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_triada.Checked)
            {
                tb_input.Text = TextToTriada(tb_input.Text);
            }
            else
            {
                tb_input.Text = TriadaToText(tb_input.Text);
            }
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            data.Clear();
            Double.TryParse(TriadaToText(tb_input.Text), out data.second);
            data.operation = "SIN";
            tb_data.Text = "SIN( " + data.second.ToString() + " ) = ";

            if (rbtn_grad.Checked == true)
                data.rez = Math.Sin(data.second*Math.PI/180);
            else data.rez = Math.Sin(data.second);

            tb_data.Text += data.rez.ToString();
            data.first = data.rez;
            data.answer = true;
            tb_input.Text = "0";
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            data.Clear();
            Double.TryParse(TriadaToText(tb_input.Text), out data.second);
            data.operation = "COS";
            tb_data.Text = "COS( " + data.second.ToString() + " ) = ";

            if (rbtn_grad.Checked == true)
                data.rez = Math.Cos(data.second * Math.PI / 180);
            else data.rez = Math.Cos(data.second);

            tb_data.Text += data.rez.ToString();
            data.first = data.rez;
            data.answer = true;
            tb_input.Text = "0";
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            data.Clear();
            Double.TryParse(TriadaToText(tb_input.Text), out data.second);
            data.operation = "TAN";
            tb_data.Text = "TAN( " + data.second.ToString() + " ) = ";

            if (rbtn_grad.Checked == true)
                data.rez = Math.Tan(data.second * Math.PI / 180);
            else data.rez = Math.Tan(data.second);

            tb_data.Text += data.rez.ToString();
            data.first = data.rez;
            data.answer = true;
            tb_input.Text = "0";
        }

        private void f_calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn_zero.PerformClick();
                    break;
                case '1':
                    btn_one.PerformClick();
                    break;
                case '2':
                    btn_two.PerformClick();
                    break;
                case '3':
                    btn_three.PerformClick();
                    break;
                case '4':
                    btn_four.PerformClick();
                    break;
                case '5':
                    btn_five.PerformClick();
                    break;
                case '6':
                    btn_six.PerformClick();
                    break;
                case '7':
                    btn_seven.PerformClick();
                    break;
                case '8':
                    btn_eight.PerformClick();
                    break;
                case '9':
                    btn_nine.PerformClick();
                    break;
                case '.' :
                    btn_separator.PerformClick();
                    break;
                case ',':
                    btn_separator.PerformClick();
                    break;
                case '/':
                    btn_divide.PerformClick();
                    break;
                case '*':
                    btn_multiply.PerformClick();
                    break;
                case '+':
                    btn_plus.PerformClick();
                    break;
                case '-':
                    btn_substruct.PerformClick();
                    break;
                case (char)Keys.Return: //ентер
                    btn_rez.PerformClick();
                    break;
                case (char)Keys.S: //сінус
                    btn_sin.PerformClick();
                    break;
                case 's': //сінус
                    btn_sin.PerformClick();
                    break;
                case (char)Keys.C: //косинус
                    btn_cos.PerformClick();
                    break;
                case 'c'://косинус
                    btn_cos.PerformClick();
                    break;
                case (char)Keys.T: //тангенс
                    btn_tan.PerformClick();
                    break;
                case 't'://тангенс
                    btn_tan.PerformClick();
                    break;
            }
        }

        private void f_calc_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F9: //встановлює знак +-
                    btn_sing.PerformClick();
                    break;
                case Keys.Back: // видаляє останній ввадений символ
                    btn_del.PerformClick();
                    break;
                case Keys.Delete: // очищає поле введення
                    btn_ce.PerformClick();
                    break;
                case Keys.Escape: //очищає все
                    btn_c.PerformClick();
                    break;
            }
        }
    }
}
