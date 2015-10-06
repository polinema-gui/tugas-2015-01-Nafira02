Public Class Picture_Form1

    Private Sub Ubah_Button1_Click(sender As Object, e As EventArgs) Handles Ubah_Button.Click
        If Me.BackColor = Color.HotPink Then
            Me.BackColor = Color.Aqua
        Else
            Me.BackColor = Color.HotPink
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.HotPink
    End Sub
End Class
