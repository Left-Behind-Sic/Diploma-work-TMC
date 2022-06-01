using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TMC
{
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        private OleDbConnection dbConnection;
        public Form1()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection(DataBank.ConnectString);
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable carsDT = new DataTable();
            string query = "SELECT * FROM cars ORDER BY id";
            OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query, dbConnection);
            commandBatteries.Fill(carsDT);
            dataGridView1.DataSource = carsDT;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBank.SelRowStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //MessageBox.Show(DataBank.SelRowStr);
            DataBank.ChangeCar = true;
            f2 = new Form2();
            f2.Owner = this;
            f2.Text = "Данные транспортного средства: " + DataBank.SelRowStr;
            f2.Show();
            dbConnection.Close();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataBank.ChangeCar = false;
            f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Добавление нового ТС";
            this.Hide();
            dbConnection.Close();
            f3.Show();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string delRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            DataTable carsDT = new DataTable();
            string query1 = $"DELETE FROM cars WHERE [Гос номер]='{delRow}'";
            OleDbDataAdapter commandDel = new OleDbDataAdapter(query1, dbConnection);
            commandDel.Fill(carsDT);
            string query = "SELECT * FROM cars ORDER BY id";
            OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query, dbConnection);
            commandBatteries.Fill(carsDT);
            dataGridView1.DataSource = carsDT;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataBank.ChangeCar = false;
            dbConnection.Open();
            DataTable carsDT = new DataTable();
            string query = "SELECT * FROM cars ORDER BY id";
            OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query, dbConnection);
            commandBatteries.Fill(carsDT);
            dataGridView1.DataSource = carsDT;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.ChangeCar = true;
            DataBank.SelRowStr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Измение данных ТС";
            this.Hide();
            dbConnection.Close();
            f3.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.ChangeCar = false;
            f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Добавление нового ТС";
            this.Hide();
            dbConnection.Close();
            f3.Show();
        }

        private void изменитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.ChangeCar = true;
            DataBank.SelRowStr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Измение данных ТС";
            this.Hide();
            dbConnection.Close();
            f3.Show();
        }

        private void удалитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string query1 = $"DELETE FROM cars WHERE [Гос номер]='{delRow}'";
            OleDbCommand command = new OleDbCommand(query1, dbConnection);
            command.ExecuteNonQuery();
            DataTable carsDT = new DataTable();
            string query = "SELECT * FROM cars ORDER BY id";
            OleDbDataAdapter commandBatteries = new OleDbDataAdapter(query, dbConnection);
            commandBatteries.Fill(carsDT);
            dataGridView1.DataSource = carsDT;
        }

        private void открытьКарточкуТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank.SelRowStr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            DataBank.ChangeCar = true;
            f2 = new Form2();
            f2.Owner = this;
            f2.Text = "Данные транспортного средства: " + DataBank.SelRowStr;
            f2.Show();
            dbConnection.Close();
            this.Hide();
        }

        private void добавитьТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            добавитьToolStripMenuItem_Click(null, new EventArgs());
        }

        private void изменитьВыбранноеТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            изменитьВыбранноеToolStripMenuItem_Click(null, new EventArgs());
        }

        private void удалитьВыбранноеТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            удалитьВыбранноеToolStripMenuItem_Click(null, new EventArgs());
        }
    }
}
