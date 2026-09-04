Public Structure TBusca
    Dim Criterio() As TCriterio
    Dim NumCrite As Short 'numero da coluna q vai retornar o indice de busca
    Dim Ncolunas As Short 'numero de colunas na consulta
    Dim Numcampoinicial As Short 'numero da coluna q vai a aparecer primeiro para busca
    Dim Ordem As String
    Dim OrdemAD As String
End Structure

Public Structure TCriterio
    Dim Nome As String 'nome no cabeçalho
    Dim Campo As String 'nome do campo no banco de dados
    Dim Formato As String 'formato da coluna data, moeda
    Dim Numerico As Boolean 'somente numero
    Dim Data As Boolean 'somente data
    Dim LargCol As Short ' lagrura da coluna
    Dim Alinha As String ' alinhamento
End Structure
Public Structure TLogonUser
    Dim Cod As String
    Dim User As String
    Dim Pass As String
End Structure
