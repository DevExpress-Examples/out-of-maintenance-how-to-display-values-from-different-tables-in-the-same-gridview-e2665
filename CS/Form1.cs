using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        int j = 0;
                private DataTable CreateTable(string text, int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.TableName = text;
            for (int i = 0; i < RowCount; i++)
            {
                j++;
                tbl.Rows.Add(new object[] { String.Format("{0}({1})", i, text), j, 3 - i });
            }
            return tbl;
        }


        public Form1()
        {
            InitializeComponent();
            DataTable table1 = CreateTable("Table1", 20);
            DataTable table2 = CreateTable("Table2", 20);
            DataTable table3 = CreateTable("Table3", 20);
            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2;
            dataGridView3.DataSource = table3;
            gridControl1.DataSource = table1;

            gridView1.OptionsView.ColumnAutoWidth = false;
            AddTable(table2);
            AddTable(table3);
            gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gridView1_CustomUnboundColumnData);
        }

        void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DataColumn column = e.Column.Tag as DataColumn;
            if (e.IsGetData)
                e.Value = column.Table.Rows[e.ListSourceRowIndex][column];
            if (e.IsSetData)
                column.Table.Rows[e.ListSourceRowIndex][column] = e.Value;
        }
        private void AddTable(DataTable table)
        {
            CreateColumns(table);
        }

        private void CreateColumns(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                AddUnboundColumn(table.TableName + col.ColumnName, col);
            }
        }

        private void AddUnboundColumn(string fieldName, DataColumn tag)
        {
            GridColumn col = gridView1.Columns.AddVisible(fieldName);
            col.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            col.Tag = tag;
        }
    }
}