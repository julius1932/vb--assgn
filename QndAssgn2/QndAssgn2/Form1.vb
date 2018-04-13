Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database101DataSet.Items' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ItemsTableAdapter.Fill(Me.Database101DataSet.Items)
    End Sub
End Class
