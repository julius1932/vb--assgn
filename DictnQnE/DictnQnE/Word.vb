Public Class Word
    Private wrd As String
    Private meaning As String

    Public Sub New(wrd As String, meaning As String)
        Me.wrd = wrd
        Me.meaning = meaning
    End Sub

    Public Overrides Function toString() As String
        Return Me.wrd
    End Function
    Public Function getMeaning()
        Return Me.meaning
    End Function
    Public Function getWord()
        Return Me.wrd
    End Function
End Class
