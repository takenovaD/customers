using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Data;



namespace customers
{
    class DBSQLServerUtils
    {
        public static SqlConnection
        GetDBConnection(string datasource, string database)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-82KOBC1";
            string database = "Гостиница_DB";
            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }

    [Serializable]
    public class CustomerException : Exception
    {
        public CustomerException() { }
        public CustomerException(string message) : base(message) { }
        public CustomerException(string message, Exception inner) : base(message, inner) { }
        protected CustomerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class Customer
    {
        private int _id; //код_постояльца
        private string _fio; //фио_постояльца
        private string _passport; //паспортные_данные
        private string _requisites; //реквизиты


        public Customer()
        {
            _id = 0;
            _fio = "";
            _passport = "";
            _requisites = "";
        }

        public Customer(string New_fio, string New_passport, string New_requisites)
        {
            _fio = New_fio;
            _passport = New_passport;
            _requisites = New_requisites;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string FIO { get { return _fio; } set { _fio = value; } }
        public string Passport { get { return _passport; } set { _passport = value; } }        
        public string Requisites { get { return _requisites; } set { _requisites = value; } }
        public int _insert(string FIO, string Passport, string Requisites)
        {
            if (FIO == ""|| FIO ==" ")
            {
                throw new CustomerException("Поле ФИО постояльца не заполнено");
            }
            if (Passport.ToString() == "" )
            {
                throw new CustomerException("Поле Паспортные данные на заполнено");
            }
            if (Requisites.ToString() == "" )
            {
                throw new CustomerException("Поле Реквизиты на заполнено");
            }
            try
            {
                SqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();

                string sql = "Insert into постояльцы (фио_постояльца, паспортные_данные, данные_реквизитов) " + " values (@FIO, @Passport, @Requisites) ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // Создать объект Parameter.
                SqlParameter FIOParam = new SqlParameter("@FIO", SqlDbType.NVarChar);
                FIOParam.Value = FIO;
                cmd.Parameters.Add(FIOParam);

                // Добавить параметр
                cmd.Parameters.Add("@Passport", SqlDbType.Float).Value = Passport;
                cmd.Parameters.Add("@Requisites", SqlDbType.Float).Value = Requisites;

                // Выполнить Command
                cmd.ExecuteNonQuery();

                //Ищем Код добавленного постояльца
                sql = "Select MAX([код_постояльца]) from постояльцы ";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int last_id = Convert.ToInt32(reader[0]);

                connection.Close();
                connection.Dispose();
                connection = null;

                return last_id;
            }
            catch
            {
                throw new CustomerException("Ошибка при добавлении");
            }
        }

        public bool _delete(int Id)
        {
            if (Id.ToString() == "" || Id == 0)
            {
                throw new CustomerException("Поле Код_постояльца не заполнено");
            }
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "Delete from постояльцы where код_постояльца = @Id ";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                conn = null;

                return true;
            }
            catch
            {
                throw new CustomerException("Ошибка при удалении");
            }
        }

        public bool _update(int Id, string FIO, string Passport, string Requisites)
        {
            if (Id.ToString() == "" || Id == 0)
            {
                throw new CustomerException("Поле Код_постояльца не заполнено");
            }
            if (FIO == "")
            {
                throw new CustomerException("Поле ФИО постояльца не заполнено");
            }
            if (Passport.ToString() == "" )
            {
                throw new CustomerException("Поле Паспортные данные на заполнено");
            }
            if (Requisites.ToString() == "" )
            {
                throw new CustomerException("Поле Реквизиты на заполнено");
            }
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "Update постояльцы set фио_постояльца = @FIO, паспортные_данные = @Passport, данные_реквизитов = @Requisites where код_постояльца = @Id";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Добавить и настроить значение для параметра.
                cmd.Parameters.Add("@FIO", SqlDbType.VarChar).Value = FIO;
                cmd.Parameters.Add("@Passport", SqlDbType.Float).Value = Passport;
                cmd.Parameters.Add("@Requisites", SqlDbType.Float).Value = Requisites;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

                // Выполнить Command
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                conn = null;

                return true;
            }
            catch
            {
                throw new CustomerException("Ошибка при изменении");
            }
        }

        public Customer GetCustomer(int Id)
        {
            try
            {
                SqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();
                // Команда Select
                string sql = "Select * from постояльцы where код_постояльца = " + Id;

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Customer foundProcedure = new Customer
                {
                    _id = Convert.ToInt32(reader[0]),
                    _fio = reader[1].ToString(),
                    _passport = reader[2].ToString(),
                    _requisites = reader[3].ToString()
                };

                connection.Close();
                connection.Dispose();

                return foundProcedure;
            }
            catch
            {
                throw new CustomerException("Постоялец не найден в базе данных");
            }
        }

        public static bool operator ==(Customer first, Customer second)
        {
            return first.FIO == second.FIO && first.Passport == second.Passport && first.Requisites == second.Requisites && first.Id == second.Id;

        }
        public static bool operator !=(Customer first, Customer second)
        {
            return !(first == second);
        }
    }
}
