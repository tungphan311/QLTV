<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHoTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgrDSSachMuon = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianMuon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDanhSachSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLuuVaThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrDSSachMuon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tbHoTen
        '
        Me.tbHoTen.AutoSize = True
        Me.tbHoTen.BackColor = System.Drawing.Color.White
        Me.tbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbHoTen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbHoTen.ForeColor = System.Drawing.Color.Silver
        Me.tbHoTen.HintForeColor = System.Drawing.Color.Empty
        Me.tbHoTen.HintText = ""
        Me.tbHoTen.isPassword = False
        Me.tbHoTen.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineIdleColor = System.Drawing.Color.Silver
        Me.tbHoTen.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbHoTen.LineThickness = 2
        Me.tbHoTen.Location = New System.Drawing.Point(246, 119)
        Me.tbHoTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(112, 36)
        Me.tbHoTen.TabIndex = 12
        Me.tbHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(176, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Họ tên"
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
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayNhap.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayNhap.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayNhap.CustomFormat = "ddddddddd, dd/MM/yyyy"
        Me.dtpNgayNhap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNhap.Location = New System.Drawing.Point(245, 73)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(242, 29)
        Me.dtpNgayNhap.TabIndex = 75
        Me.dtpNgayNhap.Value = New Date(2018, 6, 23, 0, 0, 0, 0)
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dgrDSSachMuon)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 175)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(426, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Còn/Hết hạn"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(176, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Ngày lập"
        '
        'dgrDSSachMuon
        '
        Me.dgrDSSachMuon.AllowUserToAddRows = False
        Me.dgrDSSachMuon.AllowUserToDeleteRows = False
        Me.dgrDSSachMuon.AllowUserToResizeColumns = False
        Me.dgrDSSachMuon.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgrDSSachMuon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgrDSSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgrDSSachMuon.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgrDSSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrDSSachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrDSSachMuon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgrDSSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrDSSachMuon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ThoiGianMuon})
        Me.dgrDSSachMuon.DoubleBuffered = True
        Me.dgrDSSachMuon.EnableHeadersVisualStyles = False
        Me.dgrDSSachMuon.GridColor = System.Drawing.Color.Gray
        Me.dgrDSSachMuon.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgrDSSachMuon.HeaderForeColor = System.Drawing.Color.Black
        Me.dgrDSSachMuon.Location = New System.Drawing.Point(43, 113)
        Me.dgrDSSachMuon.Name = "dgrDSSachMuon"
        Me.dgrDSSachMuon.ReadOnly = True
        Me.dgrDSSachMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgrDSSachMuon.Size = New System.Drawing.Size(548, 23)
        Me.dgrDSSachMuon.TabIndex = 71
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
        Me.GroupBox2.Controls.Add(Me.BunifuImageButton1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 348)
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgDanhSachSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDanhSachSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSachSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSachSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSachSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSachSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSach, Me.TenSach, Me.TheLoai, Me.TacGia})
        Me.dgDanhSachSach.DoubleBuffered = True
        Me.dgDanhSachSach.EnableHeadersVisualStyles = False
        Me.dgDanhSachSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSachSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSachSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSachSach.Location = New System.Drawing.Point(0, 110)
        Me.dgDanhSachSach.Name = "dgDanhSachSach"
        Me.dgDanhSachSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgDanhSachSach.Size = New System.Drawing.Size(639, 48)
        Me.dgDanhSachSach.TabIndex = 72
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
        Me.TacGia.Width = 120
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(298, 28)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 31
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(176, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 19)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Thêm thành công/ thất bại (...)"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.AutoSize = True
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineThickness = 2
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(177, 28)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(112, 32)
        Me.BunifuMaterialTextbox1.TabIndex = 12
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'btnLuu
        '
        Me.btnLuu.Activecolor = System.Drawing.Color.Silver
        Me.btnLuu.BackColor = System.Drawing.Color.LightGray
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.BorderRadius = 7
        Me.btnLuu.ButtonText = "Xuất phiếu mượn"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnLuu.Iconimage_right = Nothing
        Me.btnLuu.Iconimage_right_Selected = Nothing
        Me.btnLuu.Iconimage_Selected = Nothing
        Me.btnLuu.IconMarginLeft = 0
        Me.btnLuu.IconMarginRight = 0
        Me.btnLuu.IconRightVisible = True
        Me.btnLuu.IconRightZoom = 0R
        Me.btnLuu.IconVisible = True
        Me.btnLuu.IconZoom = 60.0R
        Me.btnLuu.IsTab = False
        Me.btnLuu.Location = New System.Drawing.Point(87, 561)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(171, 41)
        Me.btnLuu.TabIndex = 10
        Me.btnLuu.Text = "Xuất phiếu mượn"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucChoMuonSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbHoTen)
        Me.Controls.Add(Me.btnLuuVaThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucChoMuonSach"
        Me.Size = New System.Drawing.Size(700, 624)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrDSSachMuon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLuuVaThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents tbHoTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents dtpNgayNhap As Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents dgrDSSachMuon As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianMuon As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgDanhSachSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents STT As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TacGia As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
End Class
