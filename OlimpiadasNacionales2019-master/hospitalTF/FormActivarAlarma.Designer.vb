<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActivarAlarma
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
        Me.btnActivateAlarm = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnActivateAlarm
        '
        Me.btnActivateAlarm.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnActivateAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivateAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActivateAlarm.Location = New System.Drawing.Point(190, 78)
        Me.btnActivateAlarm.Name = "btnActivateAlarm"
        Me.btnActivateAlarm.Size = New System.Drawing.Size(191, 116)
        Me.btnActivateAlarm.TabIndex = 0
        Me.btnActivateAlarm.Text = "Activar Alarma!"
        Me.btnActivateAlarm.UseVisualStyleBackColor = False
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(514, 280)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Volver"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'FormActivarAlarma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 315)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnActivateAlarm)
        Me.Name = "FormActivarAlarma"
        Me.Text = "Activar Alarma"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnActivateAlarm As Button
    Friend WithEvents btnGoBack As Button
End Class
