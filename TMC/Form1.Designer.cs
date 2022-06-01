
namespace TMC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataSet = new TMC.vehicleDataSet();
            this.carsTableAdapter = new TMC.vehicleDataSetTableAdapters.carsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.транспортноеСредствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВыбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьКарточкуТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВыбранноеТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранноеТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(629, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.vehicleDataSet;
            // 
            // vehicleDataSet
            // 
            this.vehicleDataSet.DataSetName = "vehicleDataSet";
            this.vehicleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.транспортноеСредствоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // транспортноеСредствоToolStripMenuItem
            // 
            this.транспортноеСредствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьВыбранноеToolStripMenuItem,
            this.удалитьВыбранноеToolStripMenuItem});
            this.транспортноеСредствоToolStripMenuItem.Name = "транспортноеСредствоToolStripMenuItem";
            this.транспортноеСредствоToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.транспортноеСредствоToolStripMenuItem.Text = "Транспортное средство";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьВыбранноеToolStripMenuItem
            // 
            this.изменитьВыбранноеToolStripMenuItem.Name = "изменитьВыбранноеToolStripMenuItem";
            this.изменитьВыбранноеToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.изменитьВыбранноеToolStripMenuItem.Text = "Изменить выбранное";
            this.изменитьВыбранноеToolStripMenuItem.Click += new System.EventHandler(this.изменитьВыбранноеToolStripMenuItem_Click);
            // 
            // удалитьВыбранноеToolStripMenuItem
            // 
            this.удалитьВыбранноеToolStripMenuItem.Name = "удалитьВыбранноеToolStripMenuItem";
            this.удалитьВыбранноеToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.удалитьВыбранноеToolStripMenuItem.Text = "Удалить выбранное";
            this.удалитьВыбранноеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранноеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьКарточкуТСToolStripMenuItem,
            this.добавитьТСToolStripMenuItem,
            this.изменитьВыбранноеТСToolStripMenuItem,
            this.удалитьВыбранноеТСToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 92);
            // 
            // открытьКарточкуТСToolStripMenuItem
            // 
            this.открытьКарточкуТСToolStripMenuItem.Name = "открытьКарточкуТСToolStripMenuItem";
            this.открытьКарточкуТСToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.открытьКарточкуТСToolStripMenuItem.Text = "Открыть карточку ТС";
            this.открытьКарточкуТСToolStripMenuItem.Click += new System.EventHandler(this.открытьКарточкуТСToolStripMenuItem_Click);
            // 
            // добавитьТСToolStripMenuItem
            // 
            this.добавитьТСToolStripMenuItem.Name = "добавитьТСToolStripMenuItem";
            this.добавитьТСToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.добавитьТСToolStripMenuItem.Text = "Добавить ТС";
            this.добавитьТСToolStripMenuItem.Click += new System.EventHandler(this.добавитьТСToolStripMenuItem_Click);
            // 
            // изменитьВыбранноеТСToolStripMenuItem
            // 
            this.изменитьВыбранноеТСToolStripMenuItem.Name = "изменитьВыбранноеТСToolStripMenuItem";
            this.изменитьВыбранноеТСToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.изменитьВыбранноеТСToolStripMenuItem.Text = "Изменить выбранное ТС";
            this.изменитьВыбранноеТСToolStripMenuItem.Click += new System.EventHandler(this.изменитьВыбранноеТСToolStripMenuItem_Click);
            // 
            // удалитьВыбранноеТСToolStripMenuItem
            // 
            this.удалитьВыбранноеТСToolStripMenuItem.Name = "удалитьВыбранноеТСToolStripMenuItem";
            this.удалитьВыбранноеТСToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.удалитьВыбранноеТСToolStripMenuItem.Text = "Удалить выбранное ТС";
            this.удалитьВыбранноеТСToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранноеТСToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список ТС";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public vehicleDataSet vehicleDataSet;
        public System.Windows.Forms.BindingSource carsBindingSource;
        public vehicleDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem транспортноеСредствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьВыбранноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранноеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьКарточкуТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьВыбранноеТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранноеТСToolStripMenuItem;
    }
}

