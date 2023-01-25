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
        Me.lstOvningar = New System.Windows.Forms.ListView()
        Me.txtOvning = New System.Windows.Forms.TextBox()
        Me.btnLaggTillOvning = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOvningar
        '
        Me.lstOvningar.Location = New System.Drawing.Point(12, 12)
        Me.lstOvningar.Name = "lstOvningar"
        Me.lstOvningar.Size = New System.Drawing.Size(296, 183)
        Me.lstOvningar.TabIndex = 0
        Me.lstOvningar.UseCompatibleStateImageBehavior = False
        '
        'txtOvning
        '
        Me.txtOvning.Location = New System.Drawing.Point(314, 15)
        Me.txtOvning.Name = "txtOvning"
        Me.txtOvning.Size = New System.Drawing.Size(109, 23)
        Me.txtOvning.TabIndex = 1
        Me.txtOvning.Text = """Övning"""
        '
        'btnLaggTillOvning
        '
        Me.btnLaggTillOvning.Location = New System.Drawing.Point(314, 172)
        Me.btnLaggTillOvning.Name = "btnLaggTillOvning"
        Me.btnLaggTillOvning.Size = New System.Drawing.Size(75, 23)
        Me.btnLaggTillOvning.TabIndex = 2
        Me.btnLaggTillOvning.Text = "Lägg till"
        Me.btnLaggTillOvning.UseVisualStyleBackColor = True
        '
        'Ovningar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 202)
        Me.Controls.Add(Me.btnLaggTillOvning)
        Me.Controls.Add(Me.txtOvning)
        Me.Controls.Add(Me.lstOvningar)
        Me.Name = "Ovningar"
        Me.Text = "Ovningar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOvningar As ListView
    Friend WithEvents txtOvning As TextBox
    Friend WithEvents btnLaggTillOvning As Button
End Class
