Public Class Form1
    Function fRoundUp(ByVal num As Single) As Integer

        If (num - Fix(num) <> 0) Then
            fRoundUp = Fix(num) + 1
        Else
            fRoundUp = num
        End If

    End Function
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalc.Click
        Dim qr As Integer
        Dim rcl As Integer


        qr = Double.Parse(2000 / TxtL.Text - 2) 'Quantity Required
        rcl = Double.Parse(TxtQ.Text) ' Recut Length

    
        LblNop.Text = fRoundUp(rcl / qr)

    End Sub
 
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TxtL.Text = ""
        TxtQ.Text = ""
        LblNop.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Kathryn was instrumental in the completion of this project")

    End Sub
    'Function fRoundDown(ByVal num As Single) As Integer

    '    fRoundDown = Fix(num)

    'End Function

    'Function fRoundUp(ByVal num As Single) As Integer

    '    If (num - Fix(num) <> 0) Then
    '        fRoundUp = Fix(num) + 1
    '    Else
    '        fRoundUp = num
    '    End If

    'End Function
End Class
