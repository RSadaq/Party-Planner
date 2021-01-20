using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2
{
    public class Party
    {
        public Party()
        {
            PopulateFood();
            PopulateDrink();
            PopulateEntertainment();
        }

        public Dictionary<string, decimal> foodPrices = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> drinkPrices = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> entertainmentPrices = new Dictionary<string, decimal>();
        private bool Decorations;
        private const decimal decorationsCost = 200;
       
        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rehana\csharpProjects\PartyPlanner\PartyPlanner\PartyPlannerPrices.mdf;Integrated Security = True";

        public void PopulateFood()
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command;//Need this to query
            SqlDataReader reader;//For viewing result
            String sql = "";
            sql = "SELECT Menu, Price FROM dbo.[MenuPrices];";
            command = new SqlCommand(sql, con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                foodPrices.Add(reader["Menu"].ToString(), (decimal)reader["Price"]);
            }

          
        }

        public void PopulateDrink()
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command;
            SqlDataReader reader;
            String sql = "";
            sql = "SELECT Drink, Price FROM dbo.[drinkPrices];";
            command = new SqlCommand(sql, con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                drinkPrices.Add(reader["Drink"].ToString(), (decimal)reader["Price"]);
            }
        }

        public void PopulateEntertainment()
        {
            SqlConnection con;
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command;
            SqlDataReader reader;
            String sql = "";
            sql = "SELECT Entertainment, Price FROM dbo.[EntertainmentPrices];";
            command = new SqlCommand(sql, con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                entertainmentPrices.Add(reader["Entertainment"].ToString(), (decimal)reader["Price"]);
            }
        }
    }
}
