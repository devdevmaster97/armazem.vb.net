Public Class CustomDataGridView'faz a tecla enter funcionar com o tab pulando de coluna a coluna
    Inherits DataGridView

    <System.Security.Permissions.UIPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, _
        Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)> _
    Protected Overrides Function ProcessDialogKey( _
        ByVal keyData As Keys) As Boolean

        ' Extract the key code from the key value. 
        Dim key As Keys = keyData And Keys.KeyCode

        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        If key = Keys.Enter Then
            Return Me.ProcessRightKey(Keys.Tab)
        End If
        Return MyBase.ProcessDialogKey(keyData)

    End Function

    <System.Security.Permissions.SecurityPermission( _
        System.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
        System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    Protected Overrides Function ProcessDataGridViewKey( _
        ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean

        ' Handle the ENTER key as if it were a RIGHT ARROW key. 
        If e.KeyCode = Keys.Enter Then
            Return Me.ProcessRightKey(Keys.Tab)
        End If
        Return MyBase.ProcessDataGridViewKey(e)

    End Function
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If (Me.Focused OrElse Me.EditMode) AndAlso keyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

