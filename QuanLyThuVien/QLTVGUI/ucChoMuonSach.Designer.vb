﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChoMuonSach
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMaDocGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbHoTen = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTinhTrang = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbNgayLap = New System.Windows.Forms.Label()
        Me.dgDSSachMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDanhSachSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTrangThaiThem = New System.Windows.Forms.Label()
        Me.tbMaSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThemMaSach = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnLuuVaThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnXuatPhieuMuon = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDSSachMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnThemMaSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(249, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PHIẾU MƯỢN SÁCH"
        '
        'tbMaDocGia
        '
        Me.tbMaDocGia.AutoSize = True
        Me.tbMaDocGia.BackColor = System.Drawing.Color.White
        Me.tbMaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaDocGia.ForeColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaDocGia.HintText = ""
        Me.tbMaDocGia.isPassword = False
        Me.tbMaDocGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaDocGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaDocGia.LineThickness = 2
        Me.tbMaDocGia.Location = New System.Drawing.Point(246, 119)
        Me.tbMaDocGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaDocGia.Name = "tbMaDocGia"
        Me.tbMaDocGia.Size = New System.Drawing.Size(112, 36)
        Me.tbMaDocGia.TabIndex = 12
        Me.tbMaDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(72, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Họ tên độc giả:"
        '
        'lbHoTen
        '
        Me.lbHoTen.AutoSize = True
        Me.lbHoTen.BackColor = System.Drawing.Color.Gainsboro
        Me.lbHoTen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoTen.ForeColor = System.Drawing.Color.Black
        Me.lbHoTen.Location = New System.Drawing.Point(176, 30)
        Me.lbHoTen.Name = "lbHoTen"
        Me.lbHoTen.Size = New System.Drawing.Size(47, 17)
        Me.lbHoTen.TabIndex = 31
        Me.lbHoTen.Text = "Họ tên"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(144, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Mã độc giả:"
        '
        'dtpNgayMuon
        '
        Me.dtpNgayMuon.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayMuon.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayMuon.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayMuon.CustomFormat = "ddddddddd, dd/MM/yyyy"
        Me.dtpNgayMuon.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayMuon.Location = New System.Drawing.Point(245, 73)
        Me.dtpNgayMuon.Name = "dtpNgayMuon"
        Me.dtpNgayMuon.Size = New System.Drawing.Size(242, 29)
        Me.dtpNgayMuon.TabIndex = 75
        Me.dtpNgayMuon.Value = New Date(2018, 6, 23, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(136, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 21)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Ngày mượn:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbTinhTrang)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbNgayLap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbHoTen)
        Me.GroupBox1.Controls.Add(Me.dgDSSachMuon)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 144)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin độc giả"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(324, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tình trạng thẻ: "
        '
        'lbTinhTrang
        '
        Me.lbTinhTrang.AutoSize = True
        Me.lbTinhTrang.BackColor = System.Drawing.Color.Gainsboro
        Me.lbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTinhTrang.ForeColor = System.Drawing.Color.Black
        Me.lbTinhTrang.Location = New System.Drawing.Point(426, 58)
        Me.lbTinhTrang.Name = "lbTinhTrang"
        Me.lbTinhTrang.Size = New System.Drawing.Size(81, 17)
        Me.lbTinhTrang.TabIndex = 31
        Me.lbTinhTrang.Text = "Còn/Hết hạn"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(60, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sách đang mượn:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(84, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ngày lập thẻ:"
        '
        'lbNgayLap
        '
        Me.lbNgayLap.AutoSize = True
        Me.lbNgayLap.BackColor = System.Drawing.Color.Gainsboro
        Me.lbNgayLap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgayLap.ForeColor = System.Drawing.Color.Black
        Me.lbNgayLap.Location = New System.Drawing.Point(176, 58)
        Me.lbNgayLap.Name = "lbNgayLap"
        Me.lbNgayLap.Size = New System.Drawing.Size(61, 17)
        Me.lbNgayLap.TabIndex = 31
        Me.lbNgayLap.Text = "Ngày lập"
        '
        'dgDSSachMuon
        '
        Me.dgDSSachMuon.AllowUserToAddRows = False
        Me.dgDSSachMuon.AllowUserToDeleteRows = False
        Me.dgDSSachMuon.AllowUserToResizeColumns = False
        Me.dgDSSachMuon.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDSSachMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDSSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDSSachMuon.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDSSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDSSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSSachMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDSSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSSachMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ThoiGianMuon})
        Me.dgDSSachMuon.DoubleBuffered = True
        Me.dgDSSachMuon.EnableHeadersVisualStyles = False
        Me.dgDSSachMuon.GridColor = System.Drawing.Color.Gray
        Me.dgDSSachMuon.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDSSachMuon.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDSSachMuon.Location = New System.Drawing.Point(38, 113)
        Me.dgDSSachMuon.Name = "dgDSSachMuon"
        Me.dgDSSachMuon.ReadOnly = True
        Me.dgDSSachMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSSachMuon.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDSSachMuon.Size = New System.Drawing.Size(563, 23)
        Me.dgDSSachMuon.TabIndex = 71
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "STT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 68.438!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mã Sách"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 172.2419!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tên Sách"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'ThoiGianMuon
        '
        Me.ThoiGianMuon.HeaderText = "Thời gian mượn"
        Me.ThoiGianMuon.Name = "ThoiGianMuon"
        Me.ThoiGianMuon.ReadOnly = True
        Me.ThoiGianMuon.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgDanhSachSach)
        Me.GroupBox2.Controls.Add(Me.btnThemMaSach)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbTrangThaiThem)
        Me.GroupBox2.Controls.Add(Me.tbMaSach)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 164)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin phiếu mượn"
        '
        'dgDanhSachSach
        '
        Me.dgDanhSachSach.AllowUserToOrderColumns = True
        Me.dgDanhSachSach.AllowUserToResizeColumns = False
        Me.dgDanhSachSach.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgDanhSachSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDanhSachSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSachSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSachSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSachSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSachSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSach, Me.TenSach, Me.TheLoai, Me.TacGia})
        Me.dgDanhSachSach.DoubleBuffered = True
        Me.dgDanhSachSach.EnableHeadersVisualStyles = False
        Me.dgDanhSachSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSachSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSachSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSachSach.Location = New System.Drawing.Point(3, 110)
        Me.dgDanhSachSach.Name = "dgDanhSachSach"
        Me.dgDanhSachSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgDanhSachSach.Size = New System.Drawing.Size(633, 48)
        Me.dgDanhSachSach.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(97, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 19)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Trạng thái:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(107, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Mã sách:"
        '
        'lbTrangThaiThem
        '
        Me.lbTrangThaiThem.AutoSize = True
        Me.lbTrangThaiThem.BackColor = System.Drawing.Color.Gainsboro
        Me.lbTrangThaiThem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbTrangThaiThem.ForeColor = System.Drawing.Color.Black
        Me.lbTrangThaiThem.Location = New System.Drawing.Point(176, 72)
        Me.lbTrangThaiThem.Name = "lbTrangThaiThem"
        Me.lbTrangThaiThem.Size = New System.Drawing.Size(194, 19)
        Me.lbTrangThaiThem.TabIndex = 31
        Me.lbTrangThaiThem.Text = "Thêm thành công/ thất bại (...)"
        '
        'tbMaSach
        '
        Me.tbMaSach.AutoSize = True
        Me.tbMaSach.BackColor = System.Drawing.Color.White
        Me.tbMaSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaSach.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaSach.ForeColor = System.Drawing.Color.Silver
        Me.tbMaSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaSach.HintText = ""
        Me.tbMaSach.isPassword = False
        Me.tbMaSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaSach.LineThickness = 2
        Me.tbMaSach.Location = New System.Drawing.Point(177, 28)
        Me.tbMaSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaSach.Name = "tbMaSach"
        Me.tbMaSach.Size = New System.Drawing.Size(112, 32)
        Me.tbMaSach.TabIndex = 12
        Me.tbMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'STT
        '
        Me.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.Width = 40
        '
        'MaSach
        '
        Me.MaSach.FillWeight = 68.438!
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        '
        'TenSach
        '
        Me.TenSach.FillWeight = 172.2419!
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.Width = 218
        '
        'TheLoai
        '
        Me.TheLoai.FillWeight = 90.76328!
        Me.TheLoai.HeaderText = "Thể Loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.Width = 120
        '
        'TacGia
        '
        Me.TacGia.FillWeight = 93.9663!
        Me.TacGia.HeaderText = "Tác Giả"
        Me.TacGia.Name = "TacGia"
        Me.TacGia.Width = 114
        '
        'btnThemMaSach
        '
        Me.btnThemMaSach.BackColor = System.Drawing.Color.Transparent
        Me.btnThemMaSach.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btnThemMaSach.ImageActive = Nothing
        Me.btnThemMaSach.Location = New System.Drawing.Point(298, 28)
        Me.btnThemMaSach.Name = "btnThemMaSach"
        Me.btnThemMaSach.Size = New System.Drawing.Size(30, 30)
        Me.btnThemMaSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnThemMaSach.TabIndex = 31
        Me.btnThemMaSach.TabStop = False
        Me.btnThemMaSach.Zoom = 10
        '
        'btnLuuVaThoat
        '
        Me.btnLuuVaThoat.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuVaThoat.BorderRadius = 7
        Me.btnLuuVaThoat.ButtonText = "Lưu và Thoát"
        Me.btnLuuVaThoat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuVaThoat.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuVaThoat.ForeColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuVaThoat.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Ok_64
        Me.btnLuuVaThoat.Iconimage_right = Nothing
        Me.btnLuuVaThoat.Iconimage_right_Selected = Nothing
        Me.btnLuuVaThoat.Iconimage_Selected = Nothing
        Me.btnLuuVaThoat.IconMarginLeft = 0
        Me.btnLuuVaThoat.IconMarginRight = 0
        Me.btnLuuVaThoat.IconRightVisible = True
        Me.btnLuuVaThoat.IconRightZoom = 0R
        Me.btnLuuVaThoat.IconVisible = True
        Me.btnLuuVaThoat.IconZoom = 60.0R
        Me.btnLuuVaThoat.IsTab = False
        Me.btnLuuVaThoat.Location = New System.Drawing.Point(320, 561)
        Me.btnLuuVaThoat.Name = "btnLuuVaThoat"
        Me.btnLuuVaThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.selected = False
        Me.btnLuuVaThoat.Size = New System.Drawing.Size(141, 41)
        Me.btnLuuVaThoat.TabIndex = 8
        Me.btnLuuVaThoat.Text = "Lưu và Thoát"
        Me.btnLuuVaThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuVaThoat.Textcolor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
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
        Me.btnThoat.Location = New System.Drawing.Point(523, 561)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(90, 41)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnXuatPhieuMuon
        '
        Me.btnXuatPhieuMuon.Activecolor = System.Drawing.Color.Silver
        Me.btnXuatPhieuMuon.BackColor = System.Drawing.Color.LightGray
        Me.btnXuatPhieuMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXuatPhieuMuon.BorderRadius = 7
        Me.btnXuatPhieuMuon.ButtonText = "Xuất phiếu mượn"
        Me.btnXuatPhieuMuon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXuatPhieuMuon.DisabledColor = System.Drawing.Color.Silver
        Me.btnXuatPhieuMuon.ForeColor = System.Drawing.Color.Black
        Me.btnXuatPhieuMuon.Iconcolor = System.Drawing.Color.Transparent
        Me.btnXuatPhieuMuon.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnXuatPhieuMuon.Iconimage_right = Nothing
        Me.btnXuatPhieuMuon.Iconimage_right_Selected = Nothing
        Me.btnXuatPhieuMuon.Iconimage_Selected = Nothing
        Me.btnXuatPhieuMuon.IconMarginLeft = 0
        Me.btnXuatPhieuMuon.IconMarginRight = 0
        Me.btnXuatPhieuMuon.IconRightVisible = True
        Me.btnXuatPhieuMuon.IconRightZoom = 0R
        Me.btnXuatPhieuMuon.IconVisible = True
        Me.btnXuatPhieuMuon.IconZoom = 60.0R
        Me.btnXuatPhieuMuon.IsTab = False
        Me.btnXuatPhieuMuon.Location = New System.Drawing.Point(87, 561)
        Me.btnXuatPhieuMuon.Name = "btnXuatPhieuMuon"
        Me.btnXuatPhieuMuon.Normalcolor = System.Drawing.Color.LightGray
        Me.btnXuatPhieuMuon.OnHovercolor = System.Drawing.Color.Gray
        Me.btnXuatPhieuMuon.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnXuatPhieuMuon.selected = False
        Me.btnXuatPhieuMuon.Size = New System.Drawing.Size(171, 41)
        Me.btnXuatPhieuMuon.TabIndex = 10
        Me.btnXuatPhieuMuon.Text = "Xuất phiếu mượn"
        Me.btnXuatPhieuMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnXuatPhieuMuon.Textcolor = System.Drawing.Color.Black
        Me.btnXuatPhieuMuon.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucChoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpNgayMuon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbMaDocGia)
        Me.Controls.Add(Me.btnLuuVaThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXuatPhieuMuon)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucChoMuonSach"
        Me.Size = New System.Drawing.Size(700, 624)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDSSachMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnThemMaSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLuuVaThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnXuatPhieuMuon As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents tbMaDocGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lbHoTen As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents dtpNgayMuon As Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents lbTinhTrang As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents lbNgayLap As Windows.Forms.Label
    Friend WithEvents dgDSSachMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianMuon As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents tbMaSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgDanhSachSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnThemMaSach As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents lbTrangThaiThem As Windows.Forms.Label
    Friend WithEvents STT As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TacGia As Windows.Forms.DataGridViewTextBoxColumn
End Class