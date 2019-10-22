using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class field validation
using System.Reflection;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace A2_Coursework.Data
{
    /// <summary>
    /// An abstraction of the Customer DB entity in C#
    /// </summary>
    public class Customer
    {
        public int ID { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Address { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string Postcode { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        //ctor where the id is known
        public Customer(
            int custid, string firstName, string lastName, string address, string address2,
            string city, string postcode, string phone, string email)
        {
            ID = custid;
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
            Address2 = address2;
            City = city;
            Postcode = postcode;
            Phone = phone;
            Email = email;
        }

        //ctor where the id is not known
        public Customer(
            string firstName, string lastName, string address, string address2,
            string city, string postcode, string phone, string email)
        {
            ID = -1;
            Firstname = firstName;
            Lastname = lastName;
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
        /// <param name="customer"></param>
        /// <returns>True or False depending on whether or not the data is valid</returns>
        private bool ValidateFields(Customer customer)
        {
            //validate text only - names, city.
            if (!customer.Firstname.All(Char.IsLetter) || !customer.Lastname.All(Char.IsLetter) || !customer.City.All(Char.IsLetter))
                return false; 
            
            //Validates each field of the object using Reflection
            foreach (PropertyInfo pi in customer.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {

                    //skip address line 2 and email as they can be NULL
                    if (pi.Name == "Address2" || pi.Name == "Email")
                        continue;

                    string value = (string)pi.GetValue(customer);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            //validation passed
            return true;
        }

        /// <summary>
        /// Returns a List of all the Customers as Customer objects from the DB which are not deleted
        /// </summary>
        /// <returns>List<Customer></returns>
        public static List<Customer> RetrieveAll()
        {
            List<Customer> result = new List<Customer>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customers WHERE cust_deleted = 0", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Customer(
                    (int)record["cust_id"],
                    record["cust_firstname"].ToString(),
                    record["cust_lastname"].ToString(),
                    record["cust_add_1"].ToString(),
                    record["cust_add_2"].ToString(),
                    record["cust_city"].ToString(),
                    record["cust_postcode"].ToString(),
                    record["cust_phone"].ToString(),
                    record["cust_email"].ToString()
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Customer>();
            }

        }

        /// <summary>
        /// Returns a List of all the Customers as Customer objects from the DB which have been marked as deleted
        /// </summary>
        /// <returns>List<Customer></returns>
        public static List<Customer> RetrieveAllDeleted()
        {
            List<Customer> result = new List<Customer>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customers WHERE cust_deleted = 1", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Customer(
                    (int)record["cust_id"],
                    record["cust_firstname"].ToString(),
                    record["cust_lastname"].ToString(),
                    record["cust_add_1"].ToString(),
                    record["cust_add_2"].ToString(),
                    record["cust_city"].ToString(),
                    record["cust_postcode"].ToString(),
                    record["cust_phone"].ToString(),
                    record["cust_email"].ToString()
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Customer>();
            }

        }

        /// <summary>
        /// Returns a Customer from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Customer or null if no such customer is found</returns>
        public static Customer RetrieveById(int id)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customers WHERE cust_id = @cust_id", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@cust_id", id);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                //grab the customer record
                DataRow custRec = dataResult.Rows[0];

                Customer customer = new Customer(
                    (int)custRec["cust_id"],
                    custRec["cust_firstname"].ToString(),
                    custRec["cust_lastname"].ToString(),
                    custRec["cust_add_1"].ToString(),
                    custRec["cust_add_2"].ToString(),
                    custRec["cust_city"].ToString(),
                    custRec["cust_postcode"].ToString(),
                    custRec["cust_phone"].ToString(),
                    custRec["cust_email"].ToString()
                    );

                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return null;
            }

        }

        /// <summary>
        /// Takes a given Customer object and inserts it into the DB
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>True or False if the Customer has been added successfully</returns>
        public static bool Add(Customer customer)
        {
            //check the customer input data
            if (!customer.ValidateFields(customer))
            {
                Console.WriteLine("Bad input");
                return false;
            }

            try
            {
                string insertQuery =
                    "INSERT INTO customers " +
                    "(cust_firstname, cust_lastname, cust_add_1, cust_add_2, cust_city, cust_postcode, cust_phone, cust_email) " +
                    "VALUES " +
                    "(@cust_firstname, @cust_lastname, @cust_add_1, @cust_add_2, @cust_city, @cust_postcode, @cust_phone, @cust_email)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@cust_firstname", customer.Firstname);
                insertCommand.Parameters.AddWithValue("@cust_lastname", customer.Lastname);
                insertCommand.Parameters.AddWithValue("@cust_add_1", customer.Address);
                insertCommand.Parameters.AddWithValue("@cust_add_2", customer.Address2);
                insertCommand.Parameters.AddWithValue("@cust_city", customer.City);
                insertCommand.Parameters.AddWithValue("@cust_postcode", customer.Postcode);
                insertCommand.Parameters.AddWithValue("@cust_phone", customer.Phone);
                insertCommand.Parameters.AddWithValue("@cust_email", customer.Email);

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
        /// Takes a given Customer object and updates it in the DB
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>True or False if the Customer has been amended successfully</returns>
        public static bool Update(Customer customer)
        {
            //check the customer input data
            if (!customer.ValidateFields(customer))
            {
                Console.WriteLine("Incorrect / missing Inputs");
                return false;
            }

            try
            {
                string insertQuery =
                    "UPDATE customers SET cust_firstname=@cust_firstname, cust_lastname=@cust_lastname, cust_add_1=@cust_add_1, " +

                    "cust_add_2=@cust_add_2, cust_city=@cust_city, cust_postcode=@cust_postcode, cust_phone=@cust_phone, cust_email=@cust_email " +

                    "WHERE cust_id=@cust_id";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@cust_firstname", customer.Firstname);
                insertCommand.Parameters.AddWithValue("@cust_lastname", customer.Lastname);
                insertCommand.Parameters.AddWithValue("@cust_add_1", customer.Address);
                insertCommand.Parameters.AddWithValue("@cust_add_2", customer.Address2);
                insertCommand.Parameters.AddWithValue("@cust_city", customer.City);
                insertCommand.Parameters.AddWithValue("@cust_postcode", customer.Postcode);
                insertCommand.Parameters.AddWithValue("@cust_phone", customer.Phone);
                insertCommand.Parameters.AddWithValue("@cust_email", customer.Email);
                insertCommand.Parameters.AddWithValue("@cust_id", customer.ID);


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
        /// Deletes a Customer from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False if the deletion has been successful</returns>
        public static bool DeleteByID(int id)
        {
            //this doesn't actually delete any data it simply marks the customer record and their booking
            //record(s) as deleted
            try
            {
                string deleteCust = "UPDATE customers SET cust_deleted= 1 WHERE cust_id = @cust_id";
                SqlCommand delCustCmd = new SqlCommand(deleteCust, Database.GetConnection());

                delCustCmd.Parameters.AddWithValue("@cust_id", id);


                delCustCmd.ExecuteNonQuery();
                delCustCmd.Dispose();

                //hide their bookings also
                string deleteBookings = "UPDATE bookings SET book_deleted = 1 WHERE cust_id = @cust_id";
                SqlCommand delBookingsCmd = new SqlCommand(deleteBookings, Database.GetConnection());

                delBookingsCmd.Parameters.AddWithValue("@cust_id", id);
                delBookingsCmd.ExecuteNonQuery();
                delBookingsCmd.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

            return false;

        }

        /// <summary>
        /// Undeletes a Customer from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False if the un-deletion has been successful</returns>
        public static bool UndeleteByID(int id)
        {
            //unhides the customer and their bookings
            try
            {
                string insertQuery = "UPDATE customers SET cust_deleted= 0 WHERE cust_id = @cust_id";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@cust_id", id);


                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();

                //SHOW their bookings also
                string unDeleteBookings = "UPDATE bookings SET book_deleted = 0 WHERE cust_id = @cust_id";
                SqlCommand unDelBookingsCmd = new SqlCommand(unDeleteBookings, Database.GetConnection());

                unDelBookingsCmd.Parameters.AddWithValue("@cust_id", id);
                unDelBookingsCmd.ExecuteNonQuery();
                unDelBookingsCmd.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

            return false;

        }

        /// <summary>
        /// Searchs the customer table based on a key term given
        /// </summary>
        /// <returns></returns>
        public static List<Customer> Search(string search_term)
        {
            List<Customer> result = new List<Customer>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customers WHERE cust_firstname LIKE @search_term OR cust_lastname LIKE @search_term", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@search_term", string.Format("%{0}%", search_term));
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Customer(
                    (int)record["cust_id"],
                    record["cust_firstname"].ToString(),
                    record["cust_lastname"].ToString(),
                    record["cust_add_1"].ToString(),
                    record["cust_add_2"].ToString(),
                    record["cust_city"].ToString(),
                    record["cust_postcode"].ToString(),
                    record["cust_phone"].ToString(),
                    record["cust_email"].ToString()
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Customer>();
            }

        }


        //Used to adapt how the object is displayed in the datagrid UI
        public override string ToString()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }
    }
}
