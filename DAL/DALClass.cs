using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Model;

namespace DAL
{
    public class DALClass
    {
        public static string Connection_String = "Server=(Local);DataBase=pharmacy;trusted_Connection=true";

        public static bool Login(Model.Employee employee)
        {
            SqlConnection connection = new SqlConnection(Connection_String);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText =
                    string.Format("select * from Personel where ID = {0} and Password = '{1}' and Task = N'{2}'",
                        employee.ID, employee.PassWord, employee.Task);
                command.Connection = connection;

                object x;
                x = command.ExecuteScalar();
                connection.Close();
                if (x != null) 
                    return true;
                return false;

            }
            catch (SqlException e)
            {
                connection.Close();
                return false;
            }

        }

        public static bool AddMedicine(Model.Medicine medicine)
        {            
            SqlConnection connection = new SqlConnection(Connection_String);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = string.Format("insert into Medicine values( {0}, '{1}', {2}, {3}, {4} )", medicine.ID,
                    medicine.Name, medicine.Price, medicine.PersonelID, medicine.FactoryID);
                command.Connection = connection;

                command.ExecuteScalar();
                connection.Close();
                return true;

            }
            catch (SqlException e)
            {
                string x = e.Message;
                connection.Close();
                return false;
            }
        }

        public static DataTable ShowMedicine()
        {
            SqlConnection connection = new SqlConnection(Connection_String);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = string.Format("select * from Medicine");
                command.Connection = connection;
                DataTable dt = new DataTable();
                SqlDataReader SDR =  command.ExecuteReader();
                dt.Load(SDR);
                connection.Close();
                return dt;

            }
            catch (SqlException e)
            {
                string x = e.Message;
                connection.Close();
                return new DataTable();
            }
        }

        public static bool EditMedicine(Medicine medicine)
        {
            SqlConnection connection = new SqlConnection(Connection_String);
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = string.Format("Update Medicine set" +
                                                    " Name = '{0}'," +
                                                    "Price = {1}," +
                                                    "FK_FactoryID = {2} where ID = {3}",medicine.Name, medicine.Name, medicine.Price, medicine.ID);
                command.Connection = connection;
                object x = command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch (SqlException e)
            {
                string x = e.Message;
                connection.Close();
                return false;
            }
        }
    }
}
