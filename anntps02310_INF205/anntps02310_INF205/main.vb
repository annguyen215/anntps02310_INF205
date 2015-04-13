Public Class frmmain

    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toshethong.Click

    End Sub

    Private Sub tosdangnhap_Click(sender As Object, e As EventArgs) Handles tosdangnhap.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub tosnhanvien_Click(sender As Object, e As EventArgs) Handles tosnhanvien.Click
        Me.Hide()
        frmquanlynv.Show()

    End Sub

    Private Sub tossanpham_Click(sender As Object, e As EventArgs) Handles toskhachhang.Click
        Me.Hide()
        frmquanlykhachhang.Show()

    End Sub
End Class