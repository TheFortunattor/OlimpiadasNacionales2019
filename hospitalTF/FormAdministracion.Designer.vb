<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministracion
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
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.btnModPaciente = New System.Windows.Forms.Button()
        Me.btnDelPaciente = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnGoback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(153, 41)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(102, 49)
        Me.btnAgregarPaciente.TabIndex = 0
        Me.btnAgregarPaciente.Text = "Agregar paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'btnModPaciente
        '
        Me.btnModPaciente.Location = New System.Drawing.Point(327, 41)
        Me.btnModPaciente.Name = "btnModPaciente"
        Me.btnModPaciente.Size = New System.Drawing.Size(102, 49)
        Me.btnModPaciente.TabIndex = 1
        Me.btnModPaciente.Text = "Modificar paciente"
        Me.btnModPaciente.UseVisualStyleBackColor = True
        '
        'btnDelPaciente
        '
        Me.btnDelPaciente.Location = New System.Drawing.Point(498, 41)
        Me.btnDelPaciente.Name = "btnDelPaciente"
        Me.btnDelPaciente.Size = New System.Drawing.Size(102, 49)
        Me.btnDelPaciente.TabIndex = 2
        Me.btnDelPaciente.Text = "Eliminar paciente"
        Me.btnDelPaciente.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(153, 184)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Ficha del paciente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(327, 184)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Ingresar Usuario"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(498, 184)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 49)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Ver Estadisticas"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnGoback
        '
        Me.btnGoback.Location = New System.Drawing.Point(677, 299)
        Me.btnGoback.Name = "btnGoback"
        Me.btnGoback.Size = New System.Drawing.Size(75, 23)
        Me.btnGoback.TabIndex = 6
        Me.btnGoback.Text = "Volver"
        Me.btnGoback.UseVisualStyleBackColor = True
        '
        'FormAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 334)
        Me.Controls.Add(Me.btnGoback)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDelPaciente)
        Me.Controls.Add(Me.btnModPaciente)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Name = "FormAdministracion"
        Me.Text = "FormAdministracion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgregarPaciente As Button
    Friend WithEvents btnModPaciente As Button
    Friend WithEvents btnDelPaciente As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnGoback As Button
End Class
