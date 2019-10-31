<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVerAlarmas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerAlarmas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.GroupBoxAlrm1 = New System.Windows.Forms.GroupBox()
        Me.lblSec1 = New System.Windows.Forms.Label()
        Me.GroupBoxAlrm2 = New System.Windows.Forms.GroupBox()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblSec2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumero3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblSec3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNUmero4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblSec4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAlrm1.SuspendLayout()
        Me.GroupBoxAlrm2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(102, 49)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(72, 44)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "0 0"
        '
        'GroupBoxAlrm1
        '
        Me.GroupBoxAlrm1.Controls.Add(Me.lblSec1)
        Me.GroupBoxAlrm1.Controls.Add(Me.lblNumero)
        Me.GroupBoxAlrm1.Controls.Add(Me.PictureBox1)
        Me.GroupBoxAlrm1.Location = New System.Drawing.Point(250, 22)
        Me.GroupBoxAlrm1.Name = "GroupBoxAlrm1"
        Me.GroupBoxAlrm1.Size = New System.Drawing.Size(226, 115)
        Me.GroupBoxAlrm1.TabIndex = 2
        Me.GroupBoxAlrm1.TabStop = False
        Me.GroupBoxAlrm1.Text = "Alarma Principal"
        '
        'lblSec1
        '
        Me.lblSec1.AutoSize = True
        Me.lblSec1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec1.Location = New System.Drawing.Point(99, 16)
        Me.lblSec1.Name = "lblSec1"
        Me.lblSec1.Size = New System.Drawing.Size(64, 20)
        Me.lblSec1.TabIndex = 6
        Me.lblSec1.Text = "Sector: "
        '
        'GroupBoxAlrm2
        '
        Me.GroupBoxAlrm2.Controls.Add(Me.lblNumero2)
        Me.GroupBoxAlrm2.Controls.Add(Me.PictureBox2)
        Me.GroupBoxAlrm2.Controls.Add(Me.lblSec2)
        Me.GroupBoxAlrm2.Location = New System.Drawing.Point(27, 176)
        Me.GroupBoxAlrm2.Name = "GroupBoxAlrm2"
        Me.GroupBoxAlrm2.Size = New System.Drawing.Size(164, 93)
        Me.GroupBoxAlrm2.TabIndex = 3
        Me.GroupBoxAlrm2.TabStop = False
        Me.GroupBoxAlrm2.Text = "Alarma 1"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero2.Location = New System.Drawing.Point(71, 40)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(57, 35)
        Me.lblNumero2.TabIndex = 11
        Me.lblNumero2.Text = "0 0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(31, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'lblSec2
        '
        Me.lblSec2.AutoSize = True
        Me.lblSec2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec2.Location = New System.Drawing.Point(68, 16)
        Me.lblSec2.Name = "lblSec2"
        Me.lblSec2.Size = New System.Drawing.Size(53, 16)
        Me.lblSec2.TabIndex = 9
        Me.lblSec2.Text = "Sector: "
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(630, 316)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumero3)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.lblSec3)
        Me.GroupBox1.Location = New System.Drawing.Point(275, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 93)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alarma 2"
        '
        'lblNumero3
        '
        Me.lblNumero3.AutoSize = True
        Me.lblNumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero3.Location = New System.Drawing.Point(71, 40)
        Me.lblNumero3.Name = "lblNumero3"
        Me.lblNumero3.Size = New System.Drawing.Size(57, 35)
        Me.lblNumero3.TabIndex = 11
        Me.lblNumero3.Text = "0 0"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'lblSec3
        '
        Me.lblSec3.AutoSize = True
        Me.lblSec3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec3.Location = New System.Drawing.Point(68, 16)
        Me.lblSec3.Name = "lblSec3"
        Me.lblSec3.Size = New System.Drawing.Size(53, 16)
        Me.lblSec3.TabIndex = 9
        Me.lblSec3.Text = "Sector: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNUmero4)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.lblSec4)
        Me.GroupBox2.Location = New System.Drawing.Point(509, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 93)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alarma 3"
        '
        'lblNUmero4
        '
        Me.lblNUmero4.AutoSize = True
        Me.lblNUmero4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNUmero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNUmero4.Location = New System.Drawing.Point(71, 40)
        Me.lblNUmero4.Name = "lblNUmero4"
        Me.lblNUmero4.Size = New System.Drawing.Size(57, 35)
        Me.lblNUmero4.TabIndex = 11
        Me.lblNUmero4.Text = "0 0"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(31, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'lblSec4
        '
        Me.lblSec4.AutoSize = True
        Me.lblSec4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec4.Location = New System.Drawing.Point(68, 16)
        Me.lblSec4.Name = "lblSec4"
        Me.lblSec4.Size = New System.Drawing.Size(53, 16)
        Me.lblSec4.TabIndex = 9
        Me.lblSec4.Text = "Sector: "
        '
        'FormVerAlarmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 351)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBoxAlrm2)
        Me.Controls.Add(Me.GroupBoxAlrm1)
        Me.Name = "FormVerAlarmas"
        Me.Text = "FormVerAlarmas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAlrm1.ResumeLayout(False)
        Me.GroupBoxAlrm1.PerformLayout()
        Me.GroupBoxAlrm2.ResumeLayout(False)
        Me.GroupBoxAlrm2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents GroupBoxAlrm1 As GroupBox
    Friend WithEvents GroupBoxAlrm2 As GroupBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblSec1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblSec2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumero3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblSec3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblNUmero4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblSec4 As Label
End Class
