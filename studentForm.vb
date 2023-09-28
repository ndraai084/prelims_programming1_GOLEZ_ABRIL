Imports System.DirectoryServices.ActiveDirectory
Imports System.Net
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class studentForm
    Dim first, middle, last, address, birthday, age, grade As String
    Dim capsState As Boolean = False
    Dim fontSize As Single

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        first = txtFirst.Text
        first = first.ToUpper()

        middle = txtMid.Text
        middle = middle.ToUpper()

        last = txtLast.Text
        last = last.ToLower()

        address = txtAddress.Text
        birthday = txtBirthday.Text
        age = txtAge.Text
        grade = txtGrade.Text

        rchtxtOutput.Text = "Name: " & first & " " & middle & " " & last & vbCrLf & "Age: " & age & vbCrLf & "Birthday: " & birthday & vbCrLf & "Grade Level: " & grade & vbCrLf & "Address: " & address

        If IsNumeric(txtFontSize.Text) = True Then
            fontSize = txtFontSize.Text
            rchtxtOutput.Font = New Font(rchtxtOutput.Font.FontFamily, fontSize)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirst.Text = ""
        txtMid.Text = ""
        txtLast.Text = ""
        txtAddress.Text = ""
        txtBirthday.Text = ""
        txtAge.Text = ""
        txtGrade.Text = ""
        rchtxtOutput.Text = ""
    End Sub

    Private Sub btnGeometry_Click(sender As Object, e As EventArgs) Handles btnGeometry.Click
        Me.Hide()
        geometryClassForm.Show()
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        btnGeometry.Enabled = True
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        btnGeometry.Enabled = False
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        grpStudentForm.Hide()
    End Sub

    Private Sub btnCasing_Click(sender As Object, e As EventArgs) Handles btnCasing.Click
        If capsState = False Then
            txtFirst.Text = txtFirst.Text.ToUpper
            txtMid.Text = txtMid.Text.ToUpper
            txtLast.Text = txtLast.Text.ToUpper
            txtAddress.Text = txtAddress.Text.ToUpper

            capsState = True
            btnCasing.Text = "Lowercase"
        ElseIf capsState = True Then
            txtFirst.Text = txtFirst.Text.ToLower
            txtMid.Text = txtMid.Text.ToLower
            txtLast.Text = txtLast.Text.ToLower
            txtAddress.Text = txtAddress.Text.ToLower

            capsState = False
            btnCasing.Text = "Uppercase"
        End If
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        rchtxtOutput.BackColor = Color.Red
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        rchtxtOutput.BackColor = Color.Blue
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        rchtxtOutput.BackColor = Color.Green
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        grpStudentForm.Show()
    End Sub
End Class
