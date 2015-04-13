Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlynv
    Dim dt As New DataTable
    Dim connect As String = "workstation id=anntps02310.mssql.somee.com;packet size=4096;user id=ps02310;pwd=12345678;data source=anntps02310.mssql.somee.com;persist security info=False;initial catalog=anntps02310"

    Public Sub load()
        'tạo biến kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connect
        Dim Ket_Noi As New SqlConnection(connect)
        'Tạo biến chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", Ket_Noi)

        Try
            Ket_Noi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(dt)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = dt
        Ket_Noi.Close()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblpass.Click

    End Sub

    Private Sub nudsoluong_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmquanlynv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'tạo biến kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connect
        Dim Ket_Noi As New SqlConnection(connect)
        'Tạo biến chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", Ket_Noi)

        Try
            Ket_Noi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(dt)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = dt
        Ket_Noi.Close()
        txtmanv.Focus()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'khi click vào 1 cell bất kì, lấy giá trị nhập vào các đối tượng tuong ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmanv.Text = DataGridView1.Item(0, index).Value
        txtpass.Text = DataGridView1.Item(1, index).Value
        txttennv.Text = DataGridView1.Item(2, index).Value
        cbbgioitinh.Text = DataGridView1.Item(3, index).Value
        txtsodt.Text = DataGridView1.Item(4, index).Value


    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        If txtmanv.Text = "" OrElse txtpass.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmanv.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " UPDATE NhanVien SET Password = @pass, Ten_nhanvien = @ten, Gioi_tinh = @gt, So_dienthoai = @dt WHERE Ma_nhanvien = @ma "
            Dim com123 As New SqlCommand(sql, ket_noi)
            Try

                com123.Parameters.AddWithValue("@ma", txtmanv.Text)
                com123.Parameters.AddWithValue("@pass", txtpass.Text)
                com123.Parameters.AddWithValue("@ten", txttennv.Text)
                com123.Parameters.AddWithValue("@gt", cbbgioitinh.Text)
                com123.Parameters.AddWithValue("@dt", txtsodt.Text)
                'thư thi truy vấn và sửa dữ liệu
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView1.DataSource = dt
            DataGridView1.DataSource = Nothing
            load()
            txtmanv.Focus()
        End If
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmanv.Text = "" OrElse txtpass.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmanv.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " Delete from NhanVien WHERE Ma_nhanvien = @ma"
            Dim com123 As New SqlCommand(sql, ket_noi)
            Try
                com123.Parameters.AddWithValue("@ma", txtmanv.Text)

                'thư thi truy vấn và xóa dữ liệu
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView1.DataSource = dt
            DataGridView1.DataSource = Nothing
            load()
            txtmanv.Focus()
        End If
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmanv.Text = "" OrElse txtpass.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmanv.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " Insert into NhanVien values ( @ma, @pass, @ten, @gt, @dt)"


            Dim com123 As New SqlCommand(sql, ket_noi)
            Try
                com123.Parameters.AddWithValue("@ma", txtmanv.Text)
                com123.Parameters.AddWithValue("@pass", txtpass.Text)
                com123.Parameters.AddWithValue("@ten", txttennv.Text)
                com123.Parameters.AddWithValue("@gt", cbbgioitinh.Text)
                com123.Parameters.AddWithValue("@dt", txtsodt.Text)
                'thư thi truy vấn và thêm
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView1.DataSource = dt
            DataGridView1.DataSource = Nothing
            load()
            txtmanv.Focus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmanv.Clear()
        txtpass.Clear()
        txttennv.Clear()
        txtsodt.Clear()

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Hide()
        frmmain.Show()

    End Sub
End Class