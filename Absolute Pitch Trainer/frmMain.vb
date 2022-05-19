Imports Midi

Public Class frmMain
    Dim mdiDevice As Midi.OutputDevice = Midi.OutputDevice.InstalledDevices(0)
    Dim instr As Instrument = Instrument.AcousticGrandPiano, chnl As Channel = 0
    Dim rootNote As Pitch, plNote As Pitch
    Private Sub playNote(ByRef note As Integer)
        mdiDevice.SendNoteOn(1, note, tbVolume.Value)
    End Sub
    Private Sub Silence()
        Try
            mdiDevice.SilenceAllNotes()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Function rndNote() As Pitch
        Dim index As Short = CShort(11 * Rnd())
        rootNote = 12 + 12 * tbOctave.Value + index
        Return rootNote
    End Function
    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            tmrTrainer.Enabled = False
            Silence()
            mdiDevice.Close()
            Debug.WriteLine("Silence to all notes and close the midi sequencer")
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pbArrow.Image = Nothing
            mdiDevice.Open()
            Debug.WriteLine("opening the midi sequencer")
            chnl = My.Settings.Channel
            instr = System.Enum.Parse(GetType(Instrument), My.Settings.Instrument)
            mdiDevice.SendProgramChange(chnl, instr)
            cboInstrument.SelectedIndex = cboInstrument.FindString(My.Settings.Instrument)
            mdiDevice.SendProgramChange(1, System.Enum.Parse(GetType(Instrument), My.Settings.TrainerInstrument))
            cboTrainerInstrument.SelectedIndex = cboTrainerInstrument.FindString(My.Settings.TrainerInstrument)
            tbInterval.Value = My.Settings.Interval
            tmrTrainer.Interval = tbInterval.Value
            tbVolume.Value = My.Settings.Volume
            tbOctave.Value = My.Settings.Octave
            lblOcatave.Text = "Octave " & tbOctave.Value
            rndNote()
            tglAutoNewNote.Checked = My.Settings.AutoNewNote
            btnNew.Enabled = Not (tglAutoNewNote.Checked)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        If mdiDevice.IsOpen = False Then MsgBox("The MIDI sequencer is failed to open!", MsgBoxStyle.Critical, Application.ProductName)
    End Sub

    Private Sub cboInstrument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstrument.SelectedIndexChanged
        Try
            Silence()
            instr = System.Enum.Parse(GetType(Instrument), cboInstrument.Text)
            mdiDevice.SendProgramChange(chnl, instr)
            Debug.WriteLine("The new instrument will be: " & instr.ToString)
            My.Settings.Instrument = cboInstrument.SelectedItem.ToString
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        rndNote()
        If btnSwitch.Text = "&Start" Then
            btnSwitch.Text = "&Stop"
            tmrTrainer.Enabled = True
        Else
            btnSwitch.Text = "&Start"
            tmrTrainer.Enabled = False
            Silence()
        End If
        pbOnOff.Visible = tmrTrainer.Enabled
    End Sub

    Private Sub tbOctave_Scroll(sender As Object, e As ScrollEventArgs) Handles tbOctave.Scroll
        Silence()
        lblOcatave.Text = "Octave " & tbOctave.Value
        My.Settings.Octave = tbOctave.Value
        rndNote()
    End Sub

    Private Sub tmrTrainer_Tick(sender As Object, e As EventArgs) Handles tmrTrainer.Tick
        playNote(rootNote)
        lblInfo.Text = "Root: " & rootNote & ", " & rootNote.ToString
    End Sub

    Private Sub tbInterval_Scroll(sender As Object, e As ScrollEventArgs) Handles tbInterval.Scroll
        Silence()
        My.Settings.Interval = tbInterval.Value
        tmrTrainer.Interval = tbInterval.Value
    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As ScrollEventArgs) Handles tbVolume.Scroll
        My.Settings.Volume = tbVolume.Value
    End Sub

    Private Sub cboTrainerInstrument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrainerInstrument.SelectedIndexChanged
        Try
            Silence()
            mdiDevice.SendProgramChange(1, System.Enum.Parse(GetType(Instrument), cboTrainerInstrument.SelectedItem.ToString))
            Debug.WriteLine("Trainer's instrument will be changed to " & cboTrainerInstrument.SelectedItem.ToString)
            My.Settings.TrainerInstrument = cboTrainerInstrument.SelectedItem.ToString
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub chkAnswer(ByRef note As Pitch)
        If plNote = rootNote Then
            If tglAutoNewNote.Checked Then
                rndNote()
            End If
            pbArrow.Image = My.Resources.YellowCheck
        Else
            pbArrow.Image = My.Resources.Caution
        End If
    End Sub
