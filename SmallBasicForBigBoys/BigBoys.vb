
Imports System.Numerics
Imports Microsoft.SmallBasic.Library

<SmallBasicType()>
Public Module BigBoys

    Public Function GetRandomBigInteger(ByVal Length As Primitive) As Primitive
        Dim Result As BigInteger = BigInteger.Zero
        Dim RNG As New Random
        Dim L As Integer = Length

        For index = 1 To L
            Dim NextDigit = RNG.Next(10)
            Result *= 10
            Result += NextDigit
        Next

        Return Result.ToString()
    End Function

End Module
