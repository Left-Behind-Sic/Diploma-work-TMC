using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form8 : Form
    {
        private OleDbConnection dbConnection;
        public Form8()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "dd.MM.yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "dd.MM.yyyy";
            comboBox6.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string extType = textBox11.Text;
            int? countExtinguisher = null;
            DataTable extinguisherDT = new DataTable();
            string queryExtinguisher;
            if (DataBank.ChangeCar == true)
            {
                queryExtinguisher = $"UPDATE carExtinguisher SET [Дата перезарядки]='{dateTimePicker5.Text}', [Дата проверки]='{dateTimePicker6.Text}', [Тип]='{extType}' " +
                    $"WHERE id ={DataBank.SelectedId}";
                countExtinguisher = 1;
            }

            else
            {
                queryExtinguisher = $"INSERT INTO carExtinguisher ([Дата перезарядки], [Дата проверки], [Гос номер], [Тип]) " +
                    $"VALUES ('{dateTimePicker5.Text}', '{dateTimePicker6.Text}', '{DataBank.SelRowStr}', '{extType}')";
                countExtinguisher = Convert.ToInt32(comboBox6.Text);
            }

            try
            {


                OleDbDataAdapter commandAddextinguisher = new OleDbDataAdapter(queryExtinguisher, dbConnection);
                for (int i = 1; i <= countExtinguisher; i++)
                {
                    commandAddextinguisher.Fill(extinguisherDT);
                }
                Form2 f2 = this.Owner as Form2;
                f2.Show();
                f2.Activate();
                dbConnection.Close();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Заполните все данные корректно");
            }
        }

        private void Form8_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            if (DataBank.ChangeCar == true)
            {
                comboBox6.Hide();
                label22.Hide();

                string checkDate = string.Empty;
                string reloadDate = string.Empty;
                string type = string.Empty;

                OleDbCommand query1 = dbConnection.CreateCommand();
                query1.CommandText = $"SELECT [Дата перезарядки] FROM carExtinguisher WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel1 = query1.ExecuteReader();

                OleDbCommand query2 = dbConnection.CreateCommand();
                query2.CommandText = $"SELECT [Дата проверки] FROM carExtinguisher WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel2 = query2.ExecuteReader();

                OleDbCommand query3 = dbConnection.CreateCommand();
                query3.CommandText = $"SELECT [Тип] FROM carExtinguisher WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel3 = query3.ExecuteReader();


                while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read())
                {
                    checkDate += commandExcel1["Дата перезарядки"];
                    reloadDate += commandExcel2["Дата проверки"];
                    type += commandExcel3["Тип"];
                }

                commandExcel1.Close();
                commandExcel2.Close();
                commandExcel3.Close();

                dateTimePicker6.Text = string.Format(checkDate);
                dateTimePicker5.Text = string.Format(reloadDate);
                textBox11.Text = string.Format(type);

            }
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            f2.Show();
            f2.Activate();
            dbConnection.Close();
            this.Hide();
        }

        private void Form8_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }
    }
}