#Region "Keyboard"
    ' C
    Private Sub pbC_MouseDown(sender As Object, e As MouseEventArgs) Handles pbC.MouseDown
        plNote = 12 + 12 * tbOctave.Value
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbC.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbC_MouseUp(sender As Object, e As MouseEventArgs) Handles pbC.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbC.BackColor = Color.White
    End Sub
    'C#
    Private Sub pbCSharp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbCSharp.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 1
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbCSharp.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbCSharp_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCSharp.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbCSharp.BackColor = Color.Black
    End Sub
    'D
    Private Sub pbD_MouseDown(sender As Object, e As MouseEventArgs) Handles pbD.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 2
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbD.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbD_MouseUp(sender As Object, e As MouseEventArgs) Handles pbD.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbD.BackColor = Color.White
    End Sub

    'D#
    Private Sub pbDSharp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbDSharp.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 3
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbDSharp.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbDSharp_MouseUp(sender As Object, e As MouseEventArgs) Handles pbDSharp.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbDSharp.BackColor = Color.Black
    End Sub
    'E
    Private Sub pbE_MouseDown(sender As Object, e As MouseEventArgs) Handles pbE.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 4
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbE.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbE_MouseUp(sender As Object, e As MouseEventArgs) Handles pbE.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbE.BackColor = Color.White
    End Sub
    'F
    Private Sub pbF_MouseDown(sender As Object, e As MouseEventArgs) Handles pbF.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 5
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbF.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbF_MouseUp(sender As Object, e As MouseEventArgs) Handles pbF.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbF.BackColor = Color.White
    End Sub
    'F#
    Private Sub pbFSharp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbFSharp.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 6
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbFSharp.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbFSharp_MouseUp(sender As Object, e As MouseEventArgs) Handles pbFSharp.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbFSharp.BackColor = Color.Black
    End Sub
    'G
    Private Sub pbG_MouseDown(sender As Object, e As MouseEventArgs) Handles pbG.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 7
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbG.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbG_MouseUp(sender As Object, e As MouseEventArgs) Handles pbG.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbG.BackColor = Color.White
    End Sub
    'G#
    Private Sub pbGSharp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbGSharp.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 8
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbGSharp.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbGSharp_MouseUp(sender As Object, e As MouseEventArgs) Handles pbGSharp.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbGSharp.BackColor = Color.Black
    End Sub
    'A
    Private Sub pbA_MouseDown(sender As Object, e As MouseEventArgs) Handles pbA.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 9
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbA.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbA_MouseUp(sender As Object, e As MouseEventArgs) Handles pbA.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbA.BackColor = Color.White
    End Sub
    'A#
    Private Sub pbASharp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbASharp.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 10
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbASharp.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbASharp_MouseUp(sender As Object, e As MouseEventArgs) Handles pbASharp.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbASharp.BackColor = Color.Black
    End Sub
    'B
    Private Sub pbB_MouseDown(sender As Object, e As MouseEventArgs) Handles pbB.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 11
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbB.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbB_MouseUp(sender As Object, e As MouseEventArgs) Handles pbB.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbB.BackColor = Color.White
    End Sub
    'C2
    Private Sub pbC2_MouseDown(sender As Object, e As MouseEventArgs) Handles pbC2.MouseDown
        plNote = 12 + 12 * tbOctave.Value + 12
        lblPlayed.Text = "You played: " & plNote.ToString & ", " & plNote
        mdiDevice.SendNoteOn(chnl, plNote, tbVolume.Value)
        pbC2.BackColor = Color.Yellow
        chkAnswer(plNote)
    End Sub
    Private Sub pbC2_MouseUp(sender As Object, e As MouseEventArgs) Handles pbC2.MouseUp
        mdiDevice.SendNoteOff(chnl, plNote, tbVolume.Value)
        pbC2.BackColor = Color.White
    End Sub
#End Region
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        rndNote()
    End Sub
    Private Sub tglAutoNewNote_CheckedChanged(sender As Object, e As EventArgs) Handles tglAutoNewNote.CheckedChanged
        btnNew.Enabled = Not (tglAutoNewNote.Checked)
        My.Settings.AutoNewNote = tglAutoNewNote.Checked
    End Sub
End Class
