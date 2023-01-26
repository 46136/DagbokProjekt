<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnNyttPass = New System.Windows.Forms.Button()
        Me.btnAktiviteter = New System.Windows.Forms.Button()
        Me.btnOvningar = New System.Windows.Forms.Button()
        Me.btnTaBort = New System.Windows.Forms.Button()
        Me.btnRedigera = New System.Windows.Forms.Button()
        Me.btnExpandList = New System.Windows.Forms.Button()
        Me.lstGammlaPass = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnNyttPass
        '
        Me.btnNyttPass.Location = New System.Drawing.Point(340, 12)
        Me.btnNyttPass.Name = "btnNyttPass"
        Me.btnNyttPass.Size = New System.Drawing.Size(75, 23)
        Me.btnNyttPass.TabIndex = 0
        Me.btnNyttPass.Text = "Nytt Pass"
        Me.btnNyttPass.UseVisualStyleBackColor = True
        '
        'btnAktiviteter
        '
        Me.btnAktiviteter.Location = New System.Drawing.Point(340, 41)
        Me.btnAktiviteter.Name = "btnAktiviteter"
        Me.btnAktiviteter.Size = New System.Drawing.Size(75, 23)
        Me.btnAktiviteter.TabIndex = 1
        Me.btnAktiviteter.Text = "Aktiviteter"
        Me.btnAktiviteter.UseVisualStyleBackColor = True
        '
        'btnOvningar
        '
        Me.btnOvningar.Location = New System.Drawing.Point(340, 70)
        Me.btnOvningar.Name = "btnOvningar"
        Me.btnOvningar.Size = New System.Drawing.Size(75, 23)
        Me.btnOvningar.TabIndex = 2
        Me.btnOvningar.Text = "Övningar"
        Me.btnOvningar.UseVisualStyleBackColor = True
        '
        'btnTaBort
        '
        Me.btnTaBort.Location = New System.Drawing.Point(340, 176)
        Me.btnTaBort.Name = "btnTaBort"
        Me.btnTaBort.Size = New System.Drawing.Size(75, 23)
        Me.btnTaBort.TabIndex = 3
        Me.btnTaBort.Text = "Ta Bort"
        Me.btnTaBort.UseVisualStyleBackColor = True
        '
        'btnRedigera
        '
        Me.btnRedigera.Location = New System.Drawing.Point(246, 176)
        Me.btnRedigera.Name = "btnRedigera"
        Me.btnRedigera.Size = New System.Drawing.Size(75, 23)
        Me.btnRedigera.TabIndex = 4
        Me.btnRedigera.Text = "Redigera"
        Me.btnRedigera.UseVisualStyleBackColor = True
        '
        'btnExpandList
        '
        Me.btnExpandList.Location = New System.Drawing.Point(210, 12)
        Me.btnExpandList.Name = "btnExpandList"
        Me.btnExpandList.Size = New System.Drawing.Size(30, 23)
        Me.btnExpandList.TabIndex = 6
        Me.btnExpandList.Text = "+"
        Me.btnExpandList.UseVisualStyleBackColor = True
        '
        'lstGammlaPass
        '
        Me.lstGammlaPass.FormattingEnabled = True
        Me.lstGammlaPass.ItemHeight = 15
        Me.lstGammlaPass.Location = New System.Drawing.Point(9, 5)
        Me.lstGammlaPass.Name = "lstGammlaPass"
        Me.lstGammlaPass.Size = New System.Drawing.Size(195, 184)
        Me.lstGammlaPass.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 206)
        Me.Controls.Add(Me.lstGammlaPass)
        Me.Controls.Add(Me.btnExpandList)
        Me.Controls.Add(Me.btnRedigera)
        Me.Controls.Add(Me.btnTaBort)
        Me.Controls.Add(Me.btnOvningar)
        Me.Controls.Add(Me.btnAktiviteter)
        Me.Controls.Add(Me.btnNyttPass)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNyttPass As Button
    Friend WithEvents btnAktiviteter As Button
    Friend WithEvents btnOvningar As Button
    Friend WithEvents btnTaBort As Button
    Friend WithEvents btnRedigera As Button
    Friend WithEvents btnExpandList As Button
    Friend WithEvents lstGammlaPass As ListBox
End Class
