<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(64, 83)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(132, 27)
        Me.txtFirst.TabIndex = 0
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(275, 83)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(132, 27)
        Me.txtLast.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last"
        '
        'lblLast
        '
        Me.lblLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLast.Location = New System.Drawing.Point(92, 166)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(80, 34)
        Me.lblLast.TabIndex = 4
        Me.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(290, 166)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(80, 34)
        Me.lblFirst.TabIndex = 5
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(201, 225)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(82, 32)
        Me.btnAssign.TabIndex = 6
        Me.btnAssign.Text = "Assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 281)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents btnAssign As Button
End Class
