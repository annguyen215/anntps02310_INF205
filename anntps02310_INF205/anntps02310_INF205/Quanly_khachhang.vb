Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlykhachhang
    Dim dt As New DataTable
    Dim connect As String = "workstation id=anntps02310.mssql.somee.com;packet size=4096;user id=ps02310;pwd=12345678;data source=anntps02310.mssql.somee.com;persist security info=False;initial catalog=anntps02310"

    Public Sub load()
        'tạo biến kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connect
        Dim Ket_Noi As New SqlConnection(connect)
        'Tạo biến chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", Ket_Noi)

        Try
            Ket_Noi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(dt)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView2.DataSource = dt
        Ket_Noi.Close()
    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Hide()
        frmmain.Show()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmakh.Text = "" OrElse txttenkh.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmakh.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " Delete from KhachHang WHERE Ma_khachhang = @ma"
            Dim com123 As New SqlCommand(sql, ket_noi)
            Try
                com123.Parameters.AddWithValue("@ma", txtmakh.Text)

                'thư thi truy vấn và xóa dữ liệu
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView2.DataSource = dt
            DataGridView2.DataSource = Nothing
            load()
            txtmakh.Focus()
        End If
    End Sub

    Private Sub frmquanlykhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tạo biến kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connect
        Dim Ket_Noi As New SqlConnection(connect)
        'Tạo biến chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from KhachHang", Ket_Noi)

        Try
            Ket_Noi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(dt)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView2.DataSource = dt
        Ket_Noi.Close()
        txtmakh.Focus()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'khi click vào 1 cell bất kì, lấy giá trị nhập vào các đối tượng tuong ứng
        Dim index As Integer = DataGridView2.CurrentCell.RowIndex
        txtmakh.Text = DataGridView2.Item(0, index).Value
        txttenkh.Text = DataGridView2.Item(1, index).Value
        txtdt.Text = DataGridView2.Item(2, index).Value
        txtdiachi.Text = DataGridView2.Item(3, index).Value


    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        If txtmakh.Text = "" OrElse txttenkh.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmakh.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " UPDATE KhachHang SET Ten_khachhang = @ten, So_dienthoai = @dt, Dia_chi = @dc WHERE Ma_khachhang = @ma "
            Dim com123 As New SqlCommand(sql, ket_noi)
            Try

                com123.Parameters.AddWithValue("@ma", txtmakh.Text)
                com123.Parameters.AddWithValue("@ten", txttenkh.Text)
                com123.Parameters.AddWithValue("@dt", txtdt.Text)
                com123.Parameters.AddWithValue("@dc", txtdiachi.Text)

                'thư thi truy vấn và sửa dữ liệu
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView2.DataSource = dt
            DataGridView2.DataSource = Nothing
            load()
            txtmakh.Focus()
        End If
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmakh.Text = "" OrElse txttenkh.Text = "" Then
            MessageBox.Show(" Vui lòng nhập đầy đủ thông tin", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' hiển thị thông báo khi không nhập đầy đủ thông tin
            txtmakh.Focus()
        Else
            'kết nối đến Database online
            Dim ket_noi As New SqlConnection(connect)
            'mở kết nối
            ket_noi.Open()
            'câu truy vấn để sửa dữ liệu
            Dim sql As String = " Insert into KhachHang Values(@ma, @ten, @dt, @dc)"
            Dim com123 As New SqlCommand(sql, ket_noi)
            Try

                com123.Parameters.AddWithValue("@ma", txtmakh.Text)
                com123.Parameters.AddWithValue("@ten", txttenkh.Text)
                com123.Parameters.AddWithValue("@dt", txtdt.Text)
                com123.Parameters.AddWithValue("@dc", txtdiachi.Text)

                'thư thi truy vấn và sửa dữ liệu
                com123.ExecuteNonQuery()
                'đóng kết nối
                ket_noi.Close()
            Catch ex As Exception
                MessageBox.Show("ket noi that bai")
            End Try
            'load lại form
            dt.Clear()
            DataGridView2.DataSource = dt
            DataGridView2.DataSource = Nothing
            load()
            txtmakh.Focus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmakh.Clear()
        txttenkh.Clear()
        txtdt.Clear()
        txtdiachi.Clear()
    End Sub
End Class