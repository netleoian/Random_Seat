namespace Random_Seat
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.TextBox();
            this.Label_RowCount = new System.Windows.Forms.Label();
            this.Text_Row = new System.Windows.Forms.TextBox();
            this.Text_Column = new System.Windows.Forms.TextBox();
            this.Label_ColumnsCount = new System.Windows.Forms.Label();
            this.Divide_Check = new System.Windows.Forms.CheckBox();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.Button_Random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Names
            // 
            this.Names.Dock = System.Windows.Forms.DockStyle.Top;
            this.Names.Location = new System.Drawing.Point(512, 0);
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(288, 281);
            this.Names.TabIndex = 1;
            // 
            // Label_RowCount
            // 
            this.Label_RowCount.AutoSize = true;
            this.Label_RowCount.Location = new System.Drawing.Point(518, 308);
            this.Label_RowCount.Name = "Label_RowCount";
            this.Label_RowCount.Size = new System.Drawing.Size(17, 12);
            this.Label_RowCount.TabIndex = 2;
            this.Label_RowCount.Text = "行";
            // 
            // Text_Row
            // 
            this.Text_Row.Location = new System.Drawing.Point(541, 298);
            this.Text_Row.Name = "Text_Row";
            this.Text_Row.Size = new System.Drawing.Size(43, 22);
            this.Text_Row.TabIndex = 3;
            // 
            // Text_Column
            // 
            this.Text_Column.Location = new System.Drawing.Point(631, 298);
            this.Text_Column.Name = "Text_Column";
            this.Text_Column.Size = new System.Drawing.Size(43, 22);
            this.Text_Column.TabIndex = 5;
            // 
            // Label_ColumnsCount
            // 
            this.Label_ColumnsCount.AutoSize = true;
            this.Label_ColumnsCount.Location = new System.Drawing.Point(599, 308);
            this.Label_ColumnsCount.Name = "Label_ColumnsCount";
            this.Label_ColumnsCount.Size = new System.Drawing.Size(17, 12);
            this.Label_ColumnsCount.TabIndex = 4;
            this.Label_ColumnsCount.Text = "列";
            // 
            // Divide_Check
            // 
            this.Divide_Check.AutoSize = true;
            this.Divide_Check.Location = new System.Drawing.Point(520, 342);
            this.Divide_Check.Name = "Divide_Check";
            this.Divide_Check.Size = new System.Drawing.Size(60, 16);
            this.Divide_Check.TabIndex = 6;
            this.Divide_Check.Text = "梅花陣";
            this.Divide_Check.UseVisualStyleBackColor = true;
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(693, 296);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate.TabIndex = 7;
            this.Button_Generate.Text = "產生座位";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Location = new System.Drawing.Point(693, 335);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(75, 23);
            this.Button_Random.TabIndex = 8;
            this.Button_Random.Text = "隨機排座";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Random);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.Divide_Check);
            this.Controls.Add(this.Text_Column);
            this.Controls.Add(this.Label_ColumnsCount);
            this.Controls.Add(this.Text_Row);
            this.Controls.Add(this.Label_RowCount);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Label Label_RowCount;
        private System.Windows.Forms.TextBox Text_Row;
        private System.Windows.Forms.TextBox Text_Column;
        private System.Windows.Forms.Label Label_ColumnsCount;
        private System.Windows.Forms.CheckBox Divide_Check;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.Button Button_Random;
    }
}

