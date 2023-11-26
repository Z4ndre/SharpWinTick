using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_7
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent ( );
        }
        int n = 0;
        int min = 0;
        int sec = 0;
        private void button1_Click ( object sender, EventArgs e )
        {
            
            if (button1.Text == "Старт" )
            {
                button1.Text = "Стоп";
                timer1.Start ( );
            }
            else
            {
                button1.Text = "Старт";
                timer1.Stop ( );
            }
        }

        private void timer1_Tick ( object sender, EventArgs e )
        {
            n++;
            if (n%2 == 0 )
            {
                label3.Text = "";
            }
            else
            {
                label3.Text = ":";
            }
            sec++;

            if ( sec < 60 )
            {
                if ( sec < 10 )
                {
                    label2.Text = "0" + sec.ToString ( );
                }
                else
                {
                    label2.Text = sec.ToString ( );
                }
            }
            else
            {
                label2.Text = "00";
                sec = 0;
                min++;
                if ( min < 10 )
                {
                    label1.Text = "0" + min.ToString ( );
                }
                else
                {
                    label1.Text = min.ToString ( );
                }
            }
            switch ( label1.Text )
            {
                case "00":
                    {
                        pictureBox1.ImageLocation = @"1.jpg";
                        break;
                    }
                case "08":
                    {
                        pictureBox1.ImageLocation = @"2.jpg";
                        break;
                    }
                case "10":
                    {
                        pictureBox1.ImageLocation = @"3.jpg";
                        break;
                    }
                case "11":
                    {
                        pictureBox1.ImageLocation = @"4.jpg";
                        break;
                    }
                case "16":
                    {
                        pictureBox1.ImageLocation = @"5.jpg";
                        break;
                    }
                case "17":
                    {
                        pictureBox1.ImageLocation = @"6.jpg";
                        break;
                    }
                case "18":
                    {
                        pictureBox1.ImageLocation = @"7.jpg";
                        break;
                    }
                case "23":
                    {
                        pictureBox1.ImageLocation = @"1.jpg";
                        break;
                    }
            }
            if (label1.Text == "23" )
            {
                if ( label2.Text == "59" )
                {
                    min = 0;
                    label1.Text = "0" + min.ToString ( );
                    sec = 0;
                }
            }
        }
    }
}
