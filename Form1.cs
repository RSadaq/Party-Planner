using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Party p = new Party();

          

            foreach (KeyValuePair<string, decimal> drink in p.drinkPrices)

            {
                DrinksListBox.Items.Add(drink.Key);
            }

            foreach (KeyValuePair<string, decimal> food in p.foodPrices)
            {
                MenuListBox.Items.Add(food.Key);
            }

            foreach (KeyValuePair<string, decimal> entertainment in p.entertainmentPrices)
            {
                EntertainmentListBox.Items.Add(entertainment.Key);
            }

        }

        public void populateListBoxes()
        {

        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void EntertainmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
