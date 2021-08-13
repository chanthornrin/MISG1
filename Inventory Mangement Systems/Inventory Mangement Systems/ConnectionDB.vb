Imports System.Data.SqlClient
Module ConnectionDB

    Public Cn As New SqlConnection
    Public Cm As New SqlCommand
    Public Dr As SqlDataReader
    Public Da As SqlDataAdapter

    Sub ConnectionD()
        Cn = New SqlConnection
        With Cn
            .ConnectionString = "Data Source=DESKTOP-6G351T5;Initial Catalog=Inventory_Management_System;Integrated Security=True"
        End With
    End Sub
End Module
