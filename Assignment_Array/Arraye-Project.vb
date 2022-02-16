Public Class Form1
    'Declare an arrays with value 
    Dim Name_first() As String = {"jack", "marjy", "tom", "luke", "sam", "al", "joe", "miky", "lu"}
    Dim Name_last() As String = {"jones", "ety", "fan", "spence", "amin", "sid", "bud", "ant", "ben"}
    Dim Amount() As Double = {234.45, 8293.1, 943.25, 27381.0, 271.39, 7436.12, 2743.0, 1639.95, 2354.2}
    Private Sub Balancebtl_Click(sender As Object, e As EventArgs) Handles Balancebtl.Click
        'Declare variables to find the match
        Dim intCount As Integer = 0
        Dim blnFound As Boolean = False
        Dim intPosition As Integer = -1
        Dim Usertype As String
        Dim match As Double
        'Get the name from user
        Usertype = InputBox("Type the client first name")

        'Do the procces to find the match name in array
        Do While Not blnFound And intCount < Name_first.Length
            For intCount = 0 To Amount.Length - 1
                If Name_first(intCount) = Usertype Then
                    blnFound = True
                    intPosition = intCount
                    match = Amount(intCount)
                End If
            Next

            intCount += 1
        Loop
        'if found the match name inside the array show the massage
        If blnFound Then
            MessageBox.Show("The balance of the " & Usertype & " is: " & match)
        Else
            MessageBox.Show("your name have not balance") ' if not found show the message
        End If
    End Sub

    Private Sub BankAssetbtl_Click(sender As Object, e As EventArgs) Handles BankAssetbtl.Click
        'Declare the variables we need, for total 
        Dim total As Double = 0.0
        Dim intvalue As Integer
        'total the value in the amount 
        For Each intvalue In Amount
            total = total + intvalue

        Next
        MessageBox.Show("The total of all amount is: " & total)
    End Sub

    Private Sub BalanceUnderbtl_Click(sender As Object, e As EventArgs) Handles BalanceUnderbtl.Click
        'Declare variable for keep the min number and step the element
        Dim intcount As Integer
        Dim intmin As Double
        'check the elements of amount array to find the number under 500
        For intcount = 0 To (Amount.Length - 1)
            If Amount(intcount) < 500 Then
                intmin = Amount(intcount)
                MessageBox.Show("First name: " & Name_first(intcount) & " Last Name: " & Name_last(intcount) & " Amount: " & intmin)
            End If


        Next
    End Sub
End Class
