Imports System.Data.SqlClient

Public Class Supplier

    ' Insert data to dataGridview
    Sub LoadSupplier()
        Dim i As Integer = 0
        DGVSupplier.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from supplier", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DGVSupplier.Rows.Add(i, Dr.Item("supId").ToString, Dr.Item("companyName").ToString, Dr.Item("descriton").ToString, Dr.Item("phoneNumber").ToString, Dr.Item("email").ToString, Dr.Item("address").ToString, Dr.Item("dateCreate").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub
    ' Clear txtbox 
    Sub Clear()
        txtsupid.Clear()
        txtsupname.Clear()
        txtsupdescrition.Clear()
        txtsupphone.Clear()
        txtsupemail.Clear()
        txtsupaddress.Clear()



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("update supplier set companyName ='" & txtsupname.Text & "',descriton ='" & txtsupdescrition.Text & "',phoneNumber ='" & txtsupphone.Text & "',email ='" & txtsupemail.Text & "',address ='" & txtsupaddress.Text & "',dateCreate ='" & DateTimePickerSupplier.Text & "' where supId like '" & txtsupid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully updated,", vbInformation)
                LoadSupplier()
                Clear()
            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("insert into supplier (companyName,descriton,phoneNumber,email,address,dateCreate) values('" & txtsupname.Text & "','" & txtsupdescrition.Text & "','" & txtsupphone.Text & "','" & txtsupemail.Text & "','" & txtsupaddress.Text & "','" & DateTimePickerSupplier.Text & "')", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully saved,", vbInformation)

                ' code call from formLoad
                LoadSupplier()
                Clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplier()
    End Sub

    Private Sub DGVSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSupplier.CellContentClick
        Dim colName As String = DGVSupplier.Columns(e.ColumnIndex).Name
        If colName = "Column8" Then

            txtsupid.Text = DGVSupplier(1, e.RowIndex).Value.ToString()
            txtsupname.Text = DGVSupplier(2, e.RowIndex).Value.ToString()
            txtsupdescrition.Text = DGVSupplier(3, e.RowIndex).Value.ToString()
            txtsupphone.Text = DGVSupplier(4, e.RowIndex).Value.ToString()
            txtsupemail.Text = DGVSupplier(5, e.RowIndex).Value.ToString()
            txtsupaddress.Text = DGVSupplier(6, e.RowIndex).Value.ToString()
            DateTimePickerSupplier.Text = DGVSupplier(7, e.RowIndex).Value.ToString()

        ElseIf colName = "Column9" Then
            If (MsgBox("Are you sure want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("delete from supplier where supId like '" & txtsupid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)

                LoadSupplier()
                Clear()
            End If

        End If
    End Sub

End Class