using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form3 : Form
    {
        private OleDbConnection dbConnection;
        public Form3()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = maskedTextBox1.Text;
            string brandModel = textBox2.Text;
            string driver = textBox1.Text;
            string place = textBox3.Text;
            string invNumber = textBox4.Text;
            DataTable carsDT = new DataTable();
            string queryInsert;

            if (DataBank.ChangeCar == true)
            {

                queryInsert = $"UPDATE cars SET [Гос номер]='{number}', [Марка и модель ТС]='{brandModel}', Водитель='{driver}', [Производственная площадка]='{place}', [Инвентарный номер ТС]='{invNumber}' WHERE [Гос номер]='{DataBank.SelRowStr}'";

            }
            else
            {
                queryInsert = $"INSERT INTO cars ([Гос номер], [Марка и модель ТС], Водитель, [Производственная площадка], [Инвентарный номер ТС]) VALUES ('{number}', '{brandModel}', '{driver}', '{place}', '{invNumber}')";
            }

            if (number == string.Empty)
            {
                MessageBox.Show("Заполните все данные корректно");
                return;
            }

            try
            {
                OleDbDataAdapter commandAddCar = new OleDbDataAdapter(queryInsert, dbConnection);
                commandAddCar.Fill(carsDT);
                dbConnection.Close();
                Form1 main = this.Owner as Form1;
                main.Show();
                main.Activate();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Заполните все данные корректно");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 main = this.Owner as Form1;
            main.Show();
            main.Activate();
            dbConnection.Close();
            this.Hide();
        }

        private void maskedTextBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(this.maskedTextBox1, "введите гос. номер РФ в формате А001АА159 или А001АА59");
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            maskedTextBox1.Select();
            if (DataBank.ChangeCar == true)
            {
                string number = string.Empty;
                string brandModel = string.Empty;
                string driver = string.Empty;
                string place = string.Empty;
                string invNumber = string.Empty;

                OleDbCommand query1 = dbConnection.CreateCommand();
                query1.CommandText = $"SELECT [Гос номер] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
                OleDbDataReader commandExcel1 = query1.ExecuteReader();

                OleDbCommand query2 = dbConnection.CreateCommand();
                query2.CommandText = $"SELECT [Марка и модель ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
                OleDbDataReader commandExcel2 = query2.ExecuteReader();

                OleDbCommand query3 = dbConnection.CreateCommand();
                query3.CommandText = $"SELECT [Водитель] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
                OleDbDataReader commandExcel3 = query3.ExecuteReader();

                OleDbCommand query4 = dbConnection.CreateCommand();
                query4.CommandText = $"SELECT [Производственная площадка] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
                OleDbDataReader commandExcel4 = query4.ExecuteReader();

                OleDbCommand query5 = dbConnection.CreateCommand();
                query5.CommandText = $"SELECT [Инвентарный номер ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
                OleDbDataReader commandExcel5 = query5.ExecuteReader();

                while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read() && commandExcel4.Read() && commandExcel5.Read())
                {
                    number += commandExcel1["Гос номер"];
                    brandModel += commandExcel2["Марка и модель ТС"];
                    driver += commandExcel3["Водитель"];
                    place += commandExcel4["Производственная площадка"];
                    invNumber += commandExcel5["Инвентарный номер ТС"];
                }
                commandExcel1.Close();
                commandExcel2.Close();
                commandExcel3.Close();
                commandExcel4.Close();
                commandExcel5.Close();
                maskedTextBox1.Text = string.Format(number);
                textBox2.Text = string.Format(brandModel);
                textBox1.Text = string.Format(driver);
                textBox3.Text = string.Format(place);
                textBox4.Text = string.Format(invNumber);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }



        private void Form3_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            f1.Show();
            f1.Activate();
            dbConnection.Close();
            this.Hide();
        }
    }
}
