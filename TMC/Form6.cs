using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form6 : Form
    {
        private OleDbConnection dbConnection;
        public Form6()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "dd.MM.yyyy";
            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "dd.MM.yyyy";
            dateTimePicker9.Format = DateTimePickerFormat.Custom;
            dateTimePicker9.CustomFormat = "dd.MM.yyyy";
            comboBox4.SelectedIndex = 0;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string batteryType = textBox6.Text;
            string batteryBrand = textBox5.Text;
            int? runKmBatteries = null;
            int? normKmBatteries = null;
            int? countBattery = null;
            int? batteryNumber = null;
            int? lifeTime = null;

            try
            {
                runKmBatteries = Convert.ToInt32(textBox4.Text);
                normKmBatteries = Convert.ToInt32(comboBox3.Text);

                batteryNumber = Convert.ToInt32(textBox10.Text);
                lifeTime = Convert.ToInt32(comboBox8.Text);
            }
            catch
            {

            }

            DataTable batteriesDT = new DataTable();
            string queryBatteries;
            if (DataBank.ChangeCar == true)
            {
                queryBatteries = $"UPDATE carBatteries SET [Пробег ТС с АКБ]={runKmBatteries}, [Норма пробега]={normKmBatteries}, [Дата проверки]='{dateTimePicker2.Text}', [Гос номер]='{DataBank.SelRowStr}', [Тип АКБ]='{batteryType}', [Производитель АКБ]='{batteryBrand}', " +
                    $"[Дата изготовления АКБ]='{dateTimePicker7.Text}', [Номер АКБ]={batteryNumber}, [Дата ввода в экспл]='{dateTimePicker8.Text}', [Дата установки на ТС]='{dateTimePicker9.Text}', [Срок службы АКБ, мес]={lifeTime} " +
                    $"WHERE id={DataBank.SelectedId}";
                countBattery = 1;
            }
            else
            {
                queryBatteries = $"INSERT INTO carBatteries ([Пробег ТС с АКБ], [Норма пробега], [Дата проверки], [Гос номер], [Тип АКБ], [Производитель АКБ], " +
                    $"[Дата изготовления АКБ], [Номер АКБ], [Дата ввода в экспл], [Дата установки на ТС], [Срок службы АКБ, мес]) " +
                    $"VALUES ('{runKmBatteries}', '{normKmBatteries}', '{dateTimePicker2.Text}', '{DataBank.SelRowStr}', '{batteryType}', '{batteryBrand}', " +
                    $"'{dateTimePicker7.Text}', {batteryNumber}, '{dateTimePicker8.Text}', '{dateTimePicker9.Text}', {lifeTime})";
                countBattery = Convert.ToInt32(comboBox4.Text);
            }

            try
            {


                OleDbDataAdapter commandAddBattery = new OleDbDataAdapter(queryBatteries, dbConnection);
                for (int i = 1; i <= countBattery; i++)
                {

                    commandAddBattery.Fill(batteriesDT);
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

        private void Form6_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            if (DataBank.ChangeCar == true)
            {
                comboBox4.Hide();
                label12.Hide();
                string runKM = string.Empty;
                string normKmBattery = string.Empty;
                string checkDate = string.Empty;

                string typeBattery = string.Empty;
                string batteryBrand = string.Empty;
                string prodDate = string.Empty;
                string invNumber = string.Empty;
                string expDate = string.Empty;
                string setDate = string.Empty;
                string lifeTime = string.Empty;

                OleDbCommand query1 = dbConnection.CreateCommand();
                query1.CommandText = $"SELECT [Пробег ТС с АКБ] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel1 = query1.ExecuteReader();

                OleDbCommand query2 = dbConnection.CreateCommand();
                query2.CommandText = $"SELECT [Норма пробега] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel2 = query2.ExecuteReader();

                OleDbCommand query3 = dbConnection.CreateCommand();
                query3.CommandText = $"SELECT [Дата проверки] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel3 = query3.ExecuteReader();



                OleDbCommand query5 = dbConnection.CreateCommand();
                query5.CommandText = $"SELECT [Тип АКБ] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel5 = query5.ExecuteReader();

                OleDbCommand query6 = dbConnection.CreateCommand();
                query6.CommandText = $"SELECT [Производитель АКБ] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel6 = query6.ExecuteReader();

                OleDbCommand query7 = dbConnection.CreateCommand();
                query7.CommandText = $"SELECT [Дата изготовления АКБ] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel7 = query7.ExecuteReader();

                OleDbCommand query8 = dbConnection.CreateCommand();
                query8.CommandText = $"SELECT [Номер АКБ] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel8 = query8.ExecuteReader();

                OleDbCommand query9 = dbConnection.CreateCommand();
                query9.CommandText = $"SELECT [Дата ввода в экспл] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel9 = query9.ExecuteReader();

                OleDbCommand query10 = dbConnection.CreateCommand();
                query10.CommandText = $"SELECT [Дата установки на ТС] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel10 = query10.ExecuteReader();

                OleDbCommand query11 = dbConnection.CreateCommand();
                query11.CommandText = $"SELECT [Срок службы АКБ, мес] FROM carBatteries WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel11 = query11.ExecuteReader();

                while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read() && commandExcel5.Read() && commandExcel6.Read() && commandExcel7.Read() && commandExcel8.Read() && commandExcel9.Read() && commandExcel10.Read() && commandExcel11.Read())
                {
                    runKM += commandExcel1["Пробег ТС с АКБ"];
                    normKmBattery += commandExcel2["Норма пробега"];
                    checkDate += commandExcel3["Дата проверки"];

                    typeBattery += commandExcel5["Тип АКБ"];
                    batteryBrand += commandExcel6["Производитель АКБ"];
                    prodDate += commandExcel7["Дата изготовления АКБ"];
                    invNumber += commandExcel8["Номер АКБ"];
                    expDate += commandExcel9["Дата ввода в экспл"];
                    setDate += commandExcel10["Дата установки на ТС"];
                    lifeTime += commandExcel11["Срок службы АКБ, мес"];
                }
                commandExcel1.Close();
                commandExcel2.Close();
                commandExcel3.Close();

                commandExcel5.Close();
                commandExcel6.Close();
                commandExcel7.Close();
                commandExcel8.Close();
                commandExcel9.Close();
                commandExcel10.Close();
                commandExcel11.Close();


                dateTimePicker2.Text = string.Format(checkDate);
                textBox4.Text = string.Format(runKM);
                comboBox3.Text = string.Format(normKmBattery);
                textBox6.Text = string.Format(typeBattery);
                textBox5.Text = string.Format(batteryBrand);
                dateTimePicker7.Text = string.Format(prodDate);
                textBox10.Text = string.Format(invNumber);
                dateTimePicker8.Text = string.Format(expDate);
                dateTimePicker9.Text = string.Format(setDate);
                comboBox8.Text = string.Format(lifeTime);

            }
        }

        private void Form6_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            f2.Show();
            f2.Activate();
            dbConnection.Close();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }
    }
}
