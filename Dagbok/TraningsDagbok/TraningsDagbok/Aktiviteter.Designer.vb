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
        Me.components = New System.ComponentModel.Container()
        Me.btnLaggTillAktivitet = New System.Windows.Forms.Button()
        Me.txtAktivitet = New System.Windows.Forms.TextBox()
        Me.btnTaBort = New System.Windows.Forms.Button()
        Me.lstAktiviteter = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLaggTillAktivitet
        '
        Me.btnLaggTillAktivitet.Location = New System.Drawing.Point(245, 12)
        Me.btnLaggTillAktivitet.Name = "btnLaggTillAktivitet"
        Me.btnLaggTillAktivitet.Size = New System.Drawing.Size(75, 23)
        Me.btnLaggTillAktivitet.TabIndex = 1
        Me.btnLaggTillAktivitet.Text = "Lägg till"
        Me.btnLaggTillAktivitet.UseVisualStyleBackColor = True
        '
        'txtAktivitet
        '
        Me.txtAktivitet.Location = New System.Drawing.Point(139, 12)
        Me.txtAktivitet.Name = "txtAktivitet"
        Me.txtAktivitet.Size = New System.Drawing.Size(100, 23)
        Me.txtAktivitet.TabIndex = 2
        Me.txtAktivitet.Text = """Aktivitet"""
        '
        'btnTaBort
        '
        Me.btnTaBort.Location = New System.Drawing.Point(245, 37)
        Me.btnTaBort.Name = "btnTaBort"
        Me.btnTaBort.Size = New System.Drawing.Size(75, 23)
        Me.btnTaBort.TabIndex = 4
        Me.btnTaBort.Text = "list"
        Me.btnTaBort.UseVisualStyleBackColor = True
        '
        'lstAktiviteter
        '
        Me.lstAktiviteter.FormattingEnabled = True
        Me.lstAktiviteter.Location = New System.Drawing.Point(12, 12)
        Me.lstAktiviteter.Name = "lstAktiviteter"
        Me.lstAktiviteter.Size = New System.Drawing.Size(121, 23)
        Me.lstAktiviteter.TabIndex = 5
        '
        'BindingSource1
        '
        '
        'Aktiviteter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 76)
        Me.Controls.Add(Me.lstAktiviteter)
        Me.Controls.Add(Me.btnTaBort)
        Me.Controls.Add(Me.txtAktivitet)
        Me.Controls.Add(Me.btnLaggTillAktivitet)
        Me.Name = "Aktiviteter"
        Me.Text = "Aktiviteter"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaggTillAktivitet As Button
    Friend WithEvents txtAktivitet As TextBox
    Friend WithEvents btnTaBort As Button
    Friend WithEvents lstAktiviteter As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
End Class
