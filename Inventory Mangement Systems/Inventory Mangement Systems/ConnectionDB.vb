Imports System.Data.SqlClient
Module ConnectionDB

    Public Cn As New SqlConnection
    Public Cm As New SqlCommand
    Public Dr As SqlDataReader
    Public Da As SqlDataAdapter

    Sub ConnectionD()
        Cn = New SqlConnection
        With Cn
            .ConnectionString = "Data Source=MSI;Initial Catalog=Inventory_Managemant_Systems;Integrated Security=True"
        End With
    End Sub
End Module
