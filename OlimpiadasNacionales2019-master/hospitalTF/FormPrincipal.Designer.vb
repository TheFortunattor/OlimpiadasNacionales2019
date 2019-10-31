<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.btnAlarm = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnViewAlarm = New System.Windows.Forms.Button()
        Me.btnSetRespusta = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlarm
        '
        Me.btnAlarm.Location = New System.Drawing.Point(53, 102)
        Me.btnAlarm.Name = "btnAlarm"
        Me.btnAlarm.Size = New System.Drawing.Size(90, 41)
        Me.btnAlarm.TabIndex = 0
        Me.btnAlarm.Text = "Activar alarma"
        Me.btnAlarm.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(95, 26)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(335, 24)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Sistema Virtual Hospital tierra del fuego"
        '
        'btnViewAlarm
        '
        Me.btnViewAlarm.Location = New System.Drawing.Point(366, 102)
        Me.btnViewAlarm.Name = "btnViewAlarm"
        Me.btnViewAlarm.Size = New System.Drawing.Size(90, 41)
        Me.btnViewAlarm.TabIndex = 2
        Me.btnViewAlarm.Text = "Ver grupo de alarmas"
        Me.btnViewAlarm.UseVisualStyleBackColor = True
        '
        'btnSetRespusta
        '
        Me.btnSetRespusta.Location = New System.Drawing.Point(53, 185)
        Me.btnSetRespusta.Name = "btnSetRespusta"
        Me.btnSetRespusta.Size = New System.Drawing.Size(90, 41)
        Me.btnSetRespusta.TabIndex = 3
        Me.btnSetRespusta.Text = "Responder llamado"
        Me.btnSetRespusta.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(366, 185)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(90, 41)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Administracion"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 256)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnSetRespusta)
        Me.Controls.Add(Me.btnViewAlarm)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnAlarm)
        Me.Name = "FormPrincipal"
        Me.Text = "Sistema Virtual Hospital"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlarm As Button
    Friend WithEvents lblText As Label
    Friend WithEvents btnViewAlarm As Button
    Friend WithEvents btnSetRespusta As Button
    Friend WithEvents btnAdmin As Button
End Class
