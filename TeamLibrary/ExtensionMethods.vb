Imports System.Windows.Forms

Public Module ExtensionMethods
    <Runtime.CompilerServices.Extension()>
    Public Sub ExpandColumns(sender As DataGridView)
        For Each col As DataGridViewColumn In sender.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub
    ''' <summary>
    ''' Move the current row up (left)
    ''' </summary>
    ''' <param name="sender">Target DataGridView</param>
    ''' <param name="bs">BindingSource for the DataGridView</param>
    ''' <remarks>
    ''' Sorting must be turned off, otherwise when moving
    ''' rows the sorting will kick in and things will not be
    ''' in the proper position
    ''' </remarks>
    <Runtime.CompilerServices.Extension()>
    Public Sub MoveRowUp(sender As DataGridView, bs As BindingSource)

        If Not String.IsNullOrWhiteSpace(bs.Sort) Then
            bs.Sort = ""
        End If

        Dim currentColumnIndex As Integer = sender.CurrentCell.ColumnIndex
        Dim newIndex = CInt(IIf(bs.Position = 0, 0, bs.Position - 1))
        Dim dt = CType(bs.DataSource, DataTable)
        Dim rowToMove As DataRow = DirectCast(bs.Current, DataRowView).Row
        Dim newRow As DataRow = dt.NewRow

        newRow.ItemArray = rowToMove.ItemArray
        dt.Rows.RemoveAt(bs.Position)
        dt.Rows.InsertAt(newRow, newIndex)
        dt.AcceptChanges()
        bs.Position = newIndex

        sender.CurrentCell = sender(currentColumnIndex, newIndex)

    End Sub
    ''' <summary>
    ''' Move the current row down (right)
    ''' </summary>
    ''' <param name="sender">Target DataGridView</param>
    ''' <param name="bs">BindingSource for the DataGridView</param>
    ''' <remarks>
    ''' Sorting must be turned off, otherwise when moving
    ''' rows the sorting will kick in and things will not be
    ''' in the proper position
    ''' </remarks>
    <Runtime.CompilerServices.Extension()>
    Public Sub MoveRowDown(sender As DataGridView, bs As BindingSource)

        If Not String.IsNullOrWhiteSpace(bs.Sort) Then
            bs.Sort = ""
        End If

        Dim currentColumnIndex As Integer = sender.CurrentCell.ColumnIndex
        Dim upperLimit As Integer = bs.Count - 1
        Dim newIndex As Integer = CInt(IIf(bs.Position + 1 >= upperLimit, upperLimit, bs.Position + 1))
        Dim dt = CType(bs.DataSource, DataTable)
        Dim rowToMove As DataRow = DirectCast(bs.Current, DataRowView).Row
        Dim newRow As DataRow = dt.NewRow

        newRow.ItemArray = rowToMove.ItemArray
        dt.Rows.RemoveAt(bs.Position)
        dt.Rows.InsertAt(newRow, newIndex)
        dt.AcceptChanges()
        bs.Position = newIndex

        sender.CurrentCell = sender(currentColumnIndex, newIndex)

    End Sub
End Module
