Imports System.Data.SqlClient

Public Class DataOperations
    Inherits BaseSqlServerConnections

    Public Function CustomerView() As DataTable
        DefaultCatalog = "NorthWindDemo"

        mHasException = False
        Dim dt As New DataTable

        Dim selectStatement As String = "SELECT TOP 10 CustomerIdentifier,CompanyName,ContactName,ContactTitle,[Address], " &
                                        "City,PostalCode,Country,Phone,Fax " &
                                        "FROM dbo.Customers"
        Try
            Using cn = New SqlConnection(ConnectionString)
                Using cmd = New SqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.CommandText = selectStatement
                    cn.Open()
                    dt.Load(cmd.ExecuteReader)
                End Using
            End Using
        Catch ex As Exception
            mHasException = True
            mLastException = ex
        End Try

        Return dt

    End Function
End Class
