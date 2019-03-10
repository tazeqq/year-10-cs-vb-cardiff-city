Public Class Register

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If combotitle.Text = "Please select..." Then
            MsgBox("Select title")
            Exit Sub
        ElseIf txtfirstname.Text = "" Then
            MsgBox("Please fill out first name")
            Exit Sub
        ElseIf txtlastname.Text = "" Then
            MsgBox("Please fill out last name")
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Please fill out email address")
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MsgBox("Please fill out address")
            Exit Sub
        ElseIf txtpostcode.Text = "" Then
            MsgBox("Please fill out postcode")
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please enter password")
            Exit Sub
        ElseIf txtconfirm.Text = "" Then
            MsgBox("Please confirm password")
            Exit Sub
        ElseIf txtconfirm.Text <> txtpassword.Text Then
            MsgBox("Passwords do not match")
            Exit Sub
        Else
            My.Computer.FileSystem.WriteAllText(
                "C:\temp\temp.txt",
                combotitle.Text & vbCrLf & txtfirstname.Text & vbCrLf & txtlastname.Text & vbCrLf & txtaddress.Text & vbCrLf & txtpostcode.Text & vbCrLf & txtpassword.Text & vbCrLf & txtconfirm.Text & vbCrLf,
                True
            )
            MsgBox("Success! You are now registered.")
        End If
    End Sub

    Private Sub lblregister_Click(sender As Object, e As EventArgs) Handles lblregister.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotitle.SelectedIndexChanged

    End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtfirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged

    End Sub
End Class
