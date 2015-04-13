<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlynv
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
        Me.grbthongtinnhanvien = New System.Windows.Forms.GroupBox()
        Me.cbbgioitinh = New System.Windows.Forms.ComboBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.ptb2 = New System.Windows.Forms.PictureBox()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txttennv = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.lblsodt = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lbltennv = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblmanv = New System.Windows.Forms.Label()
        Me.grbdanhsach = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.grbthongtinnhanvien.SuspendLayout()
        CType(Me.ptb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbdanhsach.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbthongtinnhanvien
        '
        Me.grbthongtinnhanvien.Controls.Add(Me.cbbgioitinh)
        Me.grbthongtinnhanvien.Controls.Add(Me.btnclear)
        Me.grbthongtinnhanvien.Controls.Add(Me.ptb2)
        Me.grbthongtinnhanvien.Controls.Add(Me.txtsodt)
        Me.grbthongtinnhanvien.Controls.Add(Me.txttennv)
        Me.grbthongtinnhanvien.Controls.Add(Me.txtpass)
        Me.grbthongtinnhanvien.Controls.Add(Me.txtmanv)
        Me.grbthongtinnhanvien.Controls.Add(Me.lblsodt)
        Me.grbthongtinnhanvien.Controls.Add(Me.lblgioitinh)
        Me.grbthongtinnhanvien.Controls.Add(Me.lbltennv)
        Me.grbthongtinnhanvien.Controls.Add(Me.lblpass)
        Me.grbthongtinnhanvien.Controls.Add(Me.lblmanv)
        Me.grbthongtinnhanvien.Location = New System.Drawing.Point(12, 12)
        Me.grbthongtinnhanvien.Name = "grbthongtinnhanvien"
        Me.grbthongtinnhanvien.Size = New System.Drawing.Size(870, 235)
        Me.grbthongtinnhanvien.TabIndex = 0
        Me.grbthongtinnhanvien.TabStop = False
        Me.grbthongtinnhanvien.Text = "Thông tin nhân viên"
        '
        'cbbgioitinh
        '
        Me.cbbgioitinh.FormattingEnabled = True
        Me.cbbgioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbbgioitinh.Location = New System.Drawing.Point(203, 154)
        Me.cbbgioitinh.Name = "cbbgioitinh"
        Me.cbbgioitinh.Size = New System.Drawing.Size(77, 23)
        Me.cbbgioitinh.TabIndex = 4
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(475, 189)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(43, 29)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "clear:"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'ptb2
        '
        Me.ptb2.Image = Global.anntps02310_INF205.My.Resources.Resources.lam_viec_theo_nhom
        Me.ptb2.Location = New System.Drawing.Point(577, 22)
        Me.ptb2.Name = "ptb2"
        Me.ptb2.Size = New System.Drawing.Size(250, 207)
        Me.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb2.TabIndex = 3
        Me.ptb2.TabStop = False
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(203, 195)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(135, 23)
        Me.txtsodt.TabIndex = 1
        Me.txtsodt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttennv
        '
        Me.txttennv.Location = New System.Drawing.Point(203, 115)
        Me.txttennv.Name = "txttennv"
        Me.txttennv.Size = New System.Drawing.Size(166, 23)
        Me.txttennv.TabIndex = 1
        Me.txttennv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(203, 80)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(215, 23)
        Me.txtpass.TabIndex = 1
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(203, 42)
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(215, 23)
        Me.txtmanv.TabIndex = 1
        Me.txtmanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblsodt
        '
        Me.lblsodt.Location = New System.Drawing.Point(35, 190)
        Me.lblsodt.Name = "lblsodt"
        Me.lblsodt.Size = New System.Drawing.Size(90, 28)
        Me.lblsodt.TabIndex = 0
        Me.lblsodt.Text = "Số điện thoại:"
        Me.lblsodt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgioitinh
        '
        Me.lblgioitinh.Location = New System.Drawing.Point(35, 153)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(71, 24)
        Me.lblgioitinh.TabIndex = 0
        Me.lblgioitinh.Text = "Giới tính:"
        Me.lblgioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltennv
        '
        Me.lbltennv.Location = New System.Drawing.Point(35, 116)
        Me.lbltennv.Name = "lbltennv"
        Me.lbltennv.Size = New System.Drawing.Size(90, 22)
        Me.lbltennv.TabIndex = 0
        Me.lbltennv.Text = "Tên nhân viên:"
        Me.lbltennv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpass
        '
        Me.lblpass.Location = New System.Drawing.Point(35, 73)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(90, 30)
        Me.lblpass.TabIndex = 0
        Me.lblpass.Text = "password:"
        Me.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmanv
        '
        Me.lblmanv.Location = New System.Drawing.Point(35, 38)
        Me.lblmanv.Name = "lblmanv"
        Me.lblmanv.Size = New System.Drawing.Size(101, 28)
        Me.lblmanv.TabIndex = 0
        Me.lblmanv.Text = "Mã nhân viên:"
        Me.lblmanv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbdanhsach
        '
        Me.grbdanhsach.Controls.Add(Me.DataGridView1)
        Me.grbdanhsach.Location = New System.Drawing.Point(12, 301)
        Me.grbdanhsach.Name = "grbdanhsach"
        Me.grbdanhsach.Size = New System.Drawing.Size(858, 222)
        Me.grbdanhsach.TabIndex = 1
        Me.grbdanhsach.TabStop = False
        Me.grbdanhsach.Text = "Danh sách nhân viên:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(834, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'btncapnhat
        '
        Me.btncapnhat.Location = New System.Drawing.Point(524, 272)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btncapnhat.TabIndex = 2
        Me.btncapnhat.Text = "Cập nhật:"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(639, 272)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 2
        Me.btnxoa.Text = "Xóa:"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnthem.Location = New System.Drawing.Point(420, 272)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm:"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(795, 272)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 5
        Me.btnthoat.Text = "Thoát:"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmquanlynv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(906, 535)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.grbdanhsach)
        Me.Controls.Add(Me.grbthongtinnhanvien)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmquanlynv"
        Me.Text = "QUẢN LÝ NHÂN VIÊN"
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.grbthongtinnhanvien.ResumeLayout(False)
        Me.grbthongtinnhanvien.PerformLayout()
        CType(Me.ptb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbdanhsach.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbthongtinnhanvien As System.Windows.Forms.GroupBox
    Friend WithEvents lblsodt As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lbltennv As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblmanv As System.Windows.Forms.Label
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txttennv As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtmanv As System.Windows.Forms.TextBox
    Friend WithEvents ptb2 As System.Windows.Forms.PictureBox
    Friend WithEvents grbdanhsach As System.Windows.Forms.GroupBox
    Friend WithEvents cbbgioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btncapnhat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
