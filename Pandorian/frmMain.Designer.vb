﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ddStations = New System.Windows.Forms.ComboBox()
        Me.lblSongName = New System.Windows.Forms.Label()
        Me.lblArtistName = New System.Windows.Forms.Label()
        Me.lblAlbumName = New System.Windows.Forms.Label()
        Me.btnLike = New System.Windows.Forms.Button()
        Me.btnDislike = New System.Windows.Forms.Button()
        Me.btnPlayPause = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnBlock = New System.Windows.Forms.Button()
        Me.Spinner = New System.Windows.Forms.PictureBox()
        Me.SongCoverImage = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miManageStation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miShowSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.miUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.prgDownload = New System.Windows.Forms.ProgressBar()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.miShowHotkeys = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongCoverImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ddStations
        '
        Me.ddStations.BackColor = System.Drawing.Color.Azure
        Me.ddStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddStations.FormattingEnabled = True
        Me.ddStations.Location = New System.Drawing.Point(30, 17)
        Me.ddStations.Name = "ddStations"
        Me.ddStations.Size = New System.Drawing.Size(300, 21)
        Me.ddStations.TabIndex = 1
        '
        'lblSongName
        '
        Me.lblSongName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongName.Location = New System.Drawing.Point(12, 375)
        Me.lblSongName.Name = "lblSongName"
        Me.lblSongName.Size = New System.Drawing.Size(332, 15)
        Me.lblSongName.TabIndex = 3
        Me.lblSongName.Text = "Song Name"
        Me.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArtistName
        '
        Me.lblArtistName.Location = New System.Drawing.Point(12, 390)
        Me.lblArtistName.Name = "lblArtistName"
        Me.lblArtistName.Size = New System.Drawing.Size(332, 15)
        Me.lblArtistName.TabIndex = 4
        Me.lblArtistName.Text = "Artist Name"
        Me.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlbumName
        '
        Me.lblAlbumName.Location = New System.Drawing.Point(15, 405)
        Me.lblAlbumName.Name = "lblAlbumName"
        Me.lblAlbumName.Size = New System.Drawing.Size(329, 15)
        Me.lblAlbumName.TabIndex = 5
        Me.lblAlbumName.Text = "Album Name"
        Me.lblAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLike
        '
        Me.btnLike.BackColor = System.Drawing.Color.Azure
        Me.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLike.ForeColor = System.Drawing.Color.Black
        Me.btnLike.Location = New System.Drawing.Point(30, 425)
        Me.btnLike.Name = "btnLike"
        Me.btnLike.Size = New System.Drawing.Size(50, 23)
        Me.btnLike.TabIndex = 6
        Me.btnLike.Text = "Like"
        Me.btnLike.UseVisualStyleBackColor = False
        '
        'btnDislike
        '
        Me.btnDislike.BackColor = System.Drawing.Color.Azure
        Me.btnDislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDislike.ForeColor = System.Drawing.Color.Black
        Me.btnDislike.Location = New System.Drawing.Point(87, 425)
        Me.btnDislike.Name = "btnDislike"
        Me.btnDislike.Size = New System.Drawing.Size(50, 23)
        Me.btnDislike.TabIndex = 7
        Me.btnDislike.Text = "Dislike"
        Me.btnDislike.UseVisualStyleBackColor = False
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackColor = System.Drawing.Color.Azure
        Me.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayPause.ForeColor = System.Drawing.Color.Black
        Me.btnPlayPause.Location = New System.Drawing.Point(157, 425)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(50, 23)
        Me.btnPlayPause.TabIndex = 8
        Me.btnPlayPause.Text = "Pause"
        Me.btnPlayPause.UseVisualStyleBackColor = False
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.Azure
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.ForeColor = System.Drawing.Color.Black
        Me.btnSkip.Location = New System.Drawing.Point(212, 425)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(50, 23)
        Me.btnSkip.TabIndex = 9
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(30, 360)
        Me.prgBar.MarqueeAnimationSpeed = 5000
        Me.prgBar.Minimum = 1
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(300, 10)
        Me.prgBar.Step = 1
        Me.prgBar.TabIndex = 10
        Me.prgBar.Value = 1
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'btnBlock
        '
        Me.btnBlock.BackColor = System.Drawing.Color.Azure
        Me.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlock.ForeColor = System.Drawing.Color.Black
        Me.btnBlock.Location = New System.Drawing.Point(280, 425)
        Me.btnBlock.Name = "btnBlock"
        Me.btnBlock.Size = New System.Drawing.Size(50, 23)
        Me.btnBlock.TabIndex = 12
        Me.btnBlock.Text = "Block"
        Me.btnBlock.UseVisualStyleBackColor = False
        '
        'Spinner
        '
        Me.Spinner.Image = Global.Pandorian.My.Resources.Resources.spinner
        Me.Spinner.Location = New System.Drawing.Point(0, 0)
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(357, 464)
        Me.Spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Spinner.TabIndex = 13
        Me.Spinner.TabStop = False
        '
        'SongCoverImage
        '
        Me.SongCoverImage.BackColor = System.Drawing.Color.SteelBlue
        Me.SongCoverImage.ContextMenuStrip = Me.MenuStrip
        Me.SongCoverImage.Location = New System.Drawing.Point(30, 51)
        Me.SongCoverImage.Name = "SongCoverImage"
        Me.SongCoverImage.Size = New System.Drawing.Size(300, 300)
        Me.SongCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SongCoverImage.TabIndex = 2
        Me.SongCoverImage.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miManageStation, Me.ToolStripSeparator1, Me.miShowSettings, Me.miShowHotkeys, Me.miUpdate, Me.ToolStripSeparator2, Me.miVersion})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.ShowImageMargin = False
        Me.MenuStrip.Size = New System.Drawing.Size(168, 148)
        '
        'miManageStation
        '
        Me.miManageStation.Name = "miManageStation"
        Me.miManageStation.Size = New System.Drawing.Size(167, 22)
        Me.miManageStation.Text = "Manage Station"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'miShowSettings
        '
        Me.miShowSettings.Name = "miShowSettings"
        Me.miShowSettings.Size = New System.Drawing.Size(167, 22)
        Me.miShowSettings.Text = "Show Settings"
        '
        'miUpdate
        '
        Me.miUpdate.Name = "miUpdate"
        Me.miUpdate.Size = New System.Drawing.Size(167, 22)
        Me.miUpdate.Text = "Check For An Update"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'miVersion
        '
        Me.miVersion.Enabled = False
        Me.miVersion.Name = "miVersion"
        Me.miVersion.Size = New System.Drawing.Size(167, 22)
        Me.miVersion.Text = "Current Version: v1.4.0"
        '
        'prgDownload
        '
        Me.prgDownload.ForeColor = System.Drawing.Color.Aqua
        Me.prgDownload.Location = New System.Drawing.Point(0, 454)
        Me.prgDownload.Name = "prgDownload"
        Me.prgDownload.Size = New System.Drawing.Size(357, 10)
        Me.prgDownload.Step = 1
        Me.prgDownload.TabIndex = 14
        Me.prgDownload.Visible = False
        '
        'miShowHotkeys
        '
        Me.miShowHotkeys.Name = "miShowHotkeys"
        Me.miShowHotkeys.Size = New System.Drawing.Size(167, 22)
        Me.miShowHotkeys.Text = "Show HotKeys"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(356, 464)
        Me.Controls.Add(Me.prgDownload)
        Me.Controls.Add(Me.Spinner)
        Me.Controls.Add(Me.btnBlock)
        Me.Controls.Add(Me.prgBar)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.btnDislike)
        Me.Controls.Add(Me.btnLike)
        Me.Controls.Add(Me.lblAlbumName)
        Me.Controls.Add(Me.lblArtistName)
        Me.Controls.Add(Me.lblSongName)
        Me.Controls.Add(Me.SongCoverImage)
        Me.Controls.Add(Me.ddStations)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pandorian By Đĵ ΝιΓΞΗΛψΚ"
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongCoverImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ddStations As System.Windows.Forms.ComboBox
    Friend WithEvents SongCoverImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblSongName As System.Windows.Forms.Label
    Friend WithEvents lblArtistName As System.Windows.Forms.Label
    Friend WithEvents lblAlbumName As System.Windows.Forms.Label
    Friend WithEvents btnLike As System.Windows.Forms.Button
    Friend WithEvents btnDislike As System.Windows.Forms.Button
    Friend WithEvents btnPlayPause As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents prgBar As System.Windows.Forms.ProgressBar
    'Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents btnBlock As System.Windows.Forms.Button
    Friend WithEvents Spinner As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miShowSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miManageStation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prgDownload As System.Windows.Forms.ProgressBar
    Friend WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents miShowHotkeys As System.Windows.Forms.ToolStripMenuItem

End Class
