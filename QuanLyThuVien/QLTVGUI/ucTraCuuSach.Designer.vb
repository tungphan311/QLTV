<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTraCuuSach
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTenSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.nudNamXuatBan = New System.Windows.Forms.NumericUpDown()
        Me.cbNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.cbTacGia = New System.Windows.Forms.ComboBox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMaSach = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbTriGia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTinhTrang = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDanhSachSach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamXuatBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TriGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(271, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 30)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "TRA CỨU SÁCH"
        '
        'tbTenSach
        '
        Me.tbTenSach.AutoSize = True
        Me.tbTenSach.BackColor = System.Drawing.Color.White
        Me.tbTenSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTenSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbTenSach.ForeColor = System.Drawing.Color.Silver
        Me.tbTenSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbTenSach.HintText = ""
        Me.tbTenSach.isPassword = False
        Me.tbTenSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTenSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTenSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTenSach.LineThickness = 2
        Me.tbTenSach.Location = New System.Drawing.Point(116, 112)
        Me.tbTenSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTenSach.Name = "tbTenSach"
        Me.tbTenSach.Size = New System.Drawing.Size(194, 36)
        Me.tbTenSach.TabIndex = 67
        Me.tbTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'nudNamXuatBan
        '
        Me.nudNamXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudNamXuatBan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudNamXuatBan.Location = New System.Drawing.Point(472, 157)
        Me.nudNamXuatBan.Name = "nudNamXuatBan"
        Me.nudNamXuatBan.Size = New System.Drawing.Size(80, 29)
        Me.nudNamXuatBan.TabIndex = 66
        Me.nudNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbNhaXuatBan
        '
        Me.cbNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbNhaXuatBan.FormattingEnabled = True
        Me.cbNhaXuatBan.Location = New System.Drawing.Point(472, 112)
        Me.cbNhaXuatBan.Name = "cbNhaXuatBan"
        Me.cbNhaXuatBan.Size = New System.Drawing.Size(194, 29)
        Me.cbNhaXuatBan.TabIndex = 65
        '
        'cbTacGia
        '
        Me.cbTacGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbTacGia.FormattingEnabled = True
        Me.cbTacGia.Location = New System.Drawing.Point(116, 205)
        Me.cbTacGia.Name = "cbTacGia"
        Me.cbTacGia.Size = New System.Drawing.Size(194, 29)
        Me.cbTacGia.TabIndex = 64
        '
        'cbTheLoai
        '
        Me.cbTheLoai.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(116, 162)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(194, 29)
        Me.cbTheLoai.TabIndex = 63
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayNhap.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayNhap.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayNhap.CustomFormat = "ddddddddd, dd/MM/yyyy"
        Me.dtpNgayNhap.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayNhap.Location = New System.Drawing.Point(472, 203)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(194, 29)
        Me.dtpNgayNhap.TabIndex = 62
        Me.dtpNgayNhap.Value = New Date(2018, 6, 23, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(377, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Ngày nhập:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(361, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Nhà xuất bản:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(356, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Năm xuất bản:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(411, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Trị giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Mã sách:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Tên sách:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(50, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Tác giả:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(42, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Thể loại:"
        '
        'tbMaSach
        '
        Me.tbMaSach.AutoSize = True
        Me.tbMaSach.BackColor = System.Drawing.Color.White
        Me.tbMaSach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMaSach.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbMaSach.ForeColor = System.Drawing.Color.Silver
        Me.tbMaSach.HintForeColor = System.Drawing.Color.Empty
        Me.tbMaSach.HintText = ""
        Me.tbMaSach.isPassword = False
        Me.tbMaSach.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbMaSach.LineIdleColor = System.Drawing.Color.Silver
        Me.tbMaSach.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbMaSach.LineThickness = 2
        Me.tbMaSach.Location = New System.Drawing.Point(116, 62)
        Me.tbMaSach.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMaSach.Name = "tbMaSach"
        Me.tbMaSach.Size = New System.Drawing.Size(95, 36)
        Me.tbMaSach.TabIndex = 67
        Me.tbMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbTriGia
        '
        Me.cbTriGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbTriGia.FormattingEnabled = True
        Me.cbTriGia.Location = New System.Drawing.Point(472, 249)
        Me.cbTriGia.Name = "cbTriGia"
        Me.cbTriGia.Size = New System.Drawing.Size(194, 29)
        Me.cbTriGia.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 21)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Tình trạng:"
        '
        'cbTinhTrang
        '
        Me.cbTinhTrang.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbTinhTrang.FormattingEnabled = True
        Me.cbTinhTrang.Location = New System.Drawing.Point(116, 248)
        Me.cbTinhTrang.Name = "cbTinhTrang"
        Me.cbTinhTrang.Size = New System.Drawing.Size(194, 29)
        Me.cbTinhTrang.TabIndex = 64
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(21, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 247)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'dgDanhSachSach
        '
        Me.dgDanhSachSach.AllowUserToAddRows = False
        Me.dgDanhSachSach.AllowUserToDeleteRows = False
        Me.dgDanhSachSach.AllowUserToResizeColumns = False
        Me.dgDanhSachSach.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgDanhSachSach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgDanhSachSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgDanhSachSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDanhSachSach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDanhSachSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDanhSachSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDanhSachSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSach, Me.TenSach, Me.TheLoai, Me.TacGia, Me.TinhTrang, Me.NhaXuatBan, Me.NamXuatBan, Me.NgayNhap, Me.TriGia})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDanhSachSach.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgDanhSachSach.DoubleBuffered = True
        Me.dgDanhSachSach.EnableHeadersVisualStyles = False
        Me.dgDanhSachSach.GridColor = System.Drawing.Color.Gray
        Me.dgDanhSachSach.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDanhSachSach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDanhSachSach.Location = New System.Drawing.Point(20, 351)
        Me.dgDanhSachSach.Name = "dgDanhSachSach"
        Me.dgDanhSachSach.ReadOnly = True
        Me.dgDanhSachSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDanhSachSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgDanhSachSach.Size = New System.Drawing.Size(659, 40)
        Me.dgDanhSachSach.TabIndex = 70
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
        Me.btnThoat.Location = New System.Drawing.Point(453, 470)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(140, 41)
        Me.btnThoat.TabIndex = 28
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
        Me.btnLuu.ButtonText = "Xuất kết quả"
        Me.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuu.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuu.ForeColor = System.Drawing.Color.Black
        Me.btnLuu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuu.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Download_64
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
        Me.btnLuu.Location = New System.Drawing.Point(107, 470)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(140, 41)
        Me.btnLuu.TabIndex = 29
        Me.btnLuu.Text = "Xuất kết quả"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(25, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 21)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Kết quả tra cứu:"
        '
        'STT
        '
        Me.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        Me.STT.Width = 40
        '
        'MaSach
        '
        Me.MaSach.FillWeight = 68.438!
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        Me.MaSach.Width = 85
        '
        'TenSach
        '
        Me.TenSach.FillWeight = 172.2419!
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        Me.TenSach.Width = 86
        '
        'TheLoai
        '
        Me.TheLoai.FillWeight = 90.76328!
        Me.TheLoai.HeaderText = "Thể Loại"
        Me.TheLoai.Name = "TheLoai"
        Me.TheLoai.ReadOnly = True
        Me.TheLoai.Width = 84
        '
        'TacGia
        '
        Me.TacGia.FillWeight = 93.9663!
        Me.TacGia.HeaderText = "Tác Giả"
        Me.TacGia.Name = "TacGia"
        Me.TacGia.ReadOnly = True
        Me.TacGia.Width = 75
        '
        'TinhTrang
        '
        Me.TinhTrang.FillWeight = 74.59055!
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.ReadOnly = True
        Me.TinhTrang.Width = 97
        '
        'NhaXuatBan
        '
        Me.NhaXuatBan.HeaderText = "Nhà Xuất Bản"
        Me.NhaXuatBan.Name = "NhaXuatBan"
        Me.NhaXuatBan.ReadOnly = True
        Me.NhaXuatBan.Width = 117
        '
        'NamXuatBan
        '
        Me.NamXuatBan.HeaderText = "Năm Xuất Bản"
        Me.NamXuatBan.Name = "NamXuatBan"
        Me.NamXuatBan.ReadOnly = True
        Me.NamXuatBan.Width = 121
        '
        'NgayNhap
        '
        Me.NgayNhap.HeaderText = "Ngày Nhập"
        Me.NgayNhap.Name = "NgayNhap"
        Me.NgayNhap.ReadOnly = True
        Me.NgayNhap.Width = 102
        '
        'TriGia
        '
        Me.TriGia.HeaderText = "Trị Giá"
        Me.TriGia.Name = "TriGia"
        Me.TriGia.ReadOnly = True
        Me.TriGia.Width = 71
        '
        'ucTraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.dgDanhSachSach)
        Me.Controls.Add(Me.tbMaSach)
        Me.Controls.Add(Me.tbTenSach)
        Me.Controls.Add(Me.nudNamXuatBan)
        Me.Controls.Add(Me.cbTriGia)
        Me.Controls.Add(Me.cbNhaXuatBan)
        Me.Controls.Add(Me.cbTinhTrang)
        Me.Controls.Add(Me.cbTacGia)
        Me.Controls.Add(Me.cbTheLoai)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucTraCuuSach"
        Me.Size = New System.Drawing.Size(700, 530)
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents tbTenSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents nudNamXuatBan As Windows.Forms.NumericUpDown
    Friend WithEvents cbNhaXuatBan As Windows.Forms.ComboBox
    Friend WithEvents cbTacGia As Windows.Forms.ComboBox
    Friend WithEvents cbTheLoai As Windows.Forms.ComboBox
    Friend WithEvents dtpNgayNhap As Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents tbMaSach As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbTriGia As Windows.Forms.ComboBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents cbTinhTrang As Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents dgDanhSachSach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents STT As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSach As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TacGia As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NhaXuatBan As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamXuatBan As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayNhap As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TriGia As Windows.Forms.DataGridViewTextBoxColumn
End Class
