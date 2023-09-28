Public Class geometryClassForm
    Dim varLength, varWidth, varHeight, varSide, perimeter, area, volume As Double
    Dim intCheckValRectPerArea, intCheckValRectVol, intCheckValSq As Boolean
    Dim first As String = studentForm.txtFirst.Text
    Dim mid As String = studentForm.txtMid.Text
    Dim last As String = studentForm.txtLast.Text
    Dim fullName As String = first.ToUpper + " " + mid.ToUpper + " " + last.ToLower
    Dim message As String
    Private Sub btnPerimeterRect_Click(sender As Object, e As EventArgs) Handles btnPerimeterRect.Click
        intCheck()

        If intCheckValRectPerArea = True Then
            varLength = txtLength.Text
            varWidth = txtWidth.Text

            perimeter = 2 * (varLength + varWidth)
            message = "Thank you " + fullName + " for using the app. The perimeter of the rectangle is " + Str(perimeter) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValRectPerArea = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVolumeRect_Click(sender As Object, e As EventArgs) Handles btnVolumeRect.Click
        intCheck()

        If intCheckValRectVol = True Then
            varLength = txtLength.Text
            varWidth = txtWidth.Text
            varHeight = txtHeight.Text

            volume = (varLength * varHeight * varWidth)
            message = "Thank you " + fullName + " for using the app. The volume of the rectangle is " + Str(volume) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValRectVol = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAreaRect_Click(sender As Object, e As EventArgs) Handles btnAreaRect.Click
        intCheck()

        If intCheckValRectPerArea = True Then
            varLength = txtLength.Text
            varWidth = txtWidth.Text

            area = (varLength * varWidth)
            message = "Thank you " + fullName + " for using the app. The area of the rectangle is " + Str(area) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValRectPerArea = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLength.Text = ""
        txtWidth.Text = ""
        txtHeight.Text = ""
        txtSide.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub intCheck()
        intCheckValRectPerArea = IsNumeric(txtLength.Text) And IsNumeric(txtWidth.Text)
        intCheckValRectVol = IsNumeric(txtLength.Text) And IsNumeric(txtWidth.Text) And IsNumeric(txtHeight.Text)
        intCheckValSq = IsNumeric(txtSide.Text)
    End Sub

    Private Sub btnPerimeterSq_Click(sender As Object, e As EventArgs) Handles btnPerimeterSq.Click
        intCheck()

        If intCheckValSq = True Then
            varSide = txtSide.Text

            perimeter = (4 * varSide)
            message = "Thank you " + fullName + " for using the app. The perimeter of the square is " + Str(perimeter) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValSq = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAreaSq_Click(sender As Object, e As EventArgs) Handles btnAreaSq.Click
        intCheck()

        If intCheckValSq = True Then
            varSide = txtSide.Text

            area = (varSide ^ 2)
            message = "Thank you " + fullName + " for using the app. The area of the square is " + Str(area) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValSq = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVolumeSq_Click(sender As Object, e As EventArgs) Handles btnVolumeSq.Click
        intCheck()

        If intCheckValSq = True Then
            varSide = txtSide.Text

            volume = (varSide ^ 3)
            message = "Thank you " + fullName + " for using the app. The volume of the square is " + Str(volume) + "."

            MsgBox(message, MsgBoxStyle.OkOnly, "Geometry Calculator Message")
        ElseIf intCheckValSq = False Then
            MessageBox.Show("Please input valid numbers.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub
End Class