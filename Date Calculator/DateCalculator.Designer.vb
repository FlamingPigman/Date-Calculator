' Created by William Chio
' Date: 13/05/2024

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateCalculator
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
        Me.IGADate = New System.Windows.Forms.DateTimePicker()
        Me.IGALabel = New System.Windows.Forms.Label()
        Me.IGATextbox = New System.Windows.Forms.TextBox()
        Me.AldiTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AldiDate = New System.Windows.Forms.DateTimePicker()
        Me.ColesTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColesDate = New System.Windows.Forms.DateTimePicker()
        Me.CustomEffTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBtwn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IGADate
        '
        Me.IGADate.Checked = False
        Me.IGADate.CustomFormat = ""
        Me.IGADate.Location = New System.Drawing.Point(36, 58)
        Me.IGADate.Name = "IGADate"
        Me.IGADate.Size = New System.Drawing.Size(132, 23)
        Me.IGADate.TabIndex = 2
        '
        'IGALabel
        '
        Me.IGALabel.AutoSize = True
        Me.IGALabel.Location = New System.Drawing.Point(58, 40)
        Me.IGALabel.Name = "IGALabel"
        Me.IGALabel.Size = New System.Drawing.Size(82, 15)
        Me.IGALabel.TabIndex = 3
        Me.IGALabel.Text = "METCASH IGA"
        '
        'IGATextbox
        '
        Me.IGATextbox.Enabled = False
        Me.IGATextbox.Location = New System.Drawing.Point(196, 58)
        Me.IGATextbox.Name = "IGATextbox"
        Me.IGATextbox.ReadOnly = True
        Me.IGATextbox.Size = New System.Drawing.Size(130, 23)
        Me.IGATextbox.TabIndex = 4
        '
        'AldiTextbox
        '
        Me.AldiTextbox.Enabled = False
        Me.AldiTextbox.Location = New System.Drawing.Point(196, 158)
        Me.AldiTextbox.Name = "AldiTextbox"
        Me.AldiTextbox.ReadOnly = True
        Me.AldiTextbox.Size = New System.Drawing.Size(130, 23)
        Me.AldiTextbox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ALDI"
        '
        'AldiDate
        '
        Me.AldiDate.CustomFormat = ""
        Me.AldiDate.Location = New System.Drawing.Point(36, 158)
        Me.AldiDate.Name = "AldiDate"
        Me.AldiDate.Size = New System.Drawing.Size(132, 23)
        Me.AldiDate.TabIndex = 5
        '
        'ColesTextbox
        '
        Me.ColesTextbox.Enabled = False
        Me.ColesTextbox.Location = New System.Drawing.Point(196, 259)
        Me.ColesTextbox.Name = "ColesTextbox"
        Me.ColesTextbox.ReadOnly = True
        Me.ColesTextbox.Size = New System.Drawing.Size(130, 23)
        Me.ColesTextbox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "COLES"
        '
        'ColesDate
        '
        Me.ColesDate.CustomFormat = ""
        Me.ColesDate.Location = New System.Drawing.Point(36, 259)
        Me.ColesDate.Name = "ColesDate"
        Me.ColesDate.Size = New System.Drawing.Size(132, 23)
        Me.ColesDate.TabIndex = 8
        '
        'CustomEffTextbox
        '
        Me.CustomEffTextbox.Enabled = False
        Me.CustomEffTextbox.Location = New System.Drawing.Point(196, 360)
        Me.CustomEffTextbox.Name = "CustomEffTextbox"
        Me.CustomEffTextbox.ReadOnly = True
        Me.CustomEffTextbox.Size = New System.Drawing.Size(130, 23)
        Me.CustomEffTextbox.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Custom Days After"
        '
        'CustomDate
        '
        Me.CustomDate.CustomFormat = ""
        Me.CustomDate.Location = New System.Drawing.Point(36, 360)
        Me.CustomDate.Name = "CustomDate"
        Me.CustomDate.Size = New System.Drawing.Size(132, 23)
        Me.CustomDate.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "45 Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "28 Days"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "33 Days"
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(36, 468)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(132, 23)
        Me.StartDate.TabIndex = 20
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(194, 468)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(132, 23)
        Me.EndDate.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "No. Days Between:"
        '
        'TextBtwn
        '
        Me.TextBtwn.Enabled = False
        Me.TextBtwn.Location = New System.Drawing.Point(130, 508)
        Me.TextBtwn.Name = "TextBtwn"
        Me.TextBtwn.ReadOnly = True
        Me.TextBtwn.Size = New System.Drawing.Size(100, 23)
        Me.TextBtwn.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(234, 449)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "End Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(74, 449)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Start Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Effective Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Effective Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(225, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Effective Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(225, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Effective Date"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(332, 360)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 23)
        Me.NumericUpDown1.TabIndex = 32
        '
        'DateCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 564)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBtwn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CustomEffTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomDate)
        Me.Controls.Add(Me.ColesTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColesDate)
        Me.Controls.Add(Me.AldiTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AldiDate)
        Me.Controls.Add(Me.IGATextbox)
        Me.Controls.Add(Me.IGALabel)
        Me.Controls.Add(Me.IGADate)
        Me.Name = "DateCalculator"
        Me.Text = "Pallet Effective Date Calculator"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IGADate As DateTimePicker
    Friend WithEvents IGALabel As Label
    Friend WithEvents IGATextbox As TextBox
    Friend WithEvents AldiTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AldiDate As DateTimePicker
    Friend WithEvents ColesTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ColesDate As DateTimePicker
    Friend WithEvents CustomEffTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CustomDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBtwn As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
