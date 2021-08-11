Imports System.Data.SqlClient

Public Class Product
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub loandCategory()
        cbcategory.Items.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from Category", Cn)
        Dr = Cm.ExecuteReader
        While (Dr.Read)
            cbcategory.Items.Add(Dr("Cat_Name").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub


    Sub clear()
        txtProId.Text = ""
        txtname.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtSalePrice.Text = ""
        cbcategory.Text = ""
    End Sub

    Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from Tbl_Product ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DataGridView1.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(2).ToString,
                                   Dr(3).ToString, Dr(4).ToString, Dr(5).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub

    Sub getCategoryId()
        Cn.Open()
        Cm = New SqlCommand("Select * from Category", Cn)
        Dr = Cm.ExecuteReader

        Dr.Close()
        Cn.Close()

    End Sub

    Sub addProductToStock(productId As String, productName As String, qty As Int16)
        Cn.Open()
        Cm = New SqlCommand("insert into tblStock(product_id,product_name,new_qty,total_stock,created_date)values('" & productId & "','" & productName & "','" & qty & "','" & qty & "','" & Date.Now() & "')", Cn)
        Dr = Cm.ExecuteReader
        Dr.Close()
        Cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("Select * from Category where Cat_Name= '" & cbcategory.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim categoryId As String = ""
                While (Dr.Read)
                    categoryId = Dr("Cat_ID").ToString
                End While
                Dr.Close()

                Cm = New SqlCommand(" insert into Tbl_Product (Product_ID, Pro_Name, Qty_Stock, Pro_Price, Sale_Price, Category_ID) values('" & txtProId.Text & "',
                                    '" & txtname.Text & "','" & txtQty.Text & "','" & txtPrice.Text & "','" & txtSalePrice.Text & "',
                                    '" & categoryId & "')", Cn)
                Cm.ExecuteNonQuery()

                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)
                addProductToStock(txtProId.Text, txtname.Text, txtQty.Text)
                LoadRecord()
                clear()



            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
        loandCategory()
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
    End Sub
End Class