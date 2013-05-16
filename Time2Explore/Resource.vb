Public Class Resources
    Public Shared amount As Integer = 0

    Public Shared Function getAmount()
        Return amount
    End Function

    Public Shared Sub ChangeAmount(ByVal num)
        Dim change As Integer = amount + num
    End Sub

End Class