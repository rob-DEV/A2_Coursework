using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace A2_Coursework.Data
{
    //links booking to their meals
    public class Meal
    {
        public Booking Booking;
        public FoodMenu Menu;
        public int Quantity;

        public Meal(Booking booking, FoodMenu menu, int quanity)
        {
            Booking = booking;
            Menu = menu;
            Quantity = quanity;
        }

        public static bool Add(Meal meal)
        {
            //check the customer input data
            try
            {
                //query string which outputs the inserted id
                string insertQuery =
                 "INSERT INTO bookings_meals (book_id, menu_id, no_of_meals) " +
                 "VALUES (@book_id, @menu_id, @no_of_meals) ";

                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                insertCommand.Parameters.AddWithValue("@book_id", meal.Booking.ID);
                insertCommand.Parameters.AddWithValue("@menu_id", meal.Menu.ID);
                insertCommand.Parameters.AddWithValue("@no_of_meals", meal.Quantity);

                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);

            }
            return false;
        }
        public static bool Update(Meal current_meal, int new_menu_id, int quantity)
        {
            //check the customer input data
            try
            {
                //query string which outputs the inserted id
                string insertQuery = "UPDATE bookings_meals SET menu_id=@menu_id, no_of_meals=@no_of_meals WHERE book_id=@book_id AND menu_id=@old_menu_id";

                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                insertCommand.Parameters.AddWithValue("@book_id", current_meal.Booking.ID);
                insertCommand.Parameters.AddWithValue("@menu_id", new_menu_id);
                insertCommand.Parameters.AddWithValue("@no_of_meals", quantity);
                insertCommand.Parameters.AddWithValue("@old_menu_id", current_meal.Menu.ID);

                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                return false;
            }
        }
        public static List<Meal> RetrieveAll(Booking booking)
        {
            List<Meal> result = new List<Meal>();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings_meals WHERE book_id = @book_id", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@book_id", booking.ID);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Meal(
                    Booking.RetrieveById((int)record["book_id"]),
                    FoodMenu.RetrieveById((int)record["menu_id"]),
                    (int)record["no_of_meals"]
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Meal>();
            }
        }
    }
}
