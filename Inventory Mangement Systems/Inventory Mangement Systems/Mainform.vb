Imports System.Data.SqlClient
Public Class Mainform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionD()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        With Employee
            .TopLevel = False
            Panel2.Controls.Add(Employee)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        With Category
            .TopLevel = False
            Panel2.Controls.Add(Category)
            .BringToFront()
            .Show()
            .LoadRecord()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        With Product
            .TopLevel = False
            Panel2.Controls.Add(Product)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        With Supplier
            .TopLevel = False
            Panel2.Controls.Add(Supplier)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        With Customer
            .TopLevel = False
            Panel2.Controls.Add(Customer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        With Sale
            .TopLevel = False
            Panel2.Controls.Add(Sale)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PUrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PUrToolStripMenuItem.Click
        With Purchase
            .TopLevel = False
            Panel2.Controls.Add(Purchase)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub CreateUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUsersToolStripMenuItem.Click
        With CreateUser
            .TopLevel = False
            Panel2.Controls.Add(CreateUser)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
