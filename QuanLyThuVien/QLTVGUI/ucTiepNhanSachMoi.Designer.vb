<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTiepNhanSachMoi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMaDocGia = New System.Windows.Forms.Label()
        Me.nudNamXuatBan = New System.Windows.Forms.NumericUpDown()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLapThe = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbHoTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tbTriGia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.clbDSNhaXuatBan = New System.Windows.Forms.CheckedListBox()
        Me.btnAddNhaXuatBan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cbNhaXuatBan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.clbDSTacGia = New System.Windows.Forms.CheckedListBox()
        Me.btnAddTacGia = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cbTacGia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clbDSTheLoai = New System.Windows.Forms.CheckedListBox()
        Me.btAddTheLoai = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLuuVaThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuu = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.btnAddNhaXuatBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.btnAddTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(246, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TIẾP NHẬN SÁCH MỚI"
        '
        'lbMaDocGia
        '
        Me.lbMaDocGia.AutoSize = True
        Me.lbMaDocGia.BackColor = System.Drawing.Color.Gainsboro
        Me.lbMaDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbMaDocGia.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbMaDocGia.ForeColor = System.Drawing.Color.Red
        Me.lbMaDocGia.Location = New System.Drawing.Point(235, 76)
        Me.lbMaDocGia.Name = "lbMaDocGia"
        Me.lbMaDocGia.Size = New System.Drawing.Size(65, 21)
        Me.lbMaDocGia.TabIndex = 19
        Me.lbMaDocGia.Text = "MaSach"
        '
        'nudNamXuatBan
        '
        Me.nudNamXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudNamXuatBan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nudNamXuatBan.Location = New System.Drawing.Point(235, 679)
        Me.nudNamXuatBan.Name = "nudNamXuatBan"
        Me.nudNamXuatBan.Size = New System.Drawing.Size(80, 29)
        Me.nudNamXuatBan.TabIndex = 45
        Me.nudNamXuatBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbTheLoai
        '
        Me.cbTheLoai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(157, 33)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(196, 25)
        Me.cbTheLoai.TabIndex = 44
        '
        'dtpNgayLapThe
        '
        Me.dtpNgayLapThe.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpNgayLapThe.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpNgayLapThe.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.dtpNgayLapThe.CustomFormat = "ddddddddd, dd/MM/yyyy"
        Me.dtpNgayLapThe.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dtpNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLapThe.Location = New System.Drawing.Point(235, 717)
        Me.dtpNgayLapThe.Name = "dtpNgayLapThe"
        Me.dtpNgayLapThe.Size = New System.Drawing.Size(221, 29)
        Me.dtpNgayLapThe.TabIndex = 41
        Me.dtpNgayLapThe.Value = New Date(2018, 6, 23, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(115, 721)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Ngày nhập:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(94, 681)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Năm xuất bản:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(466, 760)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "VND"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(149, 761)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Trị giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(134, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Mã sách:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(133, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tên sách:"
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
        Me.tbHoTen.Location = New System.Drawing.Point(235, 106)
        Me.tbHoTen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHoTen.Name = "tbHoTen"
        Me.tbHoTen.Size = New System.Drawing.Size(331, 36)
        Me.tbHoTen.TabIndex = 46
        Me.tbHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tbTriGia
        '
        Me.tbTriGia.AutoSize = True
        Me.tbTriGia.BackColor = System.Drawing.Color.White
        Me.tbTriGia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTriGia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.tbTriGia.ForeColor = System.Drawing.Color.Black
        Me.tbTriGia.HintForeColor = System.Drawing.Color.Empty
        Me.tbTriGia.HintText = ""
        Me.tbTriGia.isPassword = False
        Me.tbTriGia.LineFocusedColor = System.Drawing.Color.Gray
        Me.tbTriGia.LineIdleColor = System.Drawing.Color.Silver
        Me.tbTriGia.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.tbTriGia.LineThickness = 2
        Me.tbTriGia.Location = New System.Drawing.Point(235, 750)
        Me.tbTriGia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTriGia.Name = "tbTriGia"
        Me.tbTriGia.Size = New System.Drawing.Size(221, 36)
        Me.tbTriGia.TabIndex = 46
        Me.tbTriGia.Text = "0"
        Me.tbTriGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(48, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 762)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.clbDSNhaXuatBan)
        Me.GroupBox4.Controls.Add(Me.btnAddNhaXuatBan)
        Me.GroupBox4.Controls.Add(Me.cbNhaXuatBan)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(89, 446)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 154)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nhà xuất bản:"
        '
        'clbDSNhaXuatBan
        '
        Me.clbDSNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clbDSNhaXuatBan.FormattingEnabled = True
        Me.clbDSNhaXuatBan.Location = New System.Drawing.Point(159, 72)
        Me.clbDSNhaXuatBan.Name = "clbDSNhaXuatBan"
        Me.clbDSNhaXuatBan.Size = New System.Drawing.Size(196, 64)
        Me.clbDSNhaXuatBan.TabIndex = 46
        '
        'btnAddNhaXuatBan
        '
        Me.btnAddNhaXuatBan.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNhaXuatBan.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btnAddNhaXuatBan.ImageActive = Nothing
        Me.btnAddNhaXuatBan.Location = New System.Drawing.Point(361, 28)
        Me.btnAddNhaXuatBan.Name = "btnAddNhaXuatBan"
        Me.btnAddNhaXuatBan.Size = New System.Drawing.Size(30, 33)
        Me.btnAddNhaXuatBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddNhaXuatBan.TabIndex = 45
        Me.btnAddNhaXuatBan.TabStop = False
        Me.btnAddNhaXuatBan.Zoom = 10
        '
        'cbNhaXuatBan
        '
        Me.cbNhaXuatBan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbNhaXuatBan.FormattingEnabled = True
        Me.cbNhaXuatBan.Location = New System.Drawing.Point(159, 33)
        Me.cbNhaXuatBan.Name = "cbNhaXuatBan"
        Me.cbNhaXuatBan.Size = New System.Drawing.Size(196, 25)
        Me.cbNhaXuatBan.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Thêm nhà xuất bản:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(63, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Danh sách:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.clbDSTacGia)
        Me.GroupBox3.Controls.Add(Me.btnAddTacGia)
        Me.GroupBox3.Controls.Add(Me.cbTacGia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(89, 278)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 154)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tác giả:"
        '
        'clbDSTacGia
        '
        Me.clbDSTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clbDSTacGia.FormattingEnabled = True
        Me.clbDSTacGia.Location = New System.Drawing.Point(159, 72)
        Me.clbDSTacGia.Name = "clbDSTacGia"
        Me.clbDSTacGia.Size = New System.Drawing.Size(196, 64)
        Me.clbDSTacGia.TabIndex = 46
        '
        'btnAddTacGia
        '
        Me.btnAddTacGia.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTacGia.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btnAddTacGia.ImageActive = Nothing
        Me.btnAddTacGia.Location = New System.Drawing.Point(361, 28)
        Me.btnAddTacGia.Name = "btnAddTacGia"
        Me.btnAddTacGia.Size = New System.Drawing.Size(30, 33)
        Me.btnAddTacGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddTacGia.TabIndex = 45
        Me.btnAddTacGia.TabStop = False
        Me.btnAddTacGia.Zoom = 10
        '
        'cbTacGia
        '
        Me.cbTacGia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTacGia.FormattingEnabled = True
        Me.cbTacGia.Location = New System.Drawing.Point(159, 33)
        Me.cbTacGia.Name = "cbTacGia"
        Me.cbTacGia.Size = New System.Drawing.Size(196, 25)
        Me.cbTacGia.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(49, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 19)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Thêm tác giả:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(63, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Danh sách:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clbDSTheLoai)
        Me.GroupBox2.Controls.Add(Me.btAddTheLoai)
        Me.GroupBox2.Controls.Add(Me.cbTheLoai)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(89, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 154)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thể loại:"
        '
        'clbDSTheLoai
        '
        Me.clbDSTheLoai.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clbDSTheLoai.FormattingEnabled = True
        Me.clbDSTheLoai.Location = New System.Drawing.Point(157, 70)
        Me.clbDSTheLoai.Name = "clbDSTheLoai"
        Me.clbDSTheLoai.Size = New System.Drawing.Size(196, 64)
        Me.clbDSTheLoai.TabIndex = 46
        '
        'btAddTheLoai
        '
        Me.btAddTheLoai.BackColor = System.Drawing.Color.Transparent
        Me.btAddTheLoai.Image = Global.QLTVGUI.My.Resources.Resources.add_circle_grey_48x48
        Me.btAddTheLoai.ImageActive = Nothing
        Me.btAddTheLoai.Location = New System.Drawing.Point(359, 28)
        Me.btAddTheLoai.Name = "btAddTheLoai"
        Me.btAddTheLoai.Size = New System.Drawing.Size(30, 33)
        Me.btAddTheLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btAddTheLoai.TabIndex = 45
        Me.btAddTheLoai.TabStop = False
        Me.btAddTheLoai.Zoom = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(45, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Thêm thể loại:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(63, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Danh sách:"
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
        Me.btnLuuVaThoat.Location = New System.Drawing.Point(281, 838)
        Me.btnLuuVaThoat.Name = "btnLuuVaThoat"
        Me.btnLuuVaThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuVaThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuVaThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuVaThoat.selected = False
        Me.btnLuuVaThoat.Size = New System.Drawing.Size(141, 41)
        Me.btnLuuVaThoat.TabIndex = 23
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
        Me.btnThoat.Location = New System.Drawing.Point(492, 838)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(90, 41)
        Me.btnThoat.TabIndex = 24
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
        Me.btnLuu.ButtonText = "Lưu"
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
        Me.btnLuu.Location = New System.Drawing.Point(121, 838)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuu.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuu.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuu.selected = False
        Me.btnLuu.Size = New System.Drawing.Size(90, 41)
        Me.btnLuu.TabIndex = 25
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuu.Textcolor = System.Drawing.Color.Black
        Me.btnLuu.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'ucTiepNhanSachMoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.tbTriGia)
        Me.Controls.Add(Me.tbHoTen)
        Me.Controls.Add(Me.nudNamXuatBan)
        Me.Controls.Add(Me.dtpNgayLapThe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLuuVaThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.lbMaDocGia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucTiepNhanSachMoi"
        Me.Size = New System.Drawing.Size(700, 900)
        CType(Me.nudNamXuatBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.btnAddNhaXuatBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.btnAddTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btAddTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMaDocGia As System.Windows.Forms.Label
    Friend WithEvents btnLuu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuuVaThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents nudNamXuatBan As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbTheLoai As System.Windows.Forms.ComboBox
    Friend WithEvents dtpNgayLapThe As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbHoTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tbTriGia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clbDSTheLoai As System.Windows.Forms.CheckedListBox
    Friend WithEvents btAddTheLoai As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents clbDSNhaXuatBan As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAddNhaXuatBan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cbNhaXuatBan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents clbDSTacGia As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAddTacGia As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cbTacGia As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
