using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Receptionist
{
    public class DBManager
    {
        string DB_Connection_String = @"Data Source=DESKTOP-PP3HNI8\SQLEXPRESS;Initial Catalog=Clinic;Integrated Security=True";
        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open(); //Open a connection with the DB
             //   Console.WriteLine("Successfully connected to the database!");
                //just for illustration when the database is opened, this should not be shown in GUI to the user
              //  MessageBox.Show("Successfully connected to the database!");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection to :" + DB_Connection_String + " failed!");
                MessageBox.Show("An error occurred while connecting to the database!");
            }
        }

        public int ExecuteNonQuery1(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int ExecuteNonQuer(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, object> Param in parameters)
                {
                    myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                }

                return myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public  DataTable ExecuteReader(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                return myCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable ExecuteReader1(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }


        }

        public object ExecuteScalar1(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
