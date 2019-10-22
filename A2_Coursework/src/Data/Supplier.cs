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
    /// <summary>
    /// An abstraction of the Supplier DB entity in C#
    /// </summary>
    public class Supplier
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string Postcode { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        //ctor where the id is known
        public Supplier(
            int id, string name, string address, string address2,
            string city, string postcode, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            Address2 = address2;
            City = city;
            Postcode = postcode;
            Phone = phone;
            Email = email;
        }

        //ctor where the id is not known
        public Supplier(
            string name, string address, string address2,
            string city, string postcode, string phone, string email)
        {
            ID = -1;
            Name = name;
            Address = address;
            Address2 = address2;
            City = city;
            Postcode = postcode;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Validates the objects data, checks for null or empty strings and negative ids
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>True or False depending on whether or not the data is valid</returns>
        private bool ValidateFields(Supplier supplier)
        {
            //validate text only - names, city.
            if (!supplier.Name.All(Char.IsLetter) || !supplier.Address.All(Char.IsLetter) || !supplier.City.All(Char.IsLetter))
                return false; 

            //checks each field in the class to see wether they are null / empty
            foreach (PropertyInfo pi in supplier.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    //skip address line 2 as it can be NULL
                    if (pi.Name == "Address2" || pi.Name == "Email")
                        continue;
                    string value = (string)pi.GetValue(supplier);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            //validation passed
            return true;
        }

        /// <summary>
        /// Returns a List of all the Suppliers as Supplier objects from the DB which are not deleted
        /// </summary>
        /// <returns>List<Supplier></returns>
        public static List<Supplier> RetrieveAll()
        {
            List<Supplier> result = new List<Supplier>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM suppliers WHERE sup_deleted = 0", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Supplier(
                    (int)record["sup_id"],
                    record["sup_name"].ToString(),
                    record["sup_add_1"].ToString(),
                    record["sup_add_2"].ToString(),
                    record["sup_city"].ToString(),
                    record["sup_postcode"].ToString(),
                    record["sup_phone"].ToString(),
                    record["sup_email"].ToString()
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Supplier>();
            }
        }

        /// <summary>
        /// Returns a List of all the Suppliers as Supplier objects from the DB which have been marked as deleted
        /// </summary>
        /// <returns>List<Supplier></returns>
        public static List<Supplier> RetrieveAllDeleted()
        {
            List<Supplier> result = new List<Supplier>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM suppliers WHERE sup_deleted = 1", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Supplier(
                    (int)record["sup_id"],
                    record["sup_name"].ToString(),
                    record["sup_add_1"].ToString(),
                    record["sup_add_2"].ToString(),
                    record["sup_city"].ToString(),
                    record["sup_postcode"].ToString(),
                    record["sup_phone"].ToString(),
                    record["sup_email"].ToString()
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Supplier>();
            }

        }

        /// <summary>
        /// Returns a Supplier from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Supplier or null if no such supplier is found</returns>
        public static Supplier RetrieveById(int id)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM suppliers WHERE sup_id = @supplier_id", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@supplier_id", id);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                //grab the supplier record
                DataRow supRec = dataResult.Rows[0];

                Supplier supplier = new Supplier(
                    (int)supRec["sup_id"],
                    supRec["sup_name"].ToString(),
                    supRec["sup_add_1"].ToString(),
                    supRec["sup_add_2"].ToString(),
                    supRec["sup_city"].ToString(),
                    supRec["sup_postcode"].ToString(),
                    supRec["sup_phone"].ToString(),
                    supRec["sup_email"].ToString()
                    );

                return supplier;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return null;
            }

        }

        /// <summary>
        /// Takes a given Supplier object and inserts it into the DB
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>True or False if the Supplier has been added successfully</returns>
        public static bool Add(Supplier supplier)
        {
            //check the supplier input data
            if (!supplier.ValidateFields(supplier))
            {
                Console.WriteLine("Bad input");
                return false;
            }

            try
            {
                string insertQuery =
                    "INSERT INTO suppliers " +
                    "(sup_name, sup_add_1, sup_add_2, sup_city, sup_postcode, sup_phone, sup_email) " +
                    "VALUES " +
                    "(@sup_name, @sup_add_1, @sup_add_2, @sup_city, @sup_postcode, @sup_phone, @sup_email)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@sup_name", supplier.Name);
                insertCommand.Parameters.AddWithValue("@sup_add_1", supplier.Address);
                insertCommand.Parameters.AddWithValue("@sup_add_2", supplier.Address2);
                insertCommand.Parameters.AddWithValue("@sup_city", supplier.City);
                insertCommand.Parameters.AddWithValue("@sup_postcode", supplier.Postcode);
                insertCommand.Parameters.AddWithValue("@sup_phone", supplier.Phone);
                insertCommand.Parameters.AddWithValue("@sup_email", supplier.Email);

                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        /// <summary>
        /// Takes a given Supplier object and updates it in the DB
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns>True or False if the Supplier has been amended successfully</returns>
        public static bool Update(Supplier supplier)
        {
            //check the supplier input data
            if (!supplier.ValidateFields(supplier))
            {
                Console.WriteLine("Incorrect / missing Inputs");
                return false;
            }

            try
            {
                string insertQuery =
                    "UPDATE suppliers SET sup_name=@sup_name, sup_add_1=@sup_add_1,sup_add_2=@sup_add_2, sup_city=@sup_city, sup_postcode=@sup_postcode, sup_phone=@sup_phone, sup_email=@sup_email WHERE sup_id=@sup_id";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@sup_name", supplier.Name);
                insertCommand.Parameters.AddWithValue("@sup_add_1", supplier.Address);
                insertCommand.Parameters.AddWithValue("@sup_add_2", supplier.Address2);
                insertCommand.Parameters.AddWithValue("@sup_city", supplier.City);
                insertCommand.Parameters.AddWithValue("@sup_postcode", supplier.Postcode);
                insertCommand.Parameters.AddWithValue("@sup_phone", supplier.Phone);
                insertCommand.Parameters.AddWithValue("@sup_email", supplier.Email);
                insertCommand.Parameters.AddWithValue("@sup_id", supplier.ID);


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

        /// <summary>
        /// Deletes a Supplier from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False if the deletion has been successful</returns>
        public static bool DeleteByID(int id)
        {
            //this doesn't actually delete any data it simply marks the supplier record and their booking
            //record(s) as deleted
            try
            {
                string deleteSup = "UPDATE suppliers SET sup_deleted= 1 WHERE sup_id = @sup_id";
                SqlCommand delSupCmd = new SqlCommand(deleteSup, Database.GetConnection());

                delSupCmd.Parameters.AddWithValue("@sup_id", id);

                delSupCmd.ExecuteNonQuery();
                delSupCmd.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

            return false;

        }

        /// <summary>
        /// Undeletes a Supplier from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False if the un-deletion has been successful</returns>
        public static bool UndeleteByID(int id)
        {
            //unhides the supplier and their bookings
            try
            {
                string undeleteQuery = "UPDATE suppliers SET sup_deleted= 0 WHERE sup_id = @sup_id";
                SqlCommand undeleteCommand = new SqlCommand(undeleteQuery, Database.GetConnection());

                undeleteCommand.Parameters.AddWithValue("@sup_id", id);
                undeleteCommand.ExecuteNonQuery();
                undeleteCommand.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

            return false;

        }

        //Used to adapt how the object is displayed in the datagrid UI
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
