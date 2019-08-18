using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1

{
    public partial class Formplaygame : Form
    {
        public Formplaygame()
        {
            InitializeComponent();
        }
        RussianRoulleteclass objRussianRoullete = new RussianRoulleteclass();
        Random numb = new Random();
        private object rr_game;

        private void Formplaygame_Load(object sender, EventArgs e)
        {

        }
        // The below button will reload 
        private void btreload_Click(object sender, EventArgs e)
        {
            (new Formplaygame()).Show();
            this.Hide();
        }

        //  The below button will enable the gun to spin.
        private void btgunload_Click(object sender, EventArgs e)
        {
            btgunspin.Enabled = true;
            btgunload.Enabled = false;
            //videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\load.gif");
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._1;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.load;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Bitmap bmp = new Bitmap(myStream);
            //pic_box_main.Image = bmp;
            //coding for sounds//
            videoplayer.Image = WindowsFormsApp1.Properties.Resources.main;

            //SoundPlayer player = new SoundPlayer(rr_game.Properties.Resources.spin);
            //player.Play()
        }
        int Missshotbtn()
        {

            if (objRussianRoullete.bulletespinedgun == 1 && objRussianRoullete.totalshottofire == 2 && objRussianRoullete.lodedshots > 0)
            {

                objRussianRoullete.Winningbullete = 1000;


            }
            if (objRussianRoullete.bulletespinedgun == 1 && objRussianRoullete.totalshottofire == 1 && objRussianRoullete.lodedshots > 0)
            {

                objRussianRoullete.Winningbullete = 500;

            }

            else if (objRussianRoullete.lodedshots > 0 && objRussianRoullete.bulletespinedgun != 1)
            {
                objRussianRoullete.Winningbullete = 0;
                objRussianRoullete.lodedshots = objRussianRoullete.lodedshots - 1;
                objRussianRoullete.totalshottofire = objRussianRoullete.totalshottofire - 1;

                objRussianRoullete.bulletespinedgun = gunloadspinner(objRussianRoullete.bulletespinedgun);



            }
            return objRussianRoullete.Winningbullete;
        }
        // This button will use to shoot the gun and will show you loose and game over.
        private void btgunshoot_Click(object sender, EventArgs e)
        {
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._2;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int shootaway = objRussianRoullete.Shootbullete();
            if (shootaway == 1)
            {
                MessageBox.Show("Gun shot Game over you loose");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;


            }
            if (shootaway == 2)//it is a if statement runs only if
            {


                objRussianRoullete.lodedshots = objRussianRoullete.lodedshots - 1;
                objRussianRoullete.bulletespinedgun = gunloadspinner(objRussianRoullete.bulletespinedgun);
                MessageBox.Show("missedbullete");
            }

        }
        // The below button will spin the gun 6 times
        public int gunloadspinner(int loderspin)
        {
            if (loderspin == 6)
            {
                loderspin = 1;
            }
            else
            {
                loderspin++;
            }
            return loderspin;
        }
        // The below button will use to shoot away
        private void Btshoot_Click(object sender, EventArgs e)
        {
            videoplayer.Image = WindowsFormsApp1.Properties.Resources._3;
            System.IO.Stream str = WindowsFormsApp1.Properties.Resources.shoot;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int gunshootaway = Missshotbtn();
            if (gunshootaway == 1000)//it is a if statement runs only if
            {

                MessageBox.Show("Winner score==1000");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;

            }
            if (gunshootaway == 500)//it is a if statement runs only if
            {
                MessageBox.Show("Winner score==500");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;

            }
            if (gunshootaway == 0)//it is a if statement runs only if
            {

                MessageBox.Show("missed bullete");// This button will use to show the message missed bullete
            }
            if (objRussianRoullete.lodedshots == 0)//it is a if statement runs only if
            {

                MessageBox.Show("Gun shot Game over you loose");// This message will pop-up when you will loose your game
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;



            }
        }
    }
}
