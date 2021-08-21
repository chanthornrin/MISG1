Imports System.Data.SqlClient

Public Class Category

    ' Insert data to dataGridview
    Sub Loadcategory()
        Dim i As Integer = 0
        DGVCategory.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from category", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DGVCategory.Rows.Add(i, Dr.Item("id").ToString, Dr.Item("name").ToString, Dr.Item("description").ToString, Dr.Item("date").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub
    'Clear 
    Sub Clear()
        txtcatname.Focus()
        txtcatname.Clear()
        txtdescrition.Clear()
        txtid.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("insert into category (name,description,date) values('" & txtcatname.Text & "','" & txtdescrition.Text & "','" & DateTimePicker1.Text & "')", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully saved,", vbInformation)

                ' code call from formLoad
                Loadcategory()
                Clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DGVCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCategory.CellContentClick
        ' clcik datagridview 

        Dim colName As String = DGVCategory.Columns(e.ColumnIndex).Name
        If colName = "Column7" Then

            txtid.Text = DGVCategory(1, e.RowIndex).Value.ToString()
            txtcatname.Text = DGVCategory(2, e.RowIndex).Value.ToString()
            txtdescrition.Text = DGVCategory(3, e.RowIndex).Value.ToString()
            DateTimePicker1.Text = DGVCategory(4, e.RowIndex).Value.ToString()

        ElseIf colName = "Column5" Then
            If (MsgBox("Are you sure want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("delete from category where id like '" & txtid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)

                Loadcategory()
                Clear()
            End If

        End If
    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcategory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("update category set name ='" & txtcatname.Text & "',description ='" & txtdescrition.Text & "',date ='" & DateTimePicker1.Text & "' where id like '" & txtid.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully updated,", vbInformation)
                Loadcategory()
                Clear()

            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class