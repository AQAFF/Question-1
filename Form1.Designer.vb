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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.cbStart = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.cbEnd = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.ListBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Loan Payment Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnCal)
        Me.GroupBox1.Controls.Add(Me.cbStart)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.cbEnd)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.txtLoan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 237)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Calculator"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(241, 192)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(154, 29)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Clear"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(53, 192)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(154, 29)
        Me.btnCal.TabIndex = 10
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'cbStart
        '
        Me.cbStart.FormattingEnabled = True
        Me.cbStart.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbStart.Location = New System.Drawing.Point(135, 81)
        Me.cbStart.Name = "cbStart"
        Me.cbStart.Size = New System.Drawing.Size(72, 28)
        Me.cbStart.TabIndex = 9
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(133, 121)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(125, 27)
        Me.txtRate.TabIndex = 8
        '
        'cbEnd
        '
        Me.cbEnd.FormattingEnabled = True
        Me.cbEnd.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbEnd.Location = New System.Drawing.Point(481, 89)
        Me.cbEnd.Name = "cbEnd"
        Me.cbEnd.Size = New System.Drawing.Size(68, 28)
        Me.cbEnd.TabIndex = 7
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbYear.Location = New System.Drawing.Point(481, 46)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(68, 28)
        Me.cbYear.TabIndex = 6
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(133, 39)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(125, 27)
        Me.txtLoan.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "End Rate(%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Years"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rate Step Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Start Rate (%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loan Amount"
        '
        'lbResult
        '
        Me.lbResult.FormattingEnabled = True
        Me.lbResult.ItemHeight = 20
        Me.lbResult.Items.AddRange(New Object() {"Interest Rate   Monthly Payment"})
        Me.lbResult.Location = New System.Drawing.Point(20, 278)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(768, 204)
        Me.lbResult.TabIndex = 12
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbName.Location = New System.Drawing.Point(20, 516)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(52, 20)
        Me.lbName.TabIndex = 13
        Me.lbName.Text = "Name"
        '
        'btnCar
        '
        Me.btnCar.Location = New System.Drawing.Point(652, 512)
        Me.btnCar.Name = "btnCar"
        Me.btnCar.Size = New System.Drawing.Size(136, 29)
        Me.btnCar.TabIndex = 14
        Me.btnCar.Text = "Car list"
        Me.btnCar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.btnCar)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car Loan Payment Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCal As Button
    Friend WithEvents cbStart As ComboBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents cbEnd As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbResult As ListBox
    Friend WithEvents lbName As Label
    Friend WithEvents btnCar As Button
End Class
