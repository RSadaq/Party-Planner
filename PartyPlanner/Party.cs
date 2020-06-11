using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PartyPlanner
{
    public class Party
    {

        public Party()
        {
            SetPricesFromDatabase();
        }

        public Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
        public int NoOfGuests;
        private decimal DrinksCost;
        private string drink;
        private string menu;
        private decimal MenuCost;
        private string Decorations;
        private decimal DecorationPrice;
        private string entertainment;
        private decimal EntertainmentPrice;
        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feroz\OneDrive\Documents\csharpProjects\PartyPlanner\PartyPlanner\PartyPlannerPrices.mdf;Integrated Security = True";

        public void SetPricesFromDatabase()
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command;//Need this to query
            SqlDataReader reader;//For viewing result
            String sql = "";
            sql = "SELECT Party_Item, Price FROM dbo.[Party Planner];";
            command = new SqlCommand(sql, con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                prices.Add(reader["Party_Item"].ToString(), (decimal)reader["Price"]);
            }
        }

        public string Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
                if (menu == "Non-Vegan")
                {
                    MenuCost = prices["Non-Vegan Menu"];
                }
                else if (menu == "Vegan")
                {
                    MenuCost = prices["Vegan Menu"];
                }
                else
                {
                    MenuCost = prices["Snacks"];
                }
            }
        }
        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                if (value == "Alcoholic")
                {
                    DrinksCost = prices["Alcoholic Drink"];
                }

                else
                {
                    DrinksCost = prices["Non-Alcoholic Drink"];
                }

            }
        }

        public string Entertainment
        {
            get
            {
                return entertainment;
            }
            set
            {
                entertainment = value;
                if (value == "DJ")
                {
                    EntertainmentPrice = prices["DJ"];
                }
                else if (value == "Live Entertainment")
                {
                    EntertainmentPrice = prices["Live Entertainment"]; 
                }
                else
                {
                    EntertainmentPrice = 0M;
                }
            }
        }

        public string DecorationOption
        {
            get
            {
                return Decorations;
            }
            set
            {
                Decorations = value;

                if(value == "Yes")
                {
                    DecorationPrice = prices["Decorations"];
                }
                else
                {
                    DecorationPrice = 0M;
                }
            }
        }

        public decimal CostOfParty()//Calculates total cost
        {
             return ((MenuCost + DrinksCost) * NoOfGuests) + EntertainmentPrice + DecorationPrice;           
        }
    }
}
