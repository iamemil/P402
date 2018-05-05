using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //List<Button> AllBoxes = new List<Button>();
        
        string order = "X";
        public Form1()
        {


            InitializeComponent();
            InfoText.Text = "Sıra " + order + "-dədir";
        }

        

        private void BtnBox_Click(object sender, EventArgs e)
        {
            Button ClickedBox = sender as Button;
            if (ClickedBox.Text == "")
            {
                ClickedBox.Text = order;
                if (order == "X")
                {
                    order = "O";
                    InfoText.Text = "Sıra " + order + "-dadır";
                }
                else
                {
                    order = "X";
                    InfoText.Text = "Sıra " + order + "-dədir";
                }
                CheckGame();
            }

        }

        private void CheckGame()
        {
            if (BtnBox1.Text == BtnBox2.Text && BtnBox2.Text == BtnBox3.Text && BtnBox1.Text == BtnBox3.Text && BtnBox1.Text!=string.Empty)
            {
                BtnBox1.BackColor = Color.Green;
                BtnBox1.ForeColor = Color.White;

                BtnBox2.BackColor = Color.Green;
                BtnBox2.ForeColor = Color.White;

                BtnBox3.BackColor = Color.Green;
                BtnBox3.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox1.Text;
            }
            else if(BtnBox4.Text == BtnBox5.Text && BtnBox5.Text == BtnBox6.Text && BtnBox4.Text == BtnBox6.Text && BtnBox4.Text != string.Empty)
            {
                BtnBox4.BackColor = Color.Green;
                BtnBox4.ForeColor = Color.White;

                BtnBox5.BackColor = Color.Green;
                BtnBox5.ForeColor = Color.White;

                BtnBox6.BackColor = Color.Green;
                BtnBox6.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox4.Text;
            }
            else if (BtnBox7.Text == BtnBox8.Text && BtnBox8.Text == BtnBox9.Text && BtnBox7.Text == BtnBox9.Text && BtnBox7.Text != string.Empty)
            {
                BtnBox7.BackColor = Color.Green;
                BtnBox7.ForeColor = Color.White;

                BtnBox8.BackColor = Color.Green;
                BtnBox8.ForeColor = Color.White;

                BtnBox9.BackColor = Color.Green;
                BtnBox9.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox7.Text;
            }
            else if (BtnBox1.Text == BtnBox4.Text && BtnBox4.Text == BtnBox7.Text && BtnBox1.Text == BtnBox7.Text && BtnBox1.Text != string.Empty)
            {
                BtnBox1.BackColor = Color.Green;
                BtnBox1.ForeColor = Color.White;

                BtnBox4.BackColor = Color.Green;
                BtnBox4.ForeColor = Color.White;

                BtnBox7.BackColor = Color.Green;
                BtnBox7.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox1.Text;
            }
            else if (BtnBox2.Text == BtnBox5.Text && BtnBox5.Text == BtnBox8.Text && BtnBox2.Text == BtnBox8.Text && BtnBox2.Text != string.Empty)
            {
                BtnBox2.BackColor = Color.Green;
                BtnBox2.ForeColor = Color.White;

                BtnBox5.BackColor = Color.Green;
                BtnBox5.ForeColor = Color.White;

                BtnBox8.BackColor = Color.Green;
                BtnBox8.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox2.Text;
            }
            else if (BtnBox3.Text == BtnBox6.Text && BtnBox6.Text == BtnBox9.Text && BtnBox3.Text == BtnBox9.Text && BtnBox3.Text != string.Empty)
            {
                BtnBox3.BackColor = Color.Green;
                BtnBox3.ForeColor = Color.White;

                BtnBox6.BackColor = Color.Green;
                BtnBox6.ForeColor = Color.White;

                BtnBox9.BackColor = Color.Green;
                BtnBox9.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox3.Text;
            }
            else if (BtnBox1.Text == BtnBox5.Text && BtnBox5.Text == BtnBox9.Text && BtnBox1.Text == BtnBox9.Text && BtnBox1.Text != string.Empty)
            {
                BtnBox1.BackColor = Color.Green;
                BtnBox1.ForeColor = Color.White;

                BtnBox5.BackColor = Color.Green;
                BtnBox5.ForeColor = Color.White;

                BtnBox9.BackColor = Color.Green;
                BtnBox9.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox1.Text;
            }
            else if (BtnBox3.Text == BtnBox5.Text && BtnBox5.Text == BtnBox7.Text && BtnBox3.Text == BtnBox7.Text && BtnBox3.Text != string.Empty)
            {
                BtnBox3.BackColor = Color.Green;
                BtnBox3.ForeColor = Color.White;

                BtnBox5.BackColor = Color.Green;
                BtnBox5.ForeColor = Color.White;

                BtnBox7.BackColor = Color.Green;
                BtnBox7.ForeColor = Color.White;

                InfoText.Text = "Qalib: " + BtnBox3.Text;
            }
        }

    }
}
