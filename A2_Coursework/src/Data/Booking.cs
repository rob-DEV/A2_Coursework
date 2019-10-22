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
    public class Booking
    {
        public int ID { get; private set; }
        public int NoPeople { get; private set; }
        public DateTime DatePlaced { get; private set; }
        public DateTime DateEvent { get; private set; }
        public bool Confirmed { get; private set; }
        public bool Paid { get; private set; }
        public Customer Customer { get; private set; }
        public Employee Employee { get; private set; }

        /// <summary>
        /// Constructor used when the booking id is not known
        /// </summary>
        /// <param name="no_people"></param>
        /// <param name="date_placed"></param>
        /// <param name="date_event"></param>
        /// <param name="confirmed"></param>
        /// <param name="paid"></param>
        /// <param name="cust_id"></param>
        /// <param name="emp"></param>
        public Booking(int no_people, DateTime date_placed, DateTime date_event, bool confirmed,
            bool paid, int cust_id, Employee emp
            )
        {
            ID = -1;
            NoPeople = no_people;
            DatePlaced = date_placed;
            DateEvent = date_event;
            Confirmed = confirmed;
            Paid = paid;
            Customer = Data.Customer.RetrieveById(cust_id);
            Employee = emp;
        }

        /// <summary>
        /// Constructor used when the booking id is known
        /// </summary>
        /// <param name="no_people"></param>
        /// <param name="date_placed"></param>
        /// <param name="date_event"></param>
        /// <param name="confirmed"></param>
        /// <param name="paid"></param>
        /// <param name="cust_id"></param>
        /// <param name="emp"></param>
        public Booking(int book_id, int no_people, DateTime date_placed, DateTime date_event, bool confirmed,
            bool paid, int cust_id, Employee emp
            )
        {
            ID = book_id;
            NoPeople = no_people;
            DatePlaced = date_placed;
            DateEvent = date_event;
            Confirmed = confirmed;
            Paid = paid;

            Customer = Data.Customer.RetrieveById(cust_id);
            Employee = emp;
        }

        /// <summary>
        /// Validates the objects data, checks for null or empty strings and negative ids
        /// </summary>
        /// <param name="booking"></param>
        /// <returns>True or False depending on whether or not the data is valid</returns>
        private bool ValidateFields(Booking booking)
        {
            //checks each feild in the class to see wether they are null / empty
            foreach (PropertyInfo pi in booking.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(booking);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            //validation passed
            return true;
        }

        /// <summary>
        /// Returns a List of all the Bookings as Booking objects from the DB which are not deleted
        /// </summary>
        /// <returns>List<Booking></returns>
        public static List<Booking> RetrieveAll()
        {
            List<Booking> result = new List<Booking>();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings WHERE book_deleted = 0", Database.GetConnection());
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                foreach (DataRow record in dataResult.Rows)
                {
                    result.Add(new Booking(
                    (int)record["book_id"],
                    (int)record["book_no_people"],
                    Convert.ToDateTime(record["book_date_placed"]),
                    Convert.ToDateTime(record["book_date_event"]),
                    (bool)record["book_confirmed"],
                    (bool)record["book_paid"],
                    (int)record["cust_id"],
                    ApplicationManagement.ApplicationManager.LoggedInEmployee
                    ));
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //return an empty list on error
                return new List<Booking>();
            }

        }

        /// <summary>
        /// Returns a Booking from the DB with a particular id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Customer or null if no such customer is found</returns>
        public static Booking RetrieveById(int id)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM bookings WHERE book_id = @book_id", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@book_id", id);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);
                DataRow record = dataResult.Rows[0];

                return new Booking(
                (int)record["book_id"],
                (int)record["book_no_people"],
                Convert.ToDateTime(record["book_date_placed"]),
                Convert.ToDateTime(record["book_date_event"]),
                (bool)record["book_confirmed"],
                (bool)record["book_paid"],
                (int)record["cust_id"],
                ApplicationManagement.ApplicationManager.LoggedInEmployee
                );

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                return null;
            }

        }

        /// <summary>
        /// Takes a given Booking object and inserts it into the DB
        /// </summary>
        /// <param name="booking"></param>
        /// <returns>The booking object with it's inserted ID</returns>
        public static Booking Add(Booking booking)
        {
            //check the customer input data
            try
            {
                //query string which outputs the inserted id
                string insertQuery =
                 "INSERT INTO bookings (book_no_people, book_date_placed, book_date_event, " +
                 "book_confirmed, book_paid, cust_id, emp_id) output INSERTED.book_id " +
                 "VALUES (@book_no_people, @book_date_placed, @book_date_event, @book_confirmed, " +
                 "@book_paid, @cust_id, @emp_id)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());
                insertCommand.Parameters.AddWithValue("@book_no_people", booking.NoPeople);
                insertCommand.Parameters.AddWithValue("@book_date_placed", booking.DatePlaced);
                insertCommand.Parameters.AddWithValue("@book_date_event", booking.DateEvent);
                insertCommand.Parameters.AddWithValue("@book_confirmed", booking.Confirmed);
                insertCommand.Parameters.AddWithValue("@book_paid", booking.Paid);
                insertCommand.Parameters.AddWithValue("@cust_id", booking.Customer.ID);
                insertCommand.Parameters.AddWithValue("@emp_id", booking.Employee.ID);

                int inserted_booking_id = (int)insertCommand.ExecuteScalar();
                insertCommand.Dispose();
                booking.ID = inserted_booking_id;
                return booking;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);

            }
            return null;
        }

        /// <summary>
        /// Takes a given Booking object and updates it in the DB
        /// </summary>
        /// <param name="booking"></param>
        /// <returns>True or False if the Booking has been amended successfully</returns>
        public static bool Update(Booking booking)
        {
            //check the customer input data


            try
            {
                string insertQuery =
                    "UPDATE bookings SET book_no_people=@book_no_people, book_date_placed=@book_date_placed, book_date_event=@book_date_event, " +

                    "book_confirmed=@book_confirmed, book_paid=@book_paid " +

                    "WHERE book_id=@book_id";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@book_no_people", booking.NoPeople);
                insertCommand.Parameters.AddWithValue("@book_date_placed", booking.DatePlaced);
                insertCommand.Parameters.AddWithValue("@book_date_event", booking.DateEvent);
                insertCommand.Parameters.AddWithValue("@book_confirmed", booking.Confirmed);
                insertCommand.Parameters.AddWithValue("@book_paid", booking.Paid);
                insertCommand.Parameters.AddWithValue("@book_id", booking.ID);


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
        /// Deletes a booking record with a given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False if the Booking has been deleted successfully</returns>
        public static bool DeleteById(int id)
        {
            //this doesn't actually delete any data it simply marks the customer record and their booking
            //record(s) as hidden
            try
            {
                //hide their bookings also
                string deleteBookings = "UPDATE bookings SET book_deleted = 1 WHERE book_id = @book_id";
                SqlCommand delBookingsCmd = new SqlCommand(deleteBookings, Database.GetConnection());

                delBookingsCmd.Parameters.AddWithValue("@book_id", id);
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
    }
}