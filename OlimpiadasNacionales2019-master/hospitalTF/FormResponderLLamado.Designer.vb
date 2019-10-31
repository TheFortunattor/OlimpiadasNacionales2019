<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResponderLLamado
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
        Me.btnSetRsp = New System.Windows.Forms.Button()
        Me.ComboBoxRespuesta = New System.Windows.Forms.ComboBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetRsp
        '
        Me.btnSetRsp.Location = New System.Drawing.Point(263, 56)
        Me.btnSetRsp.Name = "btnSetRsp"
        Me.btnSetRsp.Size = New System.Drawing.Size(75, 42)
        Me.btnSetRsp.TabIndex = 0
        Me.btnSetRsp.Text = "Responder llamdo"
        Me.btnSetRsp.UseVisualStyleBackColor = True
        '
        'ComboBoxRespuesta
        '
        Me.ComboBoxRespuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRespuesta.FormattingEnabled = True
        Me.ComboBoxRespuesta.Location = New System.Drawing.Point(12, 68)
        Me.ComboBoxRespuesta.Name = "ComboBoxRespuesta"
        Me.ComboBoxRespuesta.Size = New System.Drawing.Size(245, 21)
        Me.ComboBoxRespuesta.TabIndex = 1
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(319, 153)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 2
        Me.btnGoBack.Text = "Volver"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'FormResponderLLamado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 188)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.ComboBoxRespuesta)
        Me.Controls.Add(Me.btnSetRsp)
        Me.Name = "FormResponderLLamado"
        Me.Text = "FormResponderLLamado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSetRsp As Button
    Friend WithEvents ComboBoxRespuesta As ComboBox
    Friend WithEvents btnGoBack As Button
End Class
