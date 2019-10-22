using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace A2_Coursework.Data
{
    /// <summary>
    /// An abstraction of the Menu DB entity in C#
    /// </summary>
    public class FoodMenu
    {
        public int ID { get; private set; }
        public string Meat { get; private set; }
        public string Vegetable_1 { get; private set; }
        public string Vegetable_2 { get; private set; }
        public string Drink { get; private set; }
        public decimal Price { get; private set; }

        //ctor
        public FoodMenu(int menuID, string meatID, string veg1ID, string veg2ID, string drinkID, decimal price)
        {
            ID = menuID;
            Meat = meatID;
            Vegetable_1 = veg1ID;
            Vegetable_2 = veg2ID;
            Drink = drinkID;
            Price = price;
        }

        /// <summary>
        /// Returns a List of all the menus as FoodMenu objects from the DB which are not deleted
        /// </summary>
        /// <returns>List<FoodMenu></returns>
        public static List<FoodMenu> RetrieveAll()
        {
            List<FoodMenu> result = new List<FoodMenu>();

            try
            {
                //access each menu record and get the ids for each stock item
                //then JOIN on the foreign key data (stock name)

                string cmdText = "SELECT menu_id, meat.stock_name, veg1.stock_name, veg2.stock_name, drink.stock_name, menus.menu_price " +
                    "FROM menus INNER JOIN raw_stock meat ON menus.menu_meat_id = meat.stock_id " +
                    "INNER JOIN raw_stock veg1 ON menus.menu_veg_1_id = veg1.stock_id " +
                    "INNER JOIN raw_stock veg2 ON menus.menu_veg_2_id = veg2.stock_id " +
                    "INNER JOIN raw_stock drink ON menus.menu_drink_id = drink.stock_id";

                SqlDataAdapter sda = new SqlDataAdapter(cmdText, Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new FoodMenu(
                    (int)record[0],
                    record[1].ToString(),
                    record[2].ToString(),
                    record[3].ToString(),
                    record[4].ToString(),
                    (decimal)record[5]
                    ));
                }

                return result;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<FoodMenu>();
            }
        }

        /// <summary>
        /// Returns a FoodMenu from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FoodMenu or null if no such menu is found</returns>
        public static FoodMenu RetrieveById(int id)
        {
            try
            {
                //using INNER JOIN to connect the menu and raw_stock tables
                string cmdText = "SELECT menu_id, meat.stock_name, veg1.stock_name, veg2.stock_name, drink.stock_name, menus.menu_price " +
                    "FROM menus INNER JOIN raw_stock meat ON menus.menu_meat_id = meat.stock_id " +
                    "INNER JOIN raw_stock veg1 ON menus.menu_veg_1_id = veg1.stock_id " +
                    "INNER JOIN raw_stock veg2 ON menus.menu_veg_2_id = veg2.stock_id " +
                    "INNER JOIN raw_stock drink ON menus.menu_drink_id = drink.stock_id WHERE menu_id = @menu_id";

                SqlDataAdapter sda = new SqlDataAdapter(cmdText, Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@menu_id", id);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                //grab the customer record
                DataRow custRec = dataResult.Rows[0];

                FoodMenu menu = new FoodMenu(
                    (int)custRec[0],
                    custRec[1].ToString(),
                    custRec[2].ToString(),
                    custRec[3].ToString(),
                    custRec[4].ToString(),
                    (decimal)custRec[5]
                    );

                return menu;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return null;
            }
        }

        /// <summary>
        /// Returns a FoodMenu from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>FoodMenu or null if no such menu is found</returns>
        /// 
        public static bool Add(Raw_Stock meat, Raw_Stock veg_1, Raw_Stock veg_2, Raw_Stock drink, decimal price)
        {
            try
            {

                if(meat != null && veg_1 != null && veg_2 != null && drink != null && price > 0.00m)
                {
                    string insertQuery =
                     "INSERT INTO menus (menu_meat_id, menu_veg_1_id, menu_veg_2_id, " +
                     "menu_drink_id, menu_price) " +
                     "VALUES (@menu_meat_id, @menu_veg_1_id, @menu_veg_2_id, @menu_drink_id, " +
                     "@menu_price)";    
                    SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                    insertCommand.Parameters.AddWithValue("@menu_meat_id", meat.ID);
                    insertCommand.Parameters.AddWithValue("@menu_veg_1_id", veg_1.ID);
                    insertCommand.Parameters.AddWithValue("@menu_veg_2_id", veg_2.ID);
                    insertCommand.Parameters.AddWithValue("@menu_drink_id", drink.ID);
                    insertCommand.Parameters.AddWithValue("@menu_price", price);
                    insertCommand.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return false;
            }
        }
        /// <summary>
        /// Updates a menu record with a different item from the stock DB
        /// </summary>
        /// <param name="menu_id"></param>
        /// <param name="attribute"></param>
        /// <param name="stock_id"></param>
        /// <returns>True or False depending on whether the Update has been successful</returns>
        public static bool UpdateAttribute(int menu_id, string attribute, int stock_id)
        {
            try
            {
                //update menu according the category
                string cmdText = "UPDATE menus SET menu_{0}_id = @stock_id WHERE menu_id = @menu_id";

                //check category to determine which id has to been edited
                switch (attribute)
                {
                    case "meat":
                        cmdText = string.Format(cmdText, attribute);
                        break;
                    case "veg_1":
                        cmdText = string.Format(cmdText, attribute);
                        break;
                    case "veg_2":
                        cmdText = string.Format(cmdText, attribute);
                        break;
                    case "drink":
                        cmdText = string.Format(cmdText, attribute);
                        break;
                    case "price":
                        cmdText = string.Format(cmdText, attribute);
                        break;
                    default:
                        //invalid category
                        return false;
                }

                SqlCommand insertCommand = new SqlCommand(cmdText, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@stock_id", stock_id);
                insertCommand.Parameters.AddWithValue("@menu_id", menu_id);

                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty Customer object
                return false;
            }
        }
        /// <summary>
        /// Updates a menu record with a different price
        /// </summary>
        /// <param name="menu_id"></param>
        /// <param name="attribute"></param>
        /// <param name="stock_id"></param>
        /// <returns>True or False depending on whether the Update has been successful</returns>
        public static bool UpdateAttribute(int menu_id, decimal price)
        {
            try
            {
                //update menu according the category
                string cmdText = "UPDATE menus SET menu_price = @menu_price WHERE menu_id = @menu_id";

                //check category to determine which id has to been edited


                SqlCommand insertCommand = new SqlCommand(cmdText, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@menu_price", price);
                insertCommand.Parameters.AddWithValue("@menu_id", menu_id);

                insertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty Customer object
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Meat, Vegetable_1, Vegetable_2, Drink, Price);
        }

    }
}