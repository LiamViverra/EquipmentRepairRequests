using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipmentRepairRequests
{
    public partial class RegistrationForm : Form
    {
        DataBaseConnect dataBase = new DataBaseConnect();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Вход
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                EntranceAccount(textBox1.Text, textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Регистрация
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                AddDatabase(textBox1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        public bool EntranceAccount(string login, string password)
        {
            string query = "SELECT COUNT(*) FROM ListOfUsers WHERE Login = '" + login + "' AND Password = '" + Convert.ToInt32(password) + "'";
            dataBase.OpenConnectrion();

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToInt32(reader[0]) > 0)
                {
                    reader.Close();
                    dataBase.CloseConnectrion();

                    Form1 form1 = new Form1();

                    this.Hide();
                    form1.Show();
                    return true;
                }
                else MessageBox.Show("Неверные логин или пароль");
            }
            reader.Close();
            dataBase.CloseConnectrion();
            return false;
        }

        public bool AddDatabase(string login, string password)
        {
            string query = "INSERT INTO dbo.ListOfUsers VALUES ('" + login + "', '" + password + "')";
            string query1 = "SELECT COUNT(*) FROM ListOfUsers WHERE Login = '" + login + "'";
            
            dataBase.OpenConnectrion();

            SqlCommand command = new SqlCommand(query1, dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToInt32(reader[0]) == 0)
                {
                    reader.Close();
                    SqlCommand command1 = new SqlCommand(query, dataBase.getConnection());
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Регистрация успешна");
                    dataBase.CloseConnectrion();
                    return true;
                }
                else MessageBox.Show("Данный логин уже зарегистрирован");
            }

            dataBase.CloseConnectrion();
            return false;
        }

        public bool DelAccountDataBase(string login)
        {
            try
            {
                string query = "DELETE FROM dbo.ListOfUsers WHERE Login = @Log";

                dataBase.OpenConnectrion();

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("@Log", login);
                command.ExecuteNonQuery();

                dataBase.CloseConnectrion();
                return true;
            } catch(Exception exp)
            {
                return false;
            }
        }
    }
}
