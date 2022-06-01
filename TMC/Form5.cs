using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form5 : Form
    {
        private OleDbConnection dbConnection;
        public Form5()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            comboBox7.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tyreSize = textBox2.Text;
            string tyreBrand = textBox3.Text;
            string tyreModel = textBox7.Text;
            int? runKmTyres = null;
            int? normKmTyres = null;
            int? invNumber = null;
            int? runKMTyre = null;
            int? countTyre = null;
            string condition = comboBox7.Text;
            double? protector = null;
            try
            {

                runKmTyres = Convert.ToInt32(textBox1.Text);
                normKmTyres = Convert.ToInt32(comboBox1.Text);
                invNumber = Convert.ToInt32(textBox8.Text);
                runKMTyre = Convert.ToInt32(textBox9.Text);
                protector = Convert.ToSingle(textBox12.Text);

            }
            catch
            {

            }


            DataTable tyresDT = new DataTable();
            string queryTyres;

            if (DataBank.ChangeCar == true)
            {
                queryTyres = $"UPDATE carTyres " +
                    $" SET [Пробег автомобиля]={runKmTyres}, [Норма пробега]={normKmTyres}, [Дата проверки]='{dateTimePicker1.Text}', [Размер шины]='{tyreSize}', [Гос номер]='{DataBank.SelRowStr}', [Производитель шины]='{tyreBrand}', [Модель шины]='{tyreModel}', [Заводской номер]={invNumber}, [Пробег шины]={runKMTyre}, [Техническое состояние]='{condition}', [Остаточная высота протектора (мм)]='{protector}'" +
                    $" WHERE id={DataBank.SelectedId}";
                countTyre = 1;
            }
            else
            {
                queryTyres = $"INSERT INTO carTyres " +
                    $"([Пробег автомобиля], [Норма пробега], [Дата проверки], [Размер шины], [Гос номер], [Производитель шины], [Модель шины], [Заводской номер], [Пробег шины], [Техническое состояние], [Остаточная высота протектора (мм)])" +
                    $" VALUES ({runKmTyres}, {normKmTyres}, '{dateTimePicker1.Text}', '{tyreSize}', '{DataBank.SelRowStr}', '{tyreBrand}', '{tyreModel}', {invNumber}, {runKMTyre}, '{condition}', '{protector}')";
                countTyre = Convert.ToInt32(comboBox2.Text);
            }
            try
            {

                OleDbDataAdapter commandAddTyre = new OleDbDataAdapter(queryTyres, dbConnection);
                for (int i = 1; i <= countTyre; i++)
                {
                    commandAddTyre.Fill(tyresDT);
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

        private void Form5_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            if (DataBank.ChangeCar == true)
            {
                comboBox2.Hide();
                label7.Hide();
                string runKmTyres = string.Empty;
                string normKmTyres = string.Empty;
                string checkDate = string.Empty;
                string number = string.Empty;
                string tyreSize = string.Empty;
                string tyreBrand = string.Empty;
                string tyreModel = string.Empty;
                string invNumber = string.Empty;
                string runKMTyre = string.Empty;
                string condition = string.Empty;
                string protector = string.Empty;

                OleDbCommand query1 = dbConnection.CreateCommand();
                query1.CommandText = $"SELECT [Пробег автомобиля] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel1 = query1.ExecuteReader();

                OleDbCommand query2 = dbConnection.CreateCommand();
                query2.CommandText = $"SELECT [Норма пробега] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel2 = query2.ExecuteReader();

                OleDbCommand query3 = dbConnection.CreateCommand();
                query3.CommandText = $"SELECT [Дата проверки] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel3 = query3.ExecuteReader();



                OleDbCommand query5 = dbConnection.CreateCommand();
                query5.CommandText = $"SELECT [Размер шины] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel5 = query5.ExecuteReader();

                OleDbCommand query6 = dbConnection.CreateCommand();
                query6.CommandText = $"SELECT [Производитель шины] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel6 = query6.ExecuteReader();

                OleDbCommand query7 = dbConnection.CreateCommand();
                query7.CommandText = $"SELECT [Модель шины] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel7 = query7.ExecuteReader();

                OleDbCommand query8 = dbConnection.CreateCommand();
                query8.CommandText = $"SELECT [Заводской номер] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel8 = query8.ExecuteReader();

                OleDbCommand query9 = dbConnection.CreateCommand();
                query9.CommandText = $"SELECT [Пробег шины] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel9 = query9.ExecuteReader();

                OleDbCommand query10 = dbConnection.CreateCommand();
                query10.CommandText = $"SELECT [Техническое состояние] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel10 = query10.ExecuteReader();

                OleDbCommand query11 = dbConnection.CreateCommand();
                query11.CommandText = $"SELECT [Остаточная высота протектора (мм)] FROM carTyres WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel11 = query11.ExecuteReader();

                while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read() && commandExcel5.Read() && commandExcel6.Read() && commandExcel7.Read() && commandExcel8.Read() && commandExcel9.Read() && commandExcel10.Read() && commandExcel11.Read())
                {
                    runKmTyres += commandExcel1["Пробег автомобиля"];
                    normKmTyres += commandExcel2["Норма пробега"];
                    checkDate += commandExcel3["Дата проверки"];

                    tyreSize += commandExcel5["Размер шины"];
                    tyreBrand += commandExcel6["Производитель шины"];
                    tyreModel += commandExcel7["Модель шины"];
                    invNumber += commandExcel8["Заводской номер"];
                    runKMTyre += commandExcel9["Пробег шины"];
                    condition += commandExcel10["Техническое состояние"];
                    protector += commandExcel11["Остаточная высота протектора (мм)"];
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



                dateTimePicker1.Text = string.Format(checkDate);
                textBox1.Text = string.Format(runKmTyres);
                comboBox1.Text = string.Format(normKmTyres);
                textBox2.Text = string.Format(tyreSize);
                textBox3.Text = string.Format(tyreBrand);
                textBox7.Text = string.Format(tyreModel);
                textBox8.Text = string.Format(invNumber);
                textBox9.Text = string.Format(runKMTyre);
                textBox12.Text = string.Format(protector);
                comboBox7.Text = string.Format(condition);

            }
        }

        private void Form5_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            f2.Show();
            f2.Activate();
            dbConnection.Close();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }
    }
}
