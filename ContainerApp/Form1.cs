using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerApp.Enum;

namespace ContainerApp
{
    public partial class Form1 : Form
    {
        private Ship ship;

        Random rnd = new Random();

        List<Container> containerList = new List<Container>();

        List<Stack> stackList = new List<Stack>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int length = 0;
            int width = 0;

            if (int.TryParse(numUpDown1.Text, out length) && int.TryParse(numUpDown2.Text, out width))
            {
                try
                {
                    if (width != 0 || length != 0)
                    {
                        ship = new Ship(width, length);
                        btnCreateContainer.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ship.Width * 2 + 1; i++)
            {
                Container cont = new Container(i, rnd.Next(4000, 30000), ContainerType.Gekoeld);
                containerList.Add(cont);
                lbxContainers.Items.Add(cont.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                Container cont = new Container(i, rnd.Next(4000, 30000), ContainerType.Waardevol);
                containerList.Add(cont);
                lbxContainers.Items.Add(cont.ToString());
            }
            for (int i = 0; i < 50; i++)
            {
                Container cont = new Container(i, rnd.Next(4000, 30000), ContainerType.Standaard);
                containerList.Add(cont);
                lbxContainers.Items.Add(cont.ToString());
            }

            btnStartVisualize.Enabled = true;
        }

        private void btnStartVisualize_Click(object sender, EventArgs e)
        {
            ship.ShipVisualize();
        }
    }
}