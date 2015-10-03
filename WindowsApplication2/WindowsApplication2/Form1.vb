Public Class FormGanti

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
    End Sub

    Private Sub gantiButton_Click(sender As Object, e As EventArgs) Handles gantiButton.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
