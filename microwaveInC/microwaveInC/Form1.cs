using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace microwaveInC
{
    public partial class Micro : Form
    {

        Boolean isrunning = false;
        DateTime starttime = new DateTime();
        int powerlevel = 0;
        int numberofseconds = 0;
        float numberofminutes = 0;

        public Micro()
        {

            InitializeComponent();

            this.PowerSlide.Maximum = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();

            this.timer1.Stop();
            this.panel1.BackColor = Color.FromArgb(128 , 128 , 128);
            isrunning = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();
            
            this.panel1.BackColor = Color.FromArgb(222 , 184 , 135);

            this.timer1.Start();
            isrunning = true;   
            numberofseconds = numberofseconds + 30;

            this.TimerBox.Text = numberofseconds.ToString();
            
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();

            this.panel1.BackColor = Color.FromArgb(128 , 128 , 128);
            numberofseconds = 0;

            this.TimerBox.Text=numberofseconds.ToString();

            if (numberofseconds == 0)
            {
                this.timer1.Enabled = false;
                this.panel1.BackColor = Color.FromArgb(128, 128, 128);
                isrunning = false;

                
                player.Play();
               
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\open.wav.");
            player.Play();

            this.panel1.BackColor = Color.FromArgb(128 , 128 , 128);

            if (numberofseconds == 0)
            {
                this.timer1.Enabled = false;
                this.panel1.BackColor = Color.FromArgb(128, 128, 128);
                isrunning = false;

                
                player.Play();
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isrunning == true)
            {
                System.Diagnostics.Debug.WriteLine("working");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("not working");
            }
            
            this.starttime = DateTime.Now;
            this.numberofseconds = numberofseconds - 1;
            this.TimerBox.Text = numberofseconds.ToString();
            
            TimeSpan ts = TimeSpan.FromSeconds(numberofseconds);
            this.TimerBox.Text = ts.Minutes.ToString() + " : " + ts.Seconds.ToString();

            if (numberofseconds == 0)
            {
                this.timer1.Enabled = false;
                this.panel1.BackColor = Color.FromArgb(128, 128, 128);
                isrunning = false;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\long_beep.wav.");
                player.Play();
            }
        }

        private void PowerSlide_Scroll(object sender, EventArgs e)
        {
            powerBox.Text = PowerSlide.Value.ToString();
            
        }

        private void powerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frozen_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();
        }

        private void Defrost_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();
        }

        private void Reheat_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thoma\OneDrive\Desktop\MyProjects\codeatcollege\microwavesounds\microwavebeep.wav.");
            player.Play();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the help menu, let us contact support");
            
        }
    }
}
