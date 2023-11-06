using MySql.Data.MySqlClient;
using System.Data;

namespace CRUDApp
{
    public class ConDB
    {
        private MySqlConnection connection;
        private string connectionString;

        public ConDB()
        {
            connectionString = "Server=localhost;Database=student;Uid=root;Pwd='';Connect Timeout=3000";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataSet con_db(string sql)
        {
            OpenConnection(); // Open the database connection

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            // Do not close the connection here to allow it to remain open

            return ds;
        }

        public bool con_update(string sql)
        {
            OpenConnection(); // Open the database connection

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            try
            {
                cmd.ExecuteNonQuery(); // Execute the DELETE SQL command
                return true;
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here, such as SQL errors
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                CloseConnection();
            }
        }

        public bool con_updateStudent(string sql, params object[] parameters)
        {
            OpenConnection(); // Open the database connection

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            // Add parameters and their values to the command
            for (int i = 0; i < parameters.Length; i += 2)
            {
                string parameterName = (string)parameters[i];
                object parameterValue = parameters[i + 1];
                cmd.Parameters.AddWithValue(parameterName, parameterValue);
            }

            try
            {
                cmd.ExecuteNonQuery(); // Execute the UPDATE SQL command
                return true;
            }
            catch (Exception ex)
            {
                // Handle any potential exceptions here, such as SQL errors
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                CloseConnection();
            }
        }

    }
}
