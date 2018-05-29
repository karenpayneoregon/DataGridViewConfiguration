Imports System.Text
Imports TeamLibrary

Public Class frmDisplayColumns

    Private _bsColumns As New BindingSource
    Private _gridView As DataGridView
    Private _dOperations As New DataGridViewConfiguration

    ''' <summary>
    ''' Read in column properties if configuration file exists.
    ''' </summary>
    ''' <param name="dgv">DataGridView to configure</param>
    Public Sub New(ByRef dgv As DataGridView, pFileName As String)

        InitializeComponent()

        _gridView = dgv

        Text = String.Concat("Columns for ", _gridView.Parent.Name, ".", _gridView.Name)
        _dOperations = New DataGridViewConfiguration(dgv, pFileName)

        _dOperations.ConfigurationRead()

    End Sub
    ''' <summary>
    ''' Setup DataGridView with current settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DisplayColumns_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        _bsColumns.DataSource = _dOperations.Table

        DataGridView1.DataSource = _bsColumns

        DataGridView1.Columns("Visible").HeaderText = "Visible"
        DataGridView1.Columns("ColumnName").HeaderText = "Column name"
        DataGridView1.Columns("ColumnName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns("ColumnName").ReadOnly = True
        DataGridView1.Columns("DisplayIndex").Visible = False

    End Sub
    ''' <summary>
    ''' Apply settings to DataGridView which was passed in
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmdApply.Click
        _dOperations.Save(_gridView)
    End Sub
    ''' <summary>
    ''' Set all columns visible = true
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSetAllVisible_Click(sender As Object, e As EventArgs) Handles cmdSetAllVisible.Click
        Dim dt As DataTable = CType(_bsColumns.DataSource, DataTable)
        For rowIndex As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(rowIndex).SetField(Of Boolean)("Visible", True)
        Next
    End Sub
    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        DataGridView1.MoveRowUp(_bsColumns)
    End Sub
    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        DataGridView1.MoveRowDown(_bsColumns)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class