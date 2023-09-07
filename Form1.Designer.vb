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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTribe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(869, 64)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 26)
        Me.txtname.TabIndex = 1
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(869, 136)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(100, 26)
        Me.txtsurname.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(869, 192)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 26)
        Me.txtYear.TabIndex = 1
        '
        'txtTribe
        '
        Me.txtTribe.Location = New System.Drawing.Point(869, 263)
        Me.txtTribe.Name = "txtTribe"
        Me.txtTribe.Size = New System.Drawing.Size(100, 26)
        Me.txtTribe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(623, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year I was born?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(623, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "My tribe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(623, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Gender"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(768, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "My Small Bio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(869, 323)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(100, 26)
        Me.txtgender.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 450)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTribe)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.txtname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtgender As TextBox
End Class
