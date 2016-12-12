using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rocket.Visible = false;

        }

        int genislik = Form1.ActiveForm.Width;
        int yukseklik = Form1.ActiveForm.Height;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            genislik = this.Width;
            yukseklik = this.Height;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    spaceShip.Left -= 10;
                    break;
                case Keys.Right:
                    spaceShip.Left += 10;
                    break;
                case Keys.Up:
                    spaceShip.Top -= 10;
                    break;
                case Keys.Down:
                    spaceShip.Top += 10;
                    break;
                case Keys.Space:
                    int x = spaceShip.Location.X + spaceShip.Width / 2;
                    int y = spaceShip.Location.Y + spaceShip.Height / 2;
                    rocket.Location = new Point(x, y);
                    rocket.Visible = true;
                    break;

                default:
                    break;

            }

            int SpaceX = spaceShip.Location.X;
            int SpaceY = spaceShip.Location.Y;
            if (SpaceX > genislik - spaceShip.Width || SpaceX < 0)
            {
                MessageBox.Show("Game Over!");
                spaceShip.Location = new Point(10, 10);
                //Application.Exit();

            }
            else if (SpaceY > yukseklik - spaceShip.Height || SpaceY < 0)
            {
                MessageBox.Show("Game Over!");
                spaceShip.Location = new Point(10, 10);
                //Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            genislik = this.Width;
            yukseklik = this.Height;

            if (rocket.Location.X < genislik - rocket.Width * 2)
            {
                rocket.Left += 10;
            }
            else
            {
                timer1.Stop();

            }

        }
    }
}
