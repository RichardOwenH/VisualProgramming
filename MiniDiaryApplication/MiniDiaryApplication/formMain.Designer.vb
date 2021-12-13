<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.menuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnOpen = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSbtnCut = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnCopy = New System.Windows.Forms.ToolStripButton()
        Me.TSbtnPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSbtnInfo = New System.Windows.Forms.ToolStripButton()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatToday = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stastTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statTimes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.timerNow = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LemonChiffon
        Me.MenuStrip1.Font = New System.Drawing.Font("Lemon Cake", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TSEdit, Me.TSDelete, Me.TSExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNew, Me.menuOpen, Me.toolStripSeparator, Me.menuSave})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'menuNew
        '
        Me.menuNew.Image = CType(resources.GetObject("menuNew.Image"), System.Drawing.Image)
        Me.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuNew.Name = "menuNew"
        Me.menuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuNew.Size = New System.Drawing.Size(224, 26)
        Me.menuNew.Text = "&New"
        '
        'menuOpen
        '
        Me.menuOpen.Image = CType(resources.GetObject("menuOpen.Image"), System.Drawing.Image)
        Me.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuOpen.Name = "menuOpen"
        Me.menuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuOpen.Size = New System.Drawing.Size(170, 26)
        Me.menuOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(167, 6)
        '
        'menuSave
        '
        Me.menuSave.Image = CType(resources.GetObject("menuSave.Image"), System.Drawing.Image)
        Me.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuSave.Name = "menuSave"
        Me.menuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuSave.Size = New System.Drawing.Size(170, 26)
        Me.menuSave.Text = "&Save"
        '
        'TSEdit
        '
        Me.TSEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUndo, Me.toolStripSeparator3, Me.menuCut, Me.menuCopy, Me.menuPaste, Me.toolStripSeparator4, Me.menuAll})
        Me.TSEdit.Name = "TSEdit"
        Me.TSEdit.Size = New System.Drawing.Size(48, 21)
        Me.TSEdit.Text = "&Edit"
        '
        'menuUndo
        '
        Me.menuUndo.Name = "menuUndo"
        Me.menuUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.menuUndo.Size = New System.Drawing.Size(224, 26)
        Me.menuUndo.Text = "&Undo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(176, 6)
        '
        'menuCut
        '
        Me.menuCut.Image = CType(resources.GetObject("menuCut.Image"), System.Drawing.Image)
        Me.menuCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuCut.Name = "menuCut"
        Me.menuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuCut.Size = New System.Drawing.Size(224, 26)
        Me.menuCut.Text = "Cu&t"
        '
        'menuCopy
        '
        Me.menuCopy.Image = CType(resources.GetObject("menuCopy.Image"), System.Drawing.Image)
        Me.menuCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuCopy.Name = "menuCopy"
        Me.menuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menuCopy.Size = New System.Drawing.Size(224, 26)
        Me.menuCopy.Text = "&Copy"
        '
        'menuPaste
        '
        Me.menuPaste.Image = CType(resources.GetObject("menuPaste.Image"), System.Drawing.Image)
        Me.menuPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuPaste.Name = "menuPaste"
        Me.menuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.menuPaste.Size = New System.Drawing.Size(224, 26)
        Me.menuPaste.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(176, 6)
        '
        'menuAll
        '
        Me.menuAll.Name = "menuAll"
        Me.menuAll.Size = New System.Drawing.Size(224, 26)
        Me.menuAll.Text = "Select &All"
        '
        'TSDelete
        '
        Me.TSDelete.Name = "TSDelete"
        Me.TSDelete.Size = New System.Drawing.Size(65, 24)
        Me.TSDelete.Text = "&Delete"
        '
        'TSExit
        '
        Me.TSExit.Name = "TSExit"
        Me.TSExit.Size = New System.Drawing.Size(46, 21)
        Me.TSExit.Text = "&Exit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LemonChiffon
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSbtnNew, Me.TSbtnOpen, Me.TSbtnSave, Me.toolStripSeparator1, Me.TSbtnCut, Me.TSbtnCopy, Me.TSbtnPaste, Me.toolStripSeparator2, Me.TSbtnInfo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSbtnNew
        '
        Me.TSbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnNew.Image = CType(resources.GetObject("TSbtnNew.Image"), System.Drawing.Image)
        Me.TSbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnNew.Name = "TSbtnNew"
        Me.TSbtnNew.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnNew.Text = "&New"
        '
        'TSbtnOpen
        '
        Me.TSbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnOpen.Image = CType(resources.GetObject("TSbtnOpen.Image"), System.Drawing.Image)
        Me.TSbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnOpen.Name = "TSbtnOpen"
        Me.TSbtnOpen.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnOpen.Text = "&Open"
        '
        'TSbtnSave
        '
        Me.TSbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnSave.Image = CType(resources.GetObject("TSbtnSave.Image"), System.Drawing.Image)
        Me.TSbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnSave.Name = "TSbtnSave"
        Me.TSbtnSave.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'TSbtnCut
        '
        Me.TSbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnCut.Image = CType(resources.GetObject("TSbtnCut.Image"), System.Drawing.Image)
        Me.TSbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnCut.Name = "TSbtnCut"
        Me.TSbtnCut.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnCut.Text = "C&ut"
        '
        'TSbtnCopy
        '
        Me.TSbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnCopy.Image = CType(resources.GetObject("TSbtnCopy.Image"), System.Drawing.Image)
        Me.TSbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnCopy.Name = "TSbtnCopy"
        Me.TSbtnCopy.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnCopy.Text = "&Copy"
        '
        'TSbtnPaste
        '
        Me.TSbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnPaste.Image = CType(resources.GetObject("TSbtnPaste.Image"), System.Drawing.Image)
        Me.TSbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnPaste.Name = "TSbtnPaste"
        Me.TSbtnPaste.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnPaste.Text = "&Paste"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TSbtnInfo
        '
        Me.TSbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnInfo.Image = CType(resources.GetObject("TSbtnInfo.Image"), System.Drawing.Image)
        Me.TSbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnInfo.Name = "TSbtnInfo"
        Me.TSbtnInfo.Size = New System.Drawing.Size(29, 24)
        Me.TSbtnInfo.Text = "He&lp"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Cornsilk
        Me.txtInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtInput.Font = New System.Drawing.Font("Tempus Sans ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(0, 0)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(430, 404)
        Me.txtInput.TabIndex = 4
        Me.txtInput.Text = "Input Your Text"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 65)
        Me.Panel1.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.ForeColor = System.Drawing.Color.RosyBrown
        Me.Panel5.Location = New System.Drawing.Point(0, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 3)
        Me.Panel5.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lemon Cake", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(333, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Today's Story"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Winston Andrews", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(634, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Diary"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LemonChiffon
        Me.StatusStrip1.Font = New System.Drawing.Font("Lemon Cake", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statDate, Me.StatToday, Me.stastTime, Me.statTimes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 531)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(798, 23)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statDate
        '
        Me.statDate.Margin = New System.Windows.Forms.Padding(380, 4, 0, 2)
        Me.statDate.Name = "statDate"
        Me.statDate.Size = New System.Drawing.Size(48, 17)
        Me.statDate.Text = "Date: "
        '
        'StatToday
        '
        Me.StatToday.Margin = New System.Windows.Forms.Padding(0, 4, 10, 2)
        Me.StatToday.Name = "StatToday"
        Me.StatToday.Size = New System.Drawing.Size(51, 17)
        Me.StatToday.Text = "Today"
        '
        'stastTime
        '
        Me.stastTime.Name = "stastTime"
        Me.stastTime.Size = New System.Drawing.Size(42, 17)
        Me.stastTime.Text = "Time:"
        '
        'statTimes
        '
        Me.statTimes.Margin = New System.Windows.Forms.Padding(0, 4, 10, 2)
        Me.statTimes.Name = "statTimes"
        Me.statTimes.Size = New System.Drawing.Size(46, 17)
        Me.statTimes.Text = "Times"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 404)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lemon Cake", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 102)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hello There!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We hope you enjoy " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this simple application." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "And big thanks to u" &
    "sing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this apps." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lemon Cake", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "About Us"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel4.Location = New System.Drawing.Point(1, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 3)
        Me.Panel4.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.txtInput)
        Me.Panel3.Location = New System.Drawing.Point(211, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(587, 404)
        Me.Panel3.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.RosyBrown
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(458, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.ForeColor = System.Drawing.Color.RosyBrown
        Me.Panel6.Location = New System.Drawing.Point(618, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(3, 55)
        Me.Panel6.TabIndex = 14
        '
        'timerNow
        '
        Me.timerNow.Enabled = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 554)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "My Diary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuNew As ToolStripMenuItem
    Friend WithEvents menuOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents menuSave As ToolStripMenuItem
    Friend WithEvents TSEdit As ToolStripMenuItem
    Friend WithEvents menuUndo As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents menuCut As ToolStripMenuItem
    Friend WithEvents menuCopy As ToolStripMenuItem
    Friend WithEvents menuPaste As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents menuAll As ToolStripMenuItem
    Friend WithEvents TSExit As ToolStripMenuItem
    Friend WithEvents TSbtnNew As ToolStripButton
    Friend WithEvents TSbtnOpen As ToolStripButton
    Friend WithEvents TSbtnSave As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSbtnCut As ToolStripButton
    Friend WithEvents TSbtnCopy As ToolStripButton
    Friend WithEvents TSbtnPaste As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSbtnInfo As ToolStripButton
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents StatToday As ToolStripStatusLabel
    Friend WithEvents statDate As ToolStripStatusLabel
    Friend WithEvents stastTime As ToolStripStatusLabel
    Friend WithEvents statTimes As ToolStripStatusLabel
    Friend WithEvents timerNow As Timer
    Friend WithEvents btnClear As Button
    Friend WithEvents TSDelete As ToolStripMenuItem
End Class
