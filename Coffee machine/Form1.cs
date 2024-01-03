using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_machine
{
    public partial class Form1 : Form
    {
        Coffee_Maker Coffee_Machine;
        public Form1()
        {
            InitializeComponent();
            Coffee_Machine = new Coffee_Maker();
            UpdateTextBoxs();
        }

        private void Black_Coffee_Click(object sender, EventArgs e)
        {
            bool make = Coffee_Machine.BlackCoffee();
            if (make)
            {
                pictureBox2.Image = Properties.Resources.Black_coffee;
                UpdateTextBoxs();
            }
            else
            {
                pictureBox2.Image= Properties.Resources.Sorry_Out_of_order;
            }
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            bool make = Coffee_Machine.latte ();
            if (make)
            {
                pictureBox2.Image = Properties.Resources.Latte;
                UpdateTextBoxs();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Sorry_Out_of_order;
             }
        }

        private void Mocca_Click(object sender, EventArgs e)
        {
            bool make = Coffee_Machine.mocca();
            if (make)
            {
                pictureBox2.Image = Properties.Resources.mocca;
                UpdateTextBoxs();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Sorry_Out_of_order;
            }
        }

        private void Chocolate_Click(object sender, EventArgs e)
        {
            bool make = Coffee_Machine.Chocolate();
            if (make)
            {
                pictureBox2.Image = Properties.Resources.chocolate;
                UpdateTextBoxs();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Sorry_Out_of_order;
            }
        }
        private void UpdateTextBoxs()
        {
            water_Box.Text = Coffee_Machine.water.ToString();
            Coffee_Box.Text = Coffee_Machine.coffee.ToString();
            milk_Box.Text = Coffee_Machine.milk.ToString();
            Chocolate_Box.Text = Coffee_Machine.chocolate.ToString();
        }
    }
}
