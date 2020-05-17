

Public Class Form1
   
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Panel1.Visible = True And e.KeyCode = Keys.Escape Then
            Me.Focus()
            Panel1.Visible = False
        ElseIf Panel1.Visible = False And e.KeyCode = Keys.Escape Then
            Panel1.Visible = True
            Panel1.Focus()
        End If
    End Sub

    Private Sub Panel1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Panel1.PreviewKeyDown
        If login = False Then
        Else
            If Panel1.Visible = True And e.KeyCode = Keys.Escape Then
                Me.Focus()
                Panel1.Visible = False
            ElseIf Panel1.Visible = False And e.KeyCode = Keys.Escape Then
                Panel1.Visible = True
                Panel1.Focus()
            End If
        End If
    End Sub

    Private Sub fp1_Click(sender As Object, e As EventArgs) Handles fp1.Click
        If login = False Then
        Else
            Panel1.Visible = False
            Me.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login = True
    End Sub
End Class
