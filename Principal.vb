Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
Public Class Principal

    Public Shared filtro = "LIKE '{0}%'"

    Public Shared sql(8) As String
    Public Shared Busca As New TBusca
    Public cod_historico As Integer
    Public nome_historico As String
    Public Shared fabricante As String = "WROSISTEMAS"
    Public Shared caminhobanco As String
    Public Shared caminhoapp As String
    Public Shared caminhoreport As String
    Public Shared cn As New OleDbConnection
    Public Shared cn2 As New OleDbConnection
    Public Shared Arquivo As String
    Public Shared CriterioBusca As String
    Public Control As Short
    Public db As String
    Public db2 As String
    Public controle As String
    Public consultando As Boolean
    Public Shared col_ini_busca As Integer
    Public Shared XLogonUser As TLogonUser
    Public Shared LotesX As String
    Public Shared ServicoX As Boolean

    Public Shared Function GetConnection() As OleDbConnection
        'Obtem a string de conexão

        Dim caminhoBD As String = Application.StartupPath


        If caminhoBD.IndexOf("\bin\Debug") Then

            caminhoBD = caminhoBD.Replace("\bin\Debug", "")

        ElseIf caminhoBD.IndexOf("\bin\Release") Then

            caminhoBD = caminhoBD.Replace("\bin\Release", "")

        End If


        caminhoBD = caminhoBD & "\Dados\db.mdb"

        caminhobanco = My.Settings("caminho")
        caminhoapp = My.Settings("caminhosomente")
        caminhoreport = My.Settings("caminhoreports")

        Dim strConexao As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & caminhobanco & ";Mode=ReadWrite;Persist Security Info=False;User ID=Admin;jet oledb:database password=321654;"

        'Retorna uma conexão.

        Return New OleDbConnection(strConexao)

    End Function
    Private Function GetPrivateProfileString(ByVal Section As String, ByVal Key As String, ByVal p3 As String, ByVal Ret As String, ByVal p5 As Integer, ByVal FileName As String) As Object
        Throw New NotImplementedException
    End Function

    Private Sub WritePrivateProfileString(ByVal Section As String, ByVal Key As String, ByVal Text As String, ByVal FileName As String)
        Throw New NotImplementedException
    End Sub

    Public Shared Function CheckCNPJ(ByVal CNPJ As String) As Boolean
        Dim i As Object
        Dim NCNPJ As String
        NCNPJ = ""
        For i = 1 To Len(CNPJ)
            If Right(Left(CNPJ, i), 1) <> "." And Right(Left(CNPJ, i), 1) <> "-" And Right(Left(CNPJ, i), 1) <> "/" Then
                NCNPJ = NCNPJ & Right(Left(CNPJ, i), 1)
            End If
        Next
        CNPJ = NCNPJ
        Dim VAR4, VAR2, VAR1, VAR3, VAR5 As Object
        If Len(CNPJ) = 8 And Val(CNPJ) > 0 Then
            VAR1 = 0
            VAR2 = 0
            VAR4 = 0
            For VAR3 = 1 To 7
                VAR1 = Val(Mid(CNPJ, VAR3, 1))
                If (VAR1 Mod 2) <> 0 Then
                    VAR1 = VAR1 * 2
                End If
                If VAR1 > 9 Then
                    VAR2 = VAR2 + Int(VAR1 / 10) + (VAR1 Mod 10)
                Else
                    VAR2 = VAR2 + VAR1
                End If
            Next VAR3
            VAR4 = IIf((VAR2 Mod 10) <> 0, 10 - (VAR2 Mod 10), 0)
            If VAR4 = Val(Mid(CNPJ, 8, 1)) Then
                CheckCNPJ = True
            Else
                CheckCNPJ = False
            End If
        Else
            If Len(CNPJ) = 14 And Val(CNPJ) > 0 Then
                VAR1 = 0
                VAR3 = 0
                VAR4 = 0
                VAR5 = 0
                VAR2 = 5
                For VAR3 = 1 To 12
                    VAR1 = VAR1 + (Val(Mid(CNPJ, VAR3, 1)) * VAR2)
                    VAR2 = IIf(VAR2 > 2, VAR2 - 1, 9)
                Next VAR3
                VAR1 = VAR1 Mod 11
                VAR4 = IIf(VAR1 > 1, 11 - VAR1, 0)
                VAR1 = 0
                VAR3 = 0
                VAR2 = 6
                For VAR3 = 1 To 13
                    VAR1 = VAR1 + (Val(Mid(CNPJ, VAR3, 1)) * VAR2)
                    VAR2 = IIf(VAR2 > 2, VAR2 - 1, 9)
                Next VAR3
                VAR1 = VAR1 Mod 11
                VAR5 = IIf(VAR1 > 1, 11 - VAR1, 0)
                If (VAR4 = Val(Mid(CNPJ, 13, 1)) And VAR5 = Val(Mid(CNPJ, 14, 1))) Then
                    CheckCNPJ = True
                Else
                    CheckCNPJ = False
                End If
            Else
                CheckCNPJ = True
            End If
        End If
    End Function
    Public Shared Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
    Public Shared Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String
        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                Return
        End Select
        'Get the Typed Text and Find it in the list
        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)
        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then
            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)
            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = cbo.GetItemText(oFoundItem)
            'Append then found text to the typed text to preserve case
            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText
            'Select the Appended Text
            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length
        End If
    End Sub
    Public Shared Sub AutoCompleteCombo_Leave(ByVal cbo As ComboBox) ' NAO ESTA SENDO USADO
        Dim iFoundIndex As Integer
        iFoundIndex = cbo.FindStringExact(cbo.Text)
        cbo.SelectedIndex = iFoundIndex
    End Sub
End Class
