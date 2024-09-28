using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnetDrawBoard
{
    public partial class NumberPad : Form
    {
        
        public NumberPad()
        {
            InitializeComponent();
        }

      
        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9)
                return;
            numberBox.Text = numberBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9)
                return;
            numberBox.Text = numberBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9 )
                return;
            numberBox.Text = numberBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length > 9)
                return;
            numberBox.Text = numberBox.Text + "0";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            numberBox.Text = string.Empty;
        }

        protected virtual void buttonEnter_Click(object sender, EventArgs e)
        {
            if (numberBox.Text.Length == 0)
                return;

            // Instantiate the Client class
            Client client = new Client();
            status_label.Text = "Connecting...";
            // Step 1: Connect to the server
            if (!client.ConnectToServer("127.0.0.1", 5000))
            {
                
                status_label.Text = "Connecting Lost";
                return;
            }

            // Step 2: Check client ID
            if (!client.CheckingTheID(Convert.ToInt16(numberBox.Text)))
            {
                
                status_label.Text = "Invalid Number";
                return;
            }
            status_label.Text = "Connected";
            client.Id = numberBox.Text.ToString();
            DrawingBoard board = new DrawingBoard(client);
            board.FormClosed += new FormClosedEventHandler(DrawingBoard_FormClosed);
            this.Hide();
            board.Show();
        }
        private void DrawingBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
