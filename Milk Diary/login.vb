Imports System.Data.SqlClient


Public Class login
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Width = 25
        PictureBox3.Height = 25
        If Guna2TextBox2.UseSystemPasswordChar Then
            PictureBox3.BackgroundImage = Image.FromFile("D:\Milk Diary\Milk Diary\Images\hide.png")
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            PictureBox3.BackgroundImage = Image.FromFile("D:\Milk Diary\Milk Diary\Images\eye.png")
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox2.UseSystemPasswordChar = True
        PictureBox3.Width = 25
        PictureBox3.Height = 25
        PictureBox3.BackgroundImage = Image.FromFile("D:\Milk Diary\Milk Diary\Images\eye.png")
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point((Me.Width - Panel1.Width) / 2, (Me.Height - Panel1.Height) / 2)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connection As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=milkdb;Integrated Security=True")
        Dim command As New SqlCommand("select * from Admin where username = @username and password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = Guna2TextBox1.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Guna2TextBox2.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username Or Password are invalid")
        Else
            MessageBox.Show("Login Successfully")
            Dim lg = New Homepage
            lg.Show()
            Me.Hide()
        End If
    End Sub
End Class