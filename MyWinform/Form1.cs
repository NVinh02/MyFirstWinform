using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = 0, x2 = 0, a, b, c;
            label4.Text = "Result";
            if (num_a.Text == "" || num_b.Text == "" || num_c.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ a, b, c", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            a = Convert.ToDouble(num_a.Text);
            b = Convert.ToDouble(num_b.Text);
            c = Convert.ToDouble(num_c.Text);
            double delta = b * b - 4 * a * c;

            if (a == 0 && b == 0 && c == 0)
            {
                label4.Visible = true;
                lb_x1.Visible = false;
                lb_x2.Visible = false;
                lb_x.Visible = false;
                MessageBox.Show("Phương trình có vô số nghiệm!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (delta > 0)
            {
                label4.Visible = true;
                lb_x1.Visible = true;
                lb_x2.Visible = true;
                lb_x.Visible = false;
                MessageBox.Show("PT có 2 nghiệm phân biệt!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                x1 = Convert.ToSingle((-Math.Sqrt(delta) - b) / (2 * a));
                x2 = Convert.ToSingle((Math.Sqrt(delta) - b) / (2 * a));
                lb_x1.Text = "X1 = " + x1.ToString();
                lb_x2.Text = "X2 = " + x2.ToString();
            }

            else if (delta == 0)
            {
                label4.Visible = true;
                lb_x1.Visible = false;
                lb_x2.Visible = false;
                lb_x.Visible = true;
                MessageBox.Show("PT có 1 nghiệm kép!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                x1 = x2 = Convert.ToSingle(-b / 2 * a);
                lb_x.Text = "X = " + x1.ToString();
            }

            else if (delta < 0)
            {
                label4.Visible = false;
                lb_x1.Visible = false;
                lb_x2.Visible = false;
                lb_x.Visible = false;
                MessageBox.Show("PT vô nghiệm!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            lb_x1.Text = "";
            lb_x2.Text = "";
            lb_x.Text = "";
        }










        /*string even_odd(int n)
        {
            if (n % 2 == 0)
                return "so chan";
            return "so le";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Result.Text = "";
            Result.Text = even_odd(int.Parse(BoxInput1.Text));
        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(Box1.Text);
            int number2 = int.Parse(Box2.Text);
            int result = number1 + number2;
            Result.Text = result.ToString();
        }*/
    }
}
