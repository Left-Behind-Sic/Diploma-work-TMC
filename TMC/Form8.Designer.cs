
namespace TMC
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label32 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 105);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 71;
            this.label32.Text = "Тип огнетушителя";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(122, 102);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(262, 20);
            this.textBox11.TabIndex = 70;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 52);
            this.label22.TabIndex = 69;
            this.label22.Text = "Количество\r\nогнетушителей\r\nс одинаковыми\r\nданными";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox6.Location = new System.Drawing.Point(122, 148);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(262, 21);
            this.comboBox6.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Дата перезарядки:";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(122, 56);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(262, 20);
            this.dateTimePicker5.TabIndex = 66;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "Дата проверки:";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(122, 12);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(262, 20);
            this.dateTimePicker6.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 45);
            this.button1.TabIndex = 87;
            this.button1.Text = "Сохранить и закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePicker6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Activated += new System.EventHandler(this.Form8_Activated);
            this.Deactivate += new System.EventHandler(this.Form8_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Button button1;
    }
}