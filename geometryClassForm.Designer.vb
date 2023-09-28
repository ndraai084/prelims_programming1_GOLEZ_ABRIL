<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class geometryClassForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnPerimeterRect = New Button()
        btnAreaRect = New Button()
        btnVolumeRect = New Button()
        btnExit = New Button()
        txtLength = New TextBox()
        txtWidth = New TextBox()
        txtHeight = New TextBox()
        btnClear = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        btnPerimeterSq = New Button()
        txtSide = New TextBox()
        btnAreaSq = New Button()
        btnVolumeSq = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(19, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 21)
        Label1.TabIndex = 0
        Label1.Text = "Length"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(19, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 1
        Label2.Text = "Width"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(19, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 21)
        Label3.TabIndex = 2
        Label3.Text = "Height"
        ' 
        ' btnPerimeterRect
        ' 
        btnPerimeterRect.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPerimeterRect.Location = New Point(231, 18)
        btnPerimeterRect.Margin = New Padding(3, 2, 3, 2)
        btnPerimeterRect.Name = "btnPerimeterRect"
        btnPerimeterRect.Size = New Size(102, 28)
        btnPerimeterRect.TabIndex = 3
        btnPerimeterRect.Text = "Perimeter"
        btnPerimeterRect.UseVisualStyleBackColor = True
        ' 
        ' btnAreaRect
        ' 
        btnAreaRect.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAreaRect.Location = New Point(231, 98)
        btnAreaRect.Margin = New Padding(3, 2, 3, 2)
        btnAreaRect.Name = "btnAreaRect"
        btnAreaRect.Size = New Size(102, 28)
        btnAreaRect.TabIndex = 4
        btnAreaRect.Text = "Area"
        btnAreaRect.UseVisualStyleBackColor = True
        ' 
        ' btnVolumeRect
        ' 
        btnVolumeRect.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolumeRect.Location = New Point(231, 57)
        btnVolumeRect.Margin = New Padding(3, 2, 3, 2)
        btnVolumeRect.Name = "btnVolumeRect"
        btnVolumeRect.Size = New Size(102, 28)
        btnVolumeRect.TabIndex = 5
        btnVolumeRect.Text = "Volume"
        btnVolumeRect.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.Location = New Point(249, 283)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(102, 28)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtLength
        ' 
        txtLength.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtLength.Location = New Point(108, 19)
        txtLength.Margin = New Padding(3, 2, 3, 2)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(102, 27)
        txtLength.TabIndex = 7
        ' 
        ' txtWidth
        ' 
        txtWidth.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtWidth.Location = New Point(108, 57)
        txtWidth.Margin = New Padding(3, 2, 3, 2)
        txtWidth.Name = "txtWidth"
        txtWidth.Size = New Size(102, 27)
        txtWidth.TabIndex = 8
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtHeight.Location = New Point(108, 99)
        txtHeight.Margin = New Padding(3, 2, 3, 2)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(102, 27)
        txtHeight.TabIndex = 9
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(12, 283)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 28)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtHeight)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtWidth)
        GroupBox1.Controls.Add(btnPerimeterRect)
        GroupBox1.Controls.Add(txtLength)
        GroupBox1.Controls.Add(btnAreaRect)
        GroupBox1.Controls.Add(btnVolumeRect)
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(339, 144)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rectangle"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(btnPerimeterSq)
        GroupBox2.Controls.Add(txtSide)
        GroupBox2.Controls.Add(btnAreaSq)
        GroupBox2.Controls.Add(btnVolumeSq)
        GroupBox2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 162)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(339, 105)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Square"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(19, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 21)
        Label4.TabIndex = 0
        Label4.Text = "Side"
        ' 
        ' btnPerimeterSq
        ' 
        btnPerimeterSq.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnPerimeterSq.Location = New Point(231, 18)
        btnPerimeterSq.Margin = New Padding(3, 2, 3, 2)
        btnPerimeterSq.Name = "btnPerimeterSq"
        btnPerimeterSq.Size = New Size(102, 28)
        btnPerimeterSq.TabIndex = 3
        btnPerimeterSq.Text = "Perimeter"
        btnPerimeterSq.UseVisualStyleBackColor = True
        ' 
        ' txtSide
        ' 
        txtSide.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtSide.Location = New Point(108, 19)
        txtSide.Margin = New Padding(3, 2, 3, 2)
        txtSide.Name = "txtSide"
        txtSide.Size = New Size(102, 27)
        txtSide.TabIndex = 7
        ' 
        ' btnAreaSq
        ' 
        btnAreaSq.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAreaSq.Location = New Point(108, 57)
        btnAreaSq.Margin = New Padding(3, 2, 3, 2)
        btnAreaSq.Name = "btnAreaSq"
        btnAreaSq.Size = New Size(102, 28)
        btnAreaSq.TabIndex = 4
        btnAreaSq.Text = "Area"
        btnAreaSq.UseVisualStyleBackColor = True
        ' 
        ' btnVolumeSq
        ' 
        btnVolumeSq.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnVolumeSq.Location = New Point(231, 57)
        btnVolumeSq.Margin = New Padding(3, 2, 3, 2)
        btnVolumeSq.Name = "btnVolumeSq"
        btnVolumeSq.Size = New Size(102, 28)
        btnVolumeSq.TabIndex = 5
        btnVolumeSq.Text = "Volume"
        btnVolumeSq.UseVisualStyleBackColor = True
        ' 
        ' geometryClassForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(370, 322)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Margin = New Padding(3, 2, 3, 2)
        Name = "geometryClassForm"
        Text = "Geometry Class Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPerimeterRect As Button
    Friend WithEvents btnAreaRect As Button
    Friend WithEvents btnVolumeRect As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPerimeterSq As Button
    Friend WithEvents txtSide As TextBox
    Friend WithEvents btnAreaSq As Button
    Friend WithEvents btnVolumeSq As Button
End Class
