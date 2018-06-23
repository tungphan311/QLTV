<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnTaskBar = New System.Windows.Forms.Panel()
        Me.fpnZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnLapBaoCao = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhanTraSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChoMuonSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTraCuuSach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTiepNhanSachMoi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThayDoiQuyDinh = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLapTheDocGia = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.ibtnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ibtnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnTaskBar.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnTaskBar
        Me.BunifuDragControl1.Vertical = True
        '
        'pnTaskBar
        '
        Me.pnTaskBar.BackColor = System.Drawing.Color.LightGray
        Me.pnTaskBar.Controls.Add(Me.ibtnMinimize)
        Me.pnTaskBar.Controls.Add(Me.ibtnExit)
        Me.pnTaskBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTaskBar.Location = New System.Drawing.Point(0, 0)
        Me.pnTaskBar.Name = "pnTaskBar"
        Me.pnTaskBar.Size = New System.Drawing.Size(984, 29)
        Me.pnTaskBar.TabIndex = 2
        '
        'fpnZone
        '
        Me.fpnZone.AutoScroll = True
        Me.fpnZone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fpnZone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.fpnZone.Location = New System.Drawing.Point(252, 29)
        Me.fpnZone.Name = "fpnZone"
        Me.fpnZone.Size = New System.Drawing.Size(730, 530)
        Me.fpnZone.TabIndex = 1
        '
        'tbName
        '
        Me.tbName.AutoSize = True
        Me.tbName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbName.Location = New System.Drawing.Point(25, 111)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(199, 30)
        Me.tbName.TabIndex = 4
        Me.tbName.Text = "QUẢN LÝ THƯ VIỆN"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "________________________________"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuImageButton1.Image = Global.QLTVGUI.My.Resources.Resources.Books_96px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(85, 35)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(71, 71)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnLapBaoCao
        '
        Me.btnLapBaoCao.Activecolor = System.Drawing.Color.DimGray
        Me.btnLapBaoCao.BackColor = System.Drawing.Color.LightGray
        Me.btnLapBaoCao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLapBaoCao.BorderRadius = 7
        Me.btnLapBaoCao.ButtonText = "  Lập báo cáo"
        Me.btnLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLapBaoCao.DisabledColor = System.Drawing.Color.Silver
        Me.btnLapBaoCao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLapBaoCao.ForeColor = System.Drawing.Color.White
        Me.btnLapBaoCao.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLapBaoCao.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Combo_Chart_64
        Me.btnLapBaoCao.Iconimage_right = Nothing
        Me.btnLapBaoCao.Iconimage_right_Selected = Nothing
        Me.btnLapBaoCao.Iconimage_Selected = Nothing
        Me.btnLapBaoCao.IconMarginLeft = 0
        Me.btnLapBaoCao.IconMarginRight = 0
        Me.btnLapBaoCao.IconRightVisible = True
        Me.btnLapBaoCao.IconRightZoom = 0R
        Me.btnLapBaoCao.IconVisible = True
        Me.btnLapBaoCao.IconZoom = 70.0R
        Me.btnLapBaoCao.IsTab = True
        Me.btnLapBaoCao.Location = New System.Drawing.Point(15, 439)
        Me.btnLapBaoCao.Name = "btnLapBaoCao"
        Me.btnLapBaoCao.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLapBaoCao.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLapBaoCao.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLapBaoCao.selected = False
        Me.btnLapBaoCao.Size = New System.Drawing.Size(220, 48)
        Me.btnLapBaoCao.TabIndex = 6
        Me.btnLapBaoCao.Text = "  Lập báo cáo"
        Me.btnLapBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLapBaoCao.Textcolor = System.Drawing.Color.Black
        Me.btnLapBaoCao.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhanTraSach
        '
        Me.btnNhanTraSach.Activecolor = System.Drawing.Color.DimGray
        Me.btnNhanTraSach.BackColor = System.Drawing.Color.LightGray
        Me.btnNhanTraSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhanTraSach.BorderRadius = 7
        Me.btnNhanTraSach.ButtonText = "  Nhận trả sách"
        Me.btnNhanTraSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhanTraSach.DisabledColor = System.Drawing.Color.Silver
        Me.btnNhanTraSach.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhanTraSach.ForeColor = System.Drawing.Color.White
        Me.btnNhanTraSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhanTraSach.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Return_Book_64
        Me.btnNhanTraSach.Iconimage_right = Nothing
        Me.btnNhanTraSach.Iconimage_right_Selected = Nothing
        Me.btnNhanTraSach.Iconimage_Selected = Nothing
        Me.btnNhanTraSach.IconMarginLeft = 0
        Me.btnNhanTraSach.IconMarginRight = 0
        Me.btnNhanTraSach.IconRightVisible = True
        Me.btnNhanTraSach.IconRightZoom = 0R
        Me.btnNhanTraSach.IconVisible = True
        Me.btnNhanTraSach.IconZoom = 70.0R
        Me.btnNhanTraSach.IsTab = True
        Me.btnNhanTraSach.Location = New System.Drawing.Point(15, 386)
        Me.btnNhanTraSach.Name = "btnNhanTraSach"
        Me.btnNhanTraSach.Normalcolor = System.Drawing.Color.LightGray
        Me.btnNhanTraSach.OnHovercolor = System.Drawing.Color.Gray
        Me.btnNhanTraSach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNhanTraSach.selected = False
        Me.btnNhanTraSach.Size = New System.Drawing.Size(220, 48)
        Me.btnNhanTraSach.TabIndex = 5
        Me.btnNhanTraSach.Text = "  Nhận trả sách"
        Me.btnNhanTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhanTraSach.Textcolor = System.Drawing.Color.Black
        Me.btnNhanTraSach.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChoMuonSach
        '
        Me.btnChoMuonSach.Activecolor = System.Drawing.Color.DimGray
        Me.btnChoMuonSach.BackColor = System.Drawing.Color.LightGray
        Me.btnChoMuonSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChoMuonSach.BorderRadius = 7
        Me.btnChoMuonSach.ButtonText = "  Cho mượn sách"
        Me.btnChoMuonSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChoMuonSach.DisabledColor = System.Drawing.Color.Silver
        Me.btnChoMuonSach.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoMuonSach.ForeColor = System.Drawing.Color.White
        Me.btnChoMuonSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChoMuonSach.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Borrow_Book_64
        Me.btnChoMuonSach.Iconimage_right = Nothing
        Me.btnChoMuonSach.Iconimage_right_Selected = Nothing
        Me.btnChoMuonSach.Iconimage_Selected = Nothing
        Me.btnChoMuonSach.IconMarginLeft = 0
        Me.btnChoMuonSach.IconMarginRight = 0
        Me.btnChoMuonSach.IconRightVisible = True
        Me.btnChoMuonSach.IconRightZoom = 0R
        Me.btnChoMuonSach.IconVisible = True
        Me.btnChoMuonSach.IconZoom = 70.0R
        Me.btnChoMuonSach.IsTab = True
        Me.btnChoMuonSach.Location = New System.Drawing.Point(15, 333)
        Me.btnChoMuonSach.Name = "btnChoMuonSach"
        Me.btnChoMuonSach.Normalcolor = System.Drawing.Color.LightGray
        Me.btnChoMuonSach.OnHovercolor = System.Drawing.Color.Gray
        Me.btnChoMuonSach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnChoMuonSach.selected = False
        Me.btnChoMuonSach.Size = New System.Drawing.Size(220, 48)
        Me.btnChoMuonSach.TabIndex = 4
        Me.btnChoMuonSach.Text = "  Cho mượn sách"
        Me.btnChoMuonSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChoMuonSach.Textcolor = System.Drawing.Color.Black
        Me.btnChoMuonSach.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTraCuuSach
        '
        Me.btnTraCuuSach.Activecolor = System.Drawing.Color.DimGray
        Me.btnTraCuuSach.BackColor = System.Drawing.Color.LightGray
        Me.btnTraCuuSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTraCuuSach.BorderRadius = 7
        Me.btnTraCuuSach.ButtonText = "  Tra cứu sách "
        Me.btnTraCuuSach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTraCuuSach.DisabledColor = System.Drawing.Color.Silver
        Me.btnTraCuuSach.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraCuuSach.ForeColor = System.Drawing.Color.White
        Me.btnTraCuuSach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTraCuuSach.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Search_64
        Me.btnTraCuuSach.Iconimage_right = Nothing
        Me.btnTraCuuSach.Iconimage_right_Selected = Nothing
        Me.btnTraCuuSach.Iconimage_Selected = Nothing
        Me.btnTraCuuSach.IconMarginLeft = 0
        Me.btnTraCuuSach.IconMarginRight = 0
        Me.btnTraCuuSach.IconRightVisible = True
        Me.btnTraCuuSach.IconRightZoom = 0R
        Me.btnTraCuuSach.IconVisible = True
        Me.btnTraCuuSach.IconZoom = 70.0R
        Me.btnTraCuuSach.IsTab = True
        Me.btnTraCuuSach.Location = New System.Drawing.Point(15, 280)
        Me.btnTraCuuSach.Name = "btnTraCuuSach"
        Me.btnTraCuuSach.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTraCuuSach.OnHovercolor = System.Drawing.Color.Gray
        Me.btnTraCuuSach.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTraCuuSach.selected = False
        Me.btnTraCuuSach.Size = New System.Drawing.Size(220, 48)
        Me.btnTraCuuSach.TabIndex = 3
        Me.btnTraCuuSach.Text = "  Tra cứu sách "
        Me.btnTraCuuSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTraCuuSach.Textcolor = System.Drawing.Color.Black
        Me.btnTraCuuSach.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTiepNhanSachMoi
        '
        Me.btnTiepNhanSachMoi.Activecolor = System.Drawing.Color.DimGray
        Me.btnTiepNhanSachMoi.BackColor = System.Drawing.Color.LightGray
        Me.btnTiepNhanSachMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTiepNhanSachMoi.BorderRadius = 7
        Me.btnTiepNhanSachMoi.ButtonText = "  Tiếp nhận sách mới"
        Me.btnTiepNhanSachMoi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTiepNhanSachMoi.DisabledColor = System.Drawing.Color.Silver
        Me.btnTiepNhanSachMoi.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiepNhanSachMoi.ForeColor = System.Drawing.Color.White
        Me.btnTiepNhanSachMoi.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTiepNhanSachMoi.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Remove_Book_64
        Me.btnTiepNhanSachMoi.Iconimage_right = Nothing
        Me.btnTiepNhanSachMoi.Iconimage_right_Selected = Nothing
        Me.btnTiepNhanSachMoi.Iconimage_Selected = Nothing
        Me.btnTiepNhanSachMoi.IconMarginLeft = 0
        Me.btnTiepNhanSachMoi.IconMarginRight = 0
        Me.btnTiepNhanSachMoi.IconRightVisible = True
        Me.btnTiepNhanSachMoi.IconRightZoom = 0R
        Me.btnTiepNhanSachMoi.IconVisible = True
        Me.btnTiepNhanSachMoi.IconZoom = 70.0R
        Me.btnTiepNhanSachMoi.IsTab = True
        Me.btnTiepNhanSachMoi.Location = New System.Drawing.Point(15, 227)
        Me.btnTiepNhanSachMoi.Name = "btnTiepNhanSachMoi"
        Me.btnTiepNhanSachMoi.Normalcolor = System.Drawing.Color.LightGray
        Me.btnTiepNhanSachMoi.OnHovercolor = System.Drawing.Color.Gray
        Me.btnTiepNhanSachMoi.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTiepNhanSachMoi.selected = False
        Me.btnTiepNhanSachMoi.Size = New System.Drawing.Size(220, 48)
        Me.btnTiepNhanSachMoi.TabIndex = 2
        Me.btnTiepNhanSachMoi.Text = "  Tiếp nhận sách mới"
        Me.btnTiepNhanSachMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTiepNhanSachMoi.Textcolor = System.Drawing.Color.Black
        Me.btnTiepNhanSachMoi.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnThayDoiQuyDinh
        '
        Me.btnThayDoiQuyDinh.Activecolor = System.Drawing.Color.DimGray
        Me.btnThayDoiQuyDinh.BackColor = System.Drawing.Color.LightGray
        Me.btnThayDoiQuyDinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThayDoiQuyDinh.BorderRadius = 7
        Me.btnThayDoiQuyDinh.ButtonText = "  Thay đổi quy định"
        Me.btnThayDoiQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThayDoiQuyDinh.DisabledColor = System.Drawing.Color.Silver
        Me.btnThayDoiQuyDinh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThayDoiQuyDinh.ForeColor = System.Drawing.Color.White
        Me.btnThayDoiQuyDinh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThayDoiQuyDinh.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Term_64
        Me.btnThayDoiQuyDinh.Iconimage_right = Nothing
        Me.btnThayDoiQuyDinh.Iconimage_right_Selected = Nothing
        Me.btnThayDoiQuyDinh.Iconimage_Selected = Nothing
        Me.btnThayDoiQuyDinh.IconMarginLeft = 0
        Me.btnThayDoiQuyDinh.IconMarginRight = 0
        Me.btnThayDoiQuyDinh.IconRightVisible = True
        Me.btnThayDoiQuyDinh.IconRightZoom = 0R
        Me.btnThayDoiQuyDinh.IconVisible = True
        Me.btnThayDoiQuyDinh.IconZoom = 70.0R
        Me.btnThayDoiQuyDinh.IsTab = True
        Me.btnThayDoiQuyDinh.Location = New System.Drawing.Point(15, 492)
        Me.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh"
        Me.btnThayDoiQuyDinh.Normalcolor = System.Drawing.Color.LightGray
        Me.btnThayDoiQuyDinh.OnHovercolor = System.Drawing.Color.Gray
        Me.btnThayDoiQuyDinh.OnHoverTextColor = System.Drawing.Color.White
        Me.btnThayDoiQuyDinh.selected = False
        Me.btnThayDoiQuyDinh.Size = New System.Drawing.Size(220, 48)
        Me.btnThayDoiQuyDinh.TabIndex = 7
        Me.btnThayDoiQuyDinh.Text = "  Thay đổi quy định"
        Me.btnThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThayDoiQuyDinh.Textcolor = System.Drawing.Color.Black
        Me.btnThayDoiQuyDinh.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLapTheDocGia
        '
        Me.btnLapTheDocGia.Activecolor = System.Drawing.Color.DimGray
        Me.btnLapTheDocGia.BackColor = System.Drawing.Color.LightGray
        Me.btnLapTheDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLapTheDocGia.BorderRadius = 7
        Me.btnLapTheDocGia.ButtonText = "  Lập thẻ độc giả"
        Me.btnLapTheDocGia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLapTheDocGia.DisabledColor = System.Drawing.Color.Silver
        Me.btnLapTheDocGia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLapTheDocGia.ForeColor = System.Drawing.Color.White
        Me.btnLapTheDocGia.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLapTheDocGia.Iconimage = Global.QLTVGUI.My.Resources.Resources.icons8_Add_User_Male_64
        Me.btnLapTheDocGia.Iconimage_right = Nothing
        Me.btnLapTheDocGia.Iconimage_right_Selected = Nothing
        Me.btnLapTheDocGia.Iconimage_Selected = Nothing
        Me.btnLapTheDocGia.IconMarginLeft = 0
        Me.btnLapTheDocGia.IconMarginRight = 0
        Me.btnLapTheDocGia.IconRightVisible = True
        Me.btnLapTheDocGia.IconRightZoom = 0R
        Me.btnLapTheDocGia.IconVisible = True
        Me.btnLapTheDocGia.IconZoom = 70.0R
        Me.btnLapTheDocGia.IsTab = True
        Me.btnLapTheDocGia.Location = New System.Drawing.Point(15, 174)
        Me.btnLapTheDocGia.Name = "btnLapTheDocGia"
        Me.btnLapTheDocGia.Normalcolor = System.Drawing.Color.LightGray
        Me.btnLapTheDocGia.OnHovercolor = System.Drawing.Color.Gray
        Me.btnLapTheDocGia.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLapTheDocGia.selected = False
        Me.btnLapTheDocGia.Size = New System.Drawing.Size(220, 48)
        Me.btnLapTheDocGia.TabIndex = 1
        Me.btnLapTheDocGia.Text = "  Lập thẻ độc giả"
        Me.btnLapTheDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLapTheDocGia.Textcolor = System.Drawing.Color.Black
        Me.btnLapTheDocGia.TextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pbMenu
        '
        Me.pbMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbMenu.Image = Global.QLTVGUI.My.Resources.Resources.blankpage1
        Me.pbMenu.Location = New System.Drawing.Point(0, 29)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(250, 532)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMenu.TabIndex = 0
        Me.pbMenu.TabStop = False
        '
        'ibtnMinimize
        '
        Me.ibtnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.ibtnMinimize.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Minimize_Window_64
        Me.ibtnMinimize.ImageActive = Nothing
        Me.ibtnMinimize.Location = New System.Drawing.Point(931, 2)
        Me.ibtnMinimize.Name = "ibtnMinimize"
        Me.ibtnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.ibtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibtnMinimize.TabIndex = 0
        Me.ibtnMinimize.TabStop = False
        Me.ibtnMinimize.Zoom = 25
        '
        'ibtnExit
        '
        Me.ibtnExit.BackColor = System.Drawing.Color.Transparent
        Me.ibtnExit.Image = Global.QLTVGUI.My.Resources.Resources.icons8_Close_Window_64
        Me.ibtnExit.ImageActive = Nothing
        Me.ibtnExit.Location = New System.Drawing.Point(956, 2)
        Me.ibtnExit.Name = "ibtnExit"
        Me.ibtnExit.Size = New System.Drawing.Size(25, 25)
        Me.ibtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ibtnExit.TabIndex = 0
        Me.ibtnExit.TabStop = False
        Me.ibtnExit.Zoom = 25
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.btnLapBaoCao)
        Me.Controls.Add(Me.btnNhanTraSach)
        Me.Controls.Add(Me.btnChoMuonSach)
        Me.Controls.Add(Me.btnTraCuuSach)
        Me.Controls.Add(Me.btnTiepNhanSachMoi)
        Me.Controls.Add(Me.btnThayDoiQuyDinh)
        Me.Controls.Add(Me.btnLapTheDocGia)
        Me.Controls.Add(Me.fpnZone)
        Me.Controls.Add(Me.pbMenu)
        Me.Controls.Add(Me.pnTaskBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUẢN LÝ THƯ VIỆN"
        Me.pnTaskBar.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbMenu As Windows.Forms.PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents fpnZone As Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnTaskBar As Windows.Forms.Panel
    Friend WithEvents ibtnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ibtnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tbName As Windows.Forms.Label
    Friend WithEvents btnLapTheDocGia As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTiepNhanSachMoi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTraCuuSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnChoMuonSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhanTraSach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLapBaoCao As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThayDoiQuyDinh As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
