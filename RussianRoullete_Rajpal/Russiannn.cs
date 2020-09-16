using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete_Rajpal
{
    public partial class Russiannn : Form
    {
        OneClass oneClass = new OneClass();//Creating instance of the external class
        Random randNo = new Random();//Random class instance
        int tChance = 6;//this variable for chances
        int tryingGun = 2;//this is for trying gun variable
        public Russiannn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shotBox.Image = RussianRoullete_Rajpal.Properties.Resources.load2;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Rajpal.Properties.Resources.Loadings);//adding the sound
            soundPlayer.Play();//this sound playing function

            button1.Enabled = false;
            oneClass.LdingRj = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shotBox.Image = RussianRoullete_Rajpal.Properties.Resources.load2;//adding the image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Rajpal.Properties.Resources.Shot);//adding the sound
            soundPlayer.Play();//this sound playing function

            button2.Enabled = false;//button got false

            oneClass.RjSpinning = randNo.Next(1, 6);//random numbers changing 1 to 6
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shotBox.Image = RussianRoullete_Rajpal.Properties.Resources.sshott;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Rajpal.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (tChance > 0 && oneClass.RjSpinning == 1)
            {
                MessageBox.Show("Shoot You loose");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (tChance > 0 && oneClass.RjSpinning != 1)
            {
                MessageBox.Show("Blank Fire");
                tChance = tChance - 1;//minus one from total
                oneClass.RjSpinning = oneClass.LoopRjShot(oneClass.RjSpinning);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shotBox.Image = RussianRoullete_Rajpal.Properties.Resources.sshott;//shootaway image add
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Rajpal.Properties.Resources.Shot);//getting sound
            soundPlayer.Play();//sound paying

            if (tChance > 0 && oneClass.RjSpinning == 1 && tryingGun == 2)
            {
                MessageBox.Show("your score is 200");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            if (tChance > 0 && oneClass.RjSpinning == 1 && tryingGun == 1)
            {
                MessageBox.Show("you win you score is 100");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (tChance > 0 && oneClass.RjSpinning != 1)
            {
                MessageBox.Show("Blank Fire");
                tChance = tChance - 1;//minus one from total
                oneClass.RjSpinning = oneClass.LoopRjShot(oneClass.RjSpinning);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Russiannn()).Show();
            this.Hide();
        }
    }
}
