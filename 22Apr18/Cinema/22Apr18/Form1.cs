using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Apr18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> selectedSeats = new List<Button>();

        private void BtnAllSeats_Click(object sender, EventArgs e)
        {
            Button ClickedSeat = sender as Button;
            if (ClickedSeat.BackColor == Color.LightGray)
            {
                ClickedSeat.BackColor = Color.Green;
                ClickedSeat.FlatAppearance.BorderColor = Color.Green;
                ClickedSeat.ForeColor = Color.White;

                selectedSeats.Add(ClickedSeat);
            }
            else
            {
                ClickedSeat.BackColor = Color.LightGray;
                ClickedSeat.FlatAppearance.BorderColor = Color.LightGray;
                ClickedSeat.ForeColor = Color.Black;
                selectedSeats.Remove(ClickedSeat);
            }
            
        }
        
        private void BtnTicketBuy_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                seat.BackColor = Color.Red;
                seat.FlatAppearance.BorderColor = Color.Red;
                seat.ForeColor = Color.White;
            }
        }

        private void BtnResetSeats_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                seat.BackColor = Color.LightGray;
                seat.FlatAppearance.BorderColor = Color.LightGray;
                seat.ForeColor = Color.Black;                
            }
            selectedSeats.Clear();
        }
    }
}
