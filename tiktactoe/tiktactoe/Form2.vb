Public Class Form2
    Public player1 As Char
    Public player2 As Char

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player1 = plyr1.Text
        player2 = plyr2.Text
        If player1 = player2 Then
            MessageBox.Show("Two players cant be same!")
        ElseIf (player1 <> "X" And player1 <> "O") Then
            MessageBox.Show("Please Choose the correct option for player 1!")
        ElseIf (player2 <> "X" And player2 <> "O") Then
            MessageBox.Show("Please Choose the correct option for player 2!")
        Else
            Me.Close()
        End If
    End Sub
End Class