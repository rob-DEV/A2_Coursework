using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class field validation
using System.Reflection;
using System.Data;
using System.Data.SqlClient;

namespace A2_Coursework.Data
{
    public class Raw_Stock
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public int Quantity { get; private set; }
        public int ReorderLevel { get; private set; }
        public decimal Price { get; private set; }
        public Supplier Supplier { get; private set; }


        /// <summary>
        /// Private constructor used if DB returns an invalid or NULL result
        /// </summary>
        private Raw_Stock()
        {
            //should never be called
        }

        public Raw_Stock(
            int stock_id, string name, string category, int quanity, int reorderLevel,
            decimal price, Supplier supplier = null)
        {
            ID = stock_id;
            Name = name;
            Category = category;
            Quantity = quanity;
            ReorderLevel = reorderLevel;
            Price = price;
            Supplier = supplier;
        }

        public Raw_Stock(string name, string category, int quanity, int reorderLevel, decimal price, Supplier supplier = null)
        {
            Name = name;
            Category = category;
            Quantity = quanity;
            ReorderLevel = reorderLevel;
            Price = price;
            Supplier = supplier;
        }
        private bool ValidateFields(Raw_Stock stockItem)
        {
            //checks each feild in the class to see wether they are null / empty
            foreach (PropertyInfo pi in stockItem.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(stockItem);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            //validation passed
            return true;
        }
        public static List<Raw_Stock> RetrieveAll()
        {
            List<Raw_Stock> result = new List<Raw_Stock>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM raw_stock", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Raw_Stock(
                    (int)record["stock_id"],
                    record["stock_name"].ToString(),
                    record["stock_category"].ToString(),
                    (int)record["stock_qty"],
                    (int)record["stock_reorder_level"],
                    (decimal)record["stock_price"],
                    Supplier.RetrieveById(Convert.ToInt32(record["sup_id"]
                    ))
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Raw_Stock>();
            }

        }
        public static List<Raw_Stock> RetrieveLowStock()
        {
            List<Raw_Stock> result = new List<Raw_Stock>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM raw_stock WHERE stock_qty < stock_reorder_level", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Raw_Stock(
                    (int)record["stock_id"],
                    record["stock_name"].ToString(),
                    record["stock_category"].ToString(),
                    (int)record["stock_qty"],
                    (int)record["stock_reorder_level"],
                    (decimal)record["stock_price"],
                    Supplier.RetrieveById((int)(record["sup_id"]))
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Raw_Stock>();
            }

        }
        public static Raw_Stock RetrieveById(int id)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM raw_stock WHERE stock_id = @stock_id", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@stock_id", id);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                DataRow record = dataResult.Rows[0];

                //get the supplier from the id found in the query above

                return new Raw_Stock(
                (int)record["stock_id"],
                record["stock_name"].ToString(),
                record["stock_category"].ToString(),
                (int)record["stock_qty"],
                (int)record["stock_reorder_level"],
                (decimal)record["stock_price"],
                Supplier.RetrieveById((int)(record["sup_id"]))
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return null;
            }

        }
        /// <summary>
        /// Searchs the stock table based on a key term given
        /// </summary>
        /// <returns></returns>
        public static List<Raw_Stock> Search(string search_term)
        {
            List<Raw_Stock> result = new List<Raw_Stock>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM raw_stock WHERE stock_name LIKE @search_term OR stock_category LIKE @search_term", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@search_term", string.Format("%{0}%", search_term));
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                Console.WriteLine(dataResult.Rows.Count);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Raw_Stock(
                    (int)record["stock_id"],
                    record["stock_name"].ToString(),
                    record["stock_category"].ToString(),
                    (int)record["stock_qty"],
                    (int)record["stock_reorder_level"],
                    (decimal)record["stock_price"],
                    Supplier.RetrieveById((int)record["sup_id"])
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Raw_Stock>();
            }

        }
        public static bool Add(Raw_Stock stockItem)
        {
            //check the customer input data
            try
            {
                string insertQuery =
                 "INSERT INTO raw_stock (stock_name, stock_category, stock_qty, " +
                 "stock_reorder_level, stock_price, sup_id) " +
                 "VALUES (@stock_name, @stock_category, @stock_qty, @stock_reorder_level, " +
                 "@stock_price, @sup_id)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                insertCommand.Parameters.AddWithValue("@stock_name", stockItem.Name);
                insertCommand.Parameters.AddWithValue("@stock_category", stockItem.Category);
                insertCommand.Parameters.AddWithValue("@stock_qty", stockItem.Quantity);
                insertCommand.Parameters.AddWithValue("@stock_reorder_level", stockItem.ReorderLevel);
                insertCommand.Parameters.AddWithValue("@stock_price", stockItem.Price);
                insertCommand.Parameters.AddWithValue("@sup_id", stockItem.Supplier.ID);

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
        public static bool Update(Raw_Stock stockItem)
        {
            //check the customer input data
            try
            {
                string insertQuery =
                 "UPDATE raw_stock SET stock_name=@stock_name, stock_category=@stock_category, " +
                 "stock_qty=@stock_qty, stock_reorder_level=@stock_reorder_level, " +
                 "stock_price=@stock_price, sup_id=@sup_id WHERE stock_id=@stock_id";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                insertCommand.Parameters.AddWithValue("@stock_name", stockItem.Name);
                insertCommand.Parameters.AddWithValue("@stock_category", stockItem.Category);
                insertCommand.Parameters.AddWithValue("@stock_qty", stockItem.Quantity);
                insertCommand.Parameters.AddWithValue("@stock_reorder_level", stockItem.ReorderLevel);
                insertCommand.Parameters.AddWithValue("@stock_price", stockItem.Price);
                insertCommand.Parameters.AddWithValue("@sup_id", stockItem.Supplier.ID);
                insertCommand.Parameters.AddWithValue("@stock_id", stockItem.ID);

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

    }
}
