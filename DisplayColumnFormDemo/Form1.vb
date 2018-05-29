Imports System.ComponentModel
Imports TeamLibrary

Public Class Form1
    Private _dOperations As DataGridViewConfiguration
    Private _fileName As String = ""

    Private _bsCustomers As New BindingSource
    ''' <summary>
    ''' If configuration file exists, apply settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _fileName = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DataGridView1.Name & ".xml")

        Dim ops As New DataOperations
        _bsCustomers.DataSource = ops.CustomerView
        DataGridView1.DataSource = _bsCustomers

        _dOperations = New DataGridViewConfiguration(DataGridView1, _fileName)
        _dOperations.InitialRead()

        If Not _dOperations.IsSuccessFul Then
            MessageBox.Show(_dOperations.LastExceptionMessage)
        End If

    End Sub
    Private Sub cmdShowHide_Click(sender As Object, e As EventArgs) Handles cmdShowHide.Click

        Dim f As New frmDisplayColumns(DataGridView1, _fileName)
        Try
            f.ShowDialog()
        Finally
            f.Dispose()
        End Try

    End Sub
    Private Sub cmdExpandColumns_Click(sender As Object, e As EventArgs) Handles cmdExpandColumns.Click
        DataGridView1.ExpandColumns()
    End Sub
    Private Sub cmdFreezeCurrentColumn_Click(sender As Object, e As EventArgs) Handles cmdFreezeCurrentColumn.Click

        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).Frozen = False
        Next

        DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Frozen = True

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip1.Opening

        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Frozen Then
            FrozenToolStripMenuItem.Text = "Unfreeze"
        Else
            FrozenToolStripMenuItem.Text = "Freeze"
        End If

    End Sub
    ''' <summary>
    ''' https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-freeze-columns-in-the-windows-forms-datagridview-control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrozenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrozenToolStripMenuItem.Click

        If FrozenToolStripMenuItem.Text = "Freeze" Then

            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                DataGridView1.Columns(i).Frozen = False
            Next

            DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Frozen = True

        Else
            DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Frozen = False
        End If

    End Sub
End Class
