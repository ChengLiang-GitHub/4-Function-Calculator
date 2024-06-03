namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calButn = new Button();
            n1Text = new TextBox();
            label1 = new Label();
            n2Text = new TextBox();
            domainUpDown1 = new DomainUpDown();
            intMinMax = new Button();
            floatTest = new Button();
            splitButn = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            domainUpDown2 = new DomainUpDown();
            n3Text = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            bmiLable = new Label();
            bmiButn = new Button();
            label5 = new Label();
            label4 = new Label();
            weightText = new TextBox();
            highText = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            trapezoidButn = new Button();
            heightTB = new TextBox();
            downTB = new TextBox();
            upTB = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            rectangleButn = new Button();
            widthTB = new TextBox();
            lengthTB = new TextBox();
            label12 = new Label();
            label11 = new Label();
            circularRultButn = new Button();
            piTextBox = new TextBox();
            rTB = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            resultRTB = new RichTextBox();
            clearButn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // calButn
            // 
            calButn.Location = new Point(23, 100);
            calButn.Name = "calButn";
            calButn.Size = new Size(75, 23);
            calButn.TabIndex = 0;
            calButn.Text = "Calculate";
            calButn.UseVisualStyleBackColor = true;
            calButn.Click += calButn_Click;
            // 
            // n1Text
            // 
            n1Text.Location = new Point(23, 52);
            n1Text.Name = "n1Text";
            n1Text.Size = new Size(100, 23);
            n1Text.TabIndex = 1;
            n1Text.Text = "0";
            n1Text.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 199);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // n2Text
            // 
            n2Text.Location = new Point(217, 52);
            n2Text.Name = "n2Text";
            n2Text.Size = new Size(100, 23);
            n2Text.TabIndex = 4;
            n2Text.Text = "0";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("+");
            domainUpDown1.Items.Add("-");
            domainUpDown1.Items.Add("*");
            domainUpDown1.Items.Add("/");
            domainUpDown1.Location = new Point(153, 52);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(39, 23);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.Tag = "";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // intMinMax
            // 
            intMinMax.Location = new Point(27, 32);
            intMinMax.Name = "intMinMax";
            intMinMax.Size = new Size(148, 23);
            intMinMax.TabIndex = 6;
            intMinMax.Text = "Int Max Min";
            intMinMax.UseVisualStyleBackColor = true;
            intMinMax.Click += intMinMax_Click;
            // 
            // floatTest
            // 
            floatTest.Location = new Point(27, 61);
            floatTest.Name = "floatTest";
            floatTest.Size = new Size(148, 23);
            floatTest.TabIndex = 9;
            floatTest.Text = "float Test";
            floatTest.UseVisualStyleBackColor = true;
            floatTest.Click += floatTest_Click;
            // 
            // splitButn
            // 
            splitButn.Location = new Point(54, 93);
            splitButn.Name = "splitButn";
            splitButn.Size = new Size(185, 23);
            splitButn.TabIndex = 10;
            splitButn.Text = "Split vocaubulary";
            splitButn.UseVisualStyleBackColor = true;
            splitButn.Click += splitButn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 12;
            label2.Text = "n1";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 19);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 13;
            label3.Text = "n2";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(domainUpDown2);
            panel1.Controls.Add(n3Text);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(n1Text);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(calButn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(n2Text);
            panel1.Controls.Add(domainUpDown1);
            panel1.Location = new Point(31, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 165);
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 54);
            label8.Name = "label8";
            label8.Size = new Size(11, 15);
            label8.TabIndex = 18;
            label8.Text = ")";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 55);
            label7.Name = "label7";
            label7.Size = new Size(11, 15);
            label7.TabIndex = 17;
            label7.Text = "(";
            label7.Click += label7_Click;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Items.Add("+");
            domainUpDown2.Items.Add("-");
            domainUpDown2.Items.Add("*");
            domainUpDown2.Items.Add("/");
            domainUpDown2.Location = new Point(344, 51);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(43, 23);
            domainUpDown2.TabIndex = 16;
            // 
            // n3Text
            // 
            n3Text.Location = new Point(423, 51);
            n3Text.Name = "n3Text";
            n3Text.Size = new Size(100, 23);
            n3Text.TabIndex = 15;
            n3Text.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 19);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 14;
            label6.Text = "n3";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(splitButn);
            panel2.Location = new Point(26, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 152);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(bmiLable);
            panel3.Controls.Add(bmiButn);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(weightText);
            panel3.Controls.Add(highText);
            panel3.Location = new Point(16, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 199);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // bmiLable
            // 
            bmiLable.AutoSize = true;
            bmiLable.Location = new Point(30, 168);
            bmiLable.Name = "bmiLable";
            bmiLable.Size = new Size(0, 15);
            bmiLable.TabIndex = 5;
            // 
            // bmiButn
            // 
            bmiButn.Location = new Point(30, 114);
            bmiButn.Name = "bmiButn";
            bmiButn.Size = new Size(75, 23);
            bmiButn.TabIndex = 4;
            bmiButn.Text = "BMI";
            bmiButn.UseVisualStyleBackColor = true;
            bmiButn.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 63);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 21);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Height";
            label4.Click += label4_Click;
            // 
            // weightText
            // 
            weightText.Location = new Point(93, 60);
            weightText.Name = "weightText";
            weightText.Size = new Size(100, 23);
            weightText.TabIndex = 1;
            weightText.Text = "0";
            // 
            // highText
            // 
            highText.Location = new Point(93, 17);
            highText.Name = "highText";
            highText.Size = new Size(100, 23);
            highText.TabIndex = 0;
            highText.Text = "0";
            highText.TextChanged += textBox4_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Location = new Point(43, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(721, 250);
            tabControl1.TabIndex = 17;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Salmon;
            tabPage1.Controls.Add(floatTest);
            tabPage1.Controls.Add(intMinMax);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(713, 222);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "int Min Max";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.SandyBrown;
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(713, 222);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "caculator";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.OliveDrab;
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(713, 222);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "split letter";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.RoyalBlue;
            tabPage4.Controls.Add(panel3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(713, 222);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "bmi";
            tabPage4.Click += tabPage4_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.MediumPurple;
            tabPage5.Controls.Add(trapezoidButn);
            tabPage5.Controls.Add(heightTB);
            tabPage5.Controls.Add(downTB);
            tabPage5.Controls.Add(upTB);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(rectangleButn);
            tabPage5.Controls.Add(widthTB);
            tabPage5.Controls.Add(lengthTB);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(circularRultButn);
            tabPage5.Controls.Add(piTextBox);
            tabPage5.Controls.Add(rTB);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label9);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(713, 222);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "幾何圖形計算";
            // 
            // trapezoidButn
            // 
            trapezoidButn.Location = new Point(493, 145);
            trapezoidButn.Name = "trapezoidButn";
            trapezoidButn.Size = new Size(176, 23);
            trapezoidButn.TabIndex = 16;
            trapezoidButn.Text = "trapezoid result";
            trapezoidButn.UseVisualStyleBackColor = true;
            trapezoidButn.Click += trapezoidButn_Click;
            // 
            // heightTB
            // 
            heightTB.Location = new Point(522, 95);
            heightTB.Name = "heightTB";
            heightTB.Size = new Size(100, 23);
            heightTB.TabIndex = 15;
            // 
            // downTB
            // 
            downTB.Location = new Point(522, 57);
            downTB.Name = "downTB";
            downTB.Size = new Size(100, 23);
            downTB.TabIndex = 14;
            // 
            // upTB
            // 
            upTB.Location = new Point(522, 21);
            upTB.Name = "upTB";
            upTB.Size = new Size(100, 23);
            upTB.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(476, 98);
            label15.Name = "label15";
            label15.Size = new Size(19, 15);
            label15.TabIndex = 12;
            label15.Text = "高";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(476, 60);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 11;
            label14.Text = "下底";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(476, 28);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 10;
            label13.Text = "上底";
            // 
            // rectangleButn
            // 
            rectangleButn.Location = new Point(282, 148);
            rectangleButn.Name = "rectangleButn";
            rectangleButn.Size = new Size(137, 23);
            rectangleButn.TabIndex = 9;
            rectangleButn.Text = "rectangle result";
            rectangleButn.UseVisualStyleBackColor = true;
            rectangleButn.Click += rectangleButn_Click;
            // 
            // widthTB
            // 
            widthTB.Location = new Point(280, 72);
            widthTB.Name = "widthTB";
            widthTB.Size = new Size(100, 23);
            widthTB.TabIndex = 8;
            // 
            // lengthTB
            // 
            lengthTB.Location = new Point(280, 26);
            lengthTB.Name = "lengthTB";
            lengthTB.Size = new Size(100, 23);
            lengthTB.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 75);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 6;
            label12.Text = "寬";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(255, 34);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 5;
            label11.Text = "長";
            // 
            // circularRultButn
            // 
            circularRultButn.Location = new Point(57, 145);
            circularRultButn.Name = "circularRultButn";
            circularRultButn.Size = new Size(139, 23);
            circularRultButn.TabIndex = 4;
            circularRultButn.Text = "circular result";
            circularRultButn.UseVisualStyleBackColor = true;
            circularRultButn.Click += circularRultButn_Click;
            // 
            // piTextBox
            // 
            piTextBox.Location = new Point(82, 72);
            piTextBox.Name = "piTextBox";
            piTextBox.Size = new Size(100, 23);
            piTextBox.TabIndex = 3;
            piTextBox.Text = "3.14159";
            // 
            // rTB
            // 
            rTB.Location = new Point(82, 26);
            rTB.Name = "rTB";
            rTB.Size = new Size(100, 23);
            rTB.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 75);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 1;
            label10.Text = "PI";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 29);
            label9.Name = "label9";
            label9.Size = new Size(11, 15);
            label9.TabIndex = 0;
            label9.Text = "r";
            label9.Click += label9_Click;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(713, 222);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(713, 222);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(713, 222);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(713, 222);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // resultRTB
            // 
            resultRTB.BackColor = Color.White;
            resultRTB.Location = new Point(161, 307);
            resultRTB.Name = "resultRTB";
            resultRTB.Size = new Size(234, 96);
            resultRTB.TabIndex = 17;
            resultRTB.Text = "";
            resultRTB.TextChanged += richTextBox1_TextChanged_1;
            // 
            // clearButn
            // 
            clearButn.Location = new Point(47, 307);
            clearButn.Name = "clearButn";
            clearButn.Size = new Size(75, 23);
            clearButn.TabIndex = 18;
            clearButn.Text = "clear";
            clearButn.UseVisualStyleBackColor = true;
            clearButn.Click += clearButn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButn);
            Controls.Add(resultRTB);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calButn;
        private TextBox n1Text;
        private Label label1;
        private TextBox n2Text;
        private DomainUpDown domainUpDown1;
        private Button intMinMax;
        private Button floatTest;
        private Button splitButn;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox weightText;
        private TextBox highText;
        private Button bmiButn;
        private Label label5;
        private Label bmiLable;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label label6;
        private DomainUpDown domainUpDown2;
        private TextBox n3Text;
        private RichTextBox resultRTB;
        private Button clearButn;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox rTB;
        private TextBox piTextBox;
        private Button circularRultButn;
        private Label label12;
        private Label label11;
        private TextBox widthTB;
        private TextBox lengthTB;
        private Button rectangleButn;
        private TextBox upTB;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button trapezoidButn;
        private TextBox heightTB;
        private TextBox downTB;
    }
}
