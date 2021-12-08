Imports System.Data.SqlClient
Public Class product
    Dim Con As New SqlConnection("Data Source=WINDOWS-CT800DV;Initial Catalog=ProgrammingDB;Integrated Security=True")
    Public Sub Populate()
        Con.Open()
        Dim sql = "select * from Product_Table"
        Dim adapter As New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Con.Open()
        Dim pid As Integer = Prodidtxt.Text
        Dim pname As String = Prodnametxt.Text
        Dim pprice As Integer = Prodpricetxt.Text
        Dim pquantity As Integer = Prodqtytxt.Text
        Dim pcat As String = prodcatcb.Text
        Dim command As New SqlCommand("Insert into Product_Table Values ('" & pid & "','" & pname & "','" & pprice & "','" & pquantity & "','" & pcat & "')", Con)
        command.ExecuteNonQuery()
        MsgBox("Product Added Successfully")
        Con.Close()
        Populate()
    End Sub


    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        If Prodidtxt.Text = "" Or Prodnametxt.Text = "" Or Prodpricetxt.Text = "" Or Prodqtytxt.Text = "" Or prodcatcb.Text = "" Then
            MsgBox("Incomplete Data")
        Else
            Con.Open()
            Dim sql = "update Product_Table set ProductName='" & Prodnametxt.Text & "',ProductPrice='" & Prodpricetxt.Text & "',ProductQuantity='" & Prodqtytxt.Text & "',ProductCategory='" & prodcatcb.SelectedItem.ToString() & "' where Product_ID = " & Prodidtxt.Text & ""
            Dim cmd As New SqlCommand(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Updated Successfully")
            Con.Close()
            Populate()

        End If
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If Prodidtxt.Text = "" Then
            MsgBox("Enter the Product to be Deleted")
        Else
            Con.Open()
            Dim query As String
            query = "delete from Product_Table where Product_ID =" & Prodidtxt.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Deleted Successfully")
            Con.Close()
            Populate()
        End If
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim pid As Integer = Prodidtxt.Text
        Dim command As New SqlCommand("select * from Product_Table where Product_ID ='" & pid & "'", Con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        ProductDGV.DataSource = dt
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click, Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellContentClick

    End Sub

    Private Sub CategoryCB_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Prodidtxt_TextChanged(sender As Object, e As EventArgs) Handles Prodidtxt.TextChanged, TextBox1.TextChanged

    End Sub

    Private Sub Prodnametxt_TextChanged(sender As Object, e As EventArgs) Handles Prodnametxt.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub Prodpricetxt_TextChanged(sender As Object, e As EventArgs) Handles Prodpricetxt.TextChanged, TextBox3.TextChanged

    End Sub
    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Prodidtxt.Text = ""
        Prodnametxt.Text = ""
        Prodqtytxt.Text = ""
        Prodpricetxt.Text = ""
        prodcatcb.Text = ""
    End Sub

    Private Sub ProductTableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductTableBindingSource.CurrentChanged

    End Sub

    Private Sub Categorytxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Prodqtytxt_TextChanged(sender As Object, e As EventArgs) Handles Prodqtytxt.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub quantitylbl_Click(sender As Object, e As EventArgs) Handles quantitylbl.Click, Label10.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub prodcatcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prodcatcb.SelectedIndexChanged, ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class