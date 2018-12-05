namespace uchet_IT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iT_dbmdbDataSet1 = new uchet_IT.IT_dbmdbDataSet1();
            this.inventhellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invent_hellTableAdapter = new uchet_IT.IT_dbmdbDataSet1TableAdapters.invent_hellTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventnumbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whereitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_toExcel = new System.Windows.Forms.Button();
            this.Destroy_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iT_dbmdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventhellBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.deviceDataGridViewTextBoxColumn,
            this.inventnumbDataGridViewTextBoxColumn,
            this.whereitDataGridViewTextBoxColumn,
            this.diyDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.inventhellBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // iT_dbmdbDataSet1
            // 
            this.iT_dbmdbDataSet1.DataSetName = "IT_dbmdbDataSet1";
            this.iT_dbmdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventhellBindingSource
            // 
            this.inventhellBindingSource.DataMember = "invent_hell";
            this.inventhellBindingSource.DataSource = this.iT_dbmdbDataSet1;
            // 
            // invent_hellTableAdapter
            // 
            this.invent_hellTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "ID";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 30;
            // 
            // deviceDataGridViewTextBoxColumn
            // 
            this.deviceDataGridViewTextBoxColumn.DataPropertyName = "device";
            this.deviceDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.deviceDataGridViewTextBoxColumn.Name = "deviceDataGridViewTextBoxColumn";
            this.deviceDataGridViewTextBoxColumn.Width = 300;
            // 
            // inventnumbDataGridViewTextBoxColumn
            // 
            this.inventnumbDataGridViewTextBoxColumn.DataPropertyName = "invent_numb";
            this.inventnumbDataGridViewTextBoxColumn.HeaderText = "Инвентарный номер";
            this.inventnumbDataGridViewTextBoxColumn.Name = "inventnumbDataGridViewTextBoxColumn";
            this.inventnumbDataGridViewTextBoxColumn.Width = 150;
            // 
            // whereitDataGridViewTextBoxColumn
            // 
            this.whereitDataGridViewTextBoxColumn.DataPropertyName = "where_it";
            this.whereitDataGridViewTextBoxColumn.HeaderText = "Местоположение";
            this.whereitDataGridViewTextBoxColumn.Name = "whereitDataGridViewTextBoxColumn";
            // 
            // diyDataGridViewCheckBoxColumn
            // 
            this.diyDataGridViewCheckBoxColumn.DataPropertyName = "diy";
            this.diyDataGridViewCheckBoxColumn.HeaderText = "Поломка";
            this.diyDataGridViewCheckBoxColumn.Name = "diyDataGridViewCheckBoxColumn";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(6, 19);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Найти";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(226, 19);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(46, 19);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(123, 23);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Удалить запись";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button_toExcel
            // 
            this.button_toExcel.Location = new System.Drawing.Point(114, 48);
            this.button_toExcel.Name = "button_toExcel";
            this.button_toExcel.Size = new System.Drawing.Size(112, 23);
            this.button_toExcel.TabIndex = 5;
            this.button_toExcel.Text = "Экспорт в Excel";
            this.button_toExcel.UseVisualStyleBackColor = true;
            this.button_toExcel.Visible = false;
            this.button_toExcel.Click += new System.EventHandler(this.button_toExcel_Click);
            // 
            // Destroy_Button
            // 
            this.Destroy_Button.Location = new System.Drawing.Point(93, 48);
            this.Destroy_Button.Name = "Destroy_Button";
            this.Destroy_Button.Size = new System.Drawing.Size(160, 23);
            this.Destroy_Button.TabIndex = 6;
            this.Destroy_Button.Text = "Показать поломанное";
            this.Destroy_Button.UseVisualStyleBackColor = true;
            this.Destroy_Button.Click += new System.EventHandler(this.Destroy_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh_Button);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Destroy_Button);
            this.groupBox1.Controls.Add(this.Search_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_toExcel);
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Controls.Add(this.Save_Button);
            this.groupBox2.Location = new System.Drawing.Point(304, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с БД";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Location = new System.Drawing.Point(6, 48);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Button.TabIndex = 7;
            this.Refresh_Button.Text = "Сброс";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Информационная система учета вычислительной техники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iT_dbmdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventhellBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IT_dbmdbDataSet1 iT_dbmdbDataSet1;
        private System.Windows.Forms.BindingSource inventhellBindingSource;
        private IT_dbmdbDataSet1TableAdapters.invent_hellTableAdapter invent_hellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventnumbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whereitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn diyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_toExcel;
        private System.Windows.Forms.Button Destroy_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

