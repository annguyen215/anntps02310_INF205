<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.ptblogo = New System.Windows.Forms.PictureBox()
        Me.lbllogodangnhap = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptblogo
        '
        Me.ptblogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptblogo.Image = Global.anntps02310_INF205.My.Resources.Resources.marketing_3
        Me.ptblogo.Location = New System.Drawing.Point(12, 12)
        Me.ptblogo.Name = "ptblogo"
        Me.ptblogo.Size = New System.Drawing.Size(194, 194)
        Me.ptblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptblogo.TabIndex = 0
        Me.ptblogo.TabStop = False
        '
        'lbllogodangnhap
        '
        Me.lbllogodangnhap.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogodangnhap.ForeColor = System.Drawing.Color.Red
        Me.lbllogodangnhap.Location = New System.Drawing.Point(278, 12)
        Me.lbllogodangnhap.Name = "lbllogodangnhap"
        Me.lbllogodangnhap.Size = New System.Drawing.Size(211, 53)
        Me.lbllogodangnhap.TabIndex = 1
        Me.lbllogodangnhap.Text = "ĐĂNG NHẬP"
        Me.lbllogodangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbluser
        '
        Me.lbluser.Location = New System.Drawing.Point(246, 65)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(69, 28)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Username:"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpass
        '
        Me.lblpass.Location = New System.Drawing.Point(246, 104)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(69, 22)
        Me.lblpass.TabIndex = 2
        Me.lblpass.Text = "Password:"
        Me.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(353, 68)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(125, 23)
        Me.txtuser.TabIndex = 3
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(353, 105)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(125, 23)
        Me.txtpass.TabIndex = 3
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btndangnhap
        '
        Me.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndangnhap.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndangnhap.Location = New System.Drawing.Point(269, 154)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(107, 36)
        Me.btndangnhap.TabIndex = 4
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnthoat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(420, 154)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(98, 36)
        Me.btnthoat.TabIndex = 4
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(572, 220)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lbllogodangnhap)
        Me.Controls.Add(Me.ptblogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmlogin"
        Me.Text = "ĐĂNG NHẬP HỆ THỐNG"
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptblogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbllogodangnhap As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button

End Class
