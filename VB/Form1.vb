Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private j As Integer = 0
				Private Function CreateTable(ByVal text As String, ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.TableName = text
			For i As Integer = 0 To RowCount - 1
				j += 1
				tbl.Rows.Add(New Object() { String.Format("{0}({1})", i, text), j, 3 - i })
			Next i
			Return tbl
				End Function


		Public Sub New()
			InitializeComponent()
			Dim table1 As DataTable = CreateTable("Table1", 20)
			Dim table2 As DataTable = CreateTable("Table2", 20)
			Dim table3 As DataTable = CreateTable("Table3", 20)
			dataGridView1.DataSource = table1
			dataGridView2.DataSource = table2
			dataGridView3.DataSource = table3
			gridControl1.DataSource = table1

			gridView1.OptionsView.ColumnAutoWidth = False
			AddTable(table2)
			AddTable(table3)
			AddHandler gridView1.CustomUnboundColumnData, AddressOf gridView1_CustomUnboundColumnData
		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
			Dim column As DataColumn = TryCast(e.Column.Tag, DataColumn)
			If e.IsGetData Then
				e.Value = column.Table.Rows(e.ListSourceRowIndex)(column)
			End If
			If e.IsSetData Then
				column.Table.Rows(e.ListSourceRowIndex)(column) = e.Value
			End If
		End Sub
		Private Sub AddTable(ByVal table As DataTable)
			CreateColumns(table)
		End Sub

		Private Sub CreateColumns(ByVal table As DataTable)
			For Each col As DataColumn In table.Columns
				AddUnboundColumn(table.TableName + col.ColumnName, col)
			Next col
		End Sub

		Private Sub AddUnboundColumn(ByVal fieldName As String, ByVal tag As DataColumn)
			Dim col As GridColumn = gridView1.Columns.AddVisible(fieldName)
			col.UnboundType = DevExpress.Data.UnboundColumnType.Object
			col.Tag = tag
		End Sub
	End Class
End Namespace