using CustomBoat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Boats
{
    public partial class Form1 : Form
    {
        List<AbstractBoat> boatsType = new List<AbstractBoat>();
        List<AbstractBoat> boats = new List<AbstractBoat>();
        List<PictureBox> boatsGraphics = new List<PictureBox>();
        Random rnd = new Random();

        int boatscount = 1000;
        public Form1()
        {
            InitializeComponent();
            Yacht yacht = new Yacht(Image.FromFile("D:\\College\\4 курс 2 семестр\\КПЗ\\Flyweight\\Boats\\boatimage\\Cabo-Yachts-Boat-PNG.png"));
            yacht.SetSize(50, 50);
            yacht.SetCords(10, 10);
            yacht.SetSpeed(10);

            SailBoat sailBoat = new SailBoat(Image.FromFile("D:\\College\\4 курс 2 семестр\\КПЗ\\Flyweight\\Boats\\boatimage\\861011.png"));
            sailBoat.SetSize(50, 50);
            sailBoat.SetCords(10, 10);
            sailBoat.SetSpeed(10);

            LittleBoat littleBoat = new LittleBoat(Image.FromFile("D:\\College\\4 курс 2 семестр\\КПЗ\\Flyweight\\Boats\\boatimage\\300.png"));
            littleBoat.SetSize(50, 50);
            littleBoat.SetCords(10, 10);
            littleBoat.SetSpeed(10);


            int value = 0;
            boatsType.Add(yacht);
            boatsType.Add(sailBoat);
            boatsType.Add(littleBoat);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < boatscount; i++)
            {
                boats.Add(boatsType[rnd.Next(boatsType.Count)].GetCopy());
                //boats[i].SetSize(50,50);
                boats[i].SetCords(0, rnd.Next(this.Size.Height - 50));
                boats[i].SetSpeed(rnd.Next(10, 40));
                boatsGraphics.Add(new PictureBox() { Image = boats[i].image, SizeMode = PictureBoxSizeMode.StretchImage, Size = new Size(boats[i].width, boats[i].height), Left = boats[i].x, Top = boats[i].y, BackColor = TransparencyKey,  });
                Controls.Add(boatsGraphics[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeFrame();
        }

        private void ChangeFrame()
        {
            for (int i = 0; i < boatscount; i++)
            {
                if (boats[i] != null && boats[i].x >= 400)
                {
                    boats[i] = boatsType[rnd.Next(boatsType.Count)].GetCopy();
                    boats[i].SetSize(50, 50);
                    boats[i].SetCords(0, rnd.Next(this.Size.Height - 50));
                    boats[i].SetSpeed(rnd.Next(10, 40));
                    boatsGraphics[i].Image = boats[i].image;
                    boatsGraphics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    boatsGraphics[i].Size = new Size(boats[i].width, boats[i].height);
                    boatsGraphics[i].Left = boats[i].x;
                    boatsGraphics[i].Top = boats[i].y;
                }
                else if (boats[i] != null)
                { 
                    boats[i].SetCords(boats[i].x * boats[i].direction + boats[i].speed, boats[i].y);
                    boatsGraphics[i].Left = boats[i].x;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
