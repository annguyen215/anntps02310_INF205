Imports System.Data.SqlClient
Public Class frmlogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click

        If txtpass.Text = "" OrElse txtuser.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtuser.Focus()
        Else

            Dim connect As String = "workstation id=anntps02310.mssql.somee.com;packet size=4096;user id=ps02310;pwd=12345678;data source=anntps02310.mssql.somee.com;persist security info=False;initial catalog=anntps02310"
            Dim Ket_Noi As SqlConnection = New SqlConnection(connect)
            Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where Ma_nhanVien='" & txtuser.Text & "' and Password='" & txtpass.Text & "' ", Ket_Noi)
            Dim dt As New DataTable

            Try
                Ket_Noi.Open()
                sqlAdapter.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("ket nối thành công")
                    frmmain.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
                End If

            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub
    
End Class



