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

        [TestMethod]
        public void TestRegistration()
        {
            RegistrationForm registration = new RegistrationForm();
            Assert.IsTrue(registration.AddDatabase("TEST2", "0000"));
            Assert.IsTrue(registration.EntranceAccount("TEST2", "0000"));
        }

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
}
