Public Class Form1
    Public p1value As Char
    Public p2value As Char
    'Private p1value As Char
    'Private p2value As Char
    Private p1score As Integer
    Private p2score As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartNew()
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p1.Hide()
        p2.Hide()
        btnNxt.Enabled = False
        btnStop.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        p1score = 0
        p2score = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If p1.Visible = True Then
            Button1.Text = p1value
            Button1.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button1.Text = p2value
            Button1.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If p1.Visible = True Then
            Button2.Text = p1value
            Button2.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button2.Text = p2value
            Button2.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If p1.Visible = True Then
            Button3.Text = p1value
            Button3.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button3.Text = p2value
            Button3.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If p1.Visible = True Then
            Button4.Text = p1value
            Button4.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button4.Text = p2value
            Button4.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If p1.Visible = True Then
            Button5.Text = p1value
            Button5.Enabled = False
            p1.Hide()
            p2.Show()
        Else
            Button5.Text = p2value
            Button5.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If p1.Visible = True Then
            Button6.Text = p1value
            Button6.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button6.Text = p2value
            Button6.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If p1.Visible = True Then
            Button7.Text = p1value
            Button7.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button7.Text = p2value
            Button7.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If p1.Visible = True Then
            Button8.Text = p1value
            Button8.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button8.Text = p2value
            Button8.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If p1.Visible = True Then
            Button9.Text = p1value
            Button9.Enabled = False
            p1.Hide()
            p2.Show()
            CheckWinner()
        Else
            Button9.Text = p2value
            Button9.Enabled = False
            p2.Hide()
            p1.Show()
            CheckWinner()
        End If
    End Sub
    Public Function ResetNew()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        btnNxt.Enabled = True
        p1.Hide()
        p2.Hide()
    End Function
    Public Function StartNew()
incorrect: Form2.ShowDialog()
        p1value = Form2.player1
        p2value = Form2.player2
        'Dim result As DialogResult = MessageBox.Show("Do you want player 1's to be 'X'" & vbNewLine & "And player 2's to be 'O'", "Choose!",
        '                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If result = DialogResult.Yes Then
        '    p1value = "X"
        '    p2value = "O"
        'Else
        '    p1value = "O"
        '    p2value = "X"
        'End If
        MessageBox.Show("Best of luck!")
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        p1.Show()
    End Function
    Public Function CheckWinner()
        Dim mygraphics As Graphics = Me.CreateGraphics
        Dim mypen As Pen
        mypen = New Pen(Brushes.Red, 5)
        Dim pt11 As New Point(42, 65)
        Dim pt12 As New Point(174, 65)
        Dim pt21 As New Point(42, 131)
        Dim pt22 As New Point(174, 131)
        Dim pt31 As New Point(42, 197)
        Dim pt32 As New Point(174, 197)
        Dim pt51 As New Point(108, 65)
        Dim pt52 As New Point(108, 167)
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            MessageBox.Show("Its a Draw!" & vbNewLine & "Why dont you play again?", "Draw",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ResetNew()
            StartNew()
            ' First Line
        ElseIf Button1.Text = p1value And Button2.Text = p1value And Button3.Text = p1value Then
            mygraphics.DrawLine(mypen, pt11, pt12)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button1.Text = p2value And Button2.Text = p2value And Button3.Text = p2value Then
            mygraphics.DrawLine(mypen, pt11, pt12)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' Middle Line
        ElseIf Button4.Text = p1value And Button5.Text = p1value And Button6.Text = p1value Then
            mygraphics.DrawLine(mypen, pt21, pt22)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button4.Text = p2value And Button5.Text = p2value And Button6.Text = p2value Then
            mygraphics.DrawLine(mypen, pt21, pt22)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' Last Line
        ElseIf Button7.Text = p1value And Button8.Text = p1value And Button9.Text = p1value Then
            mygraphics.DrawLine(mypen, pt31, pt32)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button7.Text = p2value And Button8.Text = p2value And Button9.Text = p2value Then
            mygraphics.DrawLine(mypen, pt31, pt32)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' \ line
        ElseIf Button1.Text = p1value And Button5.Text = p1value And Button9.Text = p1value Then
            mygraphics.DrawLine(mypen, pt11, pt32)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button1.Text = p2value And Button5.Text = p2value And Button9.Text = p2value Then
            mygraphics.DrawLine(mypen, pt11, pt32)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' / line
        ElseIf Button3.Text = p1value And Button5.Text = p1value And Button7.Text = p1value Then
            mygraphics.DrawLine(mypen, pt12, pt31)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button3.Text = p2value And Button5.Text = p2value And Button7.Text = p2value Then
            mygraphics.DrawLine(mypen, pt12, pt31)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' Down line 1
        ElseIf Button1.Text = p1value And Button4.Text = p1value And Button7.Text = p1value Then
            mygraphics.DrawLine(mypen, pt11, pt31)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button1.Text = p2value And Button4.Text = p2value And Button7.Text = p2value Then
            mygraphics.DrawLine(mypen, pt11, pt31)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' Down line 2
        ElseIf Button2.Text = p1value And Button5.Text = p1value And Button8.Text = p1value Then
            mygraphics.DrawLine(mypen, pt51, pt52)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button2.Text = p2value And Button5.Text = p2value And Button8.Text = p2value Then
            mygraphics.DrawLine(mypen, pt51, pt52)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
            ' Down line 3
        ElseIf Button3.Text = p1value And Button9.Text = p1value And Button6.Text = p1value Then
            mygraphics.DrawLine(mypen, pt12, pt32)
            MessageBox.Show("Player 1 wins!", "We have a winner!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p1score += 1
            p1scr.Text = p1score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        ElseIf Button3.Text = p2value And Button9.Text = p2value And Button6.Text = p2value Then
            mygraphics.DrawLine(mypen, pt12, pt32)
            MessageBox.Show("Player 2 wins!", "We have a winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            p2score += 1
            p2scr.Text = p2score
            mygraphics.Clear(DefaultBackColor)
            ResetNew()
        End If
    End Function

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If p1score = 0 AndAlso p2score = 0 Then
            MessageBox.Show("Why dont you play atleast one game??", "No winner!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If p1score > p2score Then
            MessageBox.Show("Player one wins!", "Winner",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1score = 0
            p2score = 0
            p1scr.Text = "0"
            p2scr.Text = "0"
            ResetNew()
        ElseIf p1score < p2score Then
            MessageBox.Show("Player two wins!", "Winner",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1score = 0
            p2score = 0
            p1scr.Text = "0"
            p2scr.Text = "0"
            ResetNew()
        Else
            MessageBox.Show("Its a draw!", "WOW",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            p1score = 0
            p2score = 0
            p1scr.Text = "0"
            p2scr.Text = "0"
        End If
    End Sub

    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        StartNew()
        btnNxt.Enabled = False
    End Sub

End Class
