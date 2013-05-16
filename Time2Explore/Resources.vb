Public Class Resources 'Resource name
    'The amount of resource there is
    Public amount As Decimal

    'Returns amount of resources is available
    Public Function GetAmount()
        Return amount
    End Function

    'Sets the amount of resource to specified value
    Public Sub SetAmount(ByVal num As Decimal)
        amount = num
    End Sub

    'Checks to see if an amount of resource is available
    Public Function HasAmount(ByVal num As Decimal)
        If amount >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'changes the amount of resource by positive or negative
    Public Sub ChangeAmount(ByVal num As Decimal)
        Dim change As Decimal = amount + num
        amount = change
    End Sub
End Class