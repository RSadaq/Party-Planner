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

            populateListBoxes(p.entertainmentPrices, EntertainmentListBox);
            populateListBoxes(p.drinkPrices, DrinksListBox);
            populateListBoxes(p.foodPrices, MenuListBox);

        }

        public void populateListBoxes(Dictionary<string, decimal> items, ListBox x)//method to populate ListBoxes on UI
        {
            foreach (KeyValuePair<string, decimal> item in items)
            {
               x.Items.Add(item.Key);
            }
        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void EntertainmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
