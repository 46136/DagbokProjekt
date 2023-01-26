<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NyttPass
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
        Me.lstOvningar = New System.Windows.Forms.ListBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnLaggTill = New System.Windows.Forms.Button()
        Me.btnTabort = New System.Windows.Forms.Button()
        Me.btnRedigera = New System.Windows.Forms.Button()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.cbOvning = New System.Windows.Forms.ComboBox()
        Me.txtLangd = New System.Windows.Forms.TextBox()
        Me.rtbAnteckningars = New System.Windows.Forms.RichTextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.cbRep = New System.Windows.Forms.ComboBox()
        Me.cbSet = New System.Windows.Forms.ComboBox()
        Me.cbVikt = New System.Windows.Forms.ComboBox()
        Me.cbRpe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstOvningar
        '
        Me.lstOvningar.FormattingEnabled = True
        Me.lstOvningar.ItemHeight = 15
        Me.lstOvningar.Location = New System.Drawing.Point(332, 11)
        Me.lstOvningar.Name = "lstOvningar"
        Me.lstOvningar.Size = New System.Drawing.Size(194, 214)
        Me.lstOvningar.TabIndex = 0
        '
        'btnSpara
        '
        Me.btnSpara.Location = New System.Drawing.Point(12, 206)
        Me.btnSpara.Name = "btnSpara"
        Me.btnSpara.Size = New System.Drawing.Size(75, 23)
        Me.btnSpara.TabIndex = 7
        Me.btnSpara.Text = "Spara"
        Me.btnSpara.UseVisualStyleBackColor = True
        '
        'btnLaggTill
        '
        Me.btnLaggTill.Location = New System.Drawing.Point(12, 177)
        Me.btnLaggTill.Name = "btnLaggTill"
        Me.btnLaggTill.Size = New System.Drawing.Size(75, 23)
        Me.btnLaggTill.TabIndex = 6
        Me.btnLaggTill.Text = "lägg till"
        Me.btnLaggTill.UseVisualStyleBackColor = True
        '
        'btnTabort
        '
        Me.btnTabort.Location = New System.Drawing.Point(251, 206)
        Me.btnTabort.Name = "btnTabort"
        Me.btnTabort.Size = New System.Drawing.Size(75, 23)
        Me.btnTabort.TabIndex = 12
        Me.btnTabort.Text = "Ta bort"
        Me.btnTabort.UseVisualStyleBackColor = True
        '
        'btnRedigera
        '
        Me.btnRedigera.Location = New System.Drawing.Point(251, 177)
        Me.btnRedigera.Name = "btnRedigera"
        Me.btnRedigera.Size = New System.Drawing.Size(75, 23)
        Me.btnRedigera.TabIndex = 11
        Me.btnRedigera.Text = "Redigera"
        Me.btnRedigera.UseVisualStyleBackColor = True
        '
        'dtpDatum
        '
        Me.dtpDatum.Location = New System.Drawing.Point(12, 12)
        Me.dtpDatum.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDatum.Name = "dtpDatum"
        Me.dtpDatum.Size = New System.Drawing.Size(88, 23)
        Me.dtpDatum.TabIndex = 13
        '
        'cbOvning
        '
        Me.cbOvning.FormattingEnabled = True
        Me.cbOvning.Location = New System.Drawing.Point(12, 42)
        Me.cbOvning.Name = "cbOvning"
        Me.cbOvning.Size = New System.Drawing.Size(88, 23)
        Me.cbOvning.Sorted = True
        Me.cbOvning.TabIndex = 14
        Me.cbOvning.Text = """ovning"""
        '
        'txtLangd
        '
        Me.txtLangd.Location = New System.Drawing.Point(108, 27)
        Me.txtLangd.Name = "txtLangd"
        Me.txtLangd.Size = New System.Drawing.Size(90, 23)
        Me.txtLangd.TabIndex = 18
        Me.txtLangd.Text = "Pass Längd(min)"
        '
        'rtbAnteckningars
        '
        Me.rtbAnteckningars.Location = New System.Drawing.Point(108, 56)
        Me.rtbAnteckningars.Name = "rtbAnteckningars"
        Me.rtbAnteckningars.Size = New System.Drawing.Size(209, 96)
        Me.rtbAnteckningars.TabIndex = 19
        Me.rtbAnteckningars.Text = """Anteckningar"""
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(157, 177)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(88, 23)
        Me.txtReplace.TabIndex = 21
        Me.txtReplace.Text = """Nytt värde"""
        '
        'cbRep
        '
        Me.cbRep.FormattingEnabled = True
        Me.cbRep.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbRep.Location = New System.Drawing.Point(12, 71)
        Me.cbRep.Name = "cbRep"
        Me.cbRep.Size = New System.Drawing.Size(88, 23)
        Me.cbRep.TabIndex = 22
        Me.cbRep.Text = """reps"""
        '
        'cbSet
        '
        Me.cbSet.FormattingEnabled = True
        Me.cbSet.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbSet.Location = New System.Drawing.Point(12, 100)
        Me.cbSet.Name = "cbSet"
        Me.cbSet.Size = New System.Drawing.Size(88, 23)
        Me.cbSet.TabIndex = 23
        Me.cbSet.Text = """sets"""
        '
        'cbVikt
        '
        Me.cbVikt.FormattingEnabled = True
        Me.cbVikt.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbVikt.Location = New System.Drawing.Point(12, 129)
        Me.cbVikt.Name = "cbVikt"
        Me.cbVikt.Size = New System.Drawing.Size(88, 23)
        Me.cbVikt.TabIndex = 24
        Me.cbVikt.Text = """vikt"""
        '
        'cbRpe
        '
        Me.cbRpe.FormattingEnabled = True
        Me.cbRpe.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbRpe.Location = New System.Drawing.Point(229, 27)
        Me.cbRpe.Name = "cbRpe"
        Me.cbRpe.Size = New System.Drawing.Size(88, 23)
        Me.cbRpe.TabIndex = 25
        Me.cbRpe.Text = """rpe"""
        '
        'NyttPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 233)
        Me.Controls.Add(Me.cbRpe)
        Me.Controls.Add(Me.cbVikt)
        Me.Controls.Add(Me.cbSet)
        Me.Controls.Add(Me.cbRep)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.rtbAnteckningars)
        Me.Controls.Add(Me.txtLangd)
        Me.Controls.Add(Me.cbOvning)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.btnTabort)
        Me.Controls.Add(Me.btnRedigera)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.btnLaggTill)
        Me.Controls.Add(Me.lstOvningar)
        Me.Name = "NyttPass"
        Me.Text = "NyttPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOvningar As ListBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnLaggTill As Button
    Friend WithEvents btnTabort As Button
    Friend WithEvents btnRedigera As Button
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents cbOvning As ComboBox
    Friend WithEvents txtLangd As TextBox
    Friend WithEvents rtbAnteckningars As RichTextBox
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents cbRep As ComboBox
    Friend WithEvents cbSet As ComboBox
    Friend WithEvents cbVikt As ComboBox
    Friend WithEvents cbRpe As ComboBox
End Class
