Module ExplicitConversionLongToString1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Long
        Dim value2 As String
        Dim const2 As String

        value1 = 70L
        value2 = CStr(value1)
        const2 = CStr(70L)

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionLongToString1")
            Return 1
        End If
    End Function
End Module
