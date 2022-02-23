Module DatosGlobales
    Public Structure RegCliente
        Dim codigo As Integer
        Dim nombre As String
        Dim limite As Decimal
        Dim deuda As Decimal
    End Structure

    Public clientes(9) As RegCliente
    Public IND As Integer = 0

End Module
