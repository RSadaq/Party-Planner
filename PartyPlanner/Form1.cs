using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Party party = new Party();
        
        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            party.Menu = MenuListBox.SelectedItem.ToString();//Selected item on UI sets value of property 'Menu'.
        }

        private void DrinksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             party.Drink = DrinksListBox.SelectedItem.ToString();
        }

        private void EntrtnmntListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            party.Entertainment = EntertainmentListBox.SelectedItem.ToString();
        }

        private void decorationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            party.DecorationOption = DecorationsListBox.SelectedItem.ToString();
        }

        private void CalculateCostButton_Click(object sender, EventArgs e)
        {
            party.NoOfGuests = (int)numericUpDownGuestNo.Value;
            try
            {
                if (DrinksListBox.SelectedItem == null || numericUpDownGuestNo.Value == 0 || MenuListBox.SelectedItem == null || EntertainmentListBox.SelectedItem == null || DecorationsListBox.SelectedItem == null)
                {
                    throw new ArgumentNullException();
                }
                TotalCostLabel.Text = "£ " + party.CostOfParty().ToString();
            }
            catch (ArgumentNullException ex)
            {
                TotalCostLabel.Text = ex.Message + "You must complete all fields!";
            }
        }       
    }
}
