using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form4 : Form
    {
        private OleDbConnection dbConnection;
        public Form4()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd.MM.yyyy";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.CustomFormat = "dd.MM.yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.CustomFormat = "dd.MM.yyyy";
            dateTimePicker7.Format = DateTimePickerFormat.Custom;
            dateTimePicker7.CustomFormat = "dd.MM.yyyy";
            dateTimePicker8.Format = DateTimePickerFormat.Custom;
            dateTimePicker8.CustomFormat = "dd.MM.yyyy";
            dateTimePicker9.Format = DateTimePickerFormat.Custom;
            dateTimePicker9.CustomFormat = "dd.MM.yyyy";
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int runKmTyres = Convert.ToInt32(textBox1.Text);
                int normKmTyres = Convert.ToInt32(comboBox1.Text);
                string tyreSize = textBox2.Text;
                string tyreBrand = textBox3.Text;
                string tyreModel = textBox7.Text;
                int invNumber = Convert.ToInt32(textBox8.Text);
                int runKMTyre = Convert.ToInt32(textBox8.Text);
                string condition = comboBox7.Text;
                int countTyre = Convert.ToInt32(comboBox2.Text);
                Single protector = Convert.ToSingle(textBox12.Text);

                DataTable tyresDT = new DataTable();
                string queryTyres = $"INSERT INTO carTyres " +
                    $"([Пробег автомобиля], [Норма пробега], [Дата проверки], [Размер шины], [Гос номер], [Производитель шины], [Модель шины], [Заводской номер], [Пробег шины], [Техническое состояние], [Остаточная высота протектора (мм)])" +
                    $" VALUES ({runKmTyres}, {normKmTyres}, '{dateTimePicker1.Text}', '{tyreSize}', '{DataBank.SelRowStr}', '{tyreBrand}', '{tyreModel}', {invNumber}, {runKMTyre}, '{condition}', '{protector}')";
                OleDbDataAdapter commandAddTyre = new OleDbDataAdapter(queryTyres, dbConnection);
                for (int i = 1; i <= countTyre; i++)
                {
                    commandAddTyre.Fill(tyresDT);
                }



                int runKmBatteries = Convert.ToInt32(textBox4.Text);
                int normKmBatteries = Convert.ToInt32(comboBox3.Text);
                string batteryType = textBox6.Text;
                string batteryBrand = textBox5.Text;
                int countBattery = Convert.ToInt32(comboBox4.Text);
                int batteryNumber = Convert.ToInt32(textBox10.Text);
                int lifeTime = Convert.ToInt32(comboBox8.Text);
                DataTable batteriesDT = new DataTable();
                string queryBatteries = $"INSERT INTO carBatteries ([Пробег ТС с АКБ], [Норма пробега], [Дата проверки], [Гос номер], [Тип АКБ], [Производитель АКБ], " +
                    $"[Дата изготовления АКБ], [Номер АКБ], [Дата ввода в экспл], [Дата установки на ТС], [Срок службы АКБ, мес]) " +
                    $"VALUES ('{runKmBatteries}', '{normKmBatteries}', '{dateTimePicker2.Text}', '{DataBank.SelRowStr}', '{batteryType}', '{batteryBrand}', " +
                    $"'{dateTimePicker7.Text}', {batteryNumber}, '{dateTimePicker8.Text}', '{dateTimePicker9.Text}', {lifeTime})";
                OleDbDataAdapter commandAddBattery = new OleDbDataAdapter(queryBatteries, dbConnection);
                for (int i = 1; i <= countBattery; i++)
                {
                    commandAddBattery.Fill(batteriesDT);
                }



                int countAid = Convert.ToInt32(comboBox5.Text);
                DataTable aidDT = new DataTable();
                string queryAid = $"INSERT INTO carAid ([Срок годности], [Дата проверки], [Гос номер]) " +
                    $"VALUES ('{dateTimePicker4.Text}', '{dateTimePicker3.Text}', '{DataBank.SelRowStr}')";
                OleDbDataAdapter commandAddAid = new OleDbDataAdapter(queryAid, dbConnection);
                for (int i = 1; i <= countAid; i++)
                {
                    commandAddAid.Fill(aidDT);
                }



                string extType = textBox11.Text;
                int countExtinguisher = Convert.ToInt32(comboBox6.Text);
                DataTable extinguisherDT = new DataTable();
                string queryExtinguisher = $"INSERT INTO carExtinguisher ([Дата перезарядки], [Дата проверки], [Гос номер], [Тип]) " +
                    $"VALUES ('{dateTimePicker5.Text}', '{dateTimePicker6.Text}', '{DataBank.SelRowStr}', '{extType}')";
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

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
        }

        private void Form4_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = this.Owner as Form2;
            f2.Show();
            f2.Activate();
            dbConnection.Close();
            this.Hide();
        }
    }
}
