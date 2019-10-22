using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace A2_Coursework.Data
{
    /// <summary>
    /// An abstraction of the Employee DB entity in C#
    /// </summary>
    public class Employee
    {
        public int ID { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public DateTime DOB { get; private set; }
        public string Address { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string Postcode { get; private set; }
        public string Phone { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Employee(int id, string fName, string lName, DateTime dob, string add1, string add2, string city,
            string postcode, string phone, string username, string password)
        {
            ID = id;
            Firstname = fName;
            Lastname = lName;
            DOB = dob;
            Address = add1;
            Address2 = add2;
            City = city;
            Postcode = postcode;
            Phone = phone;
            Username = username;
            Password = password;
        }

        private static bool ValidateFields(Employee emp)
        {
            //Validates each field of the object using Reflection
            foreach (PropertyInfo pi in emp.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    //validate text only - names, city.
                    if (!emp.Firstname.All(Char.IsLetter) || !emp.Lastname.All(Char.IsLetter) || !emp.City.All(Char.IsLetter))
                        return false;

                    //POSTCODE


                    //skip address line 2 and email as they can be NULL
                    if (pi.Name == "Address2")
                        continue;

                    string value = (string)pi.GetValue(emp);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            //validation passed
            return true;
        }

        /// <summary>
        /// Attempts to Login an employee based on the credentials supplied
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Employee object with their information, return null if the information is wrong</returns>
        public static Employee Login(string username, string password)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM employees WHERE emp_username = @empuser AND emp_password = @emppass", Database.GetConnection());
                sda.SelectCommand.Parameters.AddWithValue("@empuser", username);
                sda.SelectCommand.Parameters.AddWithValue("@emppass", password);
                DataTable dataResult = new DataTable();
                sda.Fill(dataResult);

                //grab the customer record, 1 row assumes the user has been found
                if (dataResult.Rows.Count > 0)
                {
                    //create an object with the information
                    DataRow empRec = dataResult.Rows[0];

                    Employee employee = new Employee(
                        (int)empRec["emp_id"],
                        empRec["emp_firstname"].ToString(),
                        empRec["emp_lastname"].ToString(),
                        Convert.ToDateTime(empRec["emp_dob"]),
                        empRec["emp_add_1"].ToString(),
                        empRec["emp_add_2"].ToString(),
                        empRec["emp_city"].ToString(),
                        empRec["emp_postcode"].ToString(),
                        empRec["emp_phone"].ToString(),
                        empRec["emp_username"].ToString(),
                        empRec["emp_password"].ToString()
                        );

                    return employee;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return null;
            }
        }

        public static bool Add(Employee emp)
        {
            if (!ValidateFields(emp))
                return false;
    
            try
            {
                string insertQuery =
                    "INSERT INTO employees " +
                    "(emp_firstname, emp_lastname, emp_dob, emp_add_1, emp_add_2, emp_city, emp_postcode, emp_phone, emp_username, emp_password) " +
                    "VALUES " +
                    "(@emp_firstname, @emp_lastname, @emp_dob, @emp_add_1, @emp_add_2, @emp_city, @emp_postcode, @emp_phone, @emp_username, @emp_password)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, Database.GetConnection());

                insertCommand.Parameters.AddWithValue("@emp_firstname", emp.Firstname);
                insertCommand.Parameters.AddWithValue("@emp_lastname", emp.Lastname);
                insertCommand.Parameters.AddWithValue("@emp_dob", emp.DOB);
                insertCommand.Parameters.AddWithValue("@emp_add_1", emp.Address);
                insertCommand.Parameters.AddWithValue("@emp_add_2", emp.Address2);
                insertCommand.Parameters.AddWithValue("@emp_city", emp.City);
                insertCommand.Parameters.AddWithValue("@emp_postcode", emp.Postcode);
                insertCommand.Parameters.AddWithValue("@emp_phone", emp.Phone);
                insertCommand.Parameters.AddWithValue("@emp_username", emp.Username);
                insertCommand.Parameters.AddWithValue("@emp_password", emp.Password);
                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
                //null is returned when information isn't found or if it cannot be processed
                return false;
            }
        }


        //Used to adapt how the object is displayed in the datagrid UI
        public override string ToString()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }
    }
}
