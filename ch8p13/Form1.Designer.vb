<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUSPSTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUPSTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFedexTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalShipped = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFedexPercent = New System.Windows.Forms.Label()
        Me.lblUPSPercent = New System.Windows.Forms.Label()
        Me.lblUSPSPercent = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUSPSPercent)
        Me.GroupBox1.Controls.Add(Me.lblUPSPercent)
        Me.GroupBox1.Controls.Add(Me.lblFedexPercent)
        Me.GroupBox1.Controls.Add(Me.lblUSPSTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblUPSTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblFedexTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotalShipped)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblUSPSTotal
        '
        Me.lblUSPSTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSPSTotal.Location = New System.Drawing.Point(19, 269)
        Me.lblUSPSTotal.Name = "lblUSPSTotal"
        Me.lblUSPSTotal.Size = New System.Drawing.Size(80, 25)
        Me.lblUSPSTotal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "USPS:"
        '
        'lblUPSTotal
        '
        Me.lblUPSTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUPSTotal.Location = New System.Drawing.Point(19, 196)
        Me.lblUPSTotal.Name = "lblUPSTotal"
        Me.lblUPSTotal.Size = New System.Drawing.Size(80, 25)
        Me.lblUPSTotal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "UPS:"
        '
        'lblFedexTotal
        '
        Me.lblFedexTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFedexTotal.Location = New System.Drawing.Point(19, 116)
        Me.lblFedexTotal.Name = "lblFedexTotal"
        Me.lblFedexTotal.Size = New System.Drawing.Size(80, 25)
        Me.lblFedexTotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FedEx:"
        '
        'lblTotalShipped
        '
        Me.lblTotalShipped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalShipped.Location = New System.Drawing.Point(19, 48)
        Me.lblTotalShipped.Name = "lblTotalShipped"
        Me.lblTotalShipped.Size = New System.Drawing.Size(80, 25)
        Me.lblTotalShipped.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total shipped:"
        '
        'lblFedexPercent
        '
        Me.lblFedexPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFedexPercent.Location = New System.Drawing.Point(117, 116)
        Me.lblFedexPercent.Name = "lblFedexPercent"
        Me.lblFedexPercent.Size = New System.Drawing.Size(80, 25)
        Me.lblFedexPercent.TabIndex = 8
        '
        'lblUPSPercent
        '
        Me.lblUPSPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUPSPercent.Location = New System.Drawing.Point(117, 196)
        Me.lblUPSPercent.Name = "lblUPSPercent"
        Me.lblUPSPercent.Size = New System.Drawing.Size(80, 25)
        Me.lblUPSPercent.TabIndex = 9
        '
        'lblUSPSPercent
        '
        Me.lblUSPSPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUSPSPercent.Location = New System.Drawing.Point(117, 269)
        Me.lblUSPSPercent.Name = "lblUSPSPercent"
        Me.lblUSPSPercent.Size = New System.Drawing.Size(80, 25)
        Me.lblUSPSPercent.TabIndex = 10
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(306, 66)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(91, 33)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 404)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblUSPSTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUPSTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFedexTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalShipped As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUSPSPercent As Label
    Friend WithEvents lblUPSPercent As Label
    Friend WithEvents lblFedexPercent As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
