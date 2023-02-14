using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using customers;

namespace customers.tests
{
    [TestClass]
    public class customertests
    {
        [TestMethod]
        public void Test1Insert()
        {
            try
            {
                Customer pr = new Customer();
                int id = pr._insert("qwe rty uio", "123", "321");
                SqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();

                //Команда Select
                string sql = "Select MAX([код_постояльца]) from постояльцы ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int id_base = Convert.ToInt32(reader[0]);

                Assert.AreEqual(id_base, id);
                connection.Close();
                connection.Dispose();
                return;
            }
            catch (CustomerException e)
            {
                Assert.AreEqual(e.Message, "Не удалось добавить постояльца");
                return;
            }
        }

        [TestMethod]
        public void Test2Update()
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select MAX([код_постояльца]) from постояльцы ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id_base = Convert.ToInt32(reader[0]);
            connection.Close();
            connection.Dispose();

            Customer cust = new Customer();
            bool id = cust._update(id_base, "qwe rty uio", "1234", "4321");

            Assert.AreEqual(id, true);
        }
        [TestMethod]
        public void Test4Read()
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select TOP(1) код_постояльца, фио_постояльца, паспортные_данные, данные_реквизитов from постояльцы ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            //Создаем объект товар
            Customer cust;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cust = new Customer
            {
                Id = Convert.ToInt32(reader[0]),
                FIO = reader[1].ToString(),
                Passport = reader[2].ToString(),
                Requisites = reader[3].ToString()

            };
            connection.Close();
            connection.Dispose();

            Customer fcust = new Customer();
            fcust = cust.GetCustomer(cust.Id); //Находим

            //Сравниваем
            Assert.AreEqual(cust == fcust, true);
        }

        [TestMethod]
        public void Test3Delete()
        {
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select MAX([код_постояльца]) from постояльцы ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id_base = Convert.ToInt32(reader[0]);
            connection.Close();
            connection.Dispose();

            Customer cust = new Customer();
            bool id = cust._delete(id_base);

            Assert.AreEqual(id, true);
        }
        [TestMethod]
        public void TestFailedInsert()
        {
            try
            {
                Customer cust = new Customer();
                int this_id = cust._insert("", "234", "243");
            }
            catch (CustomerException e)
            {
                Assert.AreEqual(e.Message, "Поле ФИО постояльца не заполнено");
                return;
            }
        }
        [TestMethod]
        public void TestFailedUpdate()
        {
            try
            {
                SqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();
                // Команда Select
                string sql = "Select MAX([код_постояльца]) from постояльцы ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int id_base = Convert.ToInt32(reader[0]);
                connection.Close();
                connection.Dispose();

                Customer cust = new Customer();
                bool id = cust._update(id_base, "qwe rty uio", "", "4321");

            }
            catch (CustomerException e)
            {
                Assert.AreEqual(e.Message, "Поле Паспортные данные на заполнено");
                return;
            }
        }
        [TestMethod]
        public void TestFailedDelete()
        {
            try
            {
                Customer cust = new Customer();
                cust._delete(0);
            }
            catch (CustomerException e)
            {
                Assert.AreEqual(e.Message, "Поле Код_постояльца не заполнено");
                return;
            }
        }
        [TestMethod]
        public void TestFailedRead()
        {
            try
            {
                int id = 9999;
                Customer cust = new Customer();
                cust = cust.GetCustomer(id);
                Assert.AreEqual(cust.Id, id);
            }
            catch (CustomerException e)
            {
                Assert.AreEqual(e.Message, "Постоялец не найден в базе данных");
                return;
            }
        }
    }
}
