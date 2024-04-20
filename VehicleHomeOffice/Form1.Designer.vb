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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBJCNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cboVehicleID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHomeOffice = New System.Windows.Forms.TextBox()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(681, 321)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(191, 52)
        Me.btnClose.TabIndex = 59
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(681, 265)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(191, 52)
        Me.btnUpdate.TabIndex = 60
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 174)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 26)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Last Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Location = New System.Drawing.Point(168, 174)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(160, 22)
        Me.txtLastName.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 207)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 26)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Employee ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(168, 207)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(160, 22)
        Me.txtFirstName.TabIndex = 63
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.Location = New System.Drawing.Point(168, 141)
        Me.cboEmployeeID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(160, 24)
        Me.cboEmployeeID.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(859, 69)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Vehicle Home Office"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 295)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 26)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "BJC Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBJCNumber
        '
        Me.txtBJCNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBJCNumber.Location = New System.Drawing.Point(168, 295)
        Me.txtBJCNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBJCNumber.Name = "txtBJCNumber"
        Me.txtBJCNumber.ReadOnly = True
        Me.txtBJCNumber.Size = New System.Drawing.Size(160, 22)
        Me.txtBJCNumber.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 328)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Year"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 26)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Vehicle ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYear
        '
        Me.txtYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtYear.Location = New System.Drawing.Point(168, 328)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(160, 22)
        Me.txtYear.TabIndex = 70
        '
        'cboVehicleID
        '
        Me.cboVehicleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehicleID.FormattingEnabled = True
        Me.cboVehicleID.Location = New System.Drawing.Point(168, 262)
        Me.cboVehicleID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboVehicleID.Name = "cboVehicleID"
        Me.cboVehicleID.Size = New System.Drawing.Size(160, 24)
        Me.cboVehicleID.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 369)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 26)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Make"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMake
        '
        Me.txtMake.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMake.Location = New System.Drawing.Point(168, 369)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.ReadOnly = True
        Me.txtMake.Size = New System.Drawing.Size(160, 22)
        Me.txtMake.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 406)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 26)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Model"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModel
        '
        Me.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModel.Location = New System.Drawing.Point(168, 406)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(160, 22)
        Me.txtModel.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 436)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 26)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Home Office"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHomeOffice
        '
        Me.txtHomeOffice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHomeOffice.Location = New System.Drawing.Point(168, 436)
        Me.txtHomeOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHomeOffice.Name = "txtHomeOffice"
        Me.txtHomeOffice.ReadOnly = True
        Me.txtHomeOffice.Size = New System.Drawing.Size(160, 22)
        Me.txtHomeOffice.TabIndex = 80
        '
        'dgvVehicles
        '
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Location = New System.Drawing.Point(30, 84)
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.RowTemplate.Height = 24
        Me.dgvVehicles.Size = New System.Drawing.Size(621, 408)
        Me.dgvVehicles.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 466)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 26)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Employee ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeID.Location = New System.Drawing.Point(168, 466)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(160, 22)
        Me.txtEmployeeID.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(349, 436)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 26)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Available"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAvailable
        '
        Me.txtAvailable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAvailable.Location = New System.Drawing.Point(491, 436)
        Me.txtAvailable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.ReadOnly = True
        Me.txtAvailable.Size = New System.Drawing.Size(160, 22)
        Me.txtAvailable.TabIndex = 85
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvVehicles)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHomeOffice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBJCNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cboVehicleID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.cboEmployeeID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Home Office"
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBJCNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cboVehicleID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHomeOffice As System.Windows.Forms.TextBox
    Friend WithEvents dgvVehicles As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAvailable As System.Windows.Forms.TextBox

End Class
