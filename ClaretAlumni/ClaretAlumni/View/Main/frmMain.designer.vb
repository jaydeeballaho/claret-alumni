<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelMainTop = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMainBody = New System.Windows.Forms.Panel()
        Me.PanelMainLeft = New System.Windows.Forms.Panel()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Effect7 = New System.Windows.Forms.Panel()
        Me.Effect3 = New System.Windows.Forms.Panel()
        Me.Effect1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnContact = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.btnAlumni = New System.Windows.Forms.Button()
        Me.PanelMainTop.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelMainLeft.SuspendLayout()
        Me.PanelLeft.SuspendLayout()
        Me.Effect7.SuspendLayout()
        Me.Effect3.SuspendLayout()
        Me.Effect1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMainTop
        '
        Me.PanelMainTop.Controls.Add(Me.PanelTop)
        Me.PanelMainTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMainTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelMainTop.Name = "PanelMainTop"
        Me.PanelMainTop.Size = New System.Drawing.Size(1184, 60)
        Me.PanelMainTop.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblHost)
        Me.PanelTop.Controls.Add(Me.btnChange)
        Me.PanelTop.Controls.Add(Me.Panel1)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1184, 60)
        Me.PanelTop.TabIndex = 1
        '
        'lblHost
        '
        Me.lblHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHost.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHost.ForeColor = System.Drawing.Color.White
        Me.lblHost.Location = New System.Drawing.Point(580, 20)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.lblHost.Size = New System.Drawing.Size(424, 21)
        Me.lblHost.TabIndex = 10
        Me.lblHost.Text = "Account Name"
        Me.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChange
        '
        Me.btnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnChange.FlatAppearance.BorderSize = 0
        Me.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChange.Location = New System.Drawing.Point(1027, 16)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(144, 30)
        Me.btnChange.TabIndex = 3
        Me.btnChange.TabStop = False
        Me.btnChange.Text = "Change Account PIN"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1017, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 25)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLARET SCHOOL OF ZAMBOANGA ALUMNI RECORD KEEPING"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PanelMainBody)
        Me.Panel2.Controls.Add(Me.PanelMainLeft)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 602)
        Me.Panel2.TabIndex = 1
        '
        'PanelMainBody
        '
        Me.PanelMainBody.AutoScroll = True
        Me.PanelMainBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainBody.Location = New System.Drawing.Point(160, 0)
        Me.PanelMainBody.Name = "PanelMainBody"
        Me.PanelMainBody.Size = New System.Drawing.Size(1024, 602)
        Me.PanelMainBody.TabIndex = 1
        '
        'PanelMainLeft
        '
        Me.PanelMainLeft.Controls.Add(Me.PanelLeft)
        Me.PanelMainLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMainLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelMainLeft.Name = "PanelMainLeft"
        Me.PanelMainLeft.Size = New System.Drawing.Size(160, 602)
        Me.PanelMainLeft.TabIndex = 0
        '
        'PanelLeft
        '
        Me.PanelLeft.Controls.Add(Me.Effect7)
        Me.PanelLeft.Controls.Add(Me.btnContact)
        Me.PanelLeft.Controls.Add(Me.Effect3)
        Me.PanelLeft.Controls.Add(Me.Effect1)
        Me.PanelLeft.Controls.Add(Me.Panel4)
        Me.PanelLeft.Controls.Add(Me.btnAlumni)
        Me.PanelLeft.Controls.Add(Me.btnConnection)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(160, 602)
        Me.PanelLeft.TabIndex = 2
        '
        'Effect7
        '
        Me.Effect7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Effect7.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Effect7.Controls.Add(Me.Panel6)
        Me.Effect7.Location = New System.Drawing.Point(145, 552)
        Me.Effect7.Name = "Effect7"
        Me.Effect7.Size = New System.Drawing.Size(15, 50)
        Me.Effect7.TabIndex = 11
        Me.Effect7.Visible = False
        '
        'Effect3
        '
        Me.Effect3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Effect3.Controls.Add(Me.Panel12)
        Me.Effect3.Location = New System.Drawing.Point(145, 54)
        Me.Effect3.Name = "Effect3"
        Me.Effect3.Size = New System.Drawing.Size(15, 50)
        Me.Effect3.TabIndex = 8
        Me.Effect3.Visible = False
        '
        'Effect1
        '
        Me.Effect1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Effect1.Controls.Add(Me.Panel3)
        Me.Effect1.Location = New System.Drawing.Point(145, 2)
        Me.Effect1.Name = "Effect1"
        Me.Effect1.Size = New System.Drawing.Size(15, 50)
        Me.Effect1.TabIndex = 0
        Me.Effect1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 106)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 444)
        Me.Panel4.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.Location = New System.Drawing.Point(0, 13)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(15, 25)
        Me.Panel6.TabIndex = 7
        '
        'btnContact
        '
        Me.btnContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnContact.FlatAppearance.BorderSize = 0
        Me.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContact.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContact.ForeColor = System.Drawing.Color.White
        Me.btnContact.Image = CType(resources.GetObject("btnContact.Image"), System.Drawing.Image)
        Me.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.Location = New System.Drawing.Point(0, 552)
        Me.btnContact.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnContact.Name = "btnContact"
        Me.btnContact.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnContact.Size = New System.Drawing.Size(160, 50)
        Me.btnContact.TabIndex = 11
        Me.btnContact.TabStop = False
        Me.btnContact.Text = "          Contact Us"
        Me.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContact.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel12.BackgroundImage = CType(resources.GetObject("Panel12.BackgroundImage"), System.Drawing.Image)
        Me.Panel12.Location = New System.Drawing.Point(0, 13)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(15, 25)
        Me.Panel12.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Location = New System.Drawing.Point(0, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 25)
        Me.Panel3.TabIndex = 7
        '
        'btnConnection
        '
        Me.btnConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnConnection.FlatAppearance.BorderSize = 0
        Me.btnConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnection.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnection.ForeColor = System.Drawing.Color.White
        Me.btnConnection.Image = CType(resources.GetObject("btnConnection.Image"), System.Drawing.Image)
        Me.btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnection.Location = New System.Drawing.Point(0, 54)
        Me.btnConnection.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConnection.Size = New System.Drawing.Size(160, 50)
        Me.btnConnection.TabIndex = 2
        Me.btnConnection.TabStop = False
        Me.btnConnection.Text = "          Settings"
        Me.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnection.UseVisualStyleBackColor = False
        '
        'btnAlumni
        '
        Me.btnAlumni.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAlumni.FlatAppearance.BorderSize = 0
        Me.btnAlumni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAlumni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAlumni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumni.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumni.ForeColor = System.Drawing.Color.White
        Me.btnAlumni.Image = CType(resources.GetObject("btnAlumni.Image"), System.Drawing.Image)
        Me.btnAlumni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumni.Location = New System.Drawing.Point(0, 2)
        Me.btnAlumni.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnAlumni.Name = "btnAlumni"
        Me.btnAlumni.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAlumni.Size = New System.Drawing.Size(160, 50)
        Me.btnAlumni.TabIndex = 1
        Me.btnAlumni.TabStop = False
        Me.btnAlumni.Text = "          Alumi Records"
        Me.btnAlumni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumni.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelMainTop)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLARET SCHOOL OF ZAMBOANGA ALUMNI RECORD KEEPING"
        Me.PanelMainTop.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelMainLeft.ResumeLayout(False)
        Me.PanelLeft.ResumeLayout(False)
        Me.Effect7.ResumeLayout(False)
        Me.Effect3.ResumeLayout(False)
        Me.Effect1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMainTop As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelMainLeft As System.Windows.Forms.Panel
    Friend WithEvents PanelMainBody As System.Windows.Forms.Panel
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents Effect7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnContact As System.Windows.Forms.Button
    Friend WithEvents Effect3 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Effect1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnConnection As System.Windows.Forms.Button
    Friend WithEvents btnAlumni As System.Windows.Forms.Button
    Friend WithEvents lblHost As System.Windows.Forms.Label
End Class
