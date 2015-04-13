<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlykhachhang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbthongtinkhachhang = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.ptbsp = New System.Windows.Forms.PictureBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtdt = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.grbdanhsach = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.grbthongtinkhachhang.SuspendLayout()
        CType(Me.ptbsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbdanhsach.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbthongtinkhachhang
        '
        Me.grbthongtinkhachhang.Controls.Add(Me.btnclear)
        Me.grbthongtinkhachhang.Controls.Add(Me.ptbsp)
        Me.grbthongtinkhachhang.Controls.Add(Me.txtdiachi)
        Me.grbthongtinkhachhang.Controls.Add(Me.txtdt)
        Me.grbthongtinkhachhang.Controls.Add(Me.txttenkh)
        Me.grbthongtinkhachhang.Controls.Add(Me.txtmakh)
        Me.grbthongtinkhachhang.Controls.Add(Me.lbldiachi)
        Me.grbthongtinkhachhang.Controls.Add(Me.lbldt)
        Me.grbthongtinkhachhang.Controls.Add(Me.lbltenkh)
        Me.grbthongtinkhachhang.Controls.Add(Me.lblmakh)
        Me.grbthongtinkhachhang.Location = New System.Drawing.Point(12, 12)
        Me.grbthongtinkhachhang.Name = "grbthongtinkhachhang"
        Me.grbthongtinkhachhang.Size = New System.Drawing.Size(870, 204)
        Me.grbthongtinkhachhang.TabIndex = 0
        Me.grbthongtinkhachhang.TabStop = False
        Me.grbthongtinkhachhang.Text = "Thông tin khách hàng:"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(499, 122)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(44, 31)
        Me.btnclear.TabIndex = 9
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'ptbsp
        '
        Me.ptbsp.Image = Global.anntps02310_INF205.My.Resources.Resources.download
        Me.ptbsp.Location = New System.Drawing.Point(574, 12)
        Me.ptbsp.Name = "ptbsp"
        Me.ptbsp.Size = New System.Drawing.Size(239, 186)
        Me.ptbsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbsp.TabIndex = 8
        Me.ptbsp.TabStop = False
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(178, 130)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(205, 23)
        Me.txtdiachi.TabIndex = 6
        '
        'txtdt
        '
        Me.txtdt.Location = New System.Drawing.Point(178, 97)
        Me.txtdt.Name = "txtdt"
        Me.txtdt.Size = New System.Drawing.Size(205, 23)
        Me.txtdt.TabIndex = 6
        Me.txtdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(178, 64)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(205, 23)
        Me.txttenkh.TabIndex = 6
        Me.txttenkh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(178, 31)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(205, 23)
        Me.txtmakh.TabIndex = 6
        Me.txtmakh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldiachi
        '
        Me.lbldiachi.Location = New System.Drawing.Point(3, 127)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(133, 26)
        Me.lbldiachi.TabIndex = 4
        Me.lbldiachi.Text = "Địa chỉ:"
        Me.lbldiachi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldt
        '
        Me.lbldt.Location = New System.Drawing.Point(31, 97)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(104, 19)
        Me.lbldt.TabIndex = 2
        Me.lbldt.Text = "Số điện thoại:"
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltenkh
        '
        Me.lbltenkh.Location = New System.Drawing.Point(41, 61)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(104, 27)
        Me.lbltenkh.TabIndex = 1
        Me.lbltenkh.Text = "Tên khách hàng:"
        Me.lbltenkh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmakh
        '
        Me.lblmakh.Location = New System.Drawing.Point(31, 30)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(114, 22)
        Me.lblmakh.TabIndex = 0
        Me.lblmakh.Text = "Mã khách hàng:"
        Me.lblmakh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbdanhsach
        '
        Me.grbdanhsach.Controls.Add(Me.DataGridView2)
        Me.grbdanhsach.Location = New System.Drawing.Point(18, 279)
        Me.grbdanhsach.Name = "grbdanhsach"
        Me.grbdanhsach.Size = New System.Drawing.Size(858, 199)
        Me.grbdanhsach.TabIndex = 1
        Me.grbdanhsach.TabStop = False
        Me.grbdanhsach.Text = "Danh sách khách hàng:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(834, 164)
        Me.DataGridView2.TabIndex = 0
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(397, 232)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(64, 31)
        Me.btnthem.TabIndex = 2
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Location = New System.Drawing.Point(486, 232)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(81, 31)
        Me.btncapnhat.TabIndex = 2
        Me.btncapnhat.Text = "Cập nhật:"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(586, 232)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(81, 31)
        Me.btnxoa.TabIndex = 2
        Me.btnxoa.Text = "Xóa:"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(765, 232)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(81, 31)
        Me.btnthoat.TabIndex = 2
        Me.btnthoat.Text = "Thoát:"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmquanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(906, 484)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.grbdanhsach)
        Me.Controls.Add(Me.grbthongtinkhachhang)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmquanlykhachhang"
        Me.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.grbthongtinkhachhang.ResumeLayout(False)
        Me.grbthongtinkhachhang.PerformLayout()
        CType(Me.ptbsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbdanhsach.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbthongtinkhachhang As System.Windows.Forms.GroupBox
    Friend WithEvents lbldt As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtdt As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents ptbsp As System.Windows.Forms.PictureBox
    Friend WithEvents grbdanhsach As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btncapnhat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
