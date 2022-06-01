using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TMC
{
    public partial class Form2 : Form
    {

        private OleDbConnection dbConnection;
        Form4 f4;
        Form1 f1;

        public Form2()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            //dbConnection.Open();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
            dataGridView3.ContextMenuStrip = contextMenuStrip3;
            dataGridView4.ContextMenuStrip = contextMenuStrip4;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet.carExtinguisher". При необходимости она может быть перемещена или удалена.
            //this.carExtinguisherTableAdapter.Fill(this.vehicleDataSet.carExtinguisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet.carAid". При необходимости она может быть перемещена или удалена.
            //this.carAidTableAdapter.Fill(this.vehicleDataSet.carAid);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vehicleDataSet.carBatteries". При необходимости она может быть перемещена или удалена.
            //this.carBatteriesTableAdapter.Fill(this.vehicleDataSet.carBatteries);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1 = this.Owner as Form1;
            f1.Show();
            f1.Activate();
            dbConnection.Close();
            this.Hide();
        }


        private void Form2_Activated(object sender, EventArgs e)
        {
            dbConnection.Open();
            DataBank.ChangeCar = false;
            DataTable tyresDT = new DataTable();
            //OleDbDataReader myReader = null;
            string query1 = "SELECT * FROM carTyres WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
            OleDbDataAdapter commandTyres = new OleDbDataAdapter(query1, dbConnection);
            commandTyres.Fill(tyresDT);
            dataGridView1.DataSource = tyresDT;


            DataTable batteriesDT = new DataTable();
            string query2 = "SELECT * FROM carBatteries WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
            OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query2, dbConnection);
            commandBatteries.Fill(batteriesDT);
            dataGridView2.DataSource = batteriesDT;

            DataTable aidDT = new DataTable();
            string query3 = "SELECT * FROM carAid WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
            OleDbDataAdapter commandAid = new OleDbDataAdapter(query3, dbConnection);
            commandAid.Fill(aidDT);
            dataGridView3.DataSource = aidDT;

            DataTable extinguisherDT = new DataTable();
            string query4 = "SELECT * FROM carExtinguisher WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
            OleDbDataAdapter extinguisherAid = new OleDbDataAdapter(query4, dbConnection);
            extinguisherAid.Fill(extinguisherDT);
            dataGridView4.DataSource = extinguisherDT;
        }

        private void шиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentNumber = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            OleDbCommand query1 = dbConnection.CreateCommand();
            query1.CommandText = $"SELECT DISTINCT [Размер шины] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel1 = query1.ExecuteReader();
            string res1 = string.Empty;

            OleDbCommand query2 = dbConnection.CreateCommand();
            query2.CommandText = $"SELECT DISTINCT [Норма пробега] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel2 = query2.ExecuteReader();
            string res2 = string.Empty;

            OleDbCommand query3 = dbConnection.CreateCommand();
            query3.CommandText = $"SELECT DISTINCT [Пробег автомобиля] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel3 = query3.ExecuteReader();
            string res3 = string.Empty;

            OleDbCommand query4 = dbConnection.CreateCommand();
            query4.CommandText = $"SELECT DISTINCT [Дата проверки] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel4 = query4.ExecuteReader();
            string res4 = string.Empty;

            OleDbCommand query5 = dbConnection.CreateCommand();
            query5.CommandText = $"SELECT DISTINCT [Гос номер] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel5 = query5.ExecuteReader();
            string res5 = string.Empty;

            OleDbCommand query6 = dbConnection.CreateCommand();
            query6.CommandText = $"SELECT DISTINCT [Производитель шины] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel6 = query6.ExecuteReader();
            string res6 = string.Empty;


            OleDbCommand query7 = dbConnection.CreateCommand();
            query7.CommandText = $"SELECT DISTINCT [Модель шины] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel7 = query7.ExecuteReader();
            string res7 = string.Empty;


            OleDbCommand query8 = dbConnection.CreateCommand();
            query8.CommandText = $"SELECT DISTINCT [Заводской номер] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel8 = query8.ExecuteReader();
            string res8 = string.Empty;


            OleDbCommand query9 = dbConnection.CreateCommand();
            query9.CommandText = $"SELECT DISTINCT [Пробег шины] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel9 = query9.ExecuteReader();
            string res9 = string.Empty;


            OleDbCommand query10 = dbConnection.CreateCommand();
            query10.CommandText = $"SELECT DISTINCT [Техническое состояние] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel10 = query10.ExecuteReader();
            string res10 = string.Empty;

            OleDbCommand query11 = dbConnection.CreateCommand();
            query11.CommandText = $"SELECT DISTINCT [Водитель] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel11 = query11.ExecuteReader();
            string res11 = string.Empty;


            OleDbCommand query12 = dbConnection.CreateCommand();
            query12.CommandText = $"SELECT DISTINCT [Производственная площадка] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel12 = query12.ExecuteReader();
            string res12 = string.Empty;


            OleDbCommand query13 = dbConnection.CreateCommand();
            query13.CommandText = $"SELECT DISTINCT [Инвентарный номер ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel13 = query13.ExecuteReader();
            string res13 = string.Empty;

            OleDbCommand query14 = dbConnection.CreateCommand();
            query14.CommandText = $"SELECT DISTINCT [Остаточная высота протектора (мм)] FROM carTyres WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel14 = query14.ExecuteReader();
            string res14 = string.Empty;


            while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read() && commandExcel4.Read() && commandExcel5.Read() && commandExcel6.Read() && commandExcel7.Read()
                && commandExcel8.Read()
                && commandExcel9.Read()
                && commandExcel10.Read()
                && commandExcel11.Read()
                && commandExcel12.Read()
                && commandExcel13.Read()
                && commandExcel14.Read())
            {
                res1 += commandExcel1["Размер шины"];
                res2 += commandExcel2["Норма пробега"];
                res3 += commandExcel3["Пробег автомобиля"];
                res4 += commandExcel4["Дата проверки"];
                res5 += commandExcel5["Гос номер"];
                res6 += commandExcel6["Производитель шины"];
                res7 += commandExcel7["Модель шины"];
                res8 += commandExcel8["Заводской номер"];
                res9 += commandExcel9["Пробег шины"];
                res10 += commandExcel10["Техническое состояние"];
                res11 += commandExcel11["Водитель"];
                res12 += commandExcel12["Производственная площадка"];
                res13 += commandExcel13["Инвентарный номер ТС"];
                res14 += commandExcel14["Остаточная высота протектора (мм)"];
            }
            commandExcel1.Close();
            commandExcel2.Close();
            commandExcel3.Close();
            commandExcel4.Close();
            commandExcel5.Close();
            commandExcel6.Close();
            commandExcel7.Close();
            commandExcel8.Close();
            commandExcel9.Close();
            commandExcel10.Close();
            commandExcel11.Close();
            commandExcel12.Close();
            commandExcel13.Close();
            commandExcel14.Close();
            //dbConnection.Close();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string nameExcel = path + @"\КАРТОЧКА РАБОТЫ ШИНЫ.xlsx";
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Workbooks.Open(nameExcel);
            //Отобразить Excel
            ex.Visible = true;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Cells[6, 3] = String.Format(res1);
            sheet.Cells[8, 4] = String.Format(res2);
            sheet.Cells[22, 2] = String.Format(res3);
            sheet.Cells[22, 3] = String.Format(Convert.ToDateTime(res4).ToShortDateString());
            sheet.Cells[22, 1] = String.Format(res5);
            sheet.Cells[10, 6] = String.Format(res6);
            sheet.Cells[6, 8] = String.Format(res7);
            sheet.Cells[8, 9] = String.Format(res8);
            sheet.Cells[22, 6] = String.Format(res9);
            sheet.Cells[22, 7] = String.Format(res10);
            sheet.Cells[14, 3] = String.Format(res11);
            sheet.Cells[12, 9] = String.Format(res12);
            sheet.Cells[14, 9] = String.Format(res13);
            sheet.Cells[22, 9] = String.Format(res14);

        }

        private void аккумуляторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentNumber = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();

            OleDbCommand query1 = dbConnection.CreateCommand();
            query1.CommandText = $"SELECT DISTINCT [Пробег ТС с АКБ] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel1 = query1.ExecuteReader();
            string res1 = string.Empty;

            OleDbCommand query2 = dbConnection.CreateCommand();
            query2.CommandText = $"SELECT DISTINCT [Норма пробега] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel2 = query2.ExecuteReader();
            string res2 = string.Empty;

            OleDbCommand query3 = dbConnection.CreateCommand();
            query3.CommandText = $"SELECT DISTINCT [Дата проверки] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel3 = query3.ExecuteReader();
            string res3 = string.Empty;


            OleDbCommand query4 = dbConnection.CreateCommand();
            query4.CommandText = $"SELECT DISTINCT [Гос номер] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel4 = query4.ExecuteReader();
            string res4 = string.Empty;

            OleDbCommand query5 = dbConnection.CreateCommand();
            query5.CommandText = $"SELECT DISTINCT [Тип АКБ] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel5 = query5.ExecuteReader();
            string res5 = string.Empty;


            OleDbCommand query6 = dbConnection.CreateCommand();
            query6.CommandText = $"SELECT DISTINCT [Производитель АКБ] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel6 = query6.ExecuteReader();
            string res6 = string.Empty;


            OleDbCommand query7 = dbConnection.CreateCommand();
            query7.CommandText = $"SELECT DISTINCT [Дата изготовления АКБ] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel7 = query7.ExecuteReader();
            string res7 = string.Empty;


            OleDbCommand query8 = dbConnection.CreateCommand();
            query8.CommandText = $"SELECT DISTINCT [Номер АКБ] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel8 = query8.ExecuteReader();
            string res8 = string.Empty;


            OleDbCommand query9 = dbConnection.CreateCommand();
            query9.CommandText = $"SELECT DISTINCT [Дата ввода в экспл] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel9 = query9.ExecuteReader();
            string res9 = string.Empty;


            OleDbCommand query10 = dbConnection.CreateCommand();
            query10.CommandText = $"SELECT DISTINCT [Дата установки на ТС] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel10 = query10.ExecuteReader();
            string res10 = string.Empty;

            OleDbCommand query11 = dbConnection.CreateCommand();
            query11.CommandText = $"SELECT DISTINCT [Срок службы АКБ, мес] FROM carBatteries WHERE id={Convert.ToInt32(currentNumber)}";
            OleDbDataReader commandExcel11 = query11.ExecuteReader();
            string res11 = string.Empty;


            OleDbCommand query12 = dbConnection.CreateCommand();
            query12.CommandText = $"SELECT DISTINCT [Водитель] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel12 = query12.ExecuteReader();
            string res12 = string.Empty;


            OleDbCommand query13 = dbConnection.CreateCommand();
            query13.CommandText = $"SELECT DISTINCT [Производственная площадка] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel13 = query13.ExecuteReader();
            string res13 = string.Empty;


            OleDbCommand query14 = dbConnection.CreateCommand();
            query14.CommandText = $"SELECT DISTINCT [Инвентарный номер ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel14 = query14.ExecuteReader();
            string res14 = string.Empty;

            OleDbCommand query15 = dbConnection.CreateCommand();
            query15.CommandText = $"SELECT DISTINCT [Марка и модель ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel15 = query15.ExecuteReader();
            string res15 = string.Empty;


            while (commandExcel1.Read() && commandExcel2.Read() && commandExcel3.Read() && commandExcel4.Read() && commandExcel5.Read() && commandExcel6.Read() && commandExcel7.Read()
                && commandExcel8.Read()
                && commandExcel9.Read()
                && commandExcel10.Read()
                && commandExcel11.Read()
                && commandExcel12.Read()
                && commandExcel13.Read()
                && commandExcel14.Read()
                && commandExcel15.Read())
            {
                res1 += commandExcel1["Пробег ТС с АКБ"];
                res2 += commandExcel2["Норма пробега"];
                res3 += commandExcel3["Дата проверки"];
                res4 += commandExcel4["Гос номер"];
                res5 += commandExcel5["Тип АКБ"];
                res6 += commandExcel6["Производитель АКБ"];
                res7 += commandExcel7["Дата изготовления АКБ"];
                res8 += commandExcel8["Номер АКБ"];
                res9 += commandExcel9["Дата ввода в экспл"];
                res10 += commandExcel10["Дата установки на ТС"];
                res11 += commandExcel11["Срок службы АКБ, мес"];
                res12 += commandExcel12["Водитель"];
                res13 += commandExcel13["Производственная площадка"];
                res14 += commandExcel14["Инвентарный номер ТС"];
                res15 += commandExcel15["Марка и модель ТС"];
            }
            commandExcel1.Close();
            //dbConnection.Close();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string nameExcel = path + @"\КАРТОЧКА АККУМУЛЯТОРА.xls";
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Workbooks.Open(nameExcel);
            //Отобразить Excel
            ex.Visible = true;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Cells[27, 2] = String.Format(res1);
            sheet.Cells[11, 12] = String.Format(res2);
            sheet.Cells[27, 1] = String.Format(Convert.ToDateTime(res3).ToShortDateString());
            sheet.Cells[13, 7] = String.Format(res4);
            sheet.Cells[8, 2] = String.Format(res5);
            sheet.Cells[9, 3] = String.Format(res6);
            sheet.Cells[8, 18] = String.Format(Convert.ToDateTime(res7).ToShortDateString());
            sheet.Cells[8, 15] = String.Format(res8);
            sheet.Cells[10, 7] = String.Format(Convert.ToDateTime(res9).ToShortDateString());
            sheet.Cells[14, 7] = String.Format(Convert.ToDateTime(res10).ToShortDateString());
            sheet.Cells[10, 18] = String.Format(res11);
            sheet.Cells[17, 7] = String.Format(res12);
            sheet.Cells[6, 15] = String.Format(res13);
            sheet.Cells[16, 7] = String.Format(res14);
            sheet.Cells[15, 7] = String.Format(res15);


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbConnection.Close();
            f1 = this.Owner as Form1;
            f1.Show();
            f1.Activate();
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void аптечкиИОгнетушителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentNumber1 = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string currentNumber2 = dataGridView4.Rows[dataGridView4.CurrentCell.RowIndex].Cells[0].Value.ToString();


            OleDbCommand query1 = dbConnection.CreateCommand();
            query1.CommandText = $"SELECT DISTINCT [Гос номер] FROM carAid WHERE id={currentNumber1}";
            OleDbDataReader commandExcel1 = query1.ExecuteReader();
            string res1 = string.Empty;


            OleDbCommand query4 = dbConnection.CreateCommand();
            query4.CommandText = $"SELECT DISTINCT [Дата проверки] FROM carAid WHERE id={currentNumber2}";
            OleDbDataReader commandExcel4 = query4.ExecuteReader();
            string res4 = string.Empty;


            OleDbCommand query2 = dbConnection.CreateCommand();
            query2.CommandText = $"SELECT DISTINCT [Тип] FROM carExtinguisher WHERE id={currentNumber2}";
            OleDbDataReader commandExcel2 = query2.ExecuteReader();
            string res2 = string.Empty;


            OleDbCommand query3 = dbConnection.CreateCommand();
            query3.CommandText = $"SELECT DISTINCT [Дата проверки] FROM carExtinguisher WHERE id={currentNumber2}";
            OleDbDataReader commandExcel3 = query3.ExecuteReader();
            string res3 = string.Empty;




            OleDbCommand query11 = dbConnection.CreateCommand();
            query11.CommandText = $"SELECT DISTINCT [Водитель] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel11 = query11.ExecuteReader();
            string res11 = string.Empty;


            OleDbCommand query12 = dbConnection.CreateCommand();
            query12.CommandText = $"SELECT DISTINCT [Производственная площадка] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel12 = query12.ExecuteReader();
            string res12 = string.Empty;



            OleDbCommand query13 = dbConnection.CreateCommand();
            query13.CommandText = $"SELECT DISTINCT [Марка и модель ТС] FROM cars WHERE [Гос номер]='{DataBank.SelRowStr}'";
            OleDbDataReader commandExcel13 = query13.ExecuteReader();
            string res13 = string.Empty;



            while (commandExcel1.Read()
                && commandExcel2.Read()
                && commandExcel3.Read()
                && commandExcel4.Read()
                && commandExcel11.Read()
                && commandExcel12.Read()
                && commandExcel13.Read()
              )
            {
                res1 += commandExcel1["Гос номер"];
                res2 += commandExcel2["Тип"];
                res3 += commandExcel3["Дата проверки"];
                res4 += commandExcel4["Дата проверки"];
                res11 += commandExcel11["Водитель"];
                res12 += commandExcel12["Производственная площадка"];
                res13 += commandExcel13["Марка и модель ТС"];

            }
            commandExcel1.Close();
            //dbConnection.Close();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string nameExcel = path + @"\КАРТОЧКА ТМЦ.xlsx";
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            ex.Workbooks.Open(nameExcel);
            //Отобразить Excel
            ex.Visible = true;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Cells[7, 7] = String.Format(res1);
            sheet.Cells[17, 2] = String.Format("Огнетушитель " + res2);
            sheet.Cells[18, 2] = String.Format("Аптечка");
            sheet.Cells[17, 15] = String.Format(Convert.ToDateTime(res3).ToShortDateString());
            sheet.Cells[18, 15] = String.Format(Convert.ToDateTime(res4).ToShortDateString());
            sheet.Cells[9, 7] = String.Format(res11);
            sheet.Cells[4, 16] = String.Format(res12);
            sheet.Cells[8, 7] = String.Format(res13);
            sheet.Cells[17, 16] = String.Format("Исправно");
            sheet.Cells[18, 16] = String.Format("Исправно");

        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Owner = this;
            f4.Text = $"Добавление данных для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f4.Show();
        }

        private void шиныToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Text = $"Добавление шин для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f5.Show();
        }

        private void аккумуляторыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Text = $"Добавление аккумуляторов для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f6.Show();
        }

        private void аптечкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Text = $"Добавление аптечек для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f7.Show();
        }

        private void огнетушителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Text = $"Добавление огнетушителей для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f8.Show();
        }

        private void шиныToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataBank.SelectedId = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Text = $"Изменение шины для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f5.Show();
        }

        private void аккумуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.SelectedId = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Text = $"Изменение аккумулятора для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f6.Show();
        }

        private void аптечкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.SelectedId = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Text = $"Изменение аптечки для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f7.Show();
        }

        private void огнетушительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.SelectedId = dataGridView4.Rows[dataGridView4.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Text = $"Изменение огнетушителя для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f8.Show();
        }


        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.SelectedId = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form6 f6 = new Form6();
            f6.Owner = this;
            f6.Text = $"Изменение шины для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f6.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.SelectedId = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form5 f5 = new Form5();
            f5.Owner = this;
            f5.Text = $"Изменение шины для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f5.Show();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.SelectedId = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form7 f7 = new Form7();
            f7.Owner = this;
            f7.Text = $"Изменение аптечки для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f7.Show();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.SelectedId = dataGridView4.Rows[dataGridView4.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DataBank.ChangeCar = true;
            Form8 f8 = new Form8();
            f8.Owner = this;
            f8.Text = $"Изменение огнетушителя для - {DataBank.SelRowStr}";
            dbConnection.Close();
            this.Hide();
            f8.Show();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись? (Строку нельзя будет вернуть)", "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string delRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DataTable tyresDT = new DataTable();
                string query1 = $"DELETE FROM carTyres WHERE [id]={delRow}";
                OleDbDataAdapter commandDel = new OleDbDataAdapter(query1, dbConnection);
                commandDel.Fill(tyresDT);
                string query2 = "SELECT * FROM carTyres WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
                OleDbDataAdapter commandTyres = new OleDbDataAdapter(query2, dbConnection);
                commandTyres.Fill(tyresDT);
                dataGridView1.DataSource = tyresDT;
            }


        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            шиныToolStripMenuItem1_Click(null, new EventArgs());
        }

        private void изменитьВыбраннуюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            шиныToolStripMenuItem2_Click(null, new EventArgs());
        }

        private void вывестиВыбраннуюСтрокуВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            шиныToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            аккумуляторыToolStripMenuItem1_Click(null, new EventArgs());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            аккумуляторToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            аккумуляторыToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись? (Строку нельзя будет вернуть)", "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string delRow = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DataTable batteriesDT = new DataTable();
                string query1 = $"DELETE FROM carBatteries WHERE [id]={delRow}";
                OleDbDataAdapter commandDel = new OleDbDataAdapter(query1, dbConnection);
                commandDel.Fill(batteriesDT);
                string query2 = "SELECT * FROM carBatteries WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
                OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query2, dbConnection);
                commandBatteries.Fill(batteriesDT);
                dataGridView2.DataSource = batteriesDT;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            аптечкиToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            аптечкуToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            аптечкиИОгнетушителиToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись? (Строку нельзя будет вернуть)", "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string delRow = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DataTable aidDT = new DataTable();
                string query1 = $"DELETE FROM carAid WHERE [id]={delRow}";
                OleDbDataAdapter commandDel = new OleDbDataAdapter(query1, dbConnection);
                commandDel.Fill(aidDT);
                string query3 = "SELECT * FROM carAid WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
                OleDbDataAdapter commandAid = new OleDbDataAdapter(query3, dbConnection);
                commandAid.Fill(aidDT);
                dataGridView3.DataSource = aidDT;
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            огнетушителиToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            огнетушительToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            аптечкиИОгнетушителиToolStripMenuItem_Click(null, new EventArgs());
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись? (Строку нельзя будет вернуть)", "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string delRow = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DataTable extinguisherDT = new DataTable();
                string query1 = $"DELETE FROM carExtinguisher WHERE [id]={delRow}";
                OleDbDataAdapter commandDel = new OleDbDataAdapter(query1, dbConnection);
                commandDel.Fill(extinguisherDT);
                string query4 = "SELECT * FROM carExtinguisher WHERE [Гос номер]='" + DataBank.SelRowStr + "' ORDER BY id";
                OleDbDataAdapter extinguisherAid = new OleDbDataAdapter(query4, dbConnection);
                extinguisherAid.Fill(extinguisherDT);
                dataGridView4.DataSource = extinguisherDT;
            }
        }

        private void выбраннуюШинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            удалитьСтрокуToolStripMenuItem_Click(null, new EventArgs());
        }

        private void выбранныйАккумуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem4_Click(null, new EventArgs());
        }

        private void выбраннуюАптечкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8_Click(null, new EventArgs());
        }

        private void выбранныйОгнетушительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem12_Click(null, new EventArgs());
        }
    }
}
