<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cboInstrument = New MetroFramework.Controls.MetroComboBox()
        Me.tbVolume = New MetroFramework.Controls.MetroTrackBar()
        Me.tbInterval = New MetroFramework.Controls.MetroTrackBar()
        Me.lblVolume = New MetroFramework.Controls.MetroLabel()
        Me.lblInterval = New MetroFramework.Controls.MetroLabel()
        Me.lblInstrument = New MetroFramework.Controls.MetroLabel()
        Me.btnSwitch = New MetroFramework.Controls.MetroButton()
        Me.tmrTrainer = New System.Windows.Forms.Timer(Me.components)
        Me.grpbxKeyboard = New System.Windows.Forms.GroupBox()
        Me.tbOctave = New MetroFramework.Controls.MetroTrackBar()
        Me.lblOcatave = New MetroFramework.Controls.MetroLabel()
        Me.cboTrainerInstrument = New MetroFramework.Controls.MetroComboBox()
        Me.lblTrainerInstrument = New MetroFramework.Controls.MetroLabel()
        Me.lblInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblPlayed = New MetroFramework.Controls.MetroLabel()
        Me.btnNew = New MetroFramework.Controls.MetroButton()
        Me.tglAutoNewNote = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.pbOnOff = New System.Windows.Forms.PictureBox()
        Me.pbArrow = New System.Windows.Forms.PictureBox()
        Me.pbAnswer = New System.Windows.Forms.PictureBox()
        Me.pbASharp = New System.Windows.Forms.PictureBox()
        Me.pbGSharp = New System.Windows.Forms.PictureBox()
        Me.pbFSharp = New System.Windows.Forms.PictureBox()
        Me.pbDSharp = New System.Windows.Forms.PictureBox()
        Me.pbCSharp = New System.Windows.Forms.PictureBox()
        Me.pbC2 = New System.Windows.Forms.PictureBox()
        Me.pbB = New System.Windows.Forms.PictureBox()
        Me.pbA = New System.Windows.Forms.PictureBox()
        Me.pbG = New System.Windows.Forms.PictureBox()
        Me.pbF = New System.Windows.Forms.PictureBox()
        Me.pbE = New System.Windows.Forms.PictureBox()
        Me.pbD = New System.Windows.Forms.PictureBox()
        Me.pbC = New System.Windows.Forms.PictureBox()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.grpbxKeyboard.SuspendLayout()
        CType(Me.pbOnOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbASharp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGSharp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFSharp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDSharp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCSharp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboInstrument
        '
        Me.cboInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboInstrument.FormattingEnabled = True
        Me.cboInstrument.ItemHeight = 23
        Me.cboInstrument.Items.AddRange(New Object() {"AcousticGrandPiano", "BrightAcousticPiano", "ElectricPiano2", "MusicBox", "DrawbarOrgan", "ChurchOrgan", "ReedOrgan", "Harmonica", "TangoAccordion", "AcousticGuitarNylon", "AcousticGuitarSteel", "ElectricGuitarJazz", "ElectricBassFinger", "ElectricBassPick", "FretlessBass", "Violin", "Cello", "Contrabass", "OrchestralHarp", "StringEnsemble1", "ChoirAahs", "VoiceOohs", "SynthVoice", "Trumpet", "Tuba", "FrenchHorn", "AltoSax", "BaritoneSax", "Clarinet", "Piccolo", "Flute", "Shakuhachi", "Whistle", "Lead1Square", "Lead5Charang", "Lead6Voice", "Pad4Choir", "Fiddle"})
        Me.cboInstrument.Location = New System.Drawing.Point(223, 342)
        Me.cboInstrument.Name = "cboInstrument"
        Me.cboInstrument.Size = New System.Drawing.Size(197, 29)
        Me.cboInstrument.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cboInstrument.TabIndex = 0
        Me.cboInstrument.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tbVolume
        '
        Me.tbVolume.BackColor = System.Drawing.Color.Transparent
        Me.tbVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbVolume.CustomBackground = True
        Me.tbVolume.Location = New System.Drawing.Point(79, 348)
        Me.tbVolume.Maximum = 127
        Me.tbVolume.Minimum = 1
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(129, 23)
        Me.tbVolume.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tbVolume.TabIndex = 1
        Me.tbVolume.Tag = ""
        Me.tbVolume.Text = "Volume"
        Me.tbVolume.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbVolume.Value = 127
        '
        'tbInterval
        '
        Me.tbInterval.BackColor = System.Drawing.Color.Transparent
        Me.tbInterval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbInterval.CustomBackground = True
        Me.tbInterval.Location = New System.Drawing.Point(79, 319)
        Me.tbInterval.Maximum = 2500
        Me.tbInterval.Minimum = 250
        Me.tbInterval.Name = "tbInterval"
        Me.tbInterval.Size = New System.Drawing.Size(129, 23)
        Me.tbInterval.SmallChange = 250
        Me.tbInterval.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tbInterval.TabIndex = 1
        Me.tbInterval.Tag = ""
        Me.tbInterval.Text = "Interval"
        Me.tbInterval.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbInterval.Value = 500
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(19, 348)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(54, 19)
        Me.lblVolume.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblVolume.TabIndex = 2
        Me.lblVolume.Text = "Volume"
        Me.lblVolume.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(22, 319)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(51, 19)
        Me.lblInterval.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblInterval.TabIndex = 2
        Me.lblInterval.Text = "Interval"
        Me.lblInterval.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblInstrument
        '
        Me.lblInstrument.AutoSize = True
        Me.lblInstrument.Location = New System.Drawing.Point(219, 319)
        Me.lblInstrument.Name = "lblInstrument"
        Me.lblInstrument.Size = New System.Drawing.Size(70, 19)
        Me.lblInstrument.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblInstrument.TabIndex = 2
        Me.lblInstrument.Text = "Instrument"
        Me.lblInstrument.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnSwitch
        '
        Me.btnSwitch.Location = New System.Drawing.Point(19, 63)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(99, 38)
        Me.btnSwitch.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnSwitch.TabIndex = 3
        Me.btnSwitch.Text = "&Start"
        Me.btnSwitch.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tmrTrainer
        '
        Me.tmrTrainer.Interval = 1000
        '
        'grpbxKeyboard
        '
        Me.grpbxKeyboard.Controls.Add(Me.pbASharp)
        Me.grpbxKeyboard.Controls.Add(Me.pbGSharp)
        Me.grpbxKeyboard.Controls.Add(Me.pbFSharp)
        Me.grpbxKeyboard.Controls.Add(Me.pbDSharp)
        Me.grpbxKeyboard.Controls.Add(Me.pbCSharp)
        Me.grpbxKeyboard.Controls.Add(Me.pbC2)
        Me.grpbxKeyboard.Controls.Add(Me.pbB)
        Me.grpbxKeyboard.Controls.Add(Me.pbA)
        Me.grpbxKeyboard.Controls.Add(Me.pbG)
        Me.grpbxKeyboard.Controls.Add(Me.pbF)
        Me.grpbxKeyboard.Controls.Add(Me.pbE)
        Me.grpbxKeyboard.Controls.Add(Me.pbD)
        Me.grpbxKeyboard.Controls.Add(Me.pbC)
        Me.grpbxKeyboard.Controls.Add(Me.pbBack)
        Me.grpbxKeyboard.ForeColor = System.Drawing.Color.Yellow
        Me.grpbxKeyboard.Location = New System.Drawing.Point(19, 107)
        Me.grpbxKeyboard.Name = "grpbxKeyboard"
        Me.grpbxKeyboard.Size = New System.Drawing.Size(396, 174)
        Me.grpbxKeyboard.TabIndex = 80
        Me.grpbxKeyboard.TabStop = False
        '
        'tbOctave
        '
        Me.tbOctave.BackColor = System.Drawing.Color.Transparent
        Me.tbOctave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbOctave.CustomBackground = True
        Me.tbOctave.LargeChange = 2
        Me.tbOctave.Location = New System.Drawing.Point(79, 377)
        Me.tbOctave.Maximum = 6
        Me.tbOctave.Minimum = 2
        Me.tbOctave.Name = "tbOctave"
        Me.tbOctave.Size = New System.Drawing.Size(129, 23)
        Me.tbOctave.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tbOctave.TabIndex = 1
        Me.tbOctave.Tag = ""
        Me.tbOctave.Text = "Interval"
        Me.tbOctave.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tbOctave.Value = 3
        '
        'lblOcatave
        '
        Me.lblOcatave.AutoSize = True
        Me.lblOcatave.Location = New System.Drawing.Point(12, 381)
        Me.lblOcatave.Name = "lblOcatave"
        Me.lblOcatave.Size = New System.Drawing.Size(61, 19)
        Me.lblOcatave.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblOcatave.TabIndex = 2
        Me.lblOcatave.Text = "Octave 3"
        Me.lblOcatave.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cboTrainerInstrument
        '
        Me.cboTrainerInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTrainerInstrument.FormattingEnabled = True
        Me.cboTrainerInstrument.ItemHeight = 23
        Me.cboTrainerInstrument.Items.AddRange(New Object() {"AcousticGrandPiano", "BrightAcousticPiano", "ElectricPiano2", "MusicBox", "DrawbarOrgan", "ChurchOrgan", "ReedOrgan", "Harmonica", "TangoAccordion", "AcousticGuitarNylon", "AcousticGuitarSteel", "ElectricGuitarJazz", "ElectricBassFinger", "ElectricBassPick", "FretlessBass", "Violin", "Cello", "Contrabass", "OrchestralHarp", "StringEnsemble1", "ChoirAahs", "VoiceOohs", "SynthVoice", "Trumpet", "Tuba", "FrenchHorn", "AltoSax", "BaritoneSax", "Clarinet", "Piccolo", "Flute", "Shakuhachi", "Whistle", "Lead1Square", "Lead5Charang", "Lead6Voice", "Pad4Choir", "Fiddle"})
        Me.cboTrainerInstrument.Location = New System.Drawing.Point(223, 403)
        Me.cboTrainerInstrument.Name = "cboTrainerInstrument"
        Me.cboTrainerInstrument.Size = New System.Drawing.Size(197, 29)
        Me.cboTrainerInstrument.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cboTrainerInstrument.TabIndex = 0
        Me.cboTrainerInstrument.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblTrainerInstrument
        '
        Me.lblTrainerInstrument.AutoSize = True
        Me.lblTrainerInstrument.Location = New System.Drawing.Point(223, 381)
        Me.lblTrainerInstrument.Name = "lblTrainerInstrument"
        Me.lblTrainerInstrument.Size = New System.Drawing.Size(115, 19)
        Me.lblTrainerInstrument.Style = MetroFramework.MetroColorStyle.Yellow
        Me.lblTrainerInstrument.TabIndex = 2
        Me.lblTrainerInstrument.Text = "Trainer Instrument"
        Me.lblTrainerInstrument.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(338, 15)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(77, 19)
        Me.lblInfo.TabIndex = 83
        Me.lblInfo.Text = "Information"
        Me.lblInfo.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblPlayed
        '
        Me.lblPlayed.AutoSize = True
        Me.lblPlayed.Location = New System.Drawing.Point(19, 284)
        Me.lblPlayed.Name = "lblPlayed"
        Me.lblPlayed.Size = New System.Drawing.Size(82, 19)
        Me.lblPlayed.TabIndex = 84
        Me.lblPlayed.Text = "You played: "
        Me.lblPlayed.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(124, 63)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 38)
        Me.btnNew.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "&New Note"
        Me.btnNew.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'tglAutoNewNote
        '
        Me.tglAutoNewNote.AutoSize = True
        Me.tglAutoNewNote.Location = New System.Drawing.Point(128, 409)
        Me.tglAutoNewNote.Name = "tglAutoNewNote"
        Me.tglAutoNewNote.Size = New System.Drawing.Size(80, 16)
        Me.tglAutoNewNote.TabIndex = 86
        Me.tglAutoNewNote.Text = "Off"
        Me.tglAutoNewNote.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tglAutoNewNote.UseVisualStyleBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(18, 406)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Auto New note"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pbOnOff
        '
        Me.pbOnOff.Image = Global.Absolute_Pitch_Trainer.My.Resources.Resources.OnOff
        Me.pbOnOff.Location = New System.Drawing.Point(459, 38)
        Me.pbOnOff.Name = "pbOnOff"
        Me.pbOnOff.Size = New System.Drawing.Size(75, 70)
        Me.pbOnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbOnOff.TabIndex = 87
        Me.pbOnOff.TabStop = False
        Me.pbOnOff.Visible = False
        '
        'pbArrow
        '
        Me.pbArrow.Image = Global.Absolute_Pitch_Trainer.My.Resources.Resources.Caution
        Me.pbArrow.Location = New System.Drawing.Point(459, 281)
        Me.pbArrow.Name = "pbArrow"
        Me.pbArrow.Size = New System.Drawing.Size(95, 85)
        Me.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbArrow.TabIndex = 82
        Me.pbArrow.TabStop = False
        '
        'pbAnswer
        '
        Me.pbAnswer.Image = CType(resources.GetObject("pbAnswer.Image"), System.Drawing.Image)
        Me.pbAnswer.Location = New System.Drawing.Point(421, 114)
        Me.pbAnswer.Name = "pbAnswer"
        Me.pbAnswer.Size = New System.Drawing.Size(166, 167)
        Me.pbAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAnswer.TabIndex = 81
        Me.pbAnswer.TabStop = False
        '
        'pbASharp
        '
        Me.pbASharp.BackColor = System.Drawing.Color.Black
        Me.pbASharp.Location = New System.Drawing.Point(273, 26)
        Me.pbASharp.Name = "pbASharp"
        Me.pbASharp.Size = New System.Drawing.Size(33, 69)
        Me.pbASharp.TabIndex = 78
        Me.pbASharp.TabStop = False
        '
        'pbGSharp
        '
        Me.pbGSharp.BackColor = System.Drawing.Color.Black
        Me.pbGSharp.Location = New System.Drawing.Point(226, 26)
        Me.pbGSharp.Name = "pbGSharp"
        Me.pbGSharp.Size = New System.Drawing.Size(34, 69)
        Me.pbGSharp.TabIndex = 77
        Me.pbGSharp.TabStop = False
        '
        'pbFSharp
        '
        Me.pbFSharp.BackColor = System.Drawing.Color.Black
        Me.pbFSharp.Location = New System.Drawing.Point(180, 26)
        Me.pbFSharp.Name = "pbFSharp"
        Me.pbFSharp.Size = New System.Drawing.Size(33, 69)
        Me.pbFSharp.TabIndex = 76
        Me.pbFSharp.TabStop = False
        '
        'pbDSharp
        '
        Me.pbDSharp.BackColor = System.Drawing.Color.Black
        Me.pbDSharp.Location = New System.Drawing.Point(86, 26)
        Me.pbDSharp.Name = "pbDSharp"
        Me.pbDSharp.Size = New System.Drawing.Size(34, 69)
        Me.pbDSharp.TabIndex = 75
        Me.pbDSharp.TabStop = False
        '
        'pbCSharp
        '
        Me.pbCSharp.BackColor = System.Drawing.Color.Black
        Me.pbCSharp.Location = New System.Drawing.Point(40, 26)
        Me.pbCSharp.Name = "pbCSharp"
        Me.pbCSharp.Size = New System.Drawing.Size(33, 69)
        Me.pbCSharp.TabIndex = 74
        Me.pbCSharp.TabStop = False
        '
        'pbC2
        '
        Me.pbC2.BackColor = System.Drawing.Color.White
        Me.pbC2.Location = New System.Drawing.Point(340, 26)
        Me.pbC2.Name = "pbC2"
        Me.pbC2.Size = New System.Drawing.Size(40, 132)
        Me.pbC2.TabIndex = 73
        Me.pbC2.TabStop = False
        '
        'pbB
        '
        Me.pbB.BackColor = System.Drawing.Color.White
        Me.pbB.Location = New System.Drawing.Point(293, 26)
        Me.pbB.Name = "pbB"
        Me.pbB.Size = New System.Drawing.Size(40, 132)
        Me.pbB.TabIndex = 72
        Me.pbB.TabStop = False
        '
        'pbA
        '
        Me.pbA.BackColor = System.Drawing.Color.White
        Me.pbA.Location = New System.Drawing.Point(246, 26)
        Me.pbA.Name = "pbA"
        Me.pbA.Size = New System.Drawing.Size(40, 132)
        Me.pbA.TabIndex = 71
        Me.pbA.TabStop = False
        '
        'pbG
        '
        Me.pbG.BackColor = System.Drawing.Color.White
        Me.pbG.Location = New System.Drawing.Point(200, 26)
        Me.pbG.Name = "pbG"
        Me.pbG.Size = New System.Drawing.Size(40, 132)
        Me.pbG.TabIndex = 70
        Me.pbG.TabStop = False
        '
        'pbF
        '
        Me.pbF.BackColor = System.Drawing.Color.White
        Me.pbF.Location = New System.Drawing.Point(153, 26)
        Me.pbF.Name = "pbF"
        Me.pbF.Size = New System.Drawing.Size(40, 132)
        Me.pbF.TabIndex = 69
        Me.pbF.TabStop = False
        '
        'pbE
        '
        Me.pbE.BackColor = System.Drawing.Color.White
        Me.pbE.Location = New System.Drawing.Point(106, 26)
        Me.pbE.Name = "pbE"
        Me.pbE.Size = New System.Drawing.Size(40, 132)
        Me.pbE.TabIndex = 68
        Me.pbE.TabStop = False
        '
        'pbD
        '
        Me.pbD.BackColor = System.Drawing.Color.White
        Me.pbD.Location = New System.Drawing.Point(60, 26)
        Me.pbD.Name = "pbD"
        Me.pbD.Size = New System.Drawing.Size(40, 132)
        Me.pbD.TabIndex = 67
        Me.pbD.TabStop = False
        '
        'pbC
        '
        Me.pbC.BackColor = System.Drawing.Color.White
        Me.pbC.Location = New System.Drawing.Point(13, 26)
        Me.pbC.Name = "pbC"
        Me.pbC.Size = New System.Drawing.Size(40, 132)
        Me.pbC.TabIndex = 66
        Me.pbC.TabStop = False
        '
        'pbBack
        '
        Me.pbBack.BackColor = System.Drawing.Color.Black
        Me.pbBack.Location = New System.Drawing.Point(6, 19)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(382, 146)
        Me.pbBack.TabIndex = 65
        Me.pbBack.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 445)
        Me.Controls.Add(Me.pbOnOff)
        Me.Controls.Add(Me.tglAutoNewNote)
        Me.Controls.Add(Me.lblPlayed)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.pbArrow)
        Me.Controls.Add(Me.pbAnswer)
        Me.Controls.Add(Me.grpbxKeyboard)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.lblTrainerInstrument)
        Me.Controls.Add(Me.lblInstrument)
        Me.Controls.Add(Me.lblOcatave)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.tbOctave)
        Me.Controls.Add(Me.tbInterval)
        Me.Controls.Add(Me.tbVolume)
        Me.Controls.Add(Me.cboTrainerInstrument)
        Me.Controls.Add(Me.cboInstrument)
        Me.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 18)
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Absolute Pitch Trainer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.grpbxKeyboard.ResumeLayout(False)
        CType(Me.pbOnOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbASharp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGSharp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFSharp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDSharp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCSharp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboInstrument As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbVolume As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents tbInterval As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblVolume As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblInterval As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblInstrument As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSwitch As MetroFramework.Controls.MetroButton
    Friend WithEvents tmrTrainer As Timer
    Friend WithEvents grpbxKeyboard As GroupBox
    Friend WithEvents pbASharp As PictureBox
    Friend WithEvents pbGSharp As PictureBox
    Friend WithEvents pbFSharp As PictureBox
    Friend WithEvents pbDSharp As PictureBox
    Friend WithEvents pbCSharp As PictureBox
    Friend WithEvents pbC2 As PictureBox
    Friend WithEvents pbB As PictureBox
    Friend WithEvents pbA As PictureBox
    Friend WithEvents pbG As PictureBox
    Friend WithEvents pbF As PictureBox
    Friend WithEvents pbE As PictureBox
    Friend WithEvents pbD As PictureBox
    Friend WithEvents pbC As PictureBox
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents pbAnswer As PictureBox
    Friend WithEvents pbArrow As PictureBox
    Friend WithEvents tbOctave As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblOcatave As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTrainerInstrument As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblTrainerInstrument As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPlayed As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNew As MetroFramework.Controls.MetroButton
    Friend WithEvents tglAutoNewNote As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pbOnOff As PictureBox
End Class
