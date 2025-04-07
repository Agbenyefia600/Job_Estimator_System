Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim password As String

        Dim username As String = "admin"
        password = "12345"

        Try
            If txtUsername.Text = username And txtPassword.Text = password Then
                Form1.Show()
                Me.Hide()

            ElseIf (txtUsername.Text = "" And txtPassword.Text = "") Then
                Form1.Hide()
                MessageBox.Show("Enter Username and Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else

                txtUsername.Clear()
                txtPassword.Clear()
                MessageBox.Show("Invaild Username or Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class