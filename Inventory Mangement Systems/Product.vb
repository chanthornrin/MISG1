Imports System.Data.SqlClient

Public Class Product
    Sub loandCategory()
        cbcategory.Items.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from category", Cn)
        Dr = Cm.ExecuteReader
        While (Dr.Read)
            cbcategory.Items.Add(Dr("name").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub

    Sub loandEmployee()
        cbEmployee.Items.Clear()
        Cn.Open()
        Cm = New SqlCommand("Select * from employee", Cn)
        Dr = Cm.ExecuteReader
        While (Dr.Read)
            cbEmployee.Items.Add(Dr("FullName").ToString)
        End While
        Dr.Close()
        Cn.Close()

    End Sub


    Sub clear()
        txtname.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        txtSalePrice.Text = ""
        txtdescription.Text=""
        cbcategory.Text = ""
        cbEmployee.Text = ""
        txtname.Focus()
    End Sub

    Sub LoadRecord()
        Dim i As Integer = 0
        DGVproduct.Rows.Clear()
        Cn.Open()
        Cm = New SqlCommand("SELECT dbo.product.proId, dbo.product.name, dbo.product.qty, dbo.product.costPrice, dbo.product.salePrice, dbo.product.description, dbo.category.name AS Expr1, dbo.employee.FullName
                  FROM dbo.category INNER JOIN
                  dbo.employee ON dbo.category.id = dbo.employee.id INNER JOIN
                  dbo.product ON dbo.employee.id = dbo.product.employeeId ", Cn)
        Dr = Cm.ExecuteReader
        While Dr.Read
            i += 1
            DGVproduct.Rows.Add(i, Dr(0).ToString, Dr(1).ToString, Dr(2).ToString, Dr(3).ToString, Dr(4).ToString,
                                   Dr(5).ToString, Dr(6).ToString, Dr(7).ToString)
        End While
        Dr.Close()
        Cn.Close()
    End Sub

    Sub addProductToStock(productId As Integer, qty As Integer, price As Double, empId As Integer)
        Cn.Open()
        Cm = New SqlCommand("insert into stock(productId,stockQty,price,dateCreated,employeeId) values ('" & productId & "','" & qty & "',
                                                                                '" & price & "','" & Date.Now.ToString() & "','" & empId & "')", Cn)
        Dr = Cm.ExecuteReader
        Dr.Close()
        Cn.Close()

    End Sub

    Sub findProductBynName(productName As String, qty As Integer, price As Double, empId As Integer)
        Cn.Open()
        Cm = New SqlCommand("Select * from product where name= '" & productName & "'", Cn)
        Dr = Cm.ExecuteReader
        Dim productId As Integer
        While (Dr.Read)
            productId = Convert.ToInt16(Dr("proId").ToString)
        End While
        Dr.Close()
        Cn.Close()
        addProductToStock(productId, qty, price, empId)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (MsgBox("Are you sure you want to Insert?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("Select * from category where name​ = '" & cbcategory.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim categoryId As Integer
                While (Dr.Read)
                    categoryId = Dr("id").ToString
                End While
                Dr.Close()

                Cm = New SqlCommand("Select * from employee where FullName​​ = '" & cbEmployee.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim empId As Integer
                While (Dr.Read)
                    empId = Dr("id").ToString
                End While
                Dr.Close()

                Cm = New SqlCommand(" insert into product (name,qty,costPrice,salePrice,description,dateCreate,employeeId) values('" & txtname.Text & "','" & txtQty.Text & "','" & txtPrice.Text & "','" & txtSalePrice.Text & "','" & txtdescription.Text & "',
                                                                                                                         '" & Date.Now.ToString() & "'," & empId & ")", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been insert successfully,", vbInformation)

                findProductBynName(txtname.Text, Convert.ToInt16(txtQty.Text), Convert.ToInt16(txtPrice.Text), empId)
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
        loandEmployee()
        DGVproduct.DefaultCellStyle.Font = New Font("Arial", 12)
    End Sub

    Private Sub Topproduct_Paint(sender As Object, e As PaintEventArgs) Handles Topproduct.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtdescription.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                '------------------
                Cm = New SqlCommand("Select * from category where name​ = '" & cbcategory.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim categoryId As String = ""
                While (Dr.Read)
                    categoryId = Dr("id").ToString
                End While
                Dr.Close()

                Cm = New SqlCommand("Select * from employee where FullName​​ = '" & cbEmployee.Text & "'", Cn)
                Dr = Cm.ExecuteReader
                Dim empId As Integer
                While (Dr.Read)
                    empId = Convert.ToInt16(Dr("id").ToString)
                End While
                Dr.Close()
                '-----------------

                Cm = New SqlCommand("update product set name ='" & txtname.Text & "',qty =" & txtQty.Text & ",costPrice ='" & txtPrice.Text & "',salePrice ='" & txtSalePrice.Text & "'
               ,description ='" & txtdescription.Text & "',dateUpdate ='" & Date.Now.ToString() & "',employeeId =" & empId & " where proId like '" & txtproId.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully updated,", vbInformation)

                LoadRecord()
                clear()
            End If
        Catch ex As Exception
            Cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DGVproduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVproduct.CellContentClick
        Dim colName As String = DGVproduct.Columns(e.ColumnIndex).Name
        If colName = "Column9" Then

            txtproId.Text = DGVproduct(1, e.RowIndex).Value.ToString()
            txtname.Text = DGVproduct(2, e.RowIndex).Value.ToString()
            txtQty.Text = DGVproduct(3, e.RowIndex).Value.ToString()
            txtPrice.Text = DGVproduct(4, e.RowIndex).Value.ToString()
            txtSalePrice.Text = DGVproduct(5, e.RowIndex).Value.ToString()
            txtdescription.Text = DGVproduct(6, e.RowIndex).Value.ToString()
            cbcategory.Text = DGVproduct(7, e.RowIndex).Value.ToString()
            cbEmployee.Text = DGVproduct(8, e.RowIndex).Value.ToString()


        ElseIf colName = "Column10" Then
            If (MsgBox("Are you sure want to delete this record", vbYesNo + vbQuestion) = vbYes) Then
                Cn.Open()
                Cm = New SqlCommand("delete from product where proId like '" & txtproId.Text & "'", Cn)
                Cm.ExecuteNonQuery()
                Cn.Close()
                MsgBox("Record has been successfully deleted", vbInformation)

                LoadRecord()
                clear()
            End If

        End If
    End Sub
End Class