﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logon
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
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtHomeOffice = New System.Windows.Forms.TextBox()
        Me.txtActive = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogonLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTestValue = New System.Windows.Forms.Label()
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnLogon = New System.Windows.Forms.Button()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(393, 128)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(191, 52)
        Me.btnClose.TabIndex = 58
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.AcceptsReturn = True
        Me.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(442, 298)
        Me.txtType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(140, 30)
        Me.txtType.TabIndex = 57
        Me.txtType.Visible = False
        '
        'txtHomeOffice
        '
        Me.txtHomeOffice.AcceptsReturn = True
        Me.txtHomeOffice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHomeOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeOffice.Location = New System.Drawing.Point(220, 298)
        Me.txtHomeOffice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHomeOffice.Name = "txtHomeOffice"
        Me.txtHomeOffice.Size = New System.Drawing.Size(140, 30)
        Me.txtHomeOffice.TabIndex = 56
        Me.txtHomeOffice.Visible = False
        '
        'txtActive
        '
        Me.txtActive.AcceptsReturn = True
        Me.txtActive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActive.Location = New System.Drawing.Point(14, 301)
        Me.txtActive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtActive.Name = "txtActive"
        Me.txtActive.Size = New System.Drawing.Size(140, 30)
        Me.txtActive.TabIndex = 55
        Me.txtActive.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 32)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogonLastName
        '
        Me.txtLogonLastName.AcceptsReturn = True
        Me.txtLogonLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogonLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogonLastName.Location = New System.Drawing.Point(220, 140)
        Me.txtLogonLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLogonLastName.Name = "txtLogonLastName"
        Me.txtLogonLastName.Size = New System.Drawing.Size(140, 30)
        Me.txtLogonLastName.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 32)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Employee ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTestValue
        '
        Me.lblTestValue.Location = New System.Drawing.Point(484, 228)
        Me.lblTestValue.Name = "lblTestValue"
        Me.lblTestValue.Size = New System.Drawing.Size(100, 23)
        Me.lblTestValue.TabIndex = 52
        Me.lblTestValue.Text = "Label2"
        Me.lblTestValue.Visible = False
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.Location = New System.Drawing.Point(17, 228)
        Me.cboEmployeeID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(165, 24)
        Me.cboEmployeeID.TabIndex = 51
        Me.cboEmployeeID.Visible = False
        '
        'txtGroup
        '
        Me.txtGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.Location = New System.Drawing.Point(17, 264)
        Me.txtGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(165, 30)
        Me.txtGroup.TabIndex = 50
        Me.txtGroup.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(220, 264)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(177, 30)
        Me.txtFirstName.TabIndex = 49
        Me.txtFirstName.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(220, 228)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(177, 30)
        Me.txtLastName.TabIndex = 48
        Me.txtLastName.Visible = False
        '
        'btnLogon
        '
        Me.btnLogon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogon.Location = New System.Drawing.Point(393, 68)
        Me.btnLogon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogon.Name = "btnLogon"
        Me.btnLogon.Size = New System.Drawing.Size(191, 52)
        Me.btnLogon.TabIndex = 47
        Me.btnLogon.Text = "Logon"
        Me.btnLogon.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.AcceptsReturn = True
        Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(220, 79)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmployeeID.Size = New System.Drawing.Size(140, 30)
        Me.txtEmployeeID.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 50)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Please Type Your Employee ID and Last Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Logon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtHomeOffice)
        Me.Controls.Add(Me.txtActive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLogonLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTestValue)
        Me.Controls.Add(Me.cboEmployeeID)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.btnLogon)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Logon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeOffice As System.Windows.Forms.TextBox
    Friend WithEvents txtActive As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLogonLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTestValue As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnLogon As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
