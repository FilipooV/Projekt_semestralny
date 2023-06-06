using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projekt
{
    public partial class Form2 : Form
    {
        private string name;
        private string path = "potrawy.txt";


        private void Wyswietl(int index)
        {
            string linie = File.ReadAllText("potrawy.txt");
            string[] linies = linie.Split(';');

            Potrawa burgers = new Potrawa
                (linies[0 + (4 * index)], 
                linies[1 + (4 * index)],
                linies[2 + (4 * index)],
                linies[3 + (4* index)]
                );
            burgers.Display(label2, label3, label5, label7);
        }

        public Form2()
        {
            InitializeComponent();

            name = Form1.MyListString;

            Loading();

            



            

        }
        private void Loading()
        {
            pictureBox2.Size = new Size(200, 150);


            string[] potrawy = {
                "Burger Drwala",
                "McWrap",
                "Big Mac",
                "McRoyal",
                "McChicken",
                "McDouble",
                "Jalapeño Burger",
                "Cheeseburger",
            };

            string MainPath = @"img\\";
            Bitmap ImgDrwal0 = new Bitmap(MainPath + "drwal.png");
            Bitmap ImgDrwal1 = new Bitmap(MainPath + "mcwrap.png");
            Bitmap ImgDrwal2 = new Bitmap(MainPath + "bigmac.png");
            Bitmap ImgDrwal3 = new Bitmap(MainPath + "mcroyal.png");
            Bitmap ImgDrwal4 = new Bitmap(MainPath + "mcchicken.png");
            Bitmap ImgDrwal5 = new Bitmap(MainPath + "mcdouble.png");
            Bitmap ImgDrwal6 = new Bitmap(MainPath + "jalapenoburger.png");
            Bitmap ImgDrwal7 = new Bitmap(MainPath + "cheeseburger.png");


            if (name.Contains(potrawy[0]))
            {
                Wyswietl(0);
                pictureBox2.Image = ImgDrwal0;
            }
            else if (name.Contains(potrawy[1]))
            {
                Wyswietl(1);
                pictureBox2.Image = ImgDrwal1;

            }
            else if (name.Contains(potrawy[2]))
            {
                Wyswietl(2);
                /*label2.Text = linies[0 + 2 * xPlacesNext];
                label3.Text = linies[1 + 2 * xPlacesNext];
                label5.Text = linies[2 + 2 * xPlacesNext];
                label7.Text = linies[3 + 2 * xPlacesNext];*/
                pictureBox2.Image = ImgDrwal2;

            }
            else if (name.Contains(potrawy[3]))
            {
                Wyswietl(3);

                pictureBox2.Image = ImgDrwal3;

            }
            else if (name.Contains(potrawy[4]))
            {
                Wyswietl(4);

                pictureBox2.Image = ImgDrwal4;

            }
            else if (name.Contains(potrawy[5]))
            {
                Wyswietl(5);

                pictureBox2.Image = ImgDrwal5;

            }
            else if (name.Contains(potrawy[6]))
            {
                Wyswietl(6);

                pictureBox2.Image = ImgDrwal6;

            }
            else if (name.Contains(potrawy[7]))
            {
                Wyswietl(7);

                pictureBox2.Image = ImgDrwal7;

            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(43, 115, 111);


        }
    }
}
