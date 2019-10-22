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
    /// Defines the global string needed to connect to the Events Unlimted database
    /// and an instance to the database connection.
    /// </summary>
    public static class Database
    {
        //Define the string necessary to connect to the Events Unlimited Database
        private static string m_ConnnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=PATH_PLACEHOLDER\database\eu.mdf;Integrated Security=True";
        //Private instance of the database connection (cannot be directly accessed)
        private static SqlConnection m_Connection = null;
        //Setup Flag
        private static bool m_IsSetup = false;

        //Sets up the connection string for eu.mdf relative to the location of the executable
        private static void SetupRelativeConnectionString()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            m_ConnnectionString = m_ConnnectionString.Replace("PATH_PLACEHOLDER", path);

            Console.WriteLine("Using MDF Database: {0}", m_ConnnectionString);
            //create the connection with the relative path
            m_Connection = new SqlConnection(m_ConnnectionString);
            m_IsSetup = true;
        }

        /// <summary>
        /// Grab / Create a connection to the EU DB
        /// </summary>
        /// <returns>Sqlconnection to the Database</returns>
        public static SqlConnection GetConnection()
        {
            if (!m_IsSetup)
                SetupRelativeConnectionString();
            try
            {
                if (m_Connection.State != ConnectionState.Open)
                    m_Connection.Open();
                return m_Connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static void CloseConnection()
        {
            if (m_Connection.State == ConnectionState.Open)
            {
                m_Connection.Close();
                m_Connection.Dispose();
            }
        }
    }
}