Public Class Form1
    Private words(50) As Word
    Private indx As Integer = 0
    Private Sub fillDic()

        words(indx) = New Word("last", " the first in all")
        indx += 1
        words(indx) = New Word("last", " the first in all")
        indx += 1
        words(indx) = New Word("last", " the first in all")
        indx += 1
        words(indx) = New Word("last", " the first in all")
        indx += 1


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDic()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        Dim srch = TextBox1.Text
        Try
            For Each wrd In words
                If IsNothing(wrd) Then
                    Continue For
                End If
                If srch = wrd.getWord Then
                    ListBox1.Items.Add(wrd)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        RichTextBox1.Text = ""
        Try
            Dim wrd As Word = ListBox1.SelectedItem
            RichTextBox1.Text = wrd.getMeaning
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim wrd As String = InputBox("enter new word and meaning seperated by : ")
            Dim wrds() As String = wrd.Split(":")
            words(indx) = New Word(wrds(0), wrds(1))
        Catch ex As Exception

        End Try
    End Sub
End Class
