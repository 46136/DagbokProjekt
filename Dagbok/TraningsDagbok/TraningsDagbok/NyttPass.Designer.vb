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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSpara = New System.Windows.Forms.Button()
        Me.btnLaggTill = New System.Windows.Forms.Button()
        Me.btnTabort = New System.Windows.Forms.Button()
        Me.btnRedigera = New System.Windows.Forms.Button()
        Me.dtpDatum = New System.Windows.Forms.DateTimePicker()
        Me.cbOvning = New System.Windows.Forms.ComboBox()
        Me.txtSet = New System.Windows.Forms.TextBox()
        Me.txtRep = New System.Windows.Forms.TextBox()
        Me.txtVikt = New System.Windows.Forms.TextBox()
        Me.txtLangd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(202, 11)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(324, 214)
        Me.ListBox1.TabIndex = 0
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
        Me.btnTabort.Location = New System.Drawing.Point(93, 206)
        Me.btnTabort.Name = "btnTabort"
        Me.btnTabort.Size = New System.Drawing.Size(75, 23)
        Me.btnTabort.TabIndex = 12
        Me.btnTabort.Text = "Ta bort"
        Me.btnTabort.UseVisualStyleBackColor = True
        '
        'btnRedigera
        '
        Me.btnRedigera.Location = New System.Drawing.Point(93, 177)
        Me.btnRedigera.Name = "btnRedigera"
        Me.btnRedigera.Size = New System.Drawing.Size(75, 23)
        Me.btnRedigera.TabIndex = 11
        Me.btnRedigera.Text = "Redigera"
        Me.btnRedigera.UseVisualStyleBackColor = True
        '
        'dtpDatum
        '
        Me.dtpDatum.Location = New System.Drawing.Point(12, 12)
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
        Me.cbOvning.TabIndex = 14
        Me.cbOvning.Text = "Övning"
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(12, 71)
        Me.txtSet.Name = "txtSet"
        Me.txtSet.Size = New System.Drawing.Size(88, 23)
        Me.txtSet.TabIndex = 15
        Me.txtSet.Text = """SET"""
        '
        'txtRep
        '
        Me.txtRep.Location = New System.Drawing.Point(12, 100)
        Me.txtRep.Name = "txtRep"
        Me.txtRep.Size = New System.Drawing.Size(88, 23)
        Me.txtRep.TabIndex = 16
        Me.txtRep.Text = """REP"""
        '
        'txtVikt
        '
        Me.txtVikt.Location = New System.Drawing.Point(12, 129)
        Me.txtVikt.Name = "txtVikt"
        Me.txtVikt.Size = New System.Drawing.Size(88, 23)
        Me.txtVikt.TabIndex = 17
        Me.txtVikt.Text = """VIKT"""
        '
        'txtLangd
        '
        Me.txtLangd.Location = New System.Drawing.Point(108, 11)
        Me.txtLangd.Name = "txtLangd"
        Me.txtLangd.Size = New System.Drawing.Size(88, 23)
        Me.txtLangd.TabIndex = 18
        Me.txtLangd.Text = """Längd i Min"""
        '
        'NyttPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 233)
        Me.Controls.Add(Me.txtLangd)
        Me.Controls.Add(Me.txtVikt)
        Me.Controls.Add(Me.txtRep)
        Me.Controls.Add(Me.txtSet)
        Me.Controls.Add(Me.cbOvning)
        Me.Controls.Add(Me.dtpDatum)
        Me.Controls.Add(Me.btnTabort)
        Me.Controls.Add(Me.btnRedigera)
        Me.Controls.Add(Me.btnSpara)
        Me.Controls.Add(Me.btnLaggTill)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "NyttPass"
        Me.Text = "NyttPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnSpara As Button
    Friend WithEvents btnLaggTill As Button
    Friend WithEvents btnTabort As Button
    Friend WithEvents btnRedigera As Button
    Friend WithEvents dtpDatum As DateTimePicker
    Friend WithEvents cbOvning As ComboBox
    Friend WithEvents txtSet As TextBox
    Friend WithEvents txtRep As TextBox
    Friend WithEvents txtVikt As TextBox
    Friend WithEvents txtLangd As TextBox
End Class
