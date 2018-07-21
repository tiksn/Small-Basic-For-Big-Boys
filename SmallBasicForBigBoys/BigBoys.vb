
Imports System.Numerics
Imports Microsoft.SmallBasic.Library

<SmallBasicType()>
Public Module BigBoys
    Public Function GetRandomBigInteger(ByVal Length As Integer) As BigInteger
        Dim Result As BigInteger = BigInteger.Zero
        Dim RNG As New Random

        For index = 1 To Length
            Dim NextDigit = RNG.Next(10)
            Result *= 10
            Result += NextDigit
        Next
    End Function
End Module
