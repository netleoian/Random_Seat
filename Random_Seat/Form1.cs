using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Seat
{
    public partial class Form1 : Form
    {
        DataSet dataset = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            if (dataset != null)
                dataset.Dispose();
            dataset = new DataSet();
            dataset.Tables.Add(new DataTable());
            int Rows_Count = int.Parse(Text_Row.Text);
            int Cols_Count = int.Parse(Text_Column.Text);
            for (int C = 0; C < Cols_Count; C++)
                dataset.Tables[0].Columns.Add();

            for (int R = 0; R < Rows_Count; R++)
                dataset.Tables[0].Rows.Add(dataset.Tables[0].NewRow());
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (!dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Equals("無電腦"))
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = "無電腦";
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
                }
                else {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                }
            }
        }
    }
}
