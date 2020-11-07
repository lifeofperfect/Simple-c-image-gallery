using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_gallery
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void goNext(object sender, EventArgs e)
        {
            i++;

            if (i > 7)
            {
                i = 1;
            }

            changeImage(i);

        }

        private void goBack(object sender, EventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 7;
            }

            changeImage(i);

        }

        private void changeImage(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.city1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.profile1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.profile2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.profile3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.profile4;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.profile5;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.profile6;
                    break;
            }
        }
    }
}
