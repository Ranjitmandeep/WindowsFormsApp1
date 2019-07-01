using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formplaygame : Form
    {
        public Formplaygame()
        {
            InitializeComponent();
        }
        RussianRoulleteclass  objRussianRoullete = new RussianRoulleteclass();
        Random numb = new Random();
        private void Formplaygame_Load(object sender, EventArgs e)
        {

        }

        private void btreload_Click(object sender, EventArgs e)
        {
            (new Formplaygame()).Show();
            this.Hide();
        }

        private void btgunload_Click(object sender, EventArgs e)
        {
           btgunspin.Enabled = true;
            btgunload.Enabled = false;
            videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\load.gif");

        }

        private void btgunspin_Click(object sender, EventArgs e)
        {
            objRussianRoullete.bulletespinedgun = numb.Next(1, 6);
            btgunshoot .Enabled = true;
            btgunspin.Enabled = false;
            objRussianRoullete.totalshottofire = 2;
            videoplayer .Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\spin.gif");


        }
        public int Missshotbtn()
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
                objRussianRoullete.totalshottofire  = objRussianRoullete.totalshottofire - 1;

                objRussianRoullete.bulletespinedgun = gunloadspinner(objRussianRoullete.bulletespinedgun);



            }
            return objRussianRoullete.Winningbullete;
        }

        private void btgunshoot_Click(object sender, EventArgs e)
        {
            int shootaway = objRussianRoullete.Shootbullete();
            if (shootaway == 1)
            {
                MessageBox.Show("Gun shot Game over you loose");
                btgunshoot .Enabled = false;
                Btshoot .Enabled = false;
                btgunspin .Enabled = false;
                btgunload.Enabled = false;
                videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\spin.gif");


            }
            if (shootaway == 2)//it is a if statement runs only if
            {


                objRussianRoullete.lodedshots = objRussianRoullete.lodedshots - 1;
                objRussianRoullete.bulletespinedgun = gunloadspinner(objRussianRoullete.bulletespinedgun);
                MessageBox.Show("missedbullete");
            }

        }
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
        private void Btshoot_Click(object sender, EventArgs e)
        {
            int gunshootaway = Missshotbtn();
            if (gunshootaway == 1000)//it is a if statement runs only if
            {

                MessageBox.Show("Winner score==1000");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;
                videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\spin.gif");

            }
            if (gunshootaway == 500)//it is a if statement runs only if
            {
                MessageBox.Show("Winner score==500");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;
                videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\spin.gif");

            }
            if (gunshootaway == 0)//it is a if statement runs only if
            {

                MessageBox.Show("missed bullete");
            }
            if (objRussianRoullete.lodedshots == 0)//it is a if statement runs only if
            {

                MessageBox.Show("Gun shot Game over you loose");
                btgunshoot.Enabled = false;
                Btshoot.Enabled = false;
                btgunspin.Enabled = false;
                btgunload.Enabled = false;
                videoplayer.Image = Image.FromFile(@"C:\Users\sunny\source\repos\russian Rollete 1\Russian Rollete\Res\spin.gif");



            }
        }
    }
}
