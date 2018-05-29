Namespace My
    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class _Dialogs
        ''' <summary>
        ''' Ask question with NO as the default button
        ''' </summary>
        ''' <param name="pText"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Question(pText As String) As Boolean
            Return (MessageBox.Show(pText, Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function Question(pText As String, pTitle As String) As Boolean
            Return (MessageBox.Show(pText, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function Question(pText As String, pTitle As String, pDefaultButton As MsgBoxResult) As Boolean
            Dim db As MessageBoxDefaultButton
            If pDefaultButton = MsgBoxResult.No Then
                db = MessageBoxDefaultButton.Button2
            End If
            Return (MessageBox.Show(pText, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, db) = MsgBoxResult.Yes)
        End Function
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(Text As String)
            MessageBox.Show(Text, Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub ExceptionDialog(pText As String, pTitle As String, ex As Exception)
            Dim message As String = String.Concat(pText, Environment.NewLine, ex.Message)
            MessageBox.Show(message, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        Public Sub ExceptionDialog(ex As Exception, pText As String, pTitle As String)
            MessageBox.Show($"{pText}{Environment.NewLine}{ex.Message}", pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class

    <HideModuleName()>
    Friend Module KarensDialogs
        Private instance As New ThreadSafeObjectProvider(Of _Dialogs)
        ReadOnly Property Dialogs() As _Dialogs
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace
