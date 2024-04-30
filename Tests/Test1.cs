using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EquipmentRepairRequests;
using System.Data.SqlClient;

namespace EquipmentRepairRequests.Tests
{
    [TestClass]
    class Test1
    {
        [TestMethod]
        public void TestDataBaseConnect()
        {
            DataBaseConnect dataBase = new DataBaseConnect();
            dataBase.OpenConnectrion();
            Assert.IsNotNull(dataBase.getConnection());
        }
    }

    [TestClass]
    class Test2
    {
        [TestMethod]
        public void TestRegistration()
        {
            RegistrationForm registration = new RegistrationForm();
            Assert.IsTrue(registration.AddDatabase("TEST3", "0000"));
            Assert.IsTrue(registration.EntranceAccount("TEST3", "0000"));
        }
    }

    [TestClass]
    class Test3
    {
        [TestMethod]
        public void TestApplication()
        {
            DataBaseConnect dataBase = new DataBaseConnect();
            ApplicationCreateForm applicationCreate = new ApplicationCreateForm(null, 0);
            int ApplicationNum = applicationCreate.AddDatabase("Сервер", "TESTFIO", "Ожидает выполнения", "TESTDESCT");
            if (ApplicationNum <= 0)
                Assert.Fail();
            string query = "SELECT COUNT(*) FROM Applications WHERE Id = @ID";
            dataBase.OpenConnectrion();

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@ID", ApplicationNum);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            if (Convert.ToInt32(reader[0]) <= 0)
            {
                Assert.Fail();
            }

            reader.Close();
            dataBase.CloseConnectrion();
        }
    }

    [TestClass]
    class Test4
    {
        public void TestDelAccount()
        {
            RegistrationForm registration = new RegistrationForm();
            Assert.IsTrue(registration.DelAccountDataBase("TEST3"));
        }
    }
}
