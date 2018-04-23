Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.dataGridView2 = New System.Windows.Forms.DataGridView()
			Me.dataGridView3 = New System.Windows.Forms.DataGridView()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(821, 191)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "ID"
			Me.gridColumn2.FieldName = "ID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Number"
			Me.gridColumn3.FieldName = "Number"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Date"
			Me.gridColumn4.FieldName = "Date"
			Me.gridColumn4.Name = "gridColumn4"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left
			Me.dataGridView1.Location = New System.Drawing.Point(0, 191)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(211, 263)
			Me.dataGridView1.TabIndex = 1
			' 
			' dataGridView2
			' 
			Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView2.Location = New System.Drawing.Point(211, 191)
			Me.dataGridView2.Name = "dataGridView2"
			Me.dataGridView2.Size = New System.Drawing.Size(345, 263)
			Me.dataGridView2.TabIndex = 2
			' 
			' dataGridView3
			' 
			Me.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView3.Dock = System.Windows.Forms.DockStyle.Right
			Me.dataGridView3.Location = New System.Drawing.Point(556, 191)
			Me.dataGridView3.Name = "dataGridView3"
			Me.dataGridView3.Size = New System.Drawing.Size(265, 263)
			Me.dataGridView3.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(821, 454)
			Me.Controls.Add(Me.dataGridView2)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.dataGridView3)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private dataGridView2 As System.Windows.Forms.DataGridView
		Private dataGridView3 As System.Windows.Forms.DataGridView
	End Class
End Namespace

