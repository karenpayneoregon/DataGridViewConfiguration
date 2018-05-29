Imports System.Windows.Forms

Public Class DataGridViewConfiguration
    Inherits BaseExceptionsHandler

    Public Property XmlFileName As String
    Public Property DataGridView() As DataGridView
    Public Table As New DataTable
    Public FilledFromXml As Boolean
    Private _dataSetRootName As String = "DataGridViewConfigurations"
    Private _ds As New DataSet With {.DataSetName = _dataSetRootName}
    Public Sub New()

    End Sub
    Public Sub New(pDataGridView As DataGridView, pFileName As String)
        DataGridView = pDataGridView
        XmlFileName = pFileName
        FilledFromXml = False
    End Sub
    ''' <summary>
    ''' Read columns from the xml file when initially loading a DataGridView
    ''' </summary>
    Public Sub InitialRead()

        Try
            If IO.File.Exists(XmlFileName) Then

                For Each col In DataGridView.Columns.Cast(Of DataGridViewColumn)().ToList
                    col.Visible = False
                Next

                Dim ds As New DataSet
                ds.ReadXml(XmlFileName)

                Dim temp = ds.Tables(DataGridView.Name)

                For rowIndex As Integer = 0 To temp.Rows.Count - 1
                    DataGridView.Columns(CStr(temp.Rows(rowIndex).Item("ColumnName"))).Visible =
                        CBool(temp.Rows(rowIndex).Item("Visible"))
                    DataGridView.Columns(CStr(temp.Rows(rowIndex).Item("ColumnName"))).DisplayIndex =
                        CInt(temp.Rows(rowIndex).Item("DisplayIndex"))
                Next

            End If
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

    End Sub
    ''' <summary>
    ''' Read in xml file to populate the DataGridView in DisplayColumns form
    ''' </summary>
    ''' <returns></returns>
    Public Function ConfigurationRead() As Boolean

        mHasException = False

        Try
            Table.TableName = DataGridView.Name
            Table.Columns.AddRange(New DataColumn() _
                {
                    New DataColumn("Visible", GetType(Boolean)),
                    New DataColumn("ColumnName", GetType(String)),
                    New DataColumn() With {.ColumnName = "DisplayIndex", .DataType = GetType(Integer)}
                })

            If IO.File.Exists(XmlFileName) Then

                FilledFromXml = True
                _ds.ReadXml(XmlFileName)

                Dim tempTable = _ds.Tables(DataGridView.Name)

                For rowIndex As Integer = 0 To tempTable.Rows.Count - 1
                    '
                    ' Since a xsd file is not used each value must be type cast
                    '
                    Table.Rows.Add(
                    CBool(tempTable.Rows(rowIndex).Item(0)),
                    tempTable.Rows(rowIndex).Item(1),
                    CInt(tempTable.Rows(rowIndex).Item(2)))
                Next
            Else
                If Not FilledFromXml Then
                    For Each col As DataGridViewColumn In DataGridView.Columns
                        Table.Rows.Add(New Object() {col.Visible, col.Name})
                    Next
                End If
            End If
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return IsSuccessFul

    End Function
    ''' <summary>
    ''' Responsible for saving changes made in DisplayColumns form
    ''' Apply button
    ''' </summary>
    ''' <param name="gridView"></param>
    ''' <returns></returns>
    Public Function Save(ByRef gridView As DataGridView) As Boolean
        mHasException = False

        Try
            For rowIndex As Integer = 0 To Table.Rows.Count - 1

                Dim row = Table.Rows(rowIndex)

                row.SetField(Of Integer)("DisplayIndex", rowIndex)

                gridView.Columns(row.Field(Of String)("ColumnName")).Visible =
                    row.Field(Of Boolean)("Visible")

                If gridView.Columns(row.Field(Of String)("ColumnName")).Visible Then
                    gridView.Columns(row.Field(Of String)("ColumnName")).DisplayIndex =
                        row.Field(Of Integer)("DisplayIndex")
                End If

            Next

            Dim ds As New DataSet With {.DataSetName = _dataSetRootName}
            ds.Tables.Add(Table.Copy())
            ds.WriteXml(XmlFileName)

        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return IsSuccessFul

    End Function

End Class
