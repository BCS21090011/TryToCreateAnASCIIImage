namespace TryToCreateAnASCIIImage
{

    using AForge.Imaging;
    using AForge.Imaging.Filters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Image = System.Drawing.Image;

    public partial class Form1 : Form
    {

        public string characters;
        public Bitmap img = new Bitmap(720, 360);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(img.Width,img.Height);

            int font_size = 10;

            characters = textBox1.Text;

            Graphics grphc = Graphics.FromImage(bmp);

            Font fnt = new Font("Calibri", font_size);
            SolidBrush brsh = new SolidBrush(Color.Gray);

            for (int i = 0; i < bmp.Width; i += (font_size*characters.Length))
            {
                for (int j = 0; j < bmp.Height; j += font_size)
                {
                    Point pnt = new Point(i, j);

                    grphc.DrawString(characters, fnt, brsh, pnt);
                }
            }

            pictureBox1.Image = bmp;

            img = bmp;

            button2.Visible=true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            img.Save("Output.png", ImageFormat.Png);
        }
    }
}