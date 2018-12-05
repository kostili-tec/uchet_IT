using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace uchet_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iT_dbmdbDataSet1.invent_hell". При необходимости она может быть перемещена или удалена.
            this.invent_hellTableAdapter.Fill(this.iT_dbmdbDataSet1.invent_hell);
           
           

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            {
                string strNull = textBox1.Text.ToString();
                bool exists = false;

                int l = dataGridView1.Rows.Count;
                if (l == 0)
                {
                    MessageBox.Show("А где искать-то?!", "Ошибка", 0, MessageBoxIcon.Error);
                    textBox1.Clear();
                    return;
                }

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            exists = true;
                            break;
                        }
                        else
                        {
                            dataGridView1.CurrentCell = null;
                            dataGridView1.Rows[i].Visible = false;
                        }

                    }

                }

                if (!exists)
                {
                    this.invent_hellTableAdapter.Fill(this.iT_dbmdbDataSet1.invent_hell);

                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.inventhellBindingSource.EndEdit();
                this.invent_hellTableAdapter.Update(this.iT_dbmdbDataSet1.invent_hell);
                MessageBox.Show("Данные oбновлены!");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка обновления!");
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* try
            {
                this.Validate();
                this.inventhellBindingSource.EndEdit();
                this.invent_hellTableAdapter.Update(this.iT_dbmdbDataSet1.invent_hell);
                MessageBox.Show("Данные oбновлены!");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ошибка обновления!");
            } */
        }

        private void button_toExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void Destroy_Button_Click(object sender, EventArgs e)
        {
            {
                string destroy = "True";
                bool exists = false;

                int l = dataGridView1.Rows.Count;
                

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }

                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(destroy))
                        {
                            dataGridView1.Rows[i].Visible = true;
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            exists = true;
                            break;
                        }
                        else
                        {
                            dataGridView1.CurrentCell = null;
                            dataGridView1.Rows[i].Visible = false;
                        }

                    }

                }
                
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            this.invent_hellTableAdapter.Fill(this.iT_dbmdbDataSet1.invent_hell);
        }
    }
}
