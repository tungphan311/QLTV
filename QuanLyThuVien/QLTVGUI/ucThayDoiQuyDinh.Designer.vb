<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThayDoiQuyDinh
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbThoiHanThe = New System.Windows.Forms.Label()
        Me.lbTuoiToiDa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTuoiToiThieu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnThayDoiQD1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnQD1 = New System.Windows.Forms.Panel()
        Me.nudTuoiToiThieu = New System.Windows.Forms.NumericUpDown()
        Me.nudTuoiToiDa = New System.Windows.Forms.NumericUpDown()
        Me.nudThoiHanThe = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbKhoangCachNam = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbSoLuongLoai = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnThayDoiQD2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudKhoangCachNam = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbThoiGianToiDa = New System.Windows.Forms.Label()
        Me.lbSachToiDa = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnThayDoiQD3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudSachToiDa = New System.Windows.Forms.NumericUpDown()
        Me.nudThoiGianToiDa = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgDSTheLoai = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenTheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThoat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLuuThayDoi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.fpnDSTheLoai = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.pnQD1.SuspendLayout()
        CType(Me.nudTuoiToiThieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTuoiToiDa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThoiHanThe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudKhoangCachNam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudSachToiDa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThoiGianToiDa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDSTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(244, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "THAY ĐỔI QUY ĐỊNH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnQD1)
        Me.GroupBox1.Controls.Add(Me.btnThayDoiQD1)
        Me.GroupBox1.Controls.Add(Me.lbThoiHanThe)
        Me.GroupBox1.Controls.Add(Me.lbTuoiToiDa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbTuoiToiThieu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(103, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 133)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quy định 1:"
        '
        'lbThoiHanThe
        '
        Me.lbThoiHanThe.AutoSize = True
        Me.lbThoiHanThe.BackColor = System.Drawing.Color.Transparent
        Me.lbThoiHanThe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThoiHanThe.ForeColor = System.Drawing.Color.Blue
        Me.lbThoiHanThe.Location = New System.Drawing.Point(136, 93)
        Me.lbThoiHanThe.Name = "lbThoiHanThe"
        Me.lbThoiHanThe.Size = New System.Drawing.Size(39, 17)
        Me.lbThoiHanThe.TabIndex = 2
        Me.lbThoiHanThe.Text = "Value"
        '
        'lbTuoiToiDa
        '
        Me.lbTuoiToiDa.AutoSize = True
        Me.lbTuoiToiDa.BackColor = System.Drawing.Color.Transparent
        Me.lbTuoiToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTuoiToiDa.ForeColor = System.Drawing.Color.Blue
        Me.lbTuoiToiDa.Location = New System.Drawing.Point(136, 65)
        Me.lbTuoiToiDa.Name = "lbTuoiToiDa"
        Me.lbTuoiToiDa.Size = New System.Drawing.Size(39, 17)
        Me.lbTuoiToiDa.TabIndex = 2
        Me.lbTuoiToiDa.Text = "Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(29, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Thời hạn thẻ:"
        '
        'lbTuoiToiThieu
        '
        Me.lbTuoiToiThieu.AutoSize = True
        Me.lbTuoiToiThieu.BackColor = System.Drawing.Color.Transparent
        Me.lbTuoiToiThieu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTuoiToiThieu.ForeColor = System.Drawing.Color.Blue
        Me.lbTuoiToiThieu.Location = New System.Drawing.Point(136, 37)
        Me.lbTuoiToiThieu.Name = "lbTuoiToiThieu"
        Me.lbTuoiToiThieu.Size = New System.Drawing.Size(39, 17)
        Me.lbTuoiToiThieu.TabIndex = 2
        Me.lbTuoiToiThieu.Text = "Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(29, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tuổi tối đa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(29, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tuổi tối thiểu:"
        '
        'btnThayDoiQD1
        '
        Me.btnThayDoiQD1.Activecolor = System.Drawing.Color.DimGray
        Me.btnThayDoiQD1.BackColor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThayDoiQD1.BorderRadius = 7
        Me.btnThayDoiQD1.ButtonText = "Thay đổi"
        Me.btnThayDoiQD1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThayDoiQD1.DisabledColor = System.Drawing.Color.Gray
        Me.btnThayDoiQD1.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThayDoiQD1.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Support_64
        Me.btnThayDoiQD1.Iconimage_right = Nothing
        Me.btnThayDoiQD1.Iconimage_right_Selected = Nothing
        Me.btnThayDoiQD1.Iconimage_Selected = Nothing
        Me.btnThayDoiQD1.IconMarginLeft = 0
        Me.btnThayDoiQD1.IconMarginRight = 0
        Me.btnThayDoiQD1.IconRightVisible = True
        Me.btnThayDoiQD1.IconRightZoom = 0R
        Me.btnThayDoiQD1.IconVisible = True
        Me.btnThayDoiQD1.IconZoom = 50.0R
        Me.btnThayDoiQD1.IsTab = False
        Me.btnThayDoiQD1.Location = New System.Drawing.Point(199, 60)
        Me.btnThayDoiQD1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThayDoiQD1.Name = "btnThayDoiQD1"
        Me.btnThayDoiQD1.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD1.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btnThayDoiQD1.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThayDoiQD1.selected = False
        Me.btnThayDoiQD1.Size = New System.Drawing.Size(94, 26)
        Me.btnThayDoiQD1.TabIndex = 5
        Me.btnThayDoiQD1.Text = "Thay đổi"
        Me.btnThayDoiQD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThayDoiQD1.Textcolor = System.Drawing.Color.Black
        Me.btnThayDoiQD1.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tuổi tối thiểu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(14, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tuổi tối đa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(14, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Thời hạn thẻ:"
        '
        'pnQD1
        '
        Me.pnQD1.Controls.Add(Me.nudThoiHanThe)
        Me.pnQD1.Controls.Add(Me.nudTuoiToiDa)
        Me.pnQD1.Controls.Add(Me.nudTuoiToiThieu)
        Me.pnQD1.Controls.Add(Me.Label5)
        Me.pnQD1.Controls.Add(Me.Label6)
        Me.pnQD1.Controls.Add(Me.Label7)
        Me.pnQD1.Location = New System.Drawing.Point(300, 16)
        Me.pnQD1.Name = "pnQD1"
        Me.pnQD1.Size = New System.Drawing.Size(186, 111)
        Me.pnQD1.TabIndex = 6
        '
        'nudTuoiToiThieu
        '
        Me.nudTuoiToiThieu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTuoiToiThieu.Location = New System.Drawing.Point(120, 20)
        Me.nudTuoiToiThieu.Name = "nudTuoiToiThieu"
        Me.nudTuoiToiThieu.Size = New System.Drawing.Size(41, 25)
        Me.nudTuoiToiThieu.TabIndex = 3
        Me.nudTuoiToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudTuoiToiDa
        '
        Me.nudTuoiToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTuoiToiDa.Location = New System.Drawing.Point(120, 48)
        Me.nudTuoiToiDa.Name = "nudTuoiToiDa"
        Me.nudTuoiToiDa.Size = New System.Drawing.Size(41, 25)
        Me.nudTuoiToiDa.TabIndex = 3
        Me.nudTuoiToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudThoiHanThe
        '
        Me.nudThoiHanThe.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudThoiHanThe.Location = New System.Drawing.Point(120, 76)
        Me.nudThoiHanThe.Name = "nudThoiHanThe"
        Me.nudThoiHanThe.Size = New System.Drawing.Size(41, 25)
        Me.nudThoiHanThe.TabIndex = 3
        Me.nudThoiHanThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.fpnDSTheLoai)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbSoLuongLoai)
        Me.GroupBox2.Controls.Add(Me.lbKhoangCachNam)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(103, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 293)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quy định 2:"
        '
        'lbKhoangCachNam
        '
        Me.lbKhoangCachNam.AutoSize = True
        Me.lbKhoangCachNam.BackColor = System.Drawing.Color.Transparent
        Me.lbKhoangCachNam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKhoangCachNam.ForeColor = System.Drawing.Color.Blue
        Me.lbKhoangCachNam.Location = New System.Drawing.Point(218, 36)
        Me.lbKhoangCachNam.Name = "lbKhoangCachNam"
        Me.lbKhoangCachNam.Size = New System.Drawing.Size(39, 17)
        Me.lbKhoangCachNam.TabIndex = 2
        Me.lbKhoangCachNam.Text = "Value"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(29, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Khoảng cách năm xuất bản:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(29, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Số lượng thể loại sách:"
        '
        'lbSoLuongLoai
        '
        Me.lbSoLuongLoai.AutoSize = True
        Me.lbSoLuongLoai.BackColor = System.Drawing.Color.Transparent
        Me.lbSoLuongLoai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSoLuongLoai.ForeColor = System.Drawing.Color.Blue
        Me.lbSoLuongLoai.Location = New System.Drawing.Point(218, 63)
        Me.lbSoLuongLoai.Name = "lbSoLuongLoai"
        Me.lbSoLuongLoai.Size = New System.Drawing.Size(39, 17)
        Me.lbSoLuongLoai.TabIndex = 2
        Me.lbSoLuongLoai.Text = "Value"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(29, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Danh sách thể loại:"
        '
        'btnThayDoiQD2
        '
        Me.btnThayDoiQD2.Activecolor = System.Drawing.Color.DimGray
        Me.btnThayDoiQD2.BackColor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThayDoiQD2.BorderRadius = 7
        Me.btnThayDoiQD2.ButtonText = "Thay đổi"
        Me.btnThayDoiQD2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThayDoiQD2.DisabledColor = System.Drawing.Color.Gray
        Me.btnThayDoiQD2.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThayDoiQD2.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Support_64
        Me.btnThayDoiQD2.Iconimage_right = Nothing
        Me.btnThayDoiQD2.Iconimage_right_Selected = Nothing
        Me.btnThayDoiQD2.Iconimage_Selected = Nothing
        Me.btnThayDoiQD2.IconMarginLeft = 0
        Me.btnThayDoiQD2.IconMarginRight = 0
        Me.btnThayDoiQD2.IconRightVisible = True
        Me.btnThayDoiQD2.IconRightZoom = 0R
        Me.btnThayDoiQD2.IconVisible = True
        Me.btnThayDoiQD2.IconZoom = 50.0R
        Me.btnThayDoiQD2.IsTab = False
        Me.btnThayDoiQD2.Location = New System.Drawing.Point(303, 340)
        Me.btnThayDoiQD2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnThayDoiQD2.Name = "btnThayDoiQD2"
        Me.btnThayDoiQD2.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD2.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btnThayDoiQD2.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThayDoiQD2.selected = False
        Me.btnThayDoiQD2.Size = New System.Drawing.Size(94, 26)
        Me.btnThayDoiQD2.TabIndex = 8
        Me.btnThayDoiQD2.Text = "Thay đổi"
        Me.btnThayDoiQD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThayDoiQD2.Textcolor = System.Drawing.Color.Black
        Me.btnThayDoiQD2.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.dgDSTheLoai)
        Me.Panel1.Controls.Add(Me.nudKhoangCachNam)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(6, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 104)
        Me.Panel1.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(23, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Khoảng cách năm xuất bản:"
        '
        'nudKhoangCachNam
        '
        Me.nudKhoangCachNam.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.nudKhoangCachNam.Location = New System.Drawing.Point(215, 9)
        Me.nudKhoangCachNam.Name = "nudKhoangCachNam"
        Me.nudKhoangCachNam.Size = New System.Drawing.Size(41, 25)
        Me.nudKhoangCachNam.TabIndex = 4
        Me.nudKhoangCachNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nudThoiGianToiDa)
        Me.GroupBox3.Controls.Add(Me.nudSachToiDa)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.lbThoiGianToiDa)
        Me.GroupBox3.Controls.Add(Me.btnThayDoiQD3)
        Me.GroupBox3.Controls.Add(Me.lbSachToiDa)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(103, 511)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 200)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quy định 3:"
        '
        'lbThoiGianToiDa
        '
        Me.lbThoiGianToiDa.AutoSize = True
        Me.lbThoiGianToiDa.BackColor = System.Drawing.Color.Transparent
        Me.lbThoiGianToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbThoiGianToiDa.ForeColor = System.Drawing.Color.Blue
        Me.lbThoiGianToiDa.Location = New System.Drawing.Point(218, 65)
        Me.lbThoiGianToiDa.Name = "lbThoiGianToiDa"
        Me.lbThoiGianToiDa.Size = New System.Drawing.Size(39, 17)
        Me.lbThoiGianToiDa.TabIndex = 2
        Me.lbThoiGianToiDa.Text = "Value"
        '
        'lbSachToiDa
        '
        Me.lbSachToiDa.AutoSize = True
        Me.lbSachToiDa.BackColor = System.Drawing.Color.Transparent
        Me.lbSachToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSachToiDa.ForeColor = System.Drawing.Color.Blue
        Me.lbSachToiDa.Location = New System.Drawing.Point(218, 37)
        Me.lbSachToiDa.Name = "lbSachToiDa"
        Me.lbSachToiDa.Size = New System.Drawing.Size(39, 17)
        Me.lbSachToiDa.TabIndex = 2
        Me.lbSachToiDa.Text = "Value"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(29, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(141, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Thời gian mượn tối đa:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(29, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(170, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Số lượng sách mượn tối đa:"
        '
        'btnThayDoiQD3
        '
        Me.btnThayDoiQD3.Activecolor = System.Drawing.Color.DimGray
        Me.btnThayDoiQD3.BackColor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThayDoiQD3.BorderRadius = 7
        Me.btnThayDoiQD3.ButtonText = "Thay đổi"
        Me.btnThayDoiQD3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThayDoiQD3.DisabledColor = System.Drawing.Color.Gray
        Me.btnThayDoiQD3.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThayDoiQD3.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Support_64
        Me.btnThayDoiQD3.Iconimage_right = Nothing
        Me.btnThayDoiQD3.Iconimage_right_Selected = Nothing
        Me.btnThayDoiQD3.Iconimage_Selected = Nothing
        Me.btnThayDoiQD3.IconMarginLeft = 0
        Me.btnThayDoiQD3.IconMarginRight = 0
        Me.btnThayDoiQD3.IconRightVisible = True
        Me.btnThayDoiQD3.IconRightZoom = 0R
        Me.btnThayDoiQD3.IconVisible = True
        Me.btnThayDoiQD3.IconZoom = 50.0R
        Me.btnThayDoiQD3.IsTab = False
        Me.btnThayDoiQD3.Location = New System.Drawing.Point(199, 92)
        Me.btnThayDoiQD3.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btnThayDoiQD3.Name = "btnThayDoiQD3"
        Me.btnThayDoiQD3.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThayDoiQD3.OnHovercolor = System.Drawing.Color.DarkGray
        Me.btnThayDoiQD3.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThayDoiQD3.selected = False
        Me.btnThayDoiQD3.Size = New System.Drawing.Size(94, 26)
        Me.btnThayDoiQD3.TabIndex = 8
        Me.btnThayDoiQD3.Text = "Thay đổi"
        Me.btnThayDoiQD3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThayDoiQD3.Textcolor = System.Drawing.Color.Black
        Me.btnThayDoiQD3.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(29, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Thời gian mượn tối đa:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(29, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Số lượng sách mượn tối đa:"
        '
        'nudSachToiDa
        '
        Me.nudSachToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSachToiDa.Location = New System.Drawing.Point(221, 131)
        Me.nudSachToiDa.Name = "nudSachToiDa"
        Me.nudSachToiDa.Size = New System.Drawing.Size(41, 25)
        Me.nudSachToiDa.TabIndex = 11
        Me.nudSachToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudThoiGianToiDa
        '
        Me.nudThoiGianToiDa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudThoiGianToiDa.Location = New System.Drawing.Point(221, 159)
        Me.nudThoiGianToiDa.Name = "nudThoiGianToiDa"
        Me.nudThoiGianToiDa.Size = New System.Drawing.Size(41, 25)
        Me.nudThoiGianToiDa.TabIndex = 11
        Me.nudThoiGianToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(23, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Danh sách thể loại:"
        '
        'dgDSTheLoai
        '
        Me.dgDSTheLoai.AllowUserToResizeColumns = False
        Me.dgDSTheLoai.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDSTheLoai.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDSTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgDSTheLoai.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDSTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDSTheLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSTheLoai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDSTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSTheLoai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.MaTheLoai, Me.TenTheLoai})
        Me.dgDSTheLoai.DoubleBuffered = True
        Me.dgDSTheLoai.EnableHeadersVisualStyles = False
        Me.dgDSTheLoai.GridColor = System.Drawing.Color.Gray
        Me.dgDSTheLoai.HeaderBgColor = System.Drawing.Color.DarkGray
        Me.dgDSTheLoai.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDSTheLoai.Location = New System.Drawing.Point(2, 66)
        Me.dgDSTheLoai.Name = "dgDSTheLoai"
        Me.dgDSTheLoai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDSTheLoai.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgDSTheLoai.Size = New System.Drawing.Size(477, 25)
        Me.dgDSTheLoai.TabIndex = 73
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "STT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'MaTheLoai
        '
        Me.MaTheLoai.Frozen = True
        Me.MaTheLoai.HeaderText = "Mã Thể Loại"
        Me.MaTheLoai.Name = "MaTheLoai"
        Me.MaTheLoai.Width = 150
        '
        'TenTheLoai
        '
        Me.TenTheLoai.Frozen = True
        Me.TenTheLoai.HeaderText = "Tên Thể Loại"
        Me.TenTheLoai.Name = "TenTheLoai"
        Me.TenTheLoai.Width = 245
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
        Me.btnThoat.Location = New System.Drawing.Point(451, 742)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThoat.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThoat.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnThoat.selected = False
        Me.btnThoat.Size = New System.Drawing.Size(140, 41)
        Me.btnThoat.TabIndex = 36
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnThoat.Textcolor = System.Drawing.Color.Black
        Me.btnThoat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'btnLuuThayDoi
        '
        Me.btnLuuThayDoi.Activecolor = System.Drawing.Color.Silver
        Me.btnLuuThayDoi.BackColor = System.Drawing.Color.LightGray
        Me.btnLuuThayDoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuuThayDoi.BorderRadius = 7
        Me.btnLuuThayDoi.ButtonText = "Lưu thay đổi"
        Me.btnLuuThayDoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLuuThayDoi.DisabledColor = System.Drawing.Color.Silver
        Me.btnLuuThayDoi.ForeColor = System.Drawing.Color.Black
        Me.btnLuuThayDoi.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLuuThayDoi.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Save_64
        Me.btnLuuThayDoi.Iconimage_right = Nothing
        Me.btnLuuThayDoi.Iconimage_right_Selected = Nothing
        Me.btnLuuThayDoi.Iconimage_Selected = Nothing
        Me.btnLuuThayDoi.IconMarginLeft = 0
        Me.btnLuuThayDoi.IconMarginRight = 0
        Me.btnLuuThayDoi.IconRightVisible = True
        Me.btnLuuThayDoi.IconRightZoom = 0R
        Me.btnLuuThayDoi.IconVisible = True
        Me.btnLuuThayDoi.IconZoom = 60.0R
        Me.btnLuuThayDoi.IsTab = False
        Me.btnLuuThayDoi.Location = New System.Drawing.Point(109, 742)
        Me.btnLuuThayDoi.Name = "btnLuuThayDoi"
        Me.btnLuuThayDoi.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLuuThayDoi.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLuuThayDoi.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnLuuThayDoi.selected = False
        Me.btnLuuThayDoi.Size = New System.Drawing.Size(140, 41)
        Me.btnLuuThayDoi.TabIndex = 37
        Me.btnLuuThayDoi.Text = "Lưu thay đổi"
        Me.btnLuuThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLuuThayDoi.Textcolor = System.Drawing.Color.Black
        Me.btnLuuThayDoi.TextFont = New System.Drawing.Font("Segoe UI", 12.0!)
        '
        'fpnDSTheLoai
        '
        Me.fpnDSTheLoai.AutoSize = True
        Me.fpnDSTheLoai.Location = New System.Drawing.Point(221, 85)
        Me.fpnDSTheLoai.Name = "fpnDSTheLoai"
        Me.fpnDSTheLoai.Size = New System.Drawing.Size(200, 23)
        Me.fpnDSTheLoai.TabIndex = 5
        '
        'ucThayDoiQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnLuuThayDoi)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnThayDoiQD2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucThayDoiQuyDinh"
        Me.Size = New System.Drawing.Size(700, 800)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnQD1.ResumeLayout(False)
        Me.pnQD1.PerformLayout()
        CType(Me.nudTuoiToiThieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTuoiToiDa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThoiHanThe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudKhoangCachNam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudSachToiDa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThoiGianToiDa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDSTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lbThoiHanThe As Windows.Forms.Label
    Friend WithEvents lbTuoiToiDa As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lbTuoiToiThieu As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btnThayDoiQD1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents pnQD1 As Windows.Forms.Panel
    Friend WithEvents nudThoiHanThe As Windows.Forms.NumericUpDown
    Friend WithEvents nudTuoiToiDa As Windows.Forms.NumericUpDown
    Friend WithEvents nudTuoiToiThieu As Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents lbSoLuongLoai As Windows.Forms.Label
    Friend WithEvents lbKhoangCachNam As Windows.Forms.Label
    Friend WithEvents btnThayDoiQD2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents nudKhoangCachNam As Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents lbThoiGianToiDa As Windows.Forms.Label
    Friend WithEvents lbSachToiDa As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents nudThoiGianToiDa As Windows.Forms.NumericUpDown
    Friend WithEvents nudSachToiDa As Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents btnThayDoiQD3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents dgDSTheLoai As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaTheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenTheLoai As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fpnDSTheLoai As Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnThoat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLuuThayDoi As Bunifu.Framework.UI.BunifuFlatButton
End Class
