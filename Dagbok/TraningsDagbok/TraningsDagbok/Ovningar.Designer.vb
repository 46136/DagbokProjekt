<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ovningar
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
        Me.txtOvning = New System.Windows.Forms.TextBox()
        Me.btnLaggTillOvning = New System.Windows.Forms.Button()
        Me.lstOvningar = New System.Windows.Forms.ListBox()
        Me.btnTabortOvningar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOvning
        '
        Me.txtOvning.Location = New System.Drawing.Point(220, 8)
        Me.txtOvning.Name = "txtOvning"
        Me.txtOvning.Size = New System.Drawing.Size(75, 23)
        Me.txtOvning.TabIndex = 1
        Me.txtOvning.Text = """Övning"""
        '
        'btnLaggTillOvning
        '
        Me.btnLaggTillOvning.Location = New System.Drawing.Point(220, 37)
        Me.btnLaggTillOvning.Name = "btnLaggTillOvning"
        Me.btnLaggTillOvning.Size = New System.Drawing.Size(75, 23)
        Me.btnLaggTillOvning.TabIndex = 2
        Me.btnLaggTillOvning.Text = "Lägg till"
        Me.btnLaggTillOvning.UseVisualStyleBackColor = True
        '
        'lstOvningar
        '
        Me.lstOvningar.FormattingEnabled = True
        Me.lstOvningar.ItemHeight = 15
        Me.lstOvningar.Location = New System.Drawing.Point(12, 8)
        Me.lstOvningar.Name = "lstOvningar"
        Me.lstOvningar.Size = New System.Drawing.Size(194, 169)
        Me.lstOvningar.TabIndex = 4
        '
        'btnTabortOvningar
        '
        Me.btnTabortOvningar.Location = New System.Drawing.Point(220, 154)
        Me.btnTabortOvningar.Name = "btnTabortOvningar"
        Me.btnTabortOvningar.Size = New System.Drawing.Size(75, 23)
        Me.btnTabortOvningar.TabIndex = 13
        Me.btnTabortOvningar.Text = "Ta bort"
        Me.btnTabortOvningar.UseVisualStyleBackColor = True
        '
        'Ovningar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 186)
        Me.Controls.Add(Me.btnTabortOvningar)
        Me.Controls.Add(Me.lstOvningar)
        Me.Controls.Add(Me.btnLaggTillOvning)
        Me.Controls.Add(Me.txtOvning)
        Me.Name = "Ovningar"
        Me.Text = "Ovningar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOvning As TextBox
    Friend WithEvents btnLaggTillOvning As Button
    Friend WithEvents lstOvningar As ListBox
    Friend WithEvents btnTabortOvningar As Button
End Class
