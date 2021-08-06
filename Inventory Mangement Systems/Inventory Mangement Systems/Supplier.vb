Imports System.Data.SqlClient

Public Class Supplier
    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from Tbl_Supplier ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(2).ToString,
                                   Dr(3).ToString, Dr(4).ToString, Dr(5).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()


                Cm = New SqlCommand(" insert into Tbl_Supplier (Sup_ID, Sup_Name, Phone, Email, Address, Country) values('" & txtSubID.Text & "',
                                    '" & txtSubname.Text & "' , '" & txtsphone.Text & "','" & txtEmail.Text & "','" & txtsAddress.Text & "','" & txtcountry.Text & "')", Cn)
                Cm.ExecuteNonQuery()

                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)
                LoadRecord()
                'clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        loadrecord()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Cn.Open()
        Try
            Dim index As Integer
            index = e.RowIndex
            Dim seleted As DataGridViewRow
            seleted = DataGridView1.Rows(index)
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            txtSubID.Text = selectedRow.Cells(0).Value.ToString()
            txtSubname.Text = selectedRow.Cells(1).Value.ToString()
            txtsphone.Text = selectedRow.Cells(2).Value.ToString()
            txtEmail.Text = selectedRow.Cells(3).Value.ToString()
            txtsAddress.Text = selectedRow.Cells(4).Value.ToString()
            txtcountry.Text = selectedRow.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cn.Close()
    End Sub
End Class