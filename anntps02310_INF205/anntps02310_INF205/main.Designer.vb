<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.mnsmenu = New System.Windows.Forms.MenuStrip()
        Me.toshethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.tosdangnhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.tosnhanvien = New System.Windows.Forms.ToolStripMenuItem()
        Me.toskhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.ptbquanly = New System.Windows.Forms.PictureBox()
        Me.lblmssv = New System.Windows.Forms.Label()
        Me.mnsmenu.SuspendLayout()
        CType(Me.ptbquanly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsmenu
        '
        Me.mnsmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toshethong, Me.tosnhanvien, Me.toskhachhang})
        Me.mnsmenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsmenu.Name = "mnsmenu"
        Me.mnsmenu.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mnsmenu.Size = New System.Drawing.Size(761, 24)
        Me.mnsmenu.TabIndex = 0
        Me.mnsmenu.Text = "MenuStrip1"
        '
        'toshethong
        '
        Me.toshethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tosdangnhap})
        Me.toshethong.Name = "toshethong"
        Me.toshethong.Size = New System.Drawing.Size(72, 20)
        Me.toshethong.Text = "Hệ Thống"
        '
        'tosdangnhap
        '
        Me.tosdangnhap.Name = "tosdangnhap"
        Me.tosdangnhap.Size = New System.Drawing.Size(132, 22)
        Me.tosdangnhap.Text = "Đăng nhập"
        '
        'tosnhanvien
        '
        Me.tosnhanvien.Name = "tosnhanvien"
        Me.tosnhanvien.Size = New System.Drawing.Size(118, 20)
        Me.tosnhanvien.Text = "Quản Lý nhân viên"
        '
        'toskhachhang
        '
        Me.toskhachhang.Name = "toskhachhang"
        Me.toskhachhang.Size = New System.Drawing.Size(128, 20)
        Me.toskhachhang.Text = "Quản Lý khách hàng"
        '
        'ptbquanly
        '
        Me.ptbquanly.Image = Global.anntps02310_INF205.My.Resources.Resources.images1
        Me.ptbquanly.Location = New System.Drawing.Point(14, 31)
        Me.ptbquanly.Name = "ptbquanly"
        Me.ptbquanly.Size = New System.Drawing.Size(723, 351)
        Me.ptbquanly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbquanly.TabIndex = 1
        Me.ptbquanly.TabStop = False
        '
        'lblmssv
        '
        Me.lblmssv.Location = New System.Drawing.Point(0, 407)
        Me.lblmssv.Name = "lblmssv"
        Me.lblmssv.Size = New System.Drawing.Size(749, 22)
        Me.lblmssv.TabIndex = 2
        Me.lblmssv.Text = "MSSV: Nguyễn Thiên Ân ( anntps02310)"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(761, 427)
        Me.Controls.Add(Me.lblmssv)
        Me.Controls.Add(Me.ptbquanly)
        Me.Controls.Add(Me.mnsmenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnsmenu
        Me.Name = "frmmain"
        Me.Text = "QUẢN LÝ CÔNG TY"
        Me.mnsmenu.ResumeLayout(False)
        Me.mnsmenu.PerformLayout()
        CType(Me.ptbquanly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsmenu As System.Windows.Forms.MenuStrip
    Friend WithEvents toshethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tosnhanvien As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toskhachhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tosdangnhap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptbquanly As System.Windows.Forms.PictureBox
    Friend WithEvents lblmssv As System.Windows.Forms.Label
End Class
