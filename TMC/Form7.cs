using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form7 : Form
    {
        private OleDbConnection dbConnection;
        public Form7()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd.MM.yyyy";
            comboBox5.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int? countAid = null;
            DataTable aidDT = new DataTable();
            string queryAid;
            if (DataBank.ChangeCar == true)
            {
                queryAid = $"UPDATE carAid SET [Срок годности]='{dateTimePicker4.Text}', [Дата проверки]='{dateTimePicker3.Text}'" +
                    $"WHERE id={DataBank.SelectedId}";
                countAid = 1;
            }
            else
            {

                queryAid = $"INSERT INTO carAid ([Срок годности], [Дата проверки], [Гос номер]) " +
                    $"VALUES ('{dateTimePicker4.Text}', '{dateTimePicker3.Text}', '{DataBank.SelRowStr}')";
                countAid = Convert.ToInt32(comboBox5.Text);
            }

            try
            {
                OleDbDataAdapter commandAddAid = new OleDbDataAdapter(queryAid, dbConnection);
                for (int i = 1; i <= countAid; i++)
                {
                    commandAddAid.Fill(aidDT);
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

        private void Form7_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            if (DataBank.ChangeCar == true)
            {
                comboBox5.Hide();
                label21.Hide();

                string checkDate = string.Empty;
                string endDate = string.Empty;

                OleDbCommand query1 = dbConnection.CreateCommand();
                query1.CommandText = $"SELECT [Срок годности] FROM carAid WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel1 = query1.ExecuteReader();

                OleDbCommand query2 = dbConnection.CreateCommand();
                query2.CommandText = $"SELECT [Дата проверки] FROM carAid WHERE [id]={DataBank.SelectedId}";
                OleDbDataReader commandExcel2 = query2.ExecuteReader();


                while (commandExcel1.Read() && commandExcel2.Read())
                {
                    checkDate += commandExcel1["Срок годности"];
                    endDate += commandExcel2["Дата проверки"];
                }

                commandExcel1.Close();
                commandExcel2.Close();

                dateTimePicker3.Text = string.Format(checkDate);
                dateTimePicker4.Text = string.Format(endDate);

            }
        }

        private void Form7_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            f2.Show();
            f2.Activate();
            dbConnection.Close();
            this.Hide();
        }
    }
}
