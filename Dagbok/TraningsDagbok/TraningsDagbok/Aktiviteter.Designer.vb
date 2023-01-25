<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aktiviteter
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
        Me.lstAktiviteter = New System.Windows.Forms.ListView()
        Me.btnLaggTillAktivitet = New System.Windows.Forms.Button()
        Me.txtAktivitet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstAktiviteter
        '
        Me.lstAktiviteter.Location = New System.Drawing.Point(13, 11)
        Me.lstAktiviteter.Name = "lstAktiviteter"
        Me.lstAktiviteter.Size = New System.Drawing.Size(325, 260)
        Me.lstAktiviteter.TabIndex = 0
        Me.lstAktiviteter.UseCompatibleStateImageBehavior = False
        '
        'btnLaggTillAktivitet
        '
        Me.btnLaggTillAktivitet.Location = New System.Drawing.Point(344, 246)
        Me.btnLaggTillAktivitet.Name = "btnLaggTillAktivitet"
        Me.btnLaggTillAktivitet.Size = New System.Drawing.Size(75, 23)
        Me.btnLaggTillAktivitet.TabIndex = 1
        Me.btnLaggTillAktivitet.Text = "Lägg till"
        Me.btnLaggTillAktivitet.UseVisualStyleBackColor = True
        '
        'txtAktivitet
        '
        Me.txtAktivitet.Location = New System.Drawing.Point(343, 12)
        Me.txtAktivitet.Name = "txtAktivitet"
        Me.txtAktivitet.Size = New System.Drawing.Size(100, 23)
        Me.txtAktivitet.TabIndex = 2
        Me.txtAktivitet.Text = """Aktivitet"""
        '
        'Aktiviteter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 281)
        Me.Controls.Add(Me.txtAktivitet)
        Me.Controls.Add(Me.btnLaggTillAktivitet)
        Me.Controls.Add(Me.lstAktiviteter)
        Me.Name = "Aktiviteter"
        Me.Text = "Aktiviteter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAktiviteter As ListView
    Friend WithEvents btnLaggTillAktivitet As Button
    Friend WithEvents txtAktivitet As TextBox
End Class
