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
        List<String> names = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataset != null) dataset.Dispose();

                dataset = new DataSet();
                dataset.Tables.Add(new DataTable());

                int Rows_Count = int.Parse(Text_Row.Text);
                int Cols_Count = int.Parse(Text_Column.Text);
                //新增行
                for (int C = 0; C <= Cols_Count; C++)
                    dataset.Tables[0].Columns.Add();
                //新增列
                for (int R = 0; R <= Rows_Count; R++)
                    dataset.Tables[0].Rows.Add(dataset.Tables[0].NewRow());
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //客製化
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (!dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString().Equals("無電腦"))
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = "無電腦";
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
                  //  NA.i.Add(e.ColumnIndex + "," + e.RowIndex);
                }
                else {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = String.Empty;
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    //NA.Remove(e.ColumnIndex + "," + e.RowIndex);
                }
            }
        }
        private void cleartable() {
        }
        private void Button_Random_Click(object sender, EventArgs e)
        {
            cleartable();
            //隨機產生順序
            names.Clear();
            names.AddRange(Names.Text.ToString().Replace("\r", "").Split('\n'));
            Random randomnum = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < names.Count; i++)
            {
                Swap(i, randomnum.Next(0, names.Count - 1));
            }
            //放入陣列
            int listcount = 0;
            if (Divide_Check.Checked == false)//是否拆開
            {
                for (int r = 1; r < dataset.Tables[0].Rows.Count && listcount < names.Count; r++)
                    for (int c = 1; c < dataset.Tables[0].Columns.Count && listcount < names.Count; c++, listcount++)
                        dataGridView1[c, r].Value = dataGridView1[c, r].Value.Equals("無電腦") ? "無電腦" : names[listcount];
            }
            else
            {
                for (int r = 1; r < dataset.Tables[0].Rows.Count && listcount < names.Count; r++)
                    for (int c = 1; c < dataset.Tables[0].Columns.Count && listcount < names.Count; c++)
                    {
                        if (dataGridView1[c, r].Value.ToString().Equals("無電腦")) continue;
                        //第一筆或 左上為空或沒電腦
                        if ((dataGridView1[c - 1, r].Value.ToString().Equals("無電腦") || dataGridView1[c - 1, r].Value.ToString().ToString().Equals(String.Empty))
                            && (dataGridView1[c, r - 1].Value.ToString().Equals("無電腦") || dataGridView1[c, r - 1].Value.ToString().Equals(String.Empty)))
                        {
                            dataGridView1[c, r].Value = names[listcount];
                            listcount++;
                        }
                    }
            }
        }
        private void Swap(int Old,int New) {
            var tmp = names[Old];
            names[Old] = names[New];
            names[New] = tmp;
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            for (int r = 1; r < dataset.Tables[0].Rows.Count; r++)
            {
                for (int c = 1; c < dataset.Tables[0].Columns.Count; c++)
                {
                    text.Append(dataGridView1[c, r].Value + ",");
                }
                text.Append("\n");
            }
            System.IO.File.WriteAllText(System.Windows.Forms.Application.StartupPath+"output.csv",text.ToString());
        }
    }
}
