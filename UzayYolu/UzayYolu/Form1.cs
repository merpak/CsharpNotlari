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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
                default:
                    break;

                
            }
        }
    }
}
