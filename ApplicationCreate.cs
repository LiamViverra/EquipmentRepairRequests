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
    public partial class ApplicationCreateForm : Form
    {
        private Form1 form1Instance;
        private int ApplicationNumber;
        private DateTime DateCreate;
        private string query;
        DataBaseConnect dataBase = new DataBaseConnect();

        public ApplicationCreateForm(Form1 _form1Instance, int k, DataGridViewRow DGVR = null)
        {
            InitializeComponent();
            form1Instance = _form1Instance;
            if(k == 1)
            {
                string _i = DGVR.Cells["Equipment"].Value.ToString();
                string i = _i.TrimEnd();
                comboBox1.SelectedIndex = comboBox1.FindString(i);

                string _j = DGVR.Cells["Status"].Value.ToString();
                string j = _j.TrimEnd();
                comboBox2.SelectedIndex = comboBox2.FindString(j);

                string _c = DGVR.Cells["Client"].Value.ToString();
                string c = _c.TrimEnd();
                textBox1.Text = c;

                string _d = DGVR.Cells["Description"].Value.ToString();
                string d = _d.TrimEnd();
                textBox2.Text = d;

                ApplicationNumber = Convert.ToInt32(DGVR.Cells["ApplicationNum"].Value);
                DateCreate = Convert.ToDateTime(DGVR.Cells["DateCreate"].Value);
            }
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                AddDatabase(comboBox1.SelectedItem.ToString(), 
                    textBox1.Text, 
                    comboBox2.SelectedItem.ToString(), 
                    textBox2.Text);
            }
        }

        private void BackCreateBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int AddDatabase(string equipment, string fio, string status, string description)
        {
            int NumAppl = -1;
            if(ApplicationNumber == 0)
            {
                Random r = new Random();
                int Num = r.Next(1, 9999999);
                NumAppl = Num;
                DateTime date = DateTime.Now.Date;
                query = "INSERT INTO dbo.Applications VALUES ('" + Num + "', N'" + equipment + "', N'" + fio + "', N'" + status + "', '" + date + "', '" + description + "')";
            }
            else
            {
                query = "UPDATE Applications SET Id = @Value1, Оборудование = @Value2, [Ф.И.О клиента] = @Value3, Статус = @Value4, [Дата создания] = @Value5, Описание = @Value6 WHERE Id = @ApplicationID";
            }

            try
            {
                dataBase.OpenConnectrion();
                if (ApplicationNumber == 0)
                {
                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.Parameters.AddWithValue("@Value1", ApplicationNumber);
                    command.Parameters.AddWithValue("@Value2", equipment);
                    command.Parameters.AddWithValue("@Value3", fio);
                    command.Parameters.AddWithValue("@Value4", status);
                    command.Parameters.AddWithValue("@Value5", DateCreate);
                    command.Parameters.AddWithValue("@Value6", description);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationNumber);

                    command.ExecuteNonQuery();
                }
                dataBase.CloseConnectrion();
            }
            catch (Exception)
            {
                MessageBox.Show("Error 1.001");
            }
            if(form1Instance != null) form1Instance.UpdateDatabase();
            this.Close();
            return NumAppl;
        }
    }
}
