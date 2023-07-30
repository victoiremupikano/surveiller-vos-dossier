<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SurveillanceInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurveillanceInterface))
        Me.txtRapport = New System.Windows.Forms.TextBox()
        Me.btnDemarrer = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.pnlHaut = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblDossier = New System.Windows.Forms.Label()
        Me.lblOeil = New System.Windows.Forms.Label()
        Me.lblUn = New System.Windows.Forms.Label()
        Me.lblGarger = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grTxt = New System.Windows.Forms.GroupBox()
        Me.lblEthiquette = New System.Windows.Forms.Label()
        Me.lblChemin = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDossier = New System.Windows.Forms.Button()
        Me.btnSauver = New System.Windows.Forms.Button()
        Me.txtcheminDossier = New System.Windows.Forms.TextBox()
        Me.btnExists = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHaut.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grTxt.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRapport
        '
        Me.txtRapport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRapport.Location = New System.Drawing.Point(9, 13)
        Me.txtRapport.Multiline = True
        Me.txtRapport.Name = "txtRapport"
        Me.txtRapport.ReadOnly = True
        Me.txtRapport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRapport.Size = New System.Drawing.Size(676, 166)
        Me.txtRapport.TabIndex = 0
        '
        'btnDemarrer
        '
        Me.btnDemarrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDemarrer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDemarrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDemarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemarrer.ForeColor = System.Drawing.Color.White
        Me.btnDemarrer.Location = New System.Drawing.Point(546, 304)
        Me.btnDemarrer.Name = "btnDemarrer"
        Me.btnDemarrer.Size = New System.Drawing.Size(148, 23)
        Me.btnDemarrer.TabIndex = 2
        Me.btnDemarrer.Text = "Demmarrer la surveillance"
        Me.btnDemarrer.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'pnlHaut
        '
        Me.pnlHaut.BackColor = System.Drawing.Color.Maroon
        Me.pnlHaut.Controls.Add(Me.PictureBox4)
        Me.pnlHaut.Controls.Add(Me.lblDossier)
        Me.pnlHaut.Controls.Add(Me.lblOeil)
        Me.pnlHaut.Controls.Add(Me.lblUn)
        Me.pnlHaut.Controls.Add(Me.lblGarger)
        Me.pnlHaut.Controls.Add(Me.PictureBox3)
        Me.pnlHaut.Controls.Add(Me.PictureBox2)
        Me.pnlHaut.Controls.Add(Me.LinkLabel1)
        Me.pnlHaut.Controls.Add(Me.PictureBox1)
        Me.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHaut.Location = New System.Drawing.Point(2, 0)
        Me.pnlHaut.Name = "pnlHaut"
        Me.pnlHaut.Size = New System.Drawing.Size(708, 25)
        Me.pnlHaut.TabIndex = 3
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Surveiller_un_dossier.My.Resources.Resources.icon_circle_slelected
        Me.PictureBox4.Location = New System.Drawing.Point(7, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'lblDossier
        '
        Me.lblDossier.AutoSize = True
        Me.lblDossier.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDossier.Location = New System.Drawing.Point(175, 3)
        Me.lblDossier.Name = "lblDossier"
        Me.lblDossier.Size = New System.Drawing.Size(112, 20)
        Me.lblDossier.TabIndex = 13
        Me.lblDossier.Text = "sur vos dossiers"
        '
        'lblOeil
        '
        Me.lblOeil.AutoSize = True
        Me.lblOeil.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOeil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOeil.Location = New System.Drawing.Point(135, 3)
        Me.lblOeil.Name = "lblOeil"
        Me.lblOeil.Size = New System.Drawing.Size(34, 20)
        Me.lblOeil.TabIndex = 12
        Me.lblOeil.Text = "Oeil"
        '
        'lblUn
        '
        Me.lblUn.AutoSize = True
        Me.lblUn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUn.Location = New System.Drawing.Point(100, 3)
        Me.lblUn.Name = "lblUn"
        Me.lblUn.Size = New System.Drawing.Size(29, 20)
        Me.lblUn.TabIndex = 11
        Me.lblUn.Text = "un "
        '
        'lblGarger
        '
        Me.lblGarger.AutoSize = True
        Me.lblGarger.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGarger.Location = New System.Drawing.Point(43, 3)
        Me.lblGarger.Name = "lblGarger"
        Me.lblGarger.Size = New System.Drawing.Size(51, 20)
        Me.lblGarger.TabIndex = 10
        Me.lblGarger.Text = "Garder"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Surveiller_un_dossier.My.Resources.Resources.icon_minus_06
        Me.PictureBox3.Location = New System.Drawing.Point(620, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Surveiller_un_dossier.My.Resources.Resources.icon_box_empty
        Me.PictureBox2.Location = New System.Drawing.Point(649, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(518, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About the software"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Surveiller_un_dossier.My.Resources.Resources.icon_close
        Me.PictureBox1.Location = New System.Drawing.Point(679, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grTxt
        '
        Me.grTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grTxt.Controls.Add(Me.txtRapport)
        Me.grTxt.Location = New System.Drawing.Point(12, 61)
        Me.grTxt.Name = "grTxt"
        Me.grTxt.Size = New System.Drawing.Size(688, 185)
        Me.grTxt.TabIndex = 4
        Me.grTxt.TabStop = False
        '
        'lblEthiquette
        '
        Me.lblEthiquette.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEthiquette.AutoSize = True
        Me.lblEthiquette.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEthiquette.ForeColor = System.Drawing.Color.Black
        Me.lblEthiquette.Location = New System.Drawing.Point(313, 39)
        Me.lblEthiquette.Name = "lblEthiquette"
        Me.lblEthiquette.Size = New System.Drawing.Size(394, 16)
        Me.lblEthiquette.TabIndex = 5
        Me.lblEthiquette.Text = "Ici vous visualiser tous les changement apporter sur votre dossier"
        '
        'lblChemin
        '
        Me.lblChemin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblChemin.AutoSize = True
        Me.lblChemin.Location = New System.Drawing.Point(6, 20)
        Me.lblChemin.Name = "lblChemin"
        Me.lblChemin.Size = New System.Drawing.Size(218, 13)
        Me.lblChemin.TabIndex = 1
        Me.lblChemin.Text = "Coller ici le chemin d'accès de votre dossier :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnDossier)
        Me.GroupBox2.Controls.Add(Me.btnSauver)
        Me.GroupBox2.Controls.Add(Me.lblChemin)
        Me.GroupBox2.Controls.Add(Me.txtcheminDossier)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnDossier
        '
        Me.btnDossier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDossier.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDossier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDossier.ForeColor = System.Drawing.Color.White
        Me.btnDossier.Location = New System.Drawing.Point(573, 16)
        Me.btnDossier.Name = "btnDossier"
        Me.btnDossier.Size = New System.Drawing.Size(47, 23)
        Me.btnDossier.TabIndex = 9
        Me.btnDossier.Text = "..."
        Me.btnDossier.UseVisualStyleBackColor = False
        '
        'btnSauver
        '
        Me.btnSauver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSauver.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSauver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSauver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSauver.ForeColor = System.Drawing.Color.White
        Me.btnSauver.Location = New System.Drawing.Point(626, 15)
        Me.btnSauver.Name = "btnSauver"
        Me.btnSauver.Size = New System.Drawing.Size(56, 23)
        Me.btnSauver.TabIndex = 8
        Me.btnSauver.Text = "Sauver"
        Me.btnSauver.UseVisualStyleBackColor = False
        '
        'txtcheminDossier
        '
        Me.txtcheminDossier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcheminDossier.Location = New System.Drawing.Point(230, 16)
        Me.txtcheminDossier.Name = "txtcheminDossier"
        Me.txtcheminDossier.Size = New System.Drawing.Size(337, 20)
        Me.txtcheminDossier.TabIndex = 1
        '
        'btnExists
        '
        Me.btnExists.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExists.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExists.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExists.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExists.ForeColor = System.Drawing.Color.White
        Me.btnExists.Location = New System.Drawing.Point(383, 304)
        Me.btnExists.Name = "btnExists"
        Me.btnExists.Size = New System.Drawing.Size(157, 23)
        Me.btnExists.TabIndex = 7
        Me.btnExists.Text = "Verifier l'existance du dossier"
        Me.btnExists.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(710, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 337)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 337)
        Me.Panel2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 2)
        Me.Panel1.TabIndex = 13
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'SurveillanceInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 339)
        Me.Controls.Add(Me.pnlHaut)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExists)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblEthiquette)
        Me.Controls.Add(Me.btnDemarrer)
        Me.Controls.Add(Me.grTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SurveillanceInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHaut.ResumeLayout(False)
        Me.pnlHaut.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grTxt.ResumeLayout(False)
        Me.grTxt.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRapport As TextBox
    Friend WithEvents txtcheminDossier As TextBox
    Friend WithEvents btnDemarrer As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents lblEthiquette As Label
    Friend WithEvents pnlHaut As Panel
    Friend WithEvents grTxt As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblChemin As Label
    Friend WithEvents btnExists As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSauver As Button
    Friend WithEvents lblDossier As Label
    Friend WithEvents lblOeil As Label
    Friend WithEvents lblUn As Label
    Friend WithEvents lblGarger As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnDossier As Button
End Class
