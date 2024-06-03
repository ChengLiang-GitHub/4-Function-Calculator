using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            double n1, n2, n3, result;
            n1 = Convert.ToDouble(n1Text.Text);
            n2 = Convert.ToDouble(n2Text.Text);
            n3 = Convert.ToDouble(n3Text.Text);

            switch (domainUpDown1.SelectedItem.ToString())
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                default:
                    result = 0;
                    break;
            }
            switch (domainUpDown2.SelectedItem.ToString())
            {
                case "+":
                    result += n3;
                    break;
                case "-":
                    result -= n3;
                    break;
                case "*":
                    result *= n3;
                    break;
                case "/":
                    result /= n3;
                    break;
                default:
                    result = 0;
                    break;
            }
            // label1.Text = n3.ToString();
            resultRTB.Text = result.ToString();
            resultRTB.BackColor = Color.SandyBrown;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void intMinMax_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            int Max, Min, total;
            Max = byte.MaxValue + sbyte.MaxValue + short.MaxValue + ushort.MaxValue;
            Min = byte.MinValue + sbyte.MinValue + short.MinValue + ushort.MinValue;
            total = Max + Min;
            resultRTB.Text = "MAX=" + Max.ToString() + "\n"    //98684
                                            + "MIN=" + Min.ToString() + "\n"    //-32896 
                                            + "TOT=" + total.ToString();   //65788
            resultRTB.BackColor = Color.Salmon;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void floatTest_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            float f1, f2, f3;
            f1 = 0.3333333333F;      // only 7 digit precision
            f2 = -0.5555555555F;
            f3 = 123.456789F;
            resultRTB.Text = "f1 = " + f1 + "\n"    // 0.3333333
                                            + "f2=" + f2 + "\n"    //-0.5555556  	 4捨5入
                                            + "f3=" + f3 + "\n"     //123.4568          	 4捨5入
                                            + "type=" + f2.GetType().ToString();     // System.Single
            resultRTB.BackColor = Color.Salmon;
        }

        private void splitButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            Char[] c = textBox3.Text.ToCharArray();
            int n = textBox3.Text.ToCharArray().Length;
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = s + c[i] + "\n";
            }
            // MessageBox.Show(s);
            resultRTB.Text = s;
            resultRTB.BackColor = Color.OliveDrab;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            double h, w, bmi;
            h = Convert.ToDouble(highText.Text);
            w = Convert.ToDouble(weightText.Text);
            bmi = w / (h * h);
            // bmiLable.Text = bmi.ToString();
            resultRTB.Text = bmi.ToString();
            resultRTB.BackColor = Color.RoyalBlue;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void clearButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void circularRultButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            double r, pi;
            r = Convert.ToDouble(rTB.Text);
            pi = Convert.ToDouble(piTextBox.Text);
            string s = "圓的周長 = " + Convert.ToString(2 * r * pi) + "\n"
                              + "圓的面積 = " + Convert.ToString(r * r * pi) + "\n"
                              + "圓球體積 = " + Convert.ToString((4 / 3) * r * r * r * pi);
            resultRTB.BackColor = Color.MediumPurple;
            resultRTB.Text = s;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rectangleButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            double l, w;
            l = Convert.ToDouble(lengthTB.Text);
            w = Convert.ToDouble(widthTB.Text);
            string s = "矩形的周長 = " + Convert.ToString(2 * l * w) + "\n"
                  + "矩形的面積 = " + Convert.ToString(l * w);
            resultRTB.BackColor = Color.MediumPurple;
            resultRTB.Text = s;
        }

        private void trapezoidButn_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
            double u, d, h;
            u = Convert.ToDouble(upTB.Text);
            d = Convert.ToDouble(downTB.Text);
            h = Convert.ToDouble(heightTB.Text);
            string s = "梯形的面積 = " + Convert.ToString(((u + d) * h) / 2);
            resultRTB.BackColor = Color.MediumPurple;
            resultRTB.Text = s;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            resultRTB.BackColor = Color.White;
            resultRTB.Text = "";
        }
    }
}
