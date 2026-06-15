<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        grpMembership = New GroupBox()
        rdoSingle = New RadioButton()
        rdoFamily = New RadioButton()
        grpAdditional = New GroupBox()
        chkGolf = New CheckBox()
        chkTennis = New CheckBox()
        chkRaquetball = New CheckBox()
        lblBasicFee = New Label()
        lblFee = New Label()
        lblAdditional = New Label()
        lblAdditionalFee = New Label()
        lblMonthlyDues = New Label()
        lblTotal = New Label()
        btnCalculate = New Button()
        btnExit = New Button()
        grpMembership.SuspendLayout()
        grpAdditional.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpMembership
        ' 
        grpMembership.Controls.Add(rdoSingle)
        grpMembership.Controls.Add(rdoFamily)
        grpMembership.Location = New Point(12, 12)
        grpMembership.Name = "grpMembership"
        grpMembership.Size = New Size(136, 133)
        grpMembership.TabIndex = 0
        grpMembership.TabStop = False
        grpMembership.Text = "Membership"
        ' 
        ' rdoSingle
        ' 
        rdoSingle.AutoSize = True
        rdoSingle.Location = New Point(7, 37)
        rdoSingle.Name = "rdoSingle"
        rdoSingle.Size = New Size(57, 19)
        rdoSingle.TabIndex = 0
        rdoSingle.TabStop = True
        rdoSingle.Text = "&Single"
        rdoSingle.UseVisualStyleBackColor = True
        ' 
        ' rdoFamily
        ' 
        rdoFamily.AutoSize = True
        rdoFamily.Location = New Point(6, 72)
        rdoFamily.Name = "rdoFamily"
        rdoFamily.Size = New Size(60, 19)
        rdoFamily.TabIndex = 1
        rdoFamily.TabStop = True
        rdoFamily.Text = "&Family"
        rdoFamily.UseVisualStyleBackColor = True
        ' 
        ' grpAdditional
        ' 
        grpAdditional.Controls.Add(chkGolf)
        grpAdditional.Controls.Add(chkTennis)
        grpAdditional.Controls.Add(chkRaquetball)
        grpAdditional.Location = New Point(183, 12)
        grpAdditional.Name = "grpAdditional"
        grpAdditional.Size = New Size(136, 133)
        grpAdditional.TabIndex = 0
        grpAdditional.TabStop = False
        grpAdditional.Text = "Additional"
        ' 
        ' chkGolf
        ' 
        chkGolf.AutoSize = True
        chkGolf.Location = New Point(6, 22)
        chkGolf.Name = "chkGolf"
        chkGolf.Size = New Size(48, 19)
        chkGolf.TabIndex = 2
        chkGolf.Text = "&Golf"
        chkGolf.UseVisualStyleBackColor = True
        ' 
        ' chkTennis
        ' 
        chkTennis.AutoSize = True
        chkTennis.Location = New Point(6, 60)
        chkTennis.Name = "chkTennis"
        chkTennis.Size = New Size(60, 19)
        chkTennis.TabIndex = 3
        chkTennis.Text = "&Tennis"
        chkTennis.UseVisualStyleBackColor = True
        ' 
        ' chkRaquetball
        ' 
        chkRaquetball.AutoSize = True
        chkRaquetball.Location = New Point(6, 98)
        chkRaquetball.Name = "chkRaquetball"
        chkRaquetball.Size = New Size(88, 19)
        chkRaquetball.TabIndex = 4
        chkRaquetball.Text = "&Racquetball"
        chkRaquetball.UseVisualStyleBackColor = True
        ' 
        ' lblBasicFee
        ' 
        lblBasicFee.AutoSize = True
        lblBasicFee.Location = New Point(12, 182)
        lblBasicFee.Name = "lblBasicFee"
        lblBasicFee.Size = New Size(58, 15)
        lblBasicFee.TabIndex = 5
        lblBasicFee.Text = "Basic Fee:"
        ' 
        ' lblFee
        ' 
        lblFee.AutoSize = True
        lblFee.Location = New Point(12, 206)
        lblFee.Name = "lblFee"
        lblFee.Size = New Size(0, 15)
        lblFee.TabIndex = 6
        ' 
        ' lblAdditional
        ' 
        lblAdditional.AutoSize = True
        lblAdditional.Location = New Point(183, 182)
        lblAdditional.Name = "lblAdditional"
        lblAdditional.Size = New Size(65, 15)
        lblAdditional.TabIndex = 7
        lblAdditional.Text = "Additional:"
        ' 
        ' lblAdditionalFee
        ' 
        lblAdditionalFee.AutoSize = True
        lblAdditionalFee.Location = New Point(183, 206)
        lblAdditionalFee.Name = "lblAdditionalFee"
        lblAdditionalFee.Size = New Size(0, 15)
        lblAdditionalFee.TabIndex = 8
        ' 
        ' lblMonthlyDues
        ' 
        lblMonthlyDues.AutoSize = True
        lblMonthlyDues.Location = New Point(12, 308)
        lblMonthlyDues.Name = "lblMonthlyDues"
        lblMonthlyDues.Size = New Size(83, 15)
        lblMonthlyDues.TabIndex = 9
        lblMonthlyDues.Text = "Monthly dues:"
        ' 
        ' lblTotal
        ' 
        lblTotal.Location = New Point(12, 337)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(109, 24)
        lblTotal.TabIndex = 10
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ControlLight
        btnCalculate.Location = New Point(141, 328)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(83, 33)
        btnCalculate.TabIndex = 11
        btnCalculate.Text = "&Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ControlLight
        btnExit.Location = New Point(236, 328)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(83, 33)
        btnExit.TabIndex = 12
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 416)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(lblBasicFee)
        Controls.Add(lblFee)
        Controls.Add(lblAdditional)
        Controls.Add(lblAdditionalFee)
        Controls.Add(lblMonthlyDues)
        Controls.Add(lblTotal)
        Controls.Add(grpAdditional)
        Controls.Add(grpMembership)
        Name = "Form1"
        Text = "Glasgow"
        grpMembership.ResumeLayout(False)
        grpMembership.PerformLayout()
        grpAdditional.ResumeLayout(False)
        grpAdditional.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpMembership As GroupBox
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoFamily As RadioButton
    Friend WithEvents grpAdditional As GroupBox
    Friend WithEvents chkGolf As CheckBox
    Friend WithEvents chkTennis As CheckBox
    Friend WithEvents chkRaquetball As CheckBox
    Friend WithEvents lblBasicFee As Label
    Friend WithEvents lblFee As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents lblAdditionalFee As Label
    Friend WithEvents lblMonthlyDues As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button

End Class
