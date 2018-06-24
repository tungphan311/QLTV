<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBaoCaoSachMuon
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbThang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbNam = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgThongKe = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuotMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiLe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labellb = New System.Windows.Forms.Label()
        Me.lbTongLuotMuon = New System.Windows.Forms.Label()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnXuatBaoCao = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH MƯỢN SÁCH THEO THỂ LOẠI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(211, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 21)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Tháng:"
        '
        'tbThang
        '
        Me.tbThang.AutoSize = True
        Me.tbThang.BackColor = System.Drawing.Color.White
        Me.tbThang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbThang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbThang.ForeColor = System.Drawing.Color.Silver
        Me.tbThang.HintForeColor = System.Drawing.Color.Empty
        Me.tbThang.HintText = ""
        Me.tbThang.isPassword = False
        Me.tbThang.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbThang.LineIdleColor = System.Drawing.Color.Silver
        Me.tbThang.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbThang.LineThickness = 2
        Me.tbThang.Location = New System.Drawing.Point(274, 63)
        Me.tbThang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbThang.Name = "tbThang"
        Me.tbThang.Size = New System.Drawing.Size(64, 36)
        Me.tbThang.TabIndex = 31
        Me.tbThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNam
        '
        Me.tbNam.AutoSize = True
        Me.tbNam.BackColor = System.Drawing.Color.White
        Me.tbNam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNam.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbNam.ForeColor = System.Drawing.Color.Silver
        Me.tbNam.HintForeColor = System.Drawing.Color.Empty
        Me.tbNam.HintText = ""
        Me.tbNam.isPassword = False
        Me.tbNam.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbNam.LineIdleColor = System.Drawing.Color.Silver
        Me.tbNam.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbNam.LineThickness = 2
        Me.tbNam.Location = New System.Drawing.Point(426, 63)
        Me.tbNam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbNam.Name = "tbNam"
        Me.tbNam.Size = New System.Drawing.Size(64, 36)
        Me.tbNam.TabIndex = 31
        Me.tbNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(372, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Năm:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgThongKe)
        Me.GroupBox1.Controls.Add(Me.labellb)
        Me.GroupBox1.Controls.Add(Me.lbTongLuotMuon)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 288)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thống kê:"
        '
        'dgThongKe
        '
        Me.dgThongKe.AllowUserToAddRows = False
        Me.dgThongKe.AllowUserToDeleteRows = False
        Me.dgThongKe.AllowUserToResizeColumns = False
        Me.dgThongKe.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgThongKe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgThongKe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgThongKe.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgThongKe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgThongKe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.TenTheLoai, Me.SoLuotMuon, Me.TiLe})
        Me.dgThongKe.DoubleBuffered = True
        Me.dgThongKe.EnableHeadersVisualStyles = False
        Me.dgThongKe.GridColor = System.Drawing.Color.Gray
        Me.dgThongKe.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgThongKe.HeaderForeColor = System.Drawing.Color.Black
        Me.dgThongKe.Location = New System.Drawing.Point(11, 46)
        Me.dgThongKe.Name = "dgThongKe"
        Me.dgThongKe.ReadOnly = True
        Me.dgThongKe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgThongKe.Size = New System.Drawing.Size(581, 25)
        Me.dgThongKe.TabIndex = 72
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "STT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'TenTheLoai
        '
        Me.TenTheLoai.Frozen = True
        Me.TenTheLoai.HeaderText = "Tên Thể Loại"
        Me.TenTheLoai.Name = "TenTheLoai"
        Me.TenTheLoai.ReadOnly = True
        Me.TenTheLoai.Width = 200
        '
        'SoLuotMuon
        '
        Me.SoLuotMuon.Frozen = True
        Me.SoLuotMuon.HeaderText = "Số Lượt Mượn"
        Me.SoLuotMuon.Name = "SoLuotMuon"
        Me.SoLuotMuon.ReadOnly = True
        Me.SoLuotMuon.Width = 150
        '
        'TiLe
        '
        Me.TiLe.Frozen = True
        Me.TiLe.HeaderText = "Tỉ Lệ"
        Me.TiLe.Name = "TiLe"
        Me.TiLe.ReadOnly = True
        Me.TiLe.Width = 150
        '
        'labellb
        '
        Me.labellb.AutoSize = True
        Me.labellb.BackColor = System.Drawing.Color.Transparent
        Me.labellb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labellb.ForeColor = System.Drawing.Color.Black
        Me.labellb.Location = New System.Drawing.Point(361, 253)
        Me.labellb.Name = "labellb"
        Me.labellb.Size = New System.Drawing.Size(128, 17)
        Me.labellb.TabIndex = 32
        Me.labellb.Text = "Tổng số lượt mượn: "
        '
        'lbTongLuotMuon
        '
        Me.lbTongLuotMuon.BackColor = System.Drawing.Color.Transparent
        Me.lbTongLuotMuon.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTongLuotMuon.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbTongLuotMuon.Location = New System.Drawing.Point(489, 251)
        Me.lbTongLuotMuon.Name = "lbTongLuotMuon"
        Me.lbTongLuotMuon.Size = New System.Drawing.Size(103, 21)
        Me.lbTongLuotMuon.TabIndex = 32
        Me.lbTongLuotMuon.Text = "SoLuotMuon"
        Me.lbTongLuotMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThoat
        '
        Me.btnThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoat.BorderRadius = 7
        Me.btnThoat.ButtonText = "Thoát"
        Me.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnThoat.ForeColor = System.Drawing.Color.Black
        Me.btnThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Enter_64
        Me.btnThoat.Iconimage_right = Nothing
        Me.btnThoat.Iconimage_right_Selected = Nothing
        Me.btnThoat.Iconimage_Selected = Nothing
        Me.btnThoat.IconMarginLeft = 0
        Me.btnThoat.IconMarginRight = 0
        Me.btnThoat.IconRightVisible = True
        Me.btnThoat.IconRightZoom = 0R
        Me.btnThoat.IconVisible = True
        Me.btnThoat.IconZoom = 60.0R
        Me.btnThoat.IsTab = False
        Me.btnThoat.Location = New System.Drawing.Point(451, 467)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(140, 41)
        Me.btnThoat.TabIndex = 34
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnXuatBaoCao
        '
        Me.btnXuatBaoCao.Activecolor = System.Drawing.Color.Silver
        Me.btnXuatBaoCao.BackColor = System.Drawing.Color.LightGray
        Me.btnXuatBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXuatBaoCao.BorderRadius = 7
        Me.btnXuatBaoCao.ButtonText = "Xuất báo cáo"
        Me.btnXuatBaoCao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXuatBaoCao.DisabledColor = System.Drawing.Color.Silver
        Me.btnXuatBaoCao.ForeColor = System.Drawing.Color.Black
        Me.btnXuatBaoCao.Iconcolor = System.Drawing.Color.Transparent
        Me.btnXuatBaoCao.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnXuatBaoCao.Iconimage_right = Nothing
        Me.btnXuatBaoCao.Iconimage_right_Selected = Nothing
        Me.btnXuatBaoCao.Iconimage_Selected = Nothing
        Me.btnXuatBaoCao.IconMarginLeft = 0
        Me.btnXuatBaoCao.IconMarginRight = 0
        Me.btnXuatBaoCao.IconRightVisible = True
        Me.btnXuatBaoCao.IconRightZoom = 0R
        Me.btnXuatBaoCao.IconVisible = True
        Me.btnXuatBaoCao.IconZoom = 60.0R
        Me.btnXuatBaoCao.IsTab = False
        Me.btnXuatBaoCao.Location = New System.Drawing.Point(109, 467)
        Me.btnXuatBaoCao.Name = "btnXuatBaoCao"
        Me.btnXuatBaoCao.Normalcolor = System.Drawing.Color.LightGray
        Me.btnXuatBaoCao.OnHovercolor = System.Drawing.Color.Gray
        Me.btnXuatBaoCao.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnXuatBaoCao.selected = False
        Me.btnXuatBaoCao.Size = New System.Drawing.Size(140, 41)
        Me.btnXuatBaoCao.TabIndex = 35
        Me.btnXuatBaoCao.Text = "Xuất báo cáo"
        Me.btnXuatBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnXuatBaoCao.Textcolor = System.Drawing.Color.Black
        Me.btnXuatBaoCao.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucBaoCaoSachMuon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXuatBaoCao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbNam)
        Me.Controls.Add(Me.tbThang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucBaoCaoSachMuon"
        Me.Size = New System.Drawing.Size(700, 530)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents tbThang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbNam As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents dgThongKe As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenTheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuotMuon As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiLe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents labellb As Windows.Forms.Label
    Friend WithEvents lbTongLuotMuon As Windows.Forms.Label
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnXuatBaoCao As Bunifu.Framework.UI.BunifuFlatButton
End Class
