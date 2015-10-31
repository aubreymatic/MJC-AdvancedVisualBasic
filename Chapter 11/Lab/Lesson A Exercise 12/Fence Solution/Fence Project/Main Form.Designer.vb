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
        Me.btnCalcTotalCost = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcTotalCost
        '
        Me.btnCalcTotalCost.Location = New System.Drawing.Point(327, 175)
        Me.btnCalcTotalCost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalcTotalCost.Name = "btnCalcTotalCost"
        Me.btnCalcTotalCost.Size = New System.Drawing.Size(167, 33)
        Me.btnCalcTotalCost.TabIndex = 0
        Me.btnCalcTotalCost.Text = "Calculate &Total Cost"
        Me.btnCalcTotalCost.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(500, 175)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 33)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(195, 175)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(110, 36)
        Me.lblTotalCost.TabIndex = 2
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total cost:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fence_Project.My.Resources.Resources.Fence
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Length (feet):"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(195, 88)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(68, 27)
        Me.txtLength.TabIndex = 6
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(327, 88)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(68, 27)
        Me.txtWidth.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "&Width (feet):"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(463, 88)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(68, 27)
        Me.txtCost.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(459, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "&Cost: (per linear foot):"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcTotalCost)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMain"
        Me.Text = "All-Around Fence Company"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcTotalCost As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label5 As Label
End Class
