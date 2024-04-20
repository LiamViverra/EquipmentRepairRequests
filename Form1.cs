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
    public partial class Form1 : Form
    {
        DataBaseConnect dataBase = new DataBaseConnect();

        public Form1()
        {
            InitializeComponent();
        }

        private void отобразитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDatabaseContent();
        }

        private void создатьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationCreateForm create = new ApplicationCreateForm(this, 0);
            create.Show();
        }

        private void удалитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectId = Convert.ToInt32(DataViewer.SelectedRows[0].Cells["ApplicationNum"].Value);

            if (SelectId <= 0)
                MessageBox.Show("Выберите строку");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Действительно удалить заявку из БД?", "Удаление записи", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM dbo.Applications WHERE Id = @Id";

                    dataBase.OpenConnectrion();

                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.Parameters.AddWithValue("@Id", SelectId);
                    command.ExecuteNonQuery();
                    
                    dataBase.CloseConnectrion();
                }
            }
            UpdateDatabase();
        }

        private void редактироватьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DataViewer.SelectedRows.Count > 0)
            {
                int SelectId = Convert.ToInt32(DataViewer.SelectedRows[0].Cells["ApplicationNum"].Value);

                if (SelectId <= 0)
                    MessageBox.Show("Выберите строку");
                else
                {
                    DataGridViewRow selectedRow = DataViewer.SelectedRows[0];

                    ApplicationCreateForm create = new ApplicationCreateForm(this, 1, selectedRow);
                    create.Show();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования");
            }
        }

        private void ShowDatabaseContent()
        {
            if (checkBox1.Checked == true)
            {
                DatabaseQuery("SELECT * FROM Applications WHERE Статус <> 'Готов'");
            }
            else
            {
                DatabaseQuery("SELECT dbo.Applications.* FROM dbo.Applications");
            }
        }

        public void DatabaseQuery(string query)
        {
            DataViewer.Rows.Clear();
            dataBase.OpenConnectrion();
            if(dataBase.getConnection() != null)
            {
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }

                reader.Close();
                dataBase.CloseConnectrion();

                foreach(string[] s in data)
                {
                    DataViewer.Rows.Add(s);
                }
            }
        }

        public void UpdateDatabase()
        {
            DatabaseQuery("SELECT dbo.Applications.* FROM dbo.Applications");
        }

        private void DataViewer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if(e.Value != null)
                {
                    DataGridViewRow row = DataViewer.Rows[e.RowIndex];

                    string _statusValue = e.Value.ToString();
                    string statusValue = _statusValue.TrimEnd();

                    switch (statusValue)
                    {
                        case "Ожидает выполнения":
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        case "В процессе":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Готов":
                            row.DefaultCellStyle.BackColor = Color.YellowGreen;
                            break;
                        case "Заморожен":
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            break;
                        default:
                            MessageBox.Show("Статус не определен " + statusValue);
                            break;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowDatabaseContent();
        }

        private void создательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creator creator = new Creator();
            creator.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ShowDatabaseContent();
        }
    }
}
