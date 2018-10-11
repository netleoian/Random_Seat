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
                for (int C = 0; C < Cols_Count; C++)
                    dataset.Tables[0].Columns.Add();
                //新增列
                for (int R = 0; R < Rows_Count; R++)
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
                }
                else {
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                }
            }
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            names.Clear();
            //隨機產生順序
            names.AddRange(Names.Text.ToString().Replace("\r","").Split('\n'));
            Random randomnum = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < names.Count; i++) {
                Swap(i,randomnum.Next(0, names.Count - 1));
            }
            //放入陣列
            int listcount = 0;
            if (Divide_Check.Checked == false)//是否拆開
            {
                for (int r = 0; r < dataset.Tables[0].Rows.Count && listcount < names.Count; r++)
                    for (int c = 0; c < dataset.Tables[0].Columns.Count && listcount < names.Count; c++, listcount++)
                        dataGridView1[c, r].Value = dataGridView1[c, r].Value.Equals("無電腦") ?"":names[listcount];
            }
            else {
                for (int r = 0; r < dataset.Tables[0].Rows.Count && listcount < names.Count; r++)
                    for (int c = 0; c < dataset.Tables[0].Columns.Count && listcount < names.Count; c++, listcount++)

            }
        }
        private void Swap(int Old,int New) {
            var tmp = names[Old];
            names[Old] = names[New];
            names[New] = tmp;
        }
    }
}
